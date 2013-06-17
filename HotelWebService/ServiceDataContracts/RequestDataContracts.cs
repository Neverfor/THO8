using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace HotelWebService.ServiceDataContracts
{
    [DataContract]
    public class HotelInfoRequest
    {
        private String name;
        private String location;

        [DataMember(IsRequired = false)]
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember(IsRequired = true)]
        public String Location
        {
            get { return location; }
            set { location = value; }
        }
   
    }

    
}
