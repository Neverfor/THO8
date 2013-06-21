using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CarRentalService.Domain
{
    [DataContract]
    public class CarType
    {
        [DataMember]
        public int CarTypeId { get; set; }
        [DataMember]
        public int Maxpersons { get; set; }
        [DataMember]
        public double PricePerDay { get; set; }
        [DataMember]
        public string Type { get; set; }
    }
}
