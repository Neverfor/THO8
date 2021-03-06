﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CarRentalService.UserService;
using CarRentalService.Contracts;
using CarRentalService.Entities;
using System.Data.Entity;
using System.Diagnostics;

namespace CarRentalService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WebService" in both code and config file together.
    public class WebService : IWebService
    {
        public CountryContract[] GetCountries()
        {
            using (var db = new WebServiceContext())
            {
                Country[] countries = db.Countries.ToArray();
                CountryContract[] response = new CountryContract[countries.Length];
                
                for (int i = 0; i < response.Length; i++)
                {
                    response[i] = new CountryContract();
                    response[i].CountryId = countries[i].CountryId;
                    response[i].Name = countries[i].Name;
                }
     
                return response;
            }
        }

        public CityContract[] GetCities(CountryContract country)
        {
            using (var db = new WebServiceContext())
            {
                City[] cities = (from c in db.Cities
                                 where c.Country.CountryId == country.CountryId
                                 select c).ToArray();
                CityContract[] response = new CityContract[cities.Length];

                for (int i = 0; i < response.Length; i++)
                {
                    response[i] = new CityContract();
                    response[i].CityId = cities[i].CityId;
                    response[i].Name = cities[i].Name;
                }

                return response;
            }
        }

        public DealerContract[] GetDealers(CityContract city)
        {
            using (var db = new WebServiceContext())
            {
                Dealer[] dealers = (from d in db.Dealers
                                   where d.City.CityId == city.CityId
                                 select d).ToArray();
                DealerContract[] response = new DealerContract[dealers.Length];

                for (int i = 0; i < response.Length; i++)
                {
                    response[i] = new DealerContract();
                    response[i].DealerId = dealers[i].DealerId;
                    response[i].Name = dealers[i].Name;
                }

                return response;
            }
        }

        public Contracts.CarContract[] GetCars(Contracts.DealerContract dealer)
        {
            using (var db = new WebServiceContext())
            {
                Car[] cars = (from c in db.Cars
                              where c.Dealer.DealerId == dealer.DealerId
                              select c).ToArray();
                CarContract[] response = new CarContract[cars.Length];

                for (int i = 0; i < response.Length; i++)
                {
                    response[i] = new CarContract();
                    response[i].CarId = cars[i].CarId;
                    response[i].Brand = cars[i].Brand;
                    response[i].DateOfPurchase = cars[i].DateOfPurchase;
                    response[i].Licence = cars[i].Licence;
                    response[i].CarType = new CarTypeContract() 
                    { 
                        Maxpersons = cars[i].CarType.Maxpersons, 
                        PricePerDay = cars[i].CarType.PricePerDay, 
                        Type = cars[i].CarType.Type 
                    };
                }

                return response;
            }
        }

        public bool IsAvailable(CarContract car, DateTime startDate, DateTime endDate)
        {
            using (WebServiceContext db = new WebServiceContext())
            {
                var occupied = from cb in db.CarBookings
                               where (cb.Car.CarId == car.CarId) &&
                               ((cb.StartDate >= startDate && cb.StartDate < endDate) ||
                               (cb.EndDate > startDate && cb.EndDate < endDate) ||
                               (cb.StartDate < startDate && cb.EndDate > endDate))
                               select cb;
                try
                {
                    occupied.First();
                    return false;
                }
                catch (Exception ex)
                {
                    return true;
                }
            }
        }

        public CarBookingContract Book(CarBookingContract booking, string token)
        {
            try
            {
                int userId;
                using (UserServiceClient client = new UserServiceClient())
                {
                    userId = client.GetUser(token).UserId;
                }
                using (WebServiceContext db = new WebServiceContext())
                {
                    var vCar = from c in db.Cars
                               where c.CarId == booking.Car.CarId
                               select c;
                    Car car = vCar.First();
                    

                    CarBooking cb = new CarBooking() 
                    { 
                        Car = car, 
                        StartDate = booking.StartDate, 
                        EndDate = booking.EndDate, 
                        Price = booking.Price, 
                        UserId = userId 
                    };
                    db.CarBookings.Add(cb);
                    db.SaveChanges();
                }
                return booking;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CarBookingContract[] getUserBookings(string token)
        {
            try
            {
                int userId;
                using (UserServiceClient client = new UserServiceClient())
                {
                    userId = client.GetUser(token).UserId;
                }
                using (WebServiceContext db = new WebServiceContext())
                {
                    CarBooking[] carBookings = (from cb in db.CarBookings
                                                where cb.UserId == userId
                                                select cb).ToArray();
                    CarBookingContract[] response = new CarBookingContract[carBookings.Count()];

                    for (int i = 0; i < response.Length; i++)
                    {
                        response[i] = new CarBookingContract()
                        {
                            CarBookingId = carBookings[i].CarBookingId,
                            StartDate = carBookings[i].StartDate,
                            EndDate = carBookings[i].EndDate,
                            Price = carBookings[i].Price,
                            Car = new CarContract()
                            {
                                CarId = carBookings[i].Car.CarId,
                                Brand = carBookings[i].Car.Brand
                            }
                        };
                    }

                    return response;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool CancelBooking(CarBookingContract booking, string token)
        {
            try
            {
                int userId;
                using (UserServiceClient client = new UserServiceClient())
                {
                    userId = client.GetUser(token).UserId;
                }
                using (WebServiceContext db = new WebServiceContext())
                {
                    var canceledCarBooking = from cb in db.CarBookings
                                             where cb.CarBookingId == booking.CarBookingId && cb.UserId == userId
                                             select cb;
                    db.CarBookings.Remove(canceledCarBooking.First());
                    db.SaveChanges();

                    return !db.CarBookings.Any(cb => cb.CarBookingId == booking.CarBookingId);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}