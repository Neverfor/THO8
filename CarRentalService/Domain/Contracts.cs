using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CarRentalService.Contracts
{
    [DataContract]
    public class CarContract
    {
        [DataMember]
        public int CarId { get; set; }
        [DataMember]
        public string Brand { get; set; }
        [DataMember]
        public CarTypeContract CarType { get; set; }
        [DataMember]
        public DateTime DateOfPurchase { get; set; }
        //[DataMember]
        //public DealerContract Dealer { get; set; }
        [DataMember]
        public string Licence { get; set; }
    }

    [DataContract]
    public class CarBookingContract
    {
        [DataMember]
        public int CarBookingId { get; set; }
        [DataMember]
        public CarContract Car { get; set; }
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public DateTime StartDate { get; set; }
        [DataMember]
        public DateTime EndDate { get; set; }
        [DataMember]
        public int UserId { get; set; }
    }

    [DataContract]
    public class CarTypeContract
    {
        [DataMember]
        public int CarTypeId { get; set; }
        [DataMember]
        public int Maxpersons { get; set; }
        [DataMember]
        public double PricePerDay { get; set; }
        [DataMember]
        public string Type { get; set; }
    }

    [DataContract]
    public class CityContract
    {
        [DataMember]
        public int CityId { get; set; }
        //[DataMember]
        //public CountryContract Country { get; set; }
        [DataMember]
        public string Name { get; set; }
    }

    [DataContract]
    public class CountryContract
    {
        [DataMember]
        public int CountryId { get; set; }
        [DataMember]
        public string Name { get; set; }
    }

    [DataContract]
    public class DealerContract
    {
        [DataMember]
        public int DealerId { get; set; }
        //[DataMember]
        //public CityContract City { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}
