using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using TaxiService.ServicesDataContracts;


namespace TaxiService.Domain
{
    [DataContract]
    public class TaxiBooking : TaxiPriceInfo
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string UserToken { get; set; }
    }
}
