using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TaxiService.ServicesDataContracts;
using TaxiService.Domain;

namespace TaxiService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWebService" in both code and config file together.
    [ServiceContract(Namespace = "http://taxiservice.michaeldv.nl/webservices")]
    public interface IWebService
    {
        [OperationContract]
        TaxiPriceInfo GetTaxiPriceInfo(TaxiPriceInfoRequest taxiPriceInfoRequest);

        [OperationContract]
        TaxiBooking DoTaxiBooking(TaxiBookingRequest taxiBookingRequest);

        [OperationContract]
        UserBookings GetUserBookings(UserBookingsRequest userBookingsRequest);

        [OperationContract]
        bool CancelBooking(CancelBookingRequest cancelBookingRequest);

        [OperationContract]
        string[] GetCitys(string country);

        [OperationContract]
        string[] GetAddress(GetAddressRequest getAddressRequest);

        [OperationContract]
        string[] GetSpecialLocations(string locationType);
    }
}
