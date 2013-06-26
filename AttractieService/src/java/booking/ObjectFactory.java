
package booking;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlElementDecl;
import javax.xml.bind.annotation.XmlRegistry;
import javax.xml.namespace.QName;


/**
 * This object contains factory methods for each 
 * Java content interface and Java element interface 
 * generated in the booking package. 
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

    private final static QName _GetCountries_QNAME = new QName("http://booking/", "getCountries");
    private final static QName _GetCities_QNAME = new QName("http://booking/", "getCities");
    private final static QName _GetAttractionTypes_QNAME = new QName("http://booking/", "getAttractionTypes");
    private final static QName _GetCitiesResponse_QNAME = new QName("http://booking/", "getCitiesResponse");
    private final static QName _GetAttractions_QNAME = new QName("http://booking/", "getAttractions");
    private final static QName _GetAttractionsResponse_QNAME = new QName("http://booking/", "getAttractionsResponse");
    private final static QName _GetBookingResponse_QNAME = new QName("http://booking/", "getBookingResponse");
    private final static QName _GetRegionsResponse_QNAME = new QName("http://booking/", "getRegionsResponse");
    private final static QName _GetBooking_QNAME = new QName("http://booking/", "getBooking");
    private final static QName _BookAttractionResponse_QNAME = new QName("http://booking/", "bookAttractionResponse");
    private final static QName _GetRegions_QNAME = new QName("http://booking/", "getRegions");
    private final static QName _GetAttractionTypesResponse_QNAME = new QName("http://booking/", "getAttractionTypesResponse");
    private final static QName _BookAttraction_QNAME = new QName("http://booking/", "bookAttraction");
    private final static QName _GetCountriesResponse_QNAME = new QName("http://booking/", "getCountriesResponse");

    /**
     * Create a new ObjectFactory that can be used to create new instances of schema derived classes for package: booking
     * 
     */
    public ObjectFactory() {
    }

    /**
     * Create an instance of {@link GetAttractionsResponse }
     * 
     */
    public GetAttractionsResponse createGetAttractionsResponse() {
        return new GetAttractionsResponse();
    }

    /**
     * Create an instance of {@link GetBookingResponse }
     * 
     */
    public GetBookingResponse createGetBookingResponse() {
        return new GetBookingResponse();
    }

    /**
     * Create an instance of {@link GetRegionsResponse }
     * 
     */
    public GetRegionsResponse createGetRegionsResponse() {
        return new GetRegionsResponse();
    }

    /**
     * Create an instance of {@link GetBooking }
     * 
     */
    public GetBooking createGetBooking() {
        return new GetBooking();
    }

    /**
     * Create an instance of {@link GetAttractions }
     * 
     */
    public GetAttractions createGetAttractions() {
        return new GetAttractions();
    }

    /**
     * Create an instance of {@link GetCountriesResponse }
     * 
     */
    public GetCountriesResponse createGetCountriesResponse() {
        return new GetCountriesResponse();
    }

    /**
     * Create an instance of {@link BookAttraction }
     * 
     */
    public BookAttraction createBookAttraction() {
        return new BookAttraction();
    }

    /**
     * Create an instance of {@link GetRegions }
     * 
     */
    public GetRegions createGetRegions() {
        return new GetRegions();
    }

    /**
     * Create an instance of {@link BookAttractionResponse }
     * 
     */
    public BookAttractionResponse createBookAttractionResponse() {
        return new BookAttractionResponse();
    }

    /**
     * Create an instance of {@link GetAttractionTypesResponse }
     * 
     */
    public GetAttractionTypesResponse createGetAttractionTypesResponse() {
        return new GetAttractionTypesResponse();
    }

    /**
     * Create an instance of {@link GetCountries }
     * 
     */
    public GetCountries createGetCountries() {
        return new GetCountries();
    }

    /**
     * Create an instance of {@link GetCitiesResponse }
     * 
     */
    public GetCitiesResponse createGetCitiesResponse() {
        return new GetCitiesResponse();
    }

    /**
     * Create an instance of {@link GetAttractionTypes }
     * 
     */
    public GetAttractionTypes createGetAttractionTypes() {
        return new GetAttractionTypes();
    }

    /**
     * Create an instance of {@link GetCities }
     * 
     */
    public GetCities createGetCities() {
        return new GetCities();
    }

    /**
     * Create an instance of {@link Region }
     * 
     */
    public Region createRegion() {
        return new Region();
    }

    /**
     * Create an instance of {@link Booking }
     * 
     */
    public Booking createBooking() {
        return new Booking();
    }

    /**
     * Create an instance of {@link AttractieType }
     * 
     */
    public AttractieType createAttractieType() {
        return new AttractieType();
    }

    /**
     * Create an instance of {@link Country }
     * 
     */
    public Country createCountry() {
        return new Country();
    }

    /**
     * Create an instance of {@link City }
     * 
     */
    public City createCity() {
        return new City();
    }

    /**
     * Create an instance of {@link TicketType }
     * 
     */
    public TicketType createTicketType() {
        return new TicketType();
    }

    /**
     * Create an instance of {@link Attractie }
     * 
     */
    public Attractie createAttractie() {
        return new Attractie();
    }

    /**
     * Create an instance of {@link OrderedTicket }
     * 
     */
    public OrderedTicket createOrderedTicket() {
        return new OrderedTicket();
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link GetCountries }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://booking/", name = "getCountries")
    public JAXBElement<GetCountries> createGetCountries(GetCountries value) {
        return new JAXBElement<GetCountries>(_GetCountries_QNAME, GetCountries.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link GetCities }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://booking/", name = "getCities")
    public JAXBElement<GetCities> createGetCities(GetCities value) {
        return new JAXBElement<GetCities>(_GetCities_QNAME, GetCities.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link GetAttractionTypes }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://booking/", name = "getAttractionTypes")
    public JAXBElement<GetAttractionTypes> createGetAttractionTypes(GetAttractionTypes value) {
        return new JAXBElement<GetAttractionTypes>(_GetAttractionTypes_QNAME, GetAttractionTypes.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link GetCitiesResponse }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://booking/", name = "getCitiesResponse")
    public JAXBElement<GetCitiesResponse> createGetCitiesResponse(GetCitiesResponse value) {
        return new JAXBElement<GetCitiesResponse>(_GetCitiesResponse_QNAME, GetCitiesResponse.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link GetAttractions }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://booking/", name = "getAttractions")
    public JAXBElement<GetAttractions> createGetAttractions(GetAttractions value) {
        return new JAXBElement<GetAttractions>(_GetAttractions_QNAME, GetAttractions.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link GetAttractionsResponse }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://booking/", name = "getAttractionsResponse")
    public JAXBElement<GetAttractionsResponse> createGetAttractionsResponse(GetAttractionsResponse value) {
        return new JAXBElement<GetAttractionsResponse>(_GetAttractionsResponse_QNAME, GetAttractionsResponse.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link GetBookingResponse }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://booking/", name = "getBookingResponse")
    public JAXBElement<GetBookingResponse> createGetBookingResponse(GetBookingResponse value) {
        return new JAXBElement<GetBookingResponse>(_GetBookingResponse_QNAME, GetBookingResponse.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link GetRegionsResponse }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://booking/", name = "getRegionsResponse")
    public JAXBElement<GetRegionsResponse> createGetRegionsResponse(GetRegionsResponse value) {
        return new JAXBElement<GetRegionsResponse>(_GetRegionsResponse_QNAME, GetRegionsResponse.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link GetBooking }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://booking/", name = "getBooking")
    public JAXBElement<GetBooking> createGetBooking(GetBooking value) {
        return new JAXBElement<GetBooking>(_GetBooking_QNAME, GetBooking.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link BookAttractionResponse }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://booking/", name = "bookAttractionResponse")
    public JAXBElement<BookAttractionResponse> createBookAttractionResponse(BookAttractionResponse value) {
        return new JAXBElement<BookAttractionResponse>(_BookAttractionResponse_QNAME, BookAttractionResponse.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link GetRegions }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://booking/", name = "getRegions")
    public JAXBElement<GetRegions> createGetRegions(GetRegions value) {
        return new JAXBElement<GetRegions>(_GetRegions_QNAME, GetRegions.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link GetAttractionTypesResponse }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://booking/", name = "getAttractionTypesResponse")
    public JAXBElement<GetAttractionTypesResponse> createGetAttractionTypesResponse(GetAttractionTypesResponse value) {
        return new JAXBElement<GetAttractionTypesResponse>(_GetAttractionTypesResponse_QNAME, GetAttractionTypesResponse.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link BookAttraction }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://booking/", name = "bookAttraction")
    public JAXBElement<BookAttraction> createBookAttraction(BookAttraction value) {
        return new JAXBElement<BookAttraction>(_BookAttraction_QNAME, BookAttraction.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link GetCountriesResponse }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://booking/", name = "getCountriesResponse")
    public JAXBElement<GetCountriesResponse> createGetCountriesResponse(GetCountriesResponse value) {
        return new JAXBElement<GetCountriesResponse>(_GetCountriesResponse_QNAME, GetCountriesResponse.class, null, value);
    }

}
