using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.

[ServiceContract(Namespace = "http://taxiservice.michaeldv.nl/webservices")]
public interface ITaxiService
{


	[OperationContract]
    ServicesDataContracts.TaxiPriceInfo GetTaxiPriceInfo(ServicesDataContracts.TaxiPriceInfoRequest taxiPriceInfoRequest);

    [OperationContract]
    ServicesDataContracts.TaxiBooking DoTaxiBooking(ServicesDataContracts.TaxiBookingRequest taxiBookingRequest);

    [OperationContract]
    ServicesDataContracts.UserBookings GetUserBookings(ServicesDataContracts.UserBookingsRequest userBookingsRequest);

    [OperationContract]
    bool CancelBooking(ServicesDataContracts.CancelBookingRequest cancelBookingRequest);

    [OperationContract]
    string[] GetCitys(string country);

    [OperationContract]
    string[] GetAddress(ServicesDataContracts.GetAddressRequest getAddressRequest);

    [OperationContract]
    string[] GetSpecialLocations(string locationType);
}
