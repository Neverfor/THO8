using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace HotelWebService.ServiceDataContracts
{
    [DataContract]
    public class HotelInfo
    {
        [DataMember]
        public String name;
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        public String location;
        public String Location
        {
            get { return location; }
            set { location = value; }
        }

    }
}
