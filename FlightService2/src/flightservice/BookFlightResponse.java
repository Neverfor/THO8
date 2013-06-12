
package flightservice;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElementRef;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;
import flightserviceDTO.BookingDTO;


/**
 * <p>Java class for anonymous complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType>
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="BookFlightResult" type="{http://schemas.datacontract.org/2004/07/FlightService.DataModels}BookingDTO" minOccurs="0"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "", propOrder = {
    "bookFlightResult"
})
@XmlRootElement(name = "BookFlightResponse")
public class BookFlightResponse {

    @XmlElementRef(name = "BookFlightResult", namespace = "http://flightservice.themaopdracht8.nl", type = JAXBElement.class, required = false)
    protected JAXBElement<BookingDTO> bookFlightResult;

    /**
     * Gets the value of the bookFlightResult property.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link BookingDTO }{@code >}
     *     
     */
    public JAXBElement<BookingDTO> getBookFlightResult() {
        return bookFlightResult;
    }

    /**
     * Sets the value of the bookFlightResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link BookingDTO }{@code >}
     *     
     */
    public void setBookFlightResult(JAXBElement<BookingDTO> value) {
        this.bookFlightResult = value;
    }

}
