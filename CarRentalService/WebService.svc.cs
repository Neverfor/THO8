using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CarRentalService.Domain;
using CarRentalService.UserService;
using System.Data.Entity;

namespace CarRentalService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WebService" in both code and config file together.
    public class WebService : IWebService
    {
        public Country[] GetCountries()
        {
            using (var db = new WebServiceContext())
            {
                return db.Countries.ToArray();
            }
        }

        public City[] GetCities(Country country)
        {
            using (WebServiceContext db = new WebServiceContext())
            {
                var cities = from c in db.Cities
                             where c.Country == country
                             select c;
                return cities.ToArray();
            }
        }

        public Dealer[] GetDealers(City city)
        {
            using (WebServiceContext db = new WebServiceContext())
            {
                var dealers = from d in db.Dealers
                              where d.City == city
                              select d;
                return dealers.ToArray();
            }
        }

        public Car[] GetCars(Dealer dealer)
        {
            using (WebServiceContext db = new WebServiceContext())
            {
                var cars = from c in db.Cars
                           where c.Dealer == dealer
                           select c;
                return cars.ToArray();
            }
        }

        public bool IsAvailable(Car car, DateTime startDate, DateTime endDate)
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
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public CarBooking Book(CarBooking booking, string token)
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
                    booking.UserId = userId;
                    db.CarBookings.Add(booking);
                    db.SaveChanges();
                }
                return booking;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CarBooking[] getUserBookings(string token)
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
                    var carBookings = from cb in db.CarBookings
                                      where cb.UserId == userId
                                      select cb;
                    return carBookings.ToArray();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool CancelBooking(CarBooking booking, string token)
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