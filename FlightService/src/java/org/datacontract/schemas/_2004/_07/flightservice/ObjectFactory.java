
package org.datacontract.schemas._2004._07.flightservice;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlElementDecl;
import javax.xml.bind.annotation.XmlRegistry;
import javax.xml.namespace.QName;


/**
 * This object contains factory methods for each 
 * Java content interface and Java element interface 
 * generated in the org.datacontract.schemas._2004._07.flightservice package. 
 * <p>An ObjectFactory allows you to programatically 
 * construct new instances of the Java representation 
 * for XML content. The Java representation of XML 
 * content can consist of schema derived interfaces 
 * and classes representing the binding of schema 
 * type definitions, element declarations and model 
 * groups.  Factory methods for each of these are 
 * provided in this class.
 * 
 */
@XmlRegistry
public class ObjectFactory {

    private final static QName _BookingDTO_QNAME = new QName("http://schemas.datacontract.org/2004/07/FlightService.DataModels", "BookingDTO");
    private final static QName _FlightDTO_QNAME = new QName("http://schemas.datacontract.org/2004/07/FlightService.DataModels", "FlightDTO");
    private final static QName _ArrayOfFlightDTO_QNAME = new QName("http://schemas.datacontract.org/2004/07/FlightService.DataModels", "ArrayOfFlightDTO");
    private final static QName _ArrayOfBookingDTO_QNAME = new QName("http://schemas.datacontract.org/2004/07/FlightService.DataModels", "ArrayOfBookingDTO");
    private final static QName _PassengerDTO_QNAME = new QName("http://schemas.datacontract.org/2004/07/FlightService.DataModels", "PassengerDTO");
    private final static QName _ArrayOfPassengerDTO_QNAME = new QName("http://schemas.datacontract.org/2004/07/FlightService.DataModels", "ArrayOfPassengerDTO");
    private final static QName _ArrayOfAirportDTO_QNAME = new QName("http://schemas.datacontract.org/2004/07/FlightService.DataModels", "ArrayOfAirportDTO");
    private final static QName _AirportDTO_QNAME = new QName("http://schemas.datacontract.org/2004/07/FlightService.DataModels", "AirportDTO");
    private final static QName _AirportDTOLongitude_QNAME = new QName("http://schemas.datacontract.org/2004/07/FlightService.DataModels", "Longitude");
    private final static QName _AirportDTOLatitude_QNAME = new QName("http://schemas.datacontract.org/2004/07/FlightService.DataModels", "Latitude");
    private final static QName _AirportDTOName_QNAME = new QName("http://schemas.datacontract.org/2004/07/FlightService.DataModels", "Name");
    private final static QName _BookingDTOPassengers_QNAME = new QName("http://schemas.datacontract.org/2004/07/FlightService.DataModels", "Passengers");
    private final static QName _BookingDTOFlight_QNAME = new QName("http://schemas.datacontract.org/2004/07/FlightService.DataModels", "Flight");
    private final static QName _PassengerDTOSurname_QNAME = new QName("http://schemas.datacontract.org/2004/07/FlightService.DataModels", "Surname");
    private final static QName _PassengerDTOFirstname_QNAME = new QName("http://schemas.datacontract.org/2004/07/FlightService.DataModels", "Firstname");
    private final static QName _PassengerDTOZipCode_QNAME = new QName("http://schemas.datacontract.org/2004/07/FlightService.DataModels", "ZipCode");
    private final static QName _PassengerDTOPlace_QNAME = new QName("http://schemas.datacontract.org/2004/07/FlightService.DataModels", "Place");
    private final static QName _PassengerDTOGender_QNAME = new QName("http://schemas.datacontract.org/2004/07/FlightService.DataModels", "Gender");
    private final static QName _PassengerDTOAddress_QNAME = new QName("http://schemas.datacontract.org/2004/07/FlightService.DataModels", "Address");
    private final static QName _PassengerDTOType_QNAME = new QName("http://schemas.datacontract.org/2004/07/FlightService.DataModels", "Type");
    private final static QName _FlightDTODestinationLatitude_QNAME = new QName("http://schemas.datacontract.org/2004/07/FlightService.DataModels", "DestinationLatitude");
    private final static QName _FlightDTODepartureName_QNAME = new QName("http://schemas.datacontract.org/2004/07/FlightService.DataModels", "DepartureName");
    private final static QName _FlightDTODepartureLongitude_QNAME = new QName("http://schemas.datacontract.org/2004/07/FlightService.DataModels", "DepartureLongitude");
    private final static QName _FlightDTODestinationName_QNAME = new QName("http://schemas.datacontract.org/2004/07/FlightService.DataModels", "DestinationName");
    private final static QName _FlightDTODestinationLongitude_QNAME = new QName("http://schemas.datacontract.org/2004/07/FlightService.DataModels", "DestinationLongitude");
    private final static QName _FlightDTOAirplaneName_QNAME = new QName("http://schemas.datacontract.org/2004/07/FlightService.DataModels", "AirplaneName");
    private final static QName _FlightDTODepartureLatitude_QNAME = new QName("http://schemas.datacontract.org/2004/07/FlightService.DataModels", "DepartureLatitude");

