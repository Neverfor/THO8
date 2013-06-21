using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CarService.Domain;

namespace CarService
{
    [ServiceContract(Namespace = "http://taxiservice.michaeldv.nl/webservices")]
    public interface IWebService
    {
        [OperationContract]
        Country[] GetCountries();

        [OperationContract]
        City[] GetCities(Country country);

        [OperationContract]
        Dealer[] GetDealers(City city);

        [OperationContract]
        Car[] GetCars(Dealer dealer);

        [OperationContract]
        bool IsAvailable(Car car, DateTime startDate, DateTime endDate);

        [OperationContract]
        CarBooking Book(CarBooking booking, string token);

        [OperationContract]
        CarBooking[] getUserBookings(string token);

        [OperationContract]
        bool CancelBooking(CarBooking booking, string token);
    }
}
