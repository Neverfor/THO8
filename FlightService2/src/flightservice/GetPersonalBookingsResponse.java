
package flightservice;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElementRef;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;
import flightserviceDTO.ArrayOfBookingDTO;


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
 *         &lt;element name="GetPersonalBookingsResult" type="{http://schemas.datacontract.org/2004/07/FlightService.DataModels}ArrayOfBookingDTO" minOccurs="0"/>
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
    "getPersonalBookingsResult"
})
@XmlRootElement(name = "GetPersonalBookingsResponse")
public class GetPersonalBookingsResponse {

    @XmlElementRef(name = "GetPersonalBookingsResult", namespace = "http://flightservice.themaopdracht8.nl", type = JAXBElement.class, required = false)
    protected JAXBElement<ArrayOfBookingDTO> getPersonalBookingsResult;

    /**
     * Gets the value of the getPersonalBookingsResult property.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link ArrayOfBookingDTO }{@code >}
     *     
     */
    public JAXBElement<ArrayOfBookingDTO> getGetPersonalBookingsResult() {
        return getPersonalBookingsResult;
    }

    /**
     * Sets the value of the getPersonalBookingsResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link ArrayOfBookingDTO }{@code >}
     *     
     */
    public void setGetPersonalBookingsResult(JAXBElement<ArrayOfBookingDTO> value) {
        this.getPersonalBookingsResult = value;
    }

}
