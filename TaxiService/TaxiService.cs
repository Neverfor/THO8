using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

public class TaxiService : ITaxiService
{
    public ServicesDataContracts.TaxiPriceInfo GetTaxiPriceInfo(ServicesDataContracts.TaxiPriceInfoRequest taxiPriceInfoRequest)
    {
        List<Taxi> taxis = new List<Taxi>();
        Taxi taxi1 = new Taxi();
        taxi1.Id = 1;
        taxi1.PricePerKm = 5.00;
        taxi1.Type = "Sedan";
        taxis.Add(taxi1);

        Taxi taxiMetLaagstePrijs = null;
        foreach (Taxi taxi in taxis)
        {
            if (taxiMetLaagstePrijs == null || taxiMetLaagstePrijs.PricePerKm > taxi.PricePerKm)
                taxiMetLaagstePrijs = taxi;
        }

        ServicesDataContracts.TaxiPriceInfo priceInfo = new ServicesDataContracts.TaxiPriceInfo();
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


    public ServicesDataContracts.TaxiBooking DoTaxiBooking(ServicesDataContracts.TaxiPriceInfo taxiPriceInfo)
    {
        throw new NotImplementedException();
    }

    public ServicesDataContracts.UserBookings GetUserBookings(ServicesDataContracts.UserBookingsRequest userBookingsRequest)
    {
        throw new NotImplementedException();
    }

    public bool CancelBooking(ServicesDataContracts.CancelBookingRequest cancelBookingRequest)
    {
        throw new NotImplementedException();
    }


    public string[] GetCitys(string country)
    {
        throw new NotImplementedException();
    }

    public string[] GetAddress(ServicesDataContracts.GetAddressRequest getAddressRequest)
    {
        throw new NotImplementedException();
    }

    public string[] GetSpecialLocations(string locationType)
    {
        throw new NotImplementedException();
    }
}
