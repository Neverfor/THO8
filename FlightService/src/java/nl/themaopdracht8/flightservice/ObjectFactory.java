
package nl.themaopdracht8.flightservice;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlElementDecl;
import javax.xml.bind.annotation.XmlRegistry;
import javax.xml.namespace.QName;
import org.datacontract.schemas._2004._07.flightservice.ArrayOfAirportDTO;
import org.datacontract.schemas._2004._07.flightservice.ArrayOfBookingDTO;
import org.datacontract.schemas._2004._07.flightservice.ArrayOfFlightDTO;
import org.datacontract.schemas._2004._07.flightservice.ArrayOfPassengerDTO;
import org.datacontract.schemas._2004._07.flightservice.BookingDTO;
import org.datacontract.schemas._2004._07.flightservice.FlightDTO;


/**
 * This object contains factory methods for each 
 * Java content interface and Java element interface 
 * generated in the nl.themaopdracht8.flightservice package. 
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

    private final static QName _GetAirportsSearchValue_QNAME = new QName("http://flightservice.themaopdracht8.nl", "searchValue");
    private final static QName _BookFlightResponseBookFlightResult_QNAME = new QName("http://flightservice.themaopdracht8.nl", "BookFlightResult");
    private final static QName _ShowFlightsByDepartureResponseShowFlightsByDepartureResult_QNAME = new QName("http://flightservice.themaopdracht8.nl", "ShowFlightsByDepartureResult");
    private final static QName _GetPersonalBookingsResponseGetPersonalBookingsResult_QNAME = new QName("http://flightservice.themaopdracht8.nl", "GetPersonalBookingsResult");
    private final static QName _ShowFlightsByArrivalResponseShowFlightsByArrivalResult_QNAME = new QName("http://flightservice.themaopdracht8.nl", "ShowFlightsByArrivalResult");
    private final static QName _GetAirportsResponseGetAirportsResult_QNAME = new QName("http://flightservice.themaopdracht8.nl", "GetAirportsResult");
    private final static QName _BookFlightUserToken_QNAME = new QName("http://flightservice.themaopdracht8.nl", "userToken");
    private final static QName _BookFlightPassengers_QNAME = new QName("http://flightservice.themaopdracht8.nl", "passengers");
    private final static QName _GetFlightByIdResponseGetFlightByIdResult_QNAME = new QName("http://flightservice.themaopdracht8.nl", "GetFlightByIdResult");

    /**
     * Create a new ObjectFactory that can be used to create new instances of schema derived classes for package: nl.themaopdracht8.flightservice
     * 
     */
    public ObjectFactory() {
    }

    /**
     * Create an instance of {@link GetFlightByIdResponse }
     * 
     */
    public GetFlightByIdResponse createGetFlightByIdResponse() {
        return new GetFlightByIdResponse();
    }

    /**
     * Create an instance of {@link ShowFlightsByArrivalResponse }
     * 
     */
    public ShowFlightsByArrivalResponse createShowFlightsByArrivalResponse() {
        return new ShowFlightsByArrivalResponse();
    }

    /**
     * Create an instance of {@link BookFlightResponse }
     * 
     */
    public BookFlightResponse createBookFlightResponse() {
        return new BookFlightResponse();
    }

    /**
     * Create an instance of {@link GetAirports }
     * 
     */
    public GetAirports createGetAirports() {
        return new GetAirports();
    }

    /**
     * Create an instance of {@link ShowFlightsByDeparture }
     * 
     */
    public ShowFlightsByDeparture createShowFlightsByDeparture() {
        return new ShowFlightsByDeparture();
    }

    /**
     * Create an instance of {@link BookFlight }
     * 
     */
    public BookFlight createBookFlight() {
        return new BookFlight();
    }

    /**
     * Create an instance of {@link GetFlightById }
     * 
     */
    public GetFlightById createGetFlightById() {
        return new GetFlightById();
    }

    /**
     * Create an instance of {@link GetPersonalBookingsResponse }
     * 
     */
    public GetPersonalBookingsResponse createGetPersonalBookingsResponse() {
        return new GetPersonalBookingsResponse();
    }

    /**
     * Create an instance of {@link GetAirportsResponse }
     * 
     */
    public GetAirportsResponse createGetAirportsResponse() {
        return new GetAirportsResponse();
    }

    /**
     * Create an instance of {@link ShowFlightsByArrival }
     * 
     */
    public ShowFlightsByArrival createShowFlightsByArrival() {
        return new ShowFlightsByArrival();
    }

    /**
     * Create an instance of {@link ShowFlightsByDepartureResponse }
     * 
     */
    public ShowFlightsByDepartureResponse createShowFlightsByDepartureResponse() {
        return new ShowFlightsByDepartureResponse();
    }

    /**
     * Create an instance of {@link GetPersonalBookings }
     * 
     */
    public GetPersonalBookings createGetPersonalBookings() {
        return new GetPersonalBookings();
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://flightservice.themaopdracht8.nl", name = "searchValue", scope = GetAirports.class)
    public JAXBElement<String> createGetAirportsSearchValue(String value) {
        return new JAXBElement<String>(_GetAirportsSearchValue_QNAME, String.class, GetAirports.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link BookingDTO }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://flightservice.themaopdracht8.nl", name = "BookFlightResult", scope = BookFlightResponse.class)
    public JAXBElement<BookingDTO> createBookFlightResponseBookFlightResult(BookingDTO value) {
        return new JAXBElement<BookingDTO>(_BookFlightResponseBookFlightResult_QNAME, BookingDTO.class, BookFlightResponse.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ArrayOfFlightDTO }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://flightservice.themaopdracht8.nl", name = "ShowFlightsByDepartureResult", scope = ShowFlightsByDepartureResponse.class)
    public JAXBElement<ArrayOfFlightDTO> createShowFlightsByDepartureResponseShowFlightsByDepartureResult(ArrayOfFlightDTO value) {
        return new JAXBElement<ArrayOfFlightDTO>(_ShowFlightsByDepartureResponseShowFlightsByDepartureResult_QNAME, ArrayOfFlightDTO.class, ShowFlightsByDepartureResponse.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ArrayOfBookingDTO }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://flightservice.themaopdracht8.nl", name = "GetPersonalBookingsResult", scope = GetPersonalBookingsResponse.class)
    public JAXBElement<ArrayOfBookingDTO> createGetPersonalBookingsResponseGetPersonalBookingsResult(ArrayOfBookingDTO value) {
        return new JAXBElement<ArrayOfBookingDTO>(_GetPersonalBookingsResponseGetPersonalBookingsResult_QNAME, ArrayOfBookingDTO.class, GetPersonalBookingsResponse.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ArrayOfFlightDTO }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://flightservice.themaopdracht8.nl", name = "ShowFlightsByArrivalResult", scope = ShowFlightsByArrivalResponse.class)
    public JAXBElement<ArrayOfFlightDTO> createShowFlightsByArrivalResponseShowFlightsByArrivalResult(ArrayOfFlightDTO value) {
        return new JAXBElement<ArrayOfFlightDTO>(_ShowFlightsByArrivalResponseShowFlightsByArrivalResult_QNAME, ArrayOfFlightDTO.class, ShowFlightsByArrivalResponse.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ArrayOfAirportDTO }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://flightservice.themaopdracht8.nl", name = "GetAirportsResult", scope = GetAirportsResponse.class)
    public JAXBElement<ArrayOfAirportDTO> createGetAirportsResponseGetAirportsResult(ArrayOfAirportDTO value) {
        return new JAXBElement<ArrayOfAirportDTO>(_GetAirportsResponseGetAirportsResult_QNAME, ArrayOfAirportDTO.class, GetAirportsResponse.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://flightservice.themaopdracht8.nl", name = "userToken", scope = BookFlight.class)
    public JAXBElement<String> createBookFlightUserToken(String value) {
        return new JAXBElement<String>(_BookFlightUserToken_QNAME, String.class, BookFlight.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ArrayOfPassengerDTO }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://flightservice.themaopdracht8.nl", name = "passengers", scope = BookFlight.class)
    public JAXBElement<ArrayOfPassengerDTO> createBookFlightPassengers(ArrayOfPassengerDTO value) {
        return new JAXBElement<ArrayOfPassengerDTO>(_BookFlightPassengers_QNAME, ArrayOfPassengerDTO.class, BookFlight.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link FlightDTO }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://flightservice.themaopdracht8.nl", name = "GetFlightByIdResult", scope = GetFlightByIdResponse.class)
    public JAXBElement<FlightDTO> createGetFlightByIdResponseGetFlightByIdResult(FlightDTO value) {
        return new JAXBElement<FlightDTO>(_GetFlightByIdResponseGetFlightByIdResult_QNAME, FlightDTO.class, GetFlightByIdResponse.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://flightservice.themaopdracht8.nl", name = "userToken", scope = GetPersonalBookings.class)
    public JAXBElement<String> createGetPersonalBookingsUserToken(String value) {
        return new JAXBElement<String>(_BookFlightUserToken_QNAME, String.class, GetPersonalBookings.class, value);
    }

}
