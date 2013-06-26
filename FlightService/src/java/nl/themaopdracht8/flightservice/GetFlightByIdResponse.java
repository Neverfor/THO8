
package nl.themaopdracht8.flightservice;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElementRef;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;
import org.datacontract.schemas._2004._07.flightservice.FlightDTO;


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
 *         &lt;element name="GetFlightByIdResult" type="{http://schemas.datacontract.org/2004/07/FlightService.DataModels}FlightDTO" minOccurs="0"/>
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
    "getFlightByIdResult"
})
@XmlRootElement(name = "GetFlightByIdResponse")
public class GetFlightByIdResponse {

    @XmlElementRef(name = "GetFlightByIdResult", namespace = "http://flightservice.themaopdracht8.nl", type = JAXBElement.class, required = false)
    protected JAXBElement<FlightDTO> getFlightByIdResult;

    /**
     * Gets the value of the getFlightByIdResult property.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link FlightDTO }{@code >}
     *     
     */
    public JAXBElement<FlightDTO> getGetFlightByIdResult() {
        return getFlightByIdResult;
    }

    /**
     * Sets the value of the getFlightByIdResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link FlightDTO }{@code >}
     *     
     */
    public void setGetFlightByIdResult(JAXBElement<FlightDTO> value) {
        this.getFlightByIdResult = value;
    }

}
