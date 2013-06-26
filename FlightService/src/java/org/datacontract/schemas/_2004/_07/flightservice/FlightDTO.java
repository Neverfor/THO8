
package org.datacontract.schemas._2004._07.flightservice;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlElementRef;
import javax.xml.bind.annotation.XmlSchemaType;
import javax.xml.bind.annotation.XmlType;
import javax.xml.datatype.XMLGregorianCalendar;


/**
 * <p>Java class for FlightDTO complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="FlightDTO">
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="AirplaneId" type="{http://www.w3.org/2001/XMLSchema}int" minOccurs="0"/>
 *         &lt;element name="AirplaneName" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="ArrivalDate" type="{http://www.w3.org/2001/XMLSchema}dateTime" minOccurs="0"/>
 *         &lt;element name="DepartureDate" type="{http://www.w3.org/2001/XMLSchema}dateTime" minOccurs="0"/>
 *         &lt;element name="DepartureId" type="{http://www.w3.org/2001/XMLSchema}int" minOccurs="0"/>
 *         &lt;element name="DepartureLatitude" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="DepartureLongitude" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="DepartureName" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="DestinationId" type="{http://www.w3.org/2001/XMLSchema}int" minOccurs="0"/>
 *         &lt;element name="DestinationLatitude" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="DestinationLongitude" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="DestinationName" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="FlightId" type="{http://www.w3.org/2001/XMLSchema}int" minOccurs="0"/>
 *         &lt;element name="Latitude" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="Longitude" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "FlightDTO", propOrder = {
    "airplaneId",
    "airplaneName",
    "arrivalDate",
    "departureDate",
    "departureId",
    "departureLatitude",
    "departureLongitude",
    "departureName",
    "destinationId",
    "destinationLatitude",
    "destinationLongitude",
    "destinationName",
    "flightId",
    "latitude",
    "longitude"
})
public class FlightDTO {

    @XmlElement(name = "AirplaneId")
    protected Integer airplaneId;
    @XmlElementRef(name = "AirplaneName", namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", type = JAXBElement.class, required = false)
    protected JAXBElement<String> airplaneName;
    @XmlElement(name = "ArrivalDate")
    @XmlSchemaType(name = "dateTime")
    protected XMLGregorianCalendar arrivalDate;
    @XmlElement(name = "DepartureDate")
    @XmlSchemaType(name = "dateTime")
    protected XMLGregorianCalendar departureDate;
    @XmlElement(name = "DepartureId")
    protected Integer departureId;
    @XmlElementRef(name = "DepartureLatitude", namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", type = JAXBElement.class, required = false)
    protected JAXBElement<String> departureLatitude;
    @XmlElementRef(name = "DepartureLongitude", namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", type = JAXBElement.class, required = false)
    protected JAXBElement<String> departureLongitude;
    @XmlElementRef(name = "DepartureName", namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", type = JAXBElement.class, required = false)
    protected JAXBElement<String> departureName;
    @XmlElement(name = "DestinationId")
    protected Integer destinationId;
    @XmlElementRef(name = "DestinationLatitude", namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", type = JAXBElement.class, required = false)
    protected JAXBElement<String> destinationLatitude;
    @XmlElementRef(name = "DestinationLongitude", namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", type = JAXBElement.class, required = false)
    protected JAXBElement<String> destinationLongitude;
    @XmlElementRef(name = "DestinationName", namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", type = JAXBElement.class, required = false)
    protected JAXBElement<String> destinationName;
    @XmlElement(name = "FlightId")
    protected Integer flightId;
    @XmlElementRef(name = "Latitude", namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", type = JAXBElement.class, required = false)
    protected JAXBElement<String> latitude;
    @XmlElementRef(name = "Longitude", namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", type = JAXBElement.class, required = false)
    protected JAXBElement<String> longitude;

    /**
     * Gets the value of the airplaneId property.
     * 
     * @return
     *     possible object is
     *     {@link Integer }
     *     
     */
    public Integer getAirplaneId() {
        return airplaneId;
    }

    /**
     * Sets the value of the airplaneId property.
     * 
     * @param value
     *     allowed object is
     *     {@link Integer }
     *     
     */
    public void setAirplaneId(Integer value) {
        this.airplaneId = value;
    }

    /**
     * Gets the value of the airplaneName property.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public JAXBElement<String> getAirplaneName() {
        return airplaneName;
    }

    /**
     * Sets the value of the airplaneName property.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public void setAirplaneName(JAXBElement<String> value) {
        this.airplaneName = value;
    }

    /**
     * Gets the value of the arrivalDate property.
     * 
     * @return
     *     possible object is
     *     {@link XMLGregorianCalendar }
     *     
     */
    public XMLGregorianCalendar getArrivalDate() {
        return arrivalDate;
    }

    /**
     * Sets the value of the arrivalDate property.
     * 
     * @param value
     *     allowed object is
     *     {@link XMLGregorianCalendar }
     *     
     */
    public void setArrivalDate(XMLGregorianCalendar value) {
        this.arrivalDate = value;
    }

    /**
     * Gets the value of the departureDate property.
     * 
     * @return
     *     possible object is
     *     {@link XMLGregorianCalendar }
     *     
     */
    public XMLGregorianCalendar getDepartureDate() {
        return departureDate;
    }

    /**
     * Sets the value of the departureDate property.
     * 
     * @param value
     *     allowed object is
     *     {@link XMLGregorianCalendar }
     *     
     */
    public void setDepartureDate(XMLGregorianCalendar value) {
        this.departureDate = value;
    }

    /**
     * Gets the value of the departureId property.
     * 
     * @return
     *     possible object is
     *     {@link Integer }
     *     
     */
    public Integer getDepartureId() {
        return departureId;
    }

    /**
     * Sets the value of the departureId property.
     * 
     * @param value
     *     allowed object is
     *     {@link Integer }
     *     
     */
    public void setDepartureId(Integer value) {
        this.departureId = value;
    }

    /**
     * Gets the value of the departureLatitude property.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public JAXBElement<String> getDepartureLatitude() {
        return departureLatitude;
    }

    /**
     * Sets the value of the departureLatitude property.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public void setDepartureLatitude(JAXBElement<String> value) {
        this.departureLatitude = value;
    }

    /**
     * Gets the value of the departureLongitude property.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public JAXBElement<String> getDepartureLongitude() {
        return departureLongitude;
    }

    /**
     * Sets the value of the departureLongitude property.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public void setDepartureLongitude(JAXBElement<String> value) {
        this.departureLongitude = value;
    }

    /**
     * Gets the value of the departureName property.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public JAXBElement<String> getDepartureName() {
        return departureName;
    }

    /**
     * Sets the value of the departureName property.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public void setDepartureName(JAXBElement<String> value) {
        this.departureName = value;
    }

    /**
     * Gets the value of the destinationId property.
     * 
     * @return
     *     possible object is
     *     {@link Integer }
     *     
     */
    public Integer getDestinationId() {
        return destinationId;
    }

    /**
     * Sets the value of the destinationId property.
     * 
     * @param value
     *     allowed object is
     *     {@link Integer }
     *     
     */
    public void setDestinationId(Integer value) {
        this.destinationId = value;
    }

    /**
     * Gets the value of the destinationLatitude property.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public JAXBElement<String> getDestinationLatitude() {
        return destinationLatitude;
    }

    /**
     * Sets the value of the destinationLatitude property.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public void setDestinationLatitude(JAXBElement<String> value) {
        this.destinationLatitude = value;
    }

    /**
     * Gets the value of the destinationLongitude property.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public JAXBElement<String> getDestinationLongitude() {
        return destinationLongitude;
    }

    /**
     * Sets the value of the destinationLongitude property.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public void setDestinationLongitude(JAXBElement<String> value) {
        this.destinationLongitude = value;
    }

    /**
     * Gets the value of the destinationName property.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public JAXBElement<String> getDestinationName() {
        return destinationName;
    }

    /**
     * Sets the value of the destinationName property.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public void setDestinationName(JAXBElement<String> value) {
        this.destinationName = value;
    }

    /**
     * Gets the value of the flightId property.
     * 
     * @return
     *     possible object is
     *     {@link Integer }
     *     
     */
    public Integer getFlightId() {
        return flightId;
    }

    /**
     * Sets the value of the flightId property.
     * 
     * @param value
     *     allowed object is
     *     {@link Integer }
     *     
     */
    public void setFlightId(Integer value) {
        this.flightId = value;
    }

    /**
     * Gets the value of the latitude property.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public JAXBElement<String> getLatitude() {
        return latitude;
    }

    /**
     * Sets the value of the latitude property.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public void setLatitude(JAXBElement<String> value) {
        this.latitude = value;
    }

    /**
     * Gets the value of the longitude property.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public JAXBElement<String> getLongitude() {
        return longitude;
    }

    /**
     * Sets the value of the longitude property.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public void setLongitude(JAXBElement<String> value) {
        this.longitude = value;
    }

}
