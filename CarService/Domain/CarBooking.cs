using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CarService.Domain
{
    [DataContract]
    public class CarBooking
    {
        [DataMember]
        public int BookingNr { get; set; }
        [DataMember]
        public Car Car { get; set; }
        [DataMember]
        public double PriceField { get; set; }
        [DataMember]
        public DateTime StartDate { get; set; }
        [DataMember]
        public DateTime EndDate { get; set; }
        [DataMember]
        public int UserId { get; set; }
    }
}
