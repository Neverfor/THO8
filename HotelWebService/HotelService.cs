using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using HotelWebService;
using HotelService;
using HotelWebService.ServiceDataContracts;
//using HotelBookingService;

namespace HotelWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HotelService" in both code and config file together.
    public class HotelService : IHotelService
    {
        //HotelBookingServiceClient hotClient = new HotelBookingServiceClient();
        public void GetHotels(HotelInfoRequest htm)
        {

        }
    }
}
