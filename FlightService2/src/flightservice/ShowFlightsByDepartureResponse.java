
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
 *         &lt;element name="ShowFlightsByDepartureResult" type="{http://schemas.datacontract.org/2004/07/FlightService.DataModels}ArrayOfFlightDTO" minOccurs="0"/>
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
    "showFlightsByDepartureResult"
})
@XmlRootElement(name = "ShowFlightsByDepartureResponse")
public class ShowFlightsByDepartureResponse {

    @XmlElementRef(name = "ShowFlightsByDepartureResult", namespace = "http://flightservice.themaopdracht8.nl", type = JAXBElement.class, required = false)
    protected JAXBElement<ArrayOfFlightDTO> showFlightsByDepartureResult;

    /**
     * Gets the value of the showFlightsByDepartureResult property.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link ArrayOfFlightDTO }{@code >}
     *     
     */
    public JAXBElement<ArrayOfFlightDTO> getShowFlightsByDepartureResult() {
        return showFlightsByDepartureResult;
    }

    /**
     * Sets the value of the showFlightsByDepartureResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link ArrayOfFlightDTO }{@code >}
     *     
     */
    public void setShowFlightsByDepartureResult(JAXBElement<ArrayOfFlightDTO> value) {
        this.showFlightsByDepartureResult = value;
    }

}
