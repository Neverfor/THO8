using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;


namespace To8Libraries.Domain
{
    [DataContract]
    public class Taxi
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public double PricePerKm { get; set; }

        [DataMember]
        public string Type { get; set; }

        [DataMember]
        public int maxPassengers { get; set; }
    }
}