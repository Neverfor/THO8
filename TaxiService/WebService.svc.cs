using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TaxiService.ServicesDataContracts;
using TaxiService.Domain;
using TaxiService.Managers;
using System.Data.SqlClient;
using TaxiService.DB;

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
                
                
                List<Taxi> taxis = db.Taxis.ToList();
                
                Taxi taxiMetLaagstePrijs = null;
                foreach (Taxi taxi in taxis)
                {
                    if (taxiMetLaagstePrijs == null || taxiMetLaagstePrijs.PricePerKm > taxi.PricePerKm)
                        taxiMetLaagstePrijs = taxi;
                }

                TaxiPriceInfo priceInfo = new TaxiPriceInfo();
                priceInfo.Price = taxiMetLaagstePrijs.PricePerKm * 10; //statische 10km
                priceInfo.TaxiId = taxiMetLaagstePrijs.Id;
                priceInfo.TaxiType = taxiMetLaagstePrijs.Type;
                priceInfo.DepartureAddress = taxiPriceInfoRequest.DepartureAddress;
                priceInfo.AmountOfPassengers = taxiPriceInfoRequest.AmountOfPassengers;
                priceInfo.DateTime = taxiPriceInfoRequest.DateTime;
                priceInfo.DestinationAddress = taxiPriceInfoRequest.DestinationAddress;
                priceInfo.IsDepartureTime = taxiPriceInfoRequest.IsDepartureTime;

                return priceInfo;
            }
        }


        public ServicesDataContracts.TaxiBooking DoTaxiBooking(TaxiBookingRequest taxiBookingRequest)
        {
            string userToken = taxiBookingRequest.UserToken;
            UserService.UserService us = new UserService.UserServiceClient();
            User u = us.GetUser(userToken);
            //call user-service for verification
            using (var db = new WebServiceContext())
            {
                var taxi = from t in db.Taxis 
                           where t.Id == taxiBookingRequest.TaxiId 
                           select t;

                //Create TaxiBooking for persistancy
                Domain.TaxiBooking taxiBooking = new Domain.TaxiBooking();
                taxiBooking.Taxi = taxi.First();
                taxiBooking.Price = taxiBookingRequest.Price;
                taxiBooking.DepartureAddress = taxiBookingRequest.DepartureAddress;
                taxiBooking.DestinationAddress = taxiBookingRequest.DestinationAddress;
                taxiBooking.DateTime = taxiBookingRequest.DateTime;
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
                rtn.DateTime = taxiBookingRequest.DateTime;
                rtn.AmountOfPassengers = taxiBookingRequest.AmountOfPassengers;

                return rtn;
            }
        }

        public UserBookings GetUserBookings(UserBookingsRequest userBookingsRequest)
        {
            string userToken = userBookingsRequest.UserToken;
            //call user-service for verification
            bool bookingIsSpecified = (userBookingsRequest.BookingId == null);

            UserBookings ubs = new UserBookings();
           

            using (var db = new WebServiceContext())
            {
                User u = db.Users.First(); //Replace this with code from UserTokenService to get the user

                if (bookingIsSpecified)
                {
                    //Get bookings from user
                    var bookings = from b in db.Bookings 
                                   where b.User.Equals(u) 
                                   select b;

                    //Loop through found bookings and create the objects for the response
                    foreach (Domain.TaxiBooking b in bookings)
                    {
                        ServicesDataContracts.TaxiBooking taxiBooking = new ServicesDataContracts.TaxiBooking();
                        taxiBooking.TaxiId = b.Taxi.Id;
                        taxiBooking.TaxiType = b.Taxi.Type;
                        taxiBooking.Price = b.Price;
                        taxiBooking.DepartureAddress = b.DepartureAddress;
                        taxiBooking.DestinationAddress = b.DestinationAddress;
                        taxiBooking.DateTime = b.DateTime;
                        taxiBooking.AmountOfPassengers = b.AmountOfPassengers;
                        ubs.TaxiBookings.Add(taxiBooking); //add to the response
                    }                  
                }
                else
                {
                    //select * from TaxiBooking where user = user...
                    //add TaxiBooking objects to ubs.TaxiBookings
                }

                return ubs;
            }
        }

        public bool CancelBooking(CancelBookingRequest cancelBookingRequest)
        {
            using (var db = new WebServiceContext())
            {
                User u = db.Users.First(); //Replace this with code from UserTokenService to get the user
                return (u.Bookings.RemoveAll(b => b.Id.Equals(cancelBookingRequest.BookingId)) > 0);
                //TODO: remove booking from database table??
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
