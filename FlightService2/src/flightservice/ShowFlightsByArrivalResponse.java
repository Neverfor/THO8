
package flightservice;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElementRef;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;
import flightserviceDTO.ArrayOfFlightDTO;


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
 *         &lt;element name="ShowFlightsByArrivalResult" type="{http://schemas.datacontract.org/2004/07/FlightService.DataModels}ArrayOfFlightDTO" minOccurs="0"/>
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
    "showFlightsByArrivalResult"
})
@XmlRootElement(name = "ShowFlightsByArrivalResponse")
public class ShowFlightsByArrivalResponse {

    @XmlElementRef(name = "ShowFlightsByArrivalResult", namespace = "http://flightservice.themaopdracht8.nl", type = JAXBElement.class, required = false)
    protected JAXBElement<ArrayOfFlightDTO> showFlightsByArrivalResult;

    /**
     * Gets the value of the showFlightsByArrivalResult property.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link ArrayOfFlightDTO }{@code >}
     *     
     */
    public JAXBElement<ArrayOfFlightDTO> getShowFlightsByArrivalResult() {
        return showFlightsByArrivalResult;
    }

    /**
     * Sets the value of the showFlightsByArrivalResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link ArrayOfFlightDTO }{@code >}
     *     
     */
    public void setShowFlightsByArrivalResult(JAXBElement<ArrayOfFlightDTO> value) {
        this.showFlightsByArrivalResult = value;
    }

}
