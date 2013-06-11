using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace TaxiService.Domain
{
    [DataContract]
    public class Address
    {
        [DataMember]
        public string Street { get; set; }

        [DataMember]
        public int Number { get; set; }

        [DataMember(IsRequired = true)]
        public string City { get; set; }

        [DataMember(IsRequired = true)]
        public string Country { get; set; }

        [DataMember]
        public string ZipCode { get; set; }

        public Address()
        {

        }

        public override string ToString() 
        {
            return Street + Number + City + ZipCode + City + Country;
        }
    }

}