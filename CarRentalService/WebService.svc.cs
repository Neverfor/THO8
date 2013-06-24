using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CarRentalService.UserService;
using System.Data.Entity;
using System.Diagnostics;

namespace CarRentalService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WebService" in both code and config file together.
    public class WebService : IWebService
    {
        public Contracts.CountryContract[] GetCountries()
        {
            using (var db = new Entities.WebServiceContext())
            {
                Contracts.CountryContract[] response = new Contracts.CountryContract[db.Countries.Count()];
                for (int i = 0; i < db.Countries.Count(); i++)
                {
                    Contracts.CountryContract newCountry = new Contracts.CountryContract();
                    newCountry.CountryId = db.Countries.ElementAt(i).CountryId;
                    newCountry.Name = db.Countries.ElementAt(i).Name;
                    
                    response[i] = newCountry;
                }               
                return response;
            }
        }

        public Contracts.CityContract[] GetCities(Contracts.CountryContract country)
        {
            using (var db = new Entities.WebServiceContext())
            {
                Contracts.CityContract[] response = new Contracts.CityContract[db.Cities.Count()];
                for (int i = 0; i < db.Countries.Count(); i++)
                {
                    Contracts.CityContract newCity = new Contracts.CityContract();
                    newCity.CityId = db.Cities.ElementAt(i).CityId;
                    newCity.Name = db.Cities.ElementAt(i).Name;

                    Contracts.CountryContract newCountry = new Contracts.CountryContract();
                    newCountry.CountryId = db.Cities.ElementAt(i).Country.CountryId;
                    newCountry.Name = db.Cities.ElementAt(i).Country.Name;

                    newCity.Country = newCountry;

                    response[i] = newCity;
                }
                return response;
            }
        }

        public Contracts.DealerContract[] GetDealers(Contracts.CityContract city)
        {
            //using (WebServiceContext db = new WebServiceContext())
            //{
            //    var dealers = from d in db.Dealers
            //                  where d.City.CityId == city.CityId
            //                  select d;
            //    return dealers.ToArray<Dealer>();
            //}
            return null;
        }

        public Contracts.CarContract[] GetCars(Contracts.DealerContract dealer)
        {
            //using (WebServiceContext db = new WebServiceContext())
            //{
            //    var cars = from c in db.Cars
            //               where c.Dealer.DealerId == dealer.DealerId
            //               select c;
            //    return cars.ToArray<Car>();
            //}
            return null;
        }

        public bool IsAvailable(Contracts.CarContract car, DateTime startDate, DateTime endDate)
        {
            //using (WebServiceContext db = new WebServiceContext())
            //{
            //    var occupied = from cb in db.CarBookings
            //                   where (cb.Car.CarId == car.CarId) &&
            //                   ((cb.StartDate >= startDate && cb.StartDate < endDate) ||
            //                   (cb.EndDate > startDate && cb.EndDate < endDate) ||
            //                   (cb.StartDate < startDate && cb.EndDate > endDate))
            //                   select cb;
            //    try
            //    {
            //        occupied.First();
            //        return true;
            //    }
            //    catch (Exception ex)
            //    {
            //        return false;
            //    }
            //}
            return false;
        }

        public Contracts.CarBookingContract Book(CarRentalService.Contracts.CarBookingContract booking, string token)
        {
            //try
            //{
            //    int userId;
            //    using (UserServiceClient client = new UserServiceClient())
            //    {
            //        userId = client.GetUser(token).UserId;
            //    }
            //    using (WebServiceContext db = new WebServiceContext())
            //    {
            //        booking.UserId = userId;
            //        db.CarBookings.Add(booking);
            //        db.SaveChanges();
            //    }
            //    return booking;
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return null;
        }

        public Contracts.CarBookingContract[] getUserBookings(string token)
        {
            //try
            //{
            //    int userId;
            //    using (UserServiceClient client = new UserServiceClient())
            //    {
            //        userId = client.GetUser(token).UserId;
            //    }
            //    using (WebServiceContext db = new WebServiceContext())
            //    {
            //        var carBookings = from cb in db.CarBookings
            //                          where cb.UserId == userId
            //                          select cb;
            //        return carBookings.ToArray();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return null;
        }

        public bool CancelBooking(CarRentalService.Contracts.CarBookingContract booking, string token)
        {
            //try
            //{
            //    int userId;
            //    using (UserServiceClient client = new UserServiceClient())
            //    {
            //        userId = client.GetUser(token).UserId;
            //    }
            //    using (WebServiceContext db = new WebServiceContext())
            //    {
            //        var canceledCarBooking = from cb in db.CarBookings
            //                                 where cb.CarBookingId == booking.CarBookingId && cb.UserId == userId
            //                                 select cb;
            //        db.CarBookings.Remove(canceledCarBooking.First());
            //        db.SaveChanges();

            //        return !db.CarBookings.Any(cb => cb.CarBookingId == booking.CarBookingId);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return true;
        }
    }
}