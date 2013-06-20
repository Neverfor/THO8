using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TaxiService.ServicesDataContracts;
using To8Libraries.Domain;
using TaxiService.Managers;
using System.Data.SqlClient;
using TaxiService.DB;
using System.Diagnostics;

namespace TaxiService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WebService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WebService.svc or WebService.svc.cs at the Solution Explorer and start debugging.
    public class WebService : IWebService
    {
        public TaxiPriceInfo GetTaxiPriceInfo(TaxiPriceInfoRequest taxiPriceInfoRequest)
        {
            using (var db = new WebServiceContext())
            {
                // validate: request parameter-values
                Address a1 = taxiPriceInfoRequest.DepartureAddress;
                Address a2 = taxiPriceInfoRequest.DestinationAddress;
                if (a1.Street  == "" || a1.Street  == null ||
                    a1.Number  == 0  ||
                    a1.ZipCode == "" || a1.ZipCode == null ||
                    a1.City    == "" || a1.City    == null ||
                    a1.Country == "" || a1.Country == null ||

                    a2.Street  == "" || a2.Street  == null ||
                    a2.Number  == 0  ||
                    a2.ZipCode == "" || a2.ZipCode == null ||
                    a2.City    == "" || a2.City    == null ||
                    a2.Country == "" || a2.Country == null ||
                    
                    taxiPriceInfoRequest.DateTime == null  ||
                    taxiPriceInfoRequest.AmountOfPassengers == 0)
                    throw new FaultException("Sommige gegevens zijn niet (correct) ingevoerd");

                // validate: existence of addresses
                string sDepartureAddress = string.Format("{0} {1} {2} {3} {4}", a1.Street, a1.Number, a1.ZipCode, a1.City, a1.Country);
                string sDestinationAddress = string.Format("{0} {1} {2} {3} {4}", a2.Street, a2.Number, a2.ZipCode, a2.City, a2.Country);
                double distance = DistanceManager.Instance.DistanceInKmBetween(sDepartureAddress, sDestinationAddress);
                if (distance == 0)
                    throw new FaultException("Incorrect(e) adres(sen)");

                // validate: departureTime hasn't begun yet
                int duration = DistanceManager.Instance.DurationInMinBetween(sDepartureAddress, sDestinationAddress);
                DateTime dt, at;
                if (taxiPriceInfoRequest.IsDepartureTime)
                {
                    dt = taxiPriceInfoRequest.DateTime;
                    at = dt.AddMinutes(duration);
                }
                else
                {
                    at = taxiPriceInfoRequest.DateTime;
                    dt = at.Subtract(new TimeSpan(0, duration, 0));
                }
                if (dt < (DateTime.Now.AddMinutes(10)))
                    throw new FaultException(string.Format("De vertrekdatum dient 10 minuten na {0} te zijn", DateTime.Now.ToString()));

                // validate: available taxis
                var availableTaxisDueToPassengers = from t in db.Taxis
                                                    where t.maxPassengers >= taxiPriceInfoRequest.AmountOfPassengers
                                                    select t;
                List<Taxi> availableTaxis = new List<Taxi>();
                foreach (Taxi t in availableTaxisDueToPassengers)
                    availableTaxis.Add(t);
                if (availableTaxis.Count == 0)
                    throw new FaultException("Er is geen taxi beschikbaar voor het opgegeven aantal passagiers");

                var unAvailableTaxisDueToTime = from b in db.Bookings
                                                where (b.DepartureTime < dt && b.ArrivalTime > dt) || 
                                                (b.DepartureTime < at && b.ArrivalTime > at) || 
                                                (b.DepartureTime > dt && b.ArrivalTime < at)
                                                select b.Taxi;
                foreach (Taxi t in unAvailableTaxisDueToTime)
                    if (availableTaxis.Contains(t)) availableTaxis.Remove(t);
                if (availableTaxis.Count == 0)
                    throw new FaultException("Er is geen taxi beschikbaar voor de opgegeven tijd");

                Taxi taxiMinPrice = null;
                foreach (Taxi taxi in availableTaxis)
                    if (taxiMinPrice == null ||
                        taxiMinPrice.PricePerKm > taxi.PricePerKm)
                        taxiMinPrice = taxi;
             
                TaxiPriceInfo priceInfo = new TaxiPriceInfo();
                priceInfo.Price = 10 + (taxiMinPrice.PricePerKm * distance);
                priceInfo.TaxiId = taxiMinPrice.Id;
                priceInfo.TaxiType = taxiMinPrice.Type;
                priceInfo.DepartureAddress = a1;
                priceInfo.DestinationAddress = a2;
                priceInfo.ArrivalTime = at;
                priceInfo.DepartureTime = dt;
                priceInfo.AmountOfPassengers = taxiPriceInfoRequest.AmountOfPassengers;

                return priceInfo;
            }
        }


        public ServicesDataContracts.TaxiBooking DoTaxiBooking(TaxiBookingRequest taxiBookingRequest)
        {
            //string userToken = taxiBookingRequest.UserToken;
            string user = To8Libraries.UserHelper.GetUser(taxiBookingRequest.UserToken).UserName;
            //call user-service for verification
            using (var db = new WebServiceContext())
            {
                var taxi = from t in db.Taxis 
                           where t.Id == taxiBookingRequest.TaxiId 
                           select t;

                //Create TaxiBooking for persistancy
                To8Libraries.Domain.TaxiBooking taxiBooking = new To8Libraries.Domain.TaxiBooking();
                taxiBooking.UserName = user;
                taxiBooking.Taxi = taxi.First();
                taxiBooking.Price = taxiBookingRequest.Price;
                taxiBooking.DepartureAddress = taxiBookingRequest.DepartureAddress;
                taxiBooking.DestinationAddress = taxiBookingRequest.DestinationAddress;
                taxiBooking.DepartureTime = taxiBookingRequest.DepartureTime;
                taxiBooking.ArrivalTime = taxiBookingRequest.ArrivalTime;
                taxiBooking.AmountOfPassengers = taxiBookingRequest.AmountOfPassengers;

                //Add booking and save
                db.Bookings.Add(taxiBooking);
                db.SaveChanges();

                //Create booking response 
                ServicesDataContracts.TaxiBooking rtn = new ServicesDataContracts.TaxiBooking();
                rtn.TaxiId = taxi.First().Id;
                rtn.TaxiType = taxi.First().Type;
                rtn.Price = taxiBookingRequest.Price;
                rtn.DepartureAddress = taxiBookingRequest.DepartureAddress;
                rtn.DestinationAddress = taxiBookingRequest.DestinationAddress;
                rtn.DepartureTime = taxiBookingRequest.DepartureTime;
                rtn.ArrivalTime = taxiBookingRequest.ArrivalTime;
                rtn.AmountOfPassengers = taxiBookingRequest.AmountOfPassengers;

                return rtn;
            }
        }

        public UserBookings GetUserBookings(UserBookingsRequest userBookingsRequest)
        {
            string user = To8Libraries.UserHelper.GetUser(userBookingsRequest.UserToken).UserName;
            //call user-service for verification
            bool bookingIsSpecified = (userBookingsRequest.BookingId == null);

            UserBookings ubs = new UserBookings();
            ubs.TaxiBookings = new List<ServicesDataContracts.TaxiBooking>();


            using (var db = new WebServiceContext())
            {
                IQueryable<To8Libraries.Domain.TaxiBooking> bookings = null;
                if (!bookingIsSpecified)
                {
                    //Get bookings from user
                    bookings = from b in db.Bookings
                               where b.UserName.Equals(user)
                               select b;

                }
                else
                {
                    //Get booking with id from user
                    bookings = from b in db.Bookings
                               where b.UserName.Equals(user) && b.Id.Equals(userBookingsRequest.BookingId)
                               select b;
                }
                var bookingsList = bookings.ToList<To8Libraries.Domain.TaxiBooking>();
                //Loop through found bookings and create the objects for the response
                foreach (To8Libraries.Domain.TaxiBooking b in bookingsList)
                {
                    ServicesDataContracts.TaxiBooking taxiBooking = new ServicesDataContracts.TaxiBooking();
                    taxiBooking.Id = b.Id;
                    taxiBooking.TaxiId = b.Taxi.Id;
                    taxiBooking.TaxiType = b.Taxi.Type;
                    taxiBooking.Price = b.Price;
                    taxiBooking.DepartureAddress = b.DepartureAddress;
                    taxiBooking.DestinationAddress = b.DestinationAddress;
                    taxiBooking.DepartureTime = b.DepartureTime;
                    taxiBooking.ArrivalTime = b.ArrivalTime;
                    taxiBooking.AmountOfPassengers = b.AmountOfPassengers;
                    ubs.TaxiBookings.Add(taxiBooking); //add to the response
                }
            }


            return ubs;
        }

        public bool CancelBooking(CancelBookingRequest cancelBookingRequest)
        {
            using (var db = new WebServiceContext())
            {
                
                string user = To8Libraries.UserHelper.GetUser(cancelBookingRequest.UserToken).UserName;
                
                var canceledTaxiBooking = from tb in db.Bookings
                                          where tb.Id == cancelBookingRequest.BookingId && tb.UserName.Equals(user)
                                          select tb;
                db.Bookings.Remove(canceledTaxiBooking.First());
                db.SaveChanges();
                return db.Bookings.Any(b => b.Id.Equals(cancelBookingRequest.BookingId));
            }
        }


        public string[] GetCitys(string country)
        {
            using (var db = new WebServiceContext())
            {
                List<string> rtn = new List<string>();
                foreach (City c in db.Cities)
                {
                    rtn.Add(c.ToString());
                }
                return rtn.ToArray();
            }
        }

        public string[] GetAddress(GetAddressRequest getAddressRequest)
        {
            throw new NotImplementedException();
        }

        public string[] GetSpecialLocations(string LocationType)
        {
            throw new NotImplementedException();
        }
    }
}