using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CarRentalService.Domain
{
    [DataContract]
    public class CarBooking
    {
        [DataMember]
        public int CarBookingId { get; set; }
        [DataMember]
        public virtual Car Car { get; set; }
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public DateTime StartDate { get; set; }
        [DataMember]
        public DateTime EndDate { get; set; }
        [DataMember]
        public int UserId { get; set; }
    }
}
