using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using To8Libraries.Domain;

namespace TaxiService.ServicesDataContracts
{
    [DataContract]
    public class TaxiPriceInfo
    {
        [DataMember]
        public int TaxiId { get; set; }

        [DataMember]
        public string TaxiType { get; set; }

        [DataMember]
        public double Price { get; set; }

        [DataMember]
        public DateTime DepartureTime { get; set; }

        [DataMember]
        public DateTime ArrivalTime { get; set; }

        [DataMember]
        public int AmountOfPassengers { get; set; }
    }


    [DataContract]
    public class UserBookings
    {
        [DataMember]
        public List<TaxiBooking> TaxiBookings { get; set; }
    }

    [DataContract]
    public class TaxiBooking : TaxiPriceInfo
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string UserToken { get; set; }
    }
}