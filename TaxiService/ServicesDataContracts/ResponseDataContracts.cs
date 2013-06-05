using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ServicesDataContracts
{
    [DataContract]
    public class TaxiPriceInfo
    {
        int taxiId = 0;
        string taxiType = "Car";
        double price = 0.00;
        Address departureAddress = null;
        Address destinationAddress = null;
        DateTime dateTime = DateTime.Now;
        bool isDepartureTime = true;
        int amountOfPassengers = 1;

        [DataMember]
        public Address DepartureAddress
        {
            get { return departureAddress; }
            set { departureAddress = value; }
        }

        [DataMember]
        public Address DestinationAddress
        {
            get { return destinationAddress; }
            set { destinationAddress = value; }
        }

        [DataMember]
        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }

        [DataMember]
        public bool IsDepartureTime
        {
            get { return isDepartureTime; }
            set { isDepartureTime = value; }
        }

        [DataMember]
        public int AmountOfPassengers
        {
            get { return amountOfPassengers; }
            set { amountOfPassengers = value; }
        }

        [DataMember]
        public int TaxiId
        {
            get { return taxiId; }
            set { taxiId = value; }
        }

        [DataMember]
        public string TaxiType
        {
            get { return taxiType; }
            set { taxiType = value; }
        }

        [DataMember]
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    }

    [DataContract]
    public class UserBookings
    {
        [DataMember]
        List<TaxiBooking> TaxiBookings { get; set; }
    }


    [DataContract]
    public class TaxiBooking : TaxiPriceInfo
    {
       
    }


}