using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CarRentalService.Contracts;

namespace CarRentalService
{
    [ServiceContract(Namespace = "http://taxiservice.michaeldv.nl/webservices")]
    public interface IWebService
    {
        [OperationContract]
        CountryContract[] GetCountries();

        [OperationContract]
        CityContract[] GetCities(CountryContract country);

        [OperationContract]
        DealerContract[] GetDealers(CityContract city);

        [OperationContract]
        CarContract[] GetCars(DealerContract dealer);

        [OperationContract]
        bool IsAvailable(CarContract car, DateTime startDate, DateTime endDate);

        [OperationContract]
        CarBookingContract Book(CarBookingContract booking, string token);

        [OperationContract]
        CarBookingContract[] getUserBookings(string token);

        [OperationContract]
        bool CancelBooking(CarBookingContract booking, string token);
    }
}