    /**
     * Create a new ObjectFactory that can be used to create new instances of schema derived classes for package: org.datacontract.schemas._2004._07.flightservice
     * 
     */
    public ObjectFactory() {
    }

    /**
     * Create an instance of {@link FlightDTO }
     * 
     */
    public FlightDTO createFlightDTO() {
        return new FlightDTO();
    }

    /**
     * Create an instance of {@link ArrayOfFlightDTO }
     * 
     */
    public ArrayOfFlightDTO createArrayOfFlightDTO() {
        return new ArrayOfFlightDTO();
    }

    /**
     * Create an instance of {@link BookingDTO }
     * 
     */
    public BookingDTO createBookingDTO() {
        return new BookingDTO();
    }

    /**
     * Create an instance of {@link ArrayOfPassengerDTO }
     * 
     */
    public ArrayOfPassengerDTO createArrayOfPassengerDTO() {
        return new ArrayOfPassengerDTO();
    }

    /**
     * Create an instance of {@link ArrayOfBookingDTO }
     * 
     */
    public ArrayOfBookingDTO createArrayOfBookingDTO() {
        return new ArrayOfBookingDTO();
    }

    /**
     * Create an instance of {@link ArrayOfAirportDTO }
     * 
     */
    public ArrayOfAirportDTO createArrayOfAirportDTO() {
        return new ArrayOfAirportDTO();
    }

    /**
     * Create an instance of {@link AirportDTO }
     * 
     */
    public AirportDTO createAirportDTO() {
        return new AirportDTO();
    }

