using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CarService.Domain
{
    [DataContract]
    public class Car
    {
        [DataMember]
        public int CarId { get; set; }
        [DataMember]
        public string Brand { get; set; }
        [DataMember]
        public virtual CarType CarType { get; set; }
        [DataMember]
        public DateTime DateOfPurchase { get; set; }
        [DataMember]
        public virtual Dealer Dealer { get; set; }
        [DataMember]
        public string Licence { get; set; }
    }
}
