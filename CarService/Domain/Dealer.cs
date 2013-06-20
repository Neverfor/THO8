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
        public int DealerId { get; set; }
        [DataMember]
        public virtual City City { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}