    /**
     * Create an instance of {@link PassengerDTO }
     * 
     */
    public PassengerDTO createPassengerDTO() {
        return new PassengerDTO();
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link BookingDTO }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", name = "BookingDTO")
    public JAXBElement<BookingDTO> createBookingDTO(BookingDTO value) {
        return new JAXBElement<BookingDTO>(_BookingDTO_QNAME, BookingDTO.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link FlightDTO }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", name = "FlightDTO")
    public JAXBElement<FlightDTO> createFlightDTO(FlightDTO value) {
        return new JAXBElement<FlightDTO>(_FlightDTO_QNAME, FlightDTO.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ArrayOfFlightDTO }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", name = "ArrayOfFlightDTO")
    public JAXBElement<ArrayOfFlightDTO> createArrayOfFlightDTO(ArrayOfFlightDTO value) {
        return new JAXBElement<ArrayOfFlightDTO>(_ArrayOfFlightDTO_QNAME, ArrayOfFlightDTO.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ArrayOfBookingDTO }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", name = "ArrayOfBookingDTO")
    public JAXBElement<ArrayOfBookingDTO> createArrayOfBookingDTO(ArrayOfBookingDTO value) {
        return new JAXBElement<ArrayOfBookingDTO>(_ArrayOfBookingDTO_QNAME, ArrayOfBookingDTO.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link PassengerDTO }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", name = "PassengerDTO")
    public JAXBElement<PassengerDTO> createPassengerDTO(PassengerDTO value) {
        return new JAXBElement<PassengerDTO>(_PassengerDTO_QNAME, PassengerDTO.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ArrayOfPassengerDTO }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", name = "ArrayOfPassengerDTO")
    public JAXBElement<ArrayOfPassengerDTO> createArrayOfPassengerDTO(ArrayOfPassengerDTO value) {
        return new JAXBElement<ArrayOfPassengerDTO>(_ArrayOfPassengerDTO_QNAME, ArrayOfPassengerDTO.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ArrayOfAirportDTO }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", name = "ArrayOfAirportDTO")
    public JAXBElement<ArrayOfAirportDTO> createArrayOfAirportDTO(ArrayOfAirportDTO value) {
        return new JAXBElement<ArrayOfAirportDTO>(_ArrayOfAirportDTO_QNAME, ArrayOfAirportDTO.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link AirportDTO }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", name = "AirportDTO")
    public JAXBElement<AirportDTO> createAirportDTO(AirportDTO value) {
        return new JAXBElement<AirportDTO>(_AirportDTO_QNAME, AirportDTO.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", name = "Longitude", scope = AirportDTO.class)
    public JAXBElement<String> createAirportDTOLongitude(String value) {
        return new JAXBElement<String>(_AirportDTOLongitude_QNAME, String.class, AirportDTO.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", name = "Latitude", scope = AirportDTO.class)
    public JAXBElement<String> createAirportDTOLatitude(String value) {
        return new JAXBElement<String>(_AirportDTOLatitude_QNAME, String.class, AirportDTO.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", name = "Name", scope = AirportDTO.class)
    public JAXBElement<String> createAirportDTOName(String value) {
        return new JAXBElement<String>(_AirportDTOName_QNAME, String.class, AirportDTO.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ArrayOfPassengerDTO }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", name = "Passengers", scope = BookingDTO.class)
    public JAXBElement<ArrayOfPassengerDTO> createBookingDTOPassengers(ArrayOfPassengerDTO value) {
        return new JAXBElement<ArrayOfPassengerDTO>(_BookingDTOPassengers_QNAME, ArrayOfPassengerDTO.class, BookingDTO.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link FlightDTO }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", name = "Flight", scope = BookingDTO.class)
    public JAXBElement<FlightDTO> createBookingDTOFlight(FlightDTO value) {
        return new JAXBElement<FlightDTO>(_BookingDTOFlight_QNAME, FlightDTO.class, BookingDTO.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", name = "Surname", scope = PassengerDTO.class)
    public JAXBElement<String> createPassengerDTOSurname(String value) {
        return new JAXBElement<String>(_PassengerDTOSurname_QNAME, String.class, PassengerDTO.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", name = "Firstname", scope = PassengerDTO.class)
    public JAXBElement<String> createPassengerDTOFirstname(String value) {
        return new JAXBElement<String>(_PassengerDTOFirstname_QNAME, String.class, PassengerDTO.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", name = "ZipCode", scope = PassengerDTO.class)
    public JAXBElement<String> createPassengerDTOZipCode(String value) {
        return new JAXBElement<String>(_PassengerDTOZipCode_QNAME, String.class, PassengerDTO.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", name = "Place", scope = PassengerDTO.class)
    public JAXBElement<String> createPassengerDTOPlace(String value) {
        return new JAXBElement<String>(_PassengerDTOPlace_QNAME, String.class, PassengerDTO.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", name = "Gender", scope = PassengerDTO.class)
    public JAXBElement<String> createPassengerDTOGender(String value) {
        return new JAXBElement<String>(_PassengerDTOGender_QNAME, String.class, PassengerDTO.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", name = "Address", scope = PassengerDTO.class)
    public JAXBElement<String> createPassengerDTOAddress(String value) {
        return new JAXBElement<String>(_PassengerDTOAddress_QNAME, String.class, PassengerDTO.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", name = "Type", scope = PassengerDTO.class)
    public JAXBElement<String> createPassengerDTOType(String value) {
        return new JAXBElement<String>(_PassengerDTOType_QNAME, String.class, PassengerDTO.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", name = "DestinationLatitude", scope = FlightDTO.class)
    public JAXBElement<String> createFlightDTODestinationLatitude(String value) {
        return new JAXBElement<String>(_FlightDTODestinationLatitude_QNAME, String.class, FlightDTO.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", name = "Longitude", scope = FlightDTO.class)
    public JAXBElement<String> createFlightDTOLongitude(String value) {
        return new JAXBElement<String>(_AirportDTOLongitude_QNAME, String.class, FlightDTO.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", name = "DepartureName", scope = FlightDTO.class)
    public JAXBElement<String> createFlightDTODepartureName(String value) {
        return new JAXBElement<String>(_FlightDTODepartureName_QNAME, String.class, FlightDTO.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", name = "Latitude", scope = FlightDTO.class)
    public JAXBElement<String> createFlightDTOLatitude(String value) {
        return new JAXBElement<String>(_AirportDTOLatitude_QNAME, String.class, FlightDTO.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", name = "DepartureLongitude", scope = FlightDTO.class)
    public JAXBElement<String> createFlightDTODepartureLongitude(String value) {
        return new JAXBElement<String>(_FlightDTODepartureLongitude_QNAME, String.class, FlightDTO.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", name = "DestinationName", scope = FlightDTO.class)
    public JAXBElement<String> createFlightDTODestinationName(String value) {
        return new JAXBElement<String>(_FlightDTODestinationName_QNAME, String.class, FlightDTO.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", name = "DestinationLongitude", scope = FlightDTO.class)
    public JAXBElement<String> createFlightDTODestinationLongitude(String value) {
        return new JAXBElement<String>(_FlightDTODestinationLongitude_QNAME, String.class, FlightDTO.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", name = "AirplaneName", scope = FlightDTO.class)
    public JAXBElement<String> createFlightDTOAirplaneName(String value) {
        return new JAXBElement<String>(_FlightDTOAirplaneName_QNAME, String.class, FlightDTO.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", name = "DepartureLatitude", scope = FlightDTO.class)
    public JAXBElement<String> createFlightDTODepartureLatitude(String value) {
        return new JAXBElement<String>(_FlightDTODepartureLatitude_QNAME, String.class, FlightDTO.class, value);
    }

}
