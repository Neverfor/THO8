using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ServicesDataContracts
{
    [DataContract]
    public class TaxiPriceInfoRequest
    {
        Address departureAddress = null;
        Address destinationAddress = null;
        DateTime dateTime = DateTime.Now;
        bool isDepartureTime = true;
        int amountOfPassengers = 1;

        [DataMember(IsRequired = true)]
        public Address DepartureAddress
        {
            get { return departureAddress; }
            set { departureAddress = value; }
        }

        [DataMember(IsRequired = true)]
        public Address DestinationAddress
        {
            get { return destinationAddress; }
            set { destinationAddress = value; }
        }

        [DataMember(IsRequired = true)]
        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }

        [DataMember(IsRequired = true)]
        public bool IsDepartureTime
        {
            get { return isDepartureTime; }
            set { isDepartureTime = value; }
        }

        [DataMember(IsRequired = true)]
        public int AmountOfPassengers
        {
            get { return amountOfPassengers; }
            set { amountOfPassengers = value; }
        }
    }

    [DataContract(Name="TaxiBookingRequest")]
    public class TaxiBookingRequest : TaxiPriceInfo
    {
        [DataMember(IsRequired = true)]
        public string UserToken { get; set; }
    }

    [DataContract]
    public class UserBookingsRequest
    {
        [DataMember]
        public int BookingId { get; set; }

        [DataMember(IsRequired=true)]
        public string UserToken { get; set; }
    }

    [DataContract]
    public class CancelBookingRequest
    {
        [DataMember(IsRequired = true)]
        public int BookingId { get; set; }

        [DataMember(IsRequired = true)]
        public string UserToken { get; set; }
    }

    [DataContract]
    public class GetAddressRequest
    {
        [DataMember(IsRequired = true)]
        public string LocationType { get; set; }

        [DataMember(IsRequired = true)]
        public string LocationName { get; set; }
    }


}