
package org.datacontract.schemas._2004._07.flightservice;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlElementRef;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for BookingDTO complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="BookingDTO">
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="BookingId" type="{http://www.w3.org/2001/XMLSchema}int" minOccurs="0"/>
 *         &lt;element name="Flight" type="{http://schemas.datacontract.org/2004/07/FlightService.DataModels}FlightDTO" minOccurs="0"/>
 *         &lt;element name="Passengers" type="{http://schemas.datacontract.org/2004/07/FlightService.DataModels}ArrayOfPassengerDTO" minOccurs="0"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "BookingDTO", propOrder = {
    "bookingId",
    "flight",
    "passengers"
})
public class BookingDTO {

    @XmlElement(name = "BookingId")
    protected Integer bookingId;
    @XmlElementRef(name = "Flight", namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", type = JAXBElement.class, required = false)
    protected JAXBElement<FlightDTO> flight;
    @XmlElementRef(name = "Passengers", namespace = "http://schemas.datacontract.org/2004/07/FlightService.DataModels", type = JAXBElement.class, required = false)
    protected JAXBElement<ArrayOfPassengerDTO> passengers;

    /**
     * Gets the value of the bookingId property.
     * 
     * @return
     *     possible object is
     *     {@link Integer }
     *     
     */
    public Integer getBookingId() {
        return bookingId;
    }

    /**
     * Sets the value of the bookingId property.
     * 
     * @param value
     *     allowed object is
     *     {@link Integer }
     *     
     */
    public void setBookingId(Integer value) {
        this.bookingId = value;
    }

    /**
     * Gets the value of the flight property.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link FlightDTO }{@code >}
     *     
     */
    public JAXBElement<FlightDTO> getFlight() {
        return flight;
    }

    /**
     * Sets the value of the flight property.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link FlightDTO }{@code >}
     *     
     */
    public void setFlight(JAXBElement<FlightDTO> value) {
        this.flight = value;
    }

    /**
     * Gets the value of the passengers property.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link ArrayOfPassengerDTO }{@code >}
     *     
     */
    public JAXBElement<ArrayOfPassengerDTO> getPassengers() {
        return passengers;
    }

    /**
     * Sets the value of the passengers property.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link ArrayOfPassengerDTO }{@code >}
     *     
     */
    public void setPassengers(JAXBElement<ArrayOfPassengerDTO> value) {
        this.passengers = value;
    }

}
