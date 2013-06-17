namespace HotelService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Hotel", Namespace="http://schemas.datacontract.org/2004/07/HotelService")]
    public partial class Hotel : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string DescriptionField;
        
        private short HotelIdField;
        
        private string LocationField;
        
        private string NameField;
        
        private string[] PictureUrlField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short HotelId
        {
            get
            {
                return this.HotelIdField;
            }
            set
            {
                this.HotelIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Location
        {
            get
            {
                return this.LocationField;
            }
            set
            {
                this.LocationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] PictureUrl
        {
            get
            {
                return this.PictureUrlField;
            }
            set
            {
                this.PictureUrlField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RoomType", Namespace="http://schemas.datacontract.org/2004/07/HotelService")]
    public partial class RoomType : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private short AmountField;
        
        private string DescriptionField;
        
        private short MaxPersonsField;
        
        private string NameField;
        
        private short RoomTypeIdField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short Amount
        {
            get
            {
                return this.AmountField;
            }
            set
            {
                this.AmountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short MaxPersons
        {
            get
            {
                return this.MaxPersonsField;
            }
            set
            {
                this.MaxPersonsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short RoomTypeId
        {
            get
            {
                return this.RoomTypeIdField;
            }
            set
            {
                this.RoomTypeIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BookingRow", Namespace="http://schemas.datacontract.org/2004/07/HotelService")]
    public partial class BookingRow : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private short AmountField;
        
        private short BookingRowIdField;
        
        private HotelService.RoomType RoomTypeField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short Amount
        {
            get
            {
                return this.AmountField;
            }
            set
            {
                this.AmountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short BookingRowId
        {
            get
            {
                return this.BookingRowIdField;
            }
            set
            {
                this.BookingRowIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HotelService.RoomType RoomType
        {
            get
            {
                return this.RoomTypeField;
            }
            set
            {
                this.RoomTypeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Booking", Namespace="http://schemas.datacontract.org/2004/07/HotelService")]
    public partial class Booking : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.DateTime ArrivalDateField;
        
        private short BookingIdField;
        
        private HotelService.BookingRow[] BookingRowField;
        
        private System.DateTime DepartureDateField;
        
        private HotelService.Status StatusField;
        
        private short TotalPersonsField;
        
        private short UserIdField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ArrivalDate
        {
            get
            {
                return this.ArrivalDateField;
            }
            set
            {
                this.ArrivalDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short BookingId
        {
            get
            {
                return this.BookingIdField;
            }
            set
            {
                this.BookingIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HotelService.BookingRow[] BookingRow
        {
            get
            {
                return this.BookingRowField;
            }
            set
            {
                this.BookingRowField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DepartureDate
        {
            get
            {
                return this.DepartureDateField;
            }
            set
            {
                this.DepartureDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HotelService.Status Status
        {
            get
            {
                return this.StatusField;
            }
            set
            {
                this.StatusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short TotalPersons
        {
            get
            {
                return this.TotalPersonsField;
            }
            set
            {
                this.TotalPersonsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short UserId
        {
            get
            {
                return this.UserIdField;
            }
            set
            {
                this.UserIdField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Status", Namespace="http://schemas.datacontract.org/2004/07/HotelService")]
    public enum Status : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        reserved = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        cancelled = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        expired = 2,
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://hotelservice.com", ConfigurationName="IHotelBookingService")]
public interface IHotelBookingService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://hotelservice.com/IHotelBookingService/getHotels", ReplyAction="http://hotelservice.com/IHotelBookingService/getHotelsResponse")]
    HotelService.Hotel[] getHotels(string name, string location);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://hotelservice.com/IHotelBookingService/getHotels", ReplyAction="http://hotelservice.com/IHotelBookingService/getHotelsResponse")]
    System.Threading.Tasks.Task<HotelService.Hotel[]> getHotelsAsync(string name, string location);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://hotelservice.com/IHotelBookingService/getRoomTypesFromHotel", ReplyAction="http://hotelservice.com/IHotelBookingService/getRoomTypesFromHotelResponse")]
    HotelService.RoomType[] getRoomTypesFromHotel(short hotelId, System.DateTime arrivalDate, System.DateTime departureDate, short totalPersons);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://hotelservice.com/IHotelBookingService/getRoomTypesFromHotel", ReplyAction="http://hotelservice.com/IHotelBookingService/getRoomTypesFromHotelResponse")]
    System.Threading.Tasks.Task<HotelService.RoomType[]> getRoomTypesFromHotelAsync(short hotelId, System.DateTime arrivalDate, System.DateTime departureDate, short totalPersons);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://hotelservice.com/IHotelBookingService/bookRoom", ReplyAction="http://hotelservice.com/IHotelBookingService/bookRoomResponse")]
    short bookRoom(short hotelId, HotelService.BookingRow[] bookingRows, System.DateTime arrivalDate, System.DateTime departureDate, short totalPersons, string token);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://hotelservice.com/IHotelBookingService/bookRoom", ReplyAction="http://hotelservice.com/IHotelBookingService/bookRoomResponse")]
    System.Threading.Tasks.Task<short> bookRoomAsync(short hotelId, HotelService.BookingRow[] bookingRows, System.DateTime arrivalDate, System.DateTime departureDate, short totalPersons, string token);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://hotelservice.com/IHotelBookingService/getBooking", ReplyAction="http://hotelservice.com/IHotelBookingService/getBookingResponse")]
    HotelService.Booking getBooking(short bookingId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://hotelservice.com/IHotelBookingService/getBooking", ReplyAction="http://hotelservice.com/IHotelBookingService/getBookingResponse")]
    System.Threading.Tasks.Task<HotelService.Booking> getBookingAsync(short bookingId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://hotelservice.com/IHotelBookingService/GetBookingsFromUser", ReplyAction="http://hotelservice.com/IHotelBookingService/GetBookingsFromUserResponse")]
    HotelService.Booking[] GetBookingsFromUser(string token);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://hotelservice.com/IHotelBookingService/GetBookingsFromUser", ReplyAction="http://hotelservice.com/IHotelBookingService/GetBookingsFromUserResponse")]
    System.Threading.Tasks.Task<HotelService.Booking[]> GetBookingsFromUserAsync(string token);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://hotelservice.com/IHotelBookingService/CancelBooking", ReplyAction="http://hotelservice.com/IHotelBookingService/CancelBookingResponse")]
    bool CancelBooking(short bookingId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://hotelservice.com/IHotelBookingService/CancelBooking", ReplyAction="http://hotelservice.com/IHotelBookingService/CancelBookingResponse")]
    System.Threading.Tasks.Task<bool> CancelBookingAsync(short bookingId);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IHotelBookingServiceChannel : IHotelBookingService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class HotelBookingServiceClient : System.ServiceModel.ClientBase<IHotelBookingService>, IHotelBookingService
{
    
    public HotelBookingServiceClient()
    {
    }
    
    public HotelBookingServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public HotelBookingServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public HotelBookingServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public HotelBookingServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public HotelService.Hotel[] getHotels(string name, string location)
    {
        return base.Channel.getHotels(name, location);
    }
    
    public System.Threading.Tasks.Task<HotelService.Hotel[]> getHotelsAsync(string name, string location)
    {
        return base.Channel.getHotelsAsync(name, location);
    }
    
    public HotelService.RoomType[] getRoomTypesFromHotel(short hotelId, System.DateTime arrivalDate, System.DateTime departureDate, short totalPersons)
    {
        return base.Channel.getRoomTypesFromHotel(hotelId, arrivalDate, departureDate, totalPersons);
    }
    
    public System.Threading.Tasks.Task<HotelService.RoomType[]> getRoomTypesFromHotelAsync(short hotelId, System.DateTime arrivalDate, System.DateTime departureDate, short totalPersons)
    {
        return base.Channel.getRoomTypesFromHotelAsync(hotelId, arrivalDate, departureDate, totalPersons);
    }
    
    public short bookRoom(short hotelId, HotelService.BookingRow[] bookingRows, System.DateTime arrivalDate, System.DateTime departureDate, short totalPersons, string token)
    {
        return base.Channel.bookRoom(hotelId, bookingRows, arrivalDate, departureDate, totalPersons, token);
    }
    
    public System.Threading.Tasks.Task<short> bookRoomAsync(short hotelId, HotelService.BookingRow[] bookingRows, System.DateTime arrivalDate, System.DateTime departureDate, short totalPersons, string token)
    {
        return base.Channel.bookRoomAsync(hotelId, bookingRows, arrivalDate, departureDate, totalPersons, token);
    }
    
    public HotelService.Booking getBooking(short bookingId)
    {
        return base.Channel.getBooking(bookingId);
    }
    
    public System.Threading.Tasks.Task<HotelService.Booking> getBookingAsync(short bookingId)
    {
        return base.Channel.getBookingAsync(bookingId);
    }
    
    public HotelService.Booking[] GetBookingsFromUser(string token)
    {
        return base.Channel.GetBookingsFromUser(token);
    }
    
    public System.Threading.Tasks.Task<HotelService.Booking[]> GetBookingsFromUserAsync(string token)
    {
        return base.Channel.GetBookingsFromUserAsync(token);
    }
    
    public bool CancelBooking(short bookingId)
    {
        return base.Channel.CancelBooking(bookingId);
    }
    
    public System.Threading.Tasks.Task<bool> CancelBookingAsync(short bookingId)
    {
        return base.Channel.CancelBookingAsync(bookingId);
    }
}
