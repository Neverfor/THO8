﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18047
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaxiClient.CarRentalService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CountryContract", Namespace="http://schemas.datacontract.org/2004/07/CarRentalService.Contracts")]
    [System.SerializableAttribute()]
    public partial class CountryContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CountryIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CountryId {
            get {
                return this.CountryIdField;
            }
            set {
                if ((this.CountryIdField.Equals(value) != true)) {
                    this.CountryIdField = value;
                    this.RaisePropertyChanged("CountryId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CityContract", Namespace="http://schemas.datacontract.org/2004/07/CarRentalService.Contracts")]
    [System.SerializableAttribute()]
    public partial class CityContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CityIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CityId {
            get {
                return this.CityIdField;
            }
            set {
                if ((this.CityIdField.Equals(value) != true)) {
                    this.CityIdField = value;
                    this.RaisePropertyChanged("CityId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DealerContract", Namespace="http://schemas.datacontract.org/2004/07/CarRentalService.Contracts")]
    [System.SerializableAttribute()]
    public partial class DealerContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DealerIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DealerId {
            get {
                return this.DealerIdField;
            }
            set {
                if ((this.DealerIdField.Equals(value) != true)) {
                    this.DealerIdField = value;
                    this.RaisePropertyChanged("DealerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CarContract", Namespace="http://schemas.datacontract.org/2004/07/CarRentalService.Contracts")]
    [System.SerializableAttribute()]
    public partial class CarContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BrandField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CarIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TaxiClient.CarRentalService.CarTypeContract CarTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateOfPurchaseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LicenceField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Brand {
            get {
                return this.BrandField;
            }
            set {
                if ((object.ReferenceEquals(this.BrandField, value) != true)) {
                    this.BrandField = value;
                    this.RaisePropertyChanged("Brand");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CarId {
            get {
                return this.CarIdField;
            }
            set {
                if ((this.CarIdField.Equals(value) != true)) {
                    this.CarIdField = value;
                    this.RaisePropertyChanged("CarId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TaxiClient.CarRentalService.CarTypeContract CarType {
            get {
                return this.CarTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.CarTypeField, value) != true)) {
                    this.CarTypeField = value;
                    this.RaisePropertyChanged("CarType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateOfPurchase {
            get {
                return this.DateOfPurchaseField;
            }
            set {
                if ((this.DateOfPurchaseField.Equals(value) != true)) {
                    this.DateOfPurchaseField = value;
                    this.RaisePropertyChanged("DateOfPurchase");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Licence {
            get {
                return this.LicenceField;
            }
            set {
                if ((object.ReferenceEquals(this.LicenceField, value) != true)) {
                    this.LicenceField = value;
                    this.RaisePropertyChanged("Licence");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CarTypeContract", Namespace="http://schemas.datacontract.org/2004/07/CarRentalService.Contracts")]
    [System.SerializableAttribute()]
    public partial class CarTypeContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CarTypeIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MaxpersonsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PricePerDayField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CarTypeId {
            get {
                return this.CarTypeIdField;
            }
            set {
                if ((this.CarTypeIdField.Equals(value) != true)) {
                    this.CarTypeIdField = value;
                    this.RaisePropertyChanged("CarTypeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Maxpersons {
            get {
                return this.MaxpersonsField;
            }
            set {
                if ((this.MaxpersonsField.Equals(value) != true)) {
                    this.MaxpersonsField = value;
                    this.RaisePropertyChanged("Maxpersons");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double PricePerDay {
            get {
                return this.PricePerDayField;
            }
            set {
                if ((this.PricePerDayField.Equals(value) != true)) {
                    this.PricePerDayField = value;
                    this.RaisePropertyChanged("PricePerDay");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CarBookingContract", Namespace="http://schemas.datacontract.org/2004/07/CarRentalService.Contracts")]
    [System.SerializableAttribute()]
    public partial class CarBookingContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TaxiClient.CarRentalService.CarContract CarField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CarBookingIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime EndDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime StartDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TaxiClient.CarRentalService.CarContract Car {
            get {
                return this.CarField;
            }
            set {
                if ((object.ReferenceEquals(this.CarField, value) != true)) {
                    this.CarField = value;
                    this.RaisePropertyChanged("Car");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CarBookingId {
            get {
                return this.CarBookingIdField;
            }
            set {
                if ((this.CarBookingIdField.Equals(value) != true)) {
                    this.CarBookingIdField = value;
                    this.RaisePropertyChanged("CarBookingId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime EndDate {
            get {
                return this.EndDateField;
            }
            set {
                if ((this.EndDateField.Equals(value) != true)) {
                    this.EndDateField = value;
                    this.RaisePropertyChanged("EndDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime StartDate {
            get {
                return this.StartDateField;
            }
            set {
                if ((this.StartDateField.Equals(value) != true)) {
                    this.StartDateField = value;
                    this.RaisePropertyChanged("StartDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://taxiservice.michaeldv.nl/webservices", ConfigurationName="CarRentalService.IWebService")]
    public interface IWebService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://taxiservice.michaeldv.nl/webservices/IWebService/GetCountries", ReplyAction="http://taxiservice.michaeldv.nl/webservices/IWebService/GetCountriesResponse")]
        TaxiClient.CarRentalService.CountryContract[] GetCountries();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://taxiservice.michaeldv.nl/webservices/IWebService/GetCountries", ReplyAction="http://taxiservice.michaeldv.nl/webservices/IWebService/GetCountriesResponse")]
        System.Threading.Tasks.Task<TaxiClient.CarRentalService.CountryContract[]> GetCountriesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://taxiservice.michaeldv.nl/webservices/IWebService/GetCities", ReplyAction="http://taxiservice.michaeldv.nl/webservices/IWebService/GetCitiesResponse")]
        TaxiClient.CarRentalService.CityContract[] GetCities(TaxiClient.CarRentalService.CountryContract country);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://taxiservice.michaeldv.nl/webservices/IWebService/GetCities", ReplyAction="http://taxiservice.michaeldv.nl/webservices/IWebService/GetCitiesResponse")]
        System.Threading.Tasks.Task<TaxiClient.CarRentalService.CityContract[]> GetCitiesAsync(TaxiClient.CarRentalService.CountryContract country);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://taxiservice.michaeldv.nl/webservices/IWebService/GetDealers", ReplyAction="http://taxiservice.michaeldv.nl/webservices/IWebService/GetDealersResponse")]
        TaxiClient.CarRentalService.DealerContract[] GetDealers(TaxiClient.CarRentalService.CityContract city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://taxiservice.michaeldv.nl/webservices/IWebService/GetDealers", ReplyAction="http://taxiservice.michaeldv.nl/webservices/IWebService/GetDealersResponse")]
        System.Threading.Tasks.Task<TaxiClient.CarRentalService.DealerContract[]> GetDealersAsync(TaxiClient.CarRentalService.CityContract city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://taxiservice.michaeldv.nl/webservices/IWebService/GetCars", ReplyAction="http://taxiservice.michaeldv.nl/webservices/IWebService/GetCarsResponse")]
        TaxiClient.CarRentalService.CarContract[] GetCars(TaxiClient.CarRentalService.DealerContract dealer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://taxiservice.michaeldv.nl/webservices/IWebService/GetCars", ReplyAction="http://taxiservice.michaeldv.nl/webservices/IWebService/GetCarsResponse")]
        System.Threading.Tasks.Task<TaxiClient.CarRentalService.CarContract[]> GetCarsAsync(TaxiClient.CarRentalService.DealerContract dealer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://taxiservice.michaeldv.nl/webservices/IWebService/IsAvailable", ReplyAction="http://taxiservice.michaeldv.nl/webservices/IWebService/IsAvailableResponse")]
        bool IsAvailable(TaxiClient.CarRentalService.CarContract car, System.DateTime startDate, System.DateTime endDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://taxiservice.michaeldv.nl/webservices/IWebService/IsAvailable", ReplyAction="http://taxiservice.michaeldv.nl/webservices/IWebService/IsAvailableResponse")]
        System.Threading.Tasks.Task<bool> IsAvailableAsync(TaxiClient.CarRentalService.CarContract car, System.DateTime startDate, System.DateTime endDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://taxiservice.michaeldv.nl/webservices/IWebService/Book", ReplyAction="http://taxiservice.michaeldv.nl/webservices/IWebService/BookResponse")]
        TaxiClient.CarRentalService.CarBookingContract Book(TaxiClient.CarRentalService.CarBookingContract booking, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://taxiservice.michaeldv.nl/webservices/IWebService/Book", ReplyAction="http://taxiservice.michaeldv.nl/webservices/IWebService/BookResponse")]
        System.Threading.Tasks.Task<TaxiClient.CarRentalService.CarBookingContract> BookAsync(TaxiClient.CarRentalService.CarBookingContract booking, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://taxiservice.michaeldv.nl/webservices/IWebService/getUserBookings", ReplyAction="http://taxiservice.michaeldv.nl/webservices/IWebService/getUserBookingsResponse")]
        TaxiClient.CarRentalService.CarBookingContract[] getUserBookings(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://taxiservice.michaeldv.nl/webservices/IWebService/getUserBookings", ReplyAction="http://taxiservice.michaeldv.nl/webservices/IWebService/getUserBookingsResponse")]
        System.Threading.Tasks.Task<TaxiClient.CarRentalService.CarBookingContract[]> getUserBookingsAsync(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://taxiservice.michaeldv.nl/webservices/IWebService/CancelBooking", ReplyAction="http://taxiservice.michaeldv.nl/webservices/IWebService/CancelBookingResponse")]
        bool CancelBooking(TaxiClient.CarRentalService.CarBookingContract booking, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://taxiservice.michaeldv.nl/webservices/IWebService/CancelBooking", ReplyAction="http://taxiservice.michaeldv.nl/webservices/IWebService/CancelBookingResponse")]
        System.Threading.Tasks.Task<bool> CancelBookingAsync(TaxiClient.CarRentalService.CarBookingContract booking, string token);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWebServiceChannel : TaxiClient.CarRentalService.IWebService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceClient : System.ServiceModel.ClientBase<TaxiClient.CarRentalService.IWebService>, TaxiClient.CarRentalService.IWebService {
        
        public WebServiceClient() {
        }
        
        public WebServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TaxiClient.CarRentalService.CountryContract[] GetCountries() {
            return base.Channel.GetCountries();
        }
        
        public System.Threading.Tasks.Task<TaxiClient.CarRentalService.CountryContract[]> GetCountriesAsync() {
            return base.Channel.GetCountriesAsync();
        }
        
        public TaxiClient.CarRentalService.CityContract[] GetCities(TaxiClient.CarRentalService.CountryContract country) {
            return base.Channel.GetCities(country);
        }
        
        public System.Threading.Tasks.Task<TaxiClient.CarRentalService.CityContract[]> GetCitiesAsync(TaxiClient.CarRentalService.CountryContract country) {
            return base.Channel.GetCitiesAsync(country);
        }
        
        public TaxiClient.CarRentalService.DealerContract[] GetDealers(TaxiClient.CarRentalService.CityContract city) {
            return base.Channel.GetDealers(city);
        }
        
        public System.Threading.Tasks.Task<TaxiClient.CarRentalService.DealerContract[]> GetDealersAsync(TaxiClient.CarRentalService.CityContract city) {
            return base.Channel.GetDealersAsync(city);
        }
        
        public TaxiClient.CarRentalService.CarContract[] GetCars(TaxiClient.CarRentalService.DealerContract dealer) {
            return base.Channel.GetCars(dealer);
        }
        
        public System.Threading.Tasks.Task<TaxiClient.CarRentalService.CarContract[]> GetCarsAsync(TaxiClient.CarRentalService.DealerContract dealer) {
            return base.Channel.GetCarsAsync(dealer);
        }
        
        public bool IsAvailable(TaxiClient.CarRentalService.CarContract car, System.DateTime startDate, System.DateTime endDate) {
            return base.Channel.IsAvailable(car, startDate, endDate);
        }
        
        public System.Threading.Tasks.Task<bool> IsAvailableAsync(TaxiClient.CarRentalService.CarContract car, System.DateTime startDate, System.DateTime endDate) {
            return base.Channel.IsAvailableAsync(car, startDate, endDate);
        }
        
        public TaxiClient.CarRentalService.CarBookingContract Book(TaxiClient.CarRentalService.CarBookingContract booking, string token) {
            return base.Channel.Book(booking, token);
        }
        
        public System.Threading.Tasks.Task<TaxiClient.CarRentalService.CarBookingContract> BookAsync(TaxiClient.CarRentalService.CarBookingContract booking, string token) {
            return base.Channel.BookAsync(booking, token);
        }
        
        public TaxiClient.CarRentalService.CarBookingContract[] getUserBookings(string token) {
            return base.Channel.getUserBookings(token);
        }
        
        public System.Threading.Tasks.Task<TaxiClient.CarRentalService.CarBookingContract[]> getUserBookingsAsync(string token) {
            return base.Channel.getUserBookingsAsync(token);
        }
        
        public bool CancelBooking(TaxiClient.CarRentalService.CarBookingContract booking, string token) {
            return base.Channel.CancelBooking(booking, token);
        }
        
        public System.Threading.Tasks.Task<bool> CancelBookingAsync(TaxiClient.CarRentalService.CarBookingContract booking, string token) {
            return base.Channel.CancelBookingAsync(booking, token);
        }
    }
}
