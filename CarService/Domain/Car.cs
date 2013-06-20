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
        public string Brand { get; set; }
        [DataMember]
        public int CarId { get; set; }
        [DataMember]
        public CarType CarType { get; set; }
        [DataMember]
        public DateTime DateOfPurchase { get; set; }
        [DataMember]
        public Dealer DealerField { get; set; }
        [DataMember]
        public string LicenceField { get; set; }
    }
}
