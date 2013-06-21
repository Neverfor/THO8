using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CarRentalService.Domain
{
    [DataContract]
    public class City
    {
        [DataMember]
        public int CityId { get; set; }
        [DataMember]
        public virtual Country Country { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}
