using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CarService.Domain
{
    [DataContract]
    public class Dealer
    {
        [DataMember]
        public City City { get; set; }
        [DataMember]
        public int DealerId { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}
