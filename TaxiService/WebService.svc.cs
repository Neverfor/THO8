<<<<<<< HEAD
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

                Address a1 = taxiPriceInfoRequest.DepartureAddress;
                Address a2 = taxiPriceInfoRequest.DestinationAddress;
                string sDepartureAddress = string.Format("{0} {1} {2} {3} {4}", a1.Street, a1.Number, a1.ZipCode, a1.City, a1.Country);
                string sDestinationAddress = string.Format("{0} {1} {2} {3} {4}", a2.Street, a2.Number, a2.ZipCode, a2.City, a2.Country);
                double distanceInKm = DistanceManager.Instance.DistanceInKmBetween(sDepartureAddress, sDestinationAddress);

                TaxiPriceInfo priceInfo = new TaxiPriceInfo();
                priceInfo.Price = 50 + (taxiMetLaagstePrijs.PricePerKm * distanceInKm); 
                priceInfo.TaxiId = taxiMetLaagstePrijs.Id;
                priceInfo.TaxiType = taxiMetLaagstePrijs.Type;
                priceInfo.DepartureAddress = taxiPriceInfoRequest.DepartureAddress;
                priceInfo.AmountOfPassengers = taxiPriceInfoRequest.AmountOfPassengers;
                priceInfo.DestinationAddress = taxiPriceInfoRequest.DestinationAddress;
                //set arrivalTime and dateTime

                return priceInfo;
            }
        }


        public ServicesDataContracts.TaxiBooking DoTaxiBooking(TaxiBookingRequest taxiBookingRequest)
        {
            //string userToken = taxiBookingRequest.UserToken;
            User user = To8Libraries.UserHelper.getUser(taxiBookingRequest.UserToken);
            //call user-service for verification
            using (var db = new WebServiceContext())
            {
                var taxi = from t in db.Taxis 
                           where t.Id == taxiBookingRequest.TaxiId 
                           select t;

                //Create TaxiBooking for persistancy
                To8Libraries.Domain.TaxiBooking taxiBooking = new To8Libraries.Domain.TaxiBooking();
                taxiBooking.User = user;
                taxiBooking.Taxi = taxi.First();
                taxiBooking.Price = taxiBookingRequest.Price;
                taxiBooking.DepartureAddress = taxiBookingRequest.DepartureAddress;
                taxiBooking.DestinationAddress = taxiBookingRequest.DestinationAddress;
                //set arrivalTime and dateTime
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
                //set arrivalTime and dateTime
                rtn.AmountOfPassengers = taxiBookingRequest.AmountOfPassengers;

                return rtn;
            }
        }

        public UserBookings GetUserBookings(UserBookingsRequest userBookingsRequest)
        {
            User user = To8Libraries.UserHelper.getUser(userBookingsRequest.UserToken);
            //call user-service for verification
            bool bookingIsSpecified = (userBookingsRequest.BookingId == null);

            UserBookings ubs = new UserBookings();
           

            using (var db = new WebServiceContext())
            {
                if (bookingIsSpecified)
                {
                    //Get bookings from user
                    var bookings = from b in db.Bookings 
                                   where b.User.Equals(user) 
                                   select b;

                    //Loop through found bookings and create the objects for the response
                    foreach (To8Libraries.Domain.TaxiBooking b in bookings)
                    {
                        ServicesDataContracts.TaxiBooking taxiBooking = new ServicesDataContracts.TaxiBooking();
                        taxiBooking.TaxiId = b.Taxi.Id;
                        taxiBooking.TaxiType = b.Taxi.Type;
                        taxiBooking.Price = b.Price;
                        taxiBooking.DepartureAddress = b.DepartureAddress;
                        taxiBooking.DestinationAddress = b.DestinationAddress;
                        //set arrivalTime and dateTime
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
                User user = To8Libraries.UserHelper.getUser(cancelBookingRequest.UserToken);
                return (user.Bookings.RemoveAll(b => b.Id.Equals(cancelBookingRequest.BookingId)) > 0); //TODO: kijken of dit werkt
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
=======
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

                Address a1 = taxiPriceInfoRequest.DepartureAddress;
                Address a2 = taxiPriceInfoRequest.DestinationAddress;
                string sDepartureAddress = string.Format("{0} {1} {2} {3} {4}", a1.Street, a1.Number, a1.ZipCode, a1.City, a1.Country);
                string sDestinationAddress = string.Format("{0} {1} {2} {3} {4}", a2.Street, a2.Number, a2.ZipCode, a2.City, a2.Country);
                double distanceInKm = DistanceManager.Instance.DistanceInKmBetween(sDepartureAddress, sDestinationAddress);

                TaxiPriceInfo priceInfo = new TaxiPriceInfo();
                priceInfo.Price = 50 + (taxiMetLaagstePrijs.PricePerKm * distanceInKm); 
                priceInfo.TaxiId = taxiMetLaagstePrijs.Id;
                priceInfo.TaxiType = taxiMetLaagstePrijs.Type;
                priceInfo.DepartureAddress = taxiPriceInfoRequest.DepartureAddress;
                priceInfo.AmountOfPassengers = taxiPriceInfoRequest.AmountOfPassengers;
                priceInfo.DestinationAddress = taxiPriceInfoRequest.DestinationAddress;
                int duration = DistanceManager.Instance.DurationInMinBetween(sDepartureAddress, sDestinationAddress);
                if (taxiPriceInfoRequest.IsDepartureTime)
                {
                    priceInfo.DepartureTime = taxiPriceInfoRequest.DateTime;
                    priceInfo.ArrivalTime = priceInfo.DepartureTime.AddMinutes(duration);
                }
                else
                {
                    TimeSpan substraction = new TimeSpan(0, duration, 0);
                    priceInfo.ArrivalTime = taxiPriceInfoRequest.DateTime;
                    priceInfo.DepartureTime = priceInfo.ArrivalTime.Subtract(substraction);
                }

                return priceInfo;
            }
        }


        public ServicesDataContracts.TaxiBooking DoTaxiBooking(TaxiBookingRequest taxiBookingRequest)
        {
            //string userToken = taxiBookingRequest.UserToken;
            UserService.UserService us = new UserService.UserServiceClient();
            string userToken = us.Login("michael", "welkom123");
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
                        taxiBooking.DepartureTime = b.DepartureTime;
                        taxiBooking.ArrivalTime = b.ArrivalTime;
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
>>>>>>> 0a71851821d812bb0f3f8c64399b5e42e2c7476a
