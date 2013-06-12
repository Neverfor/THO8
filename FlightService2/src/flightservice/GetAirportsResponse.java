
package flightservice;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElementRef;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;
import flightserviceDTO.ArrayOfAirportDTO;


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
 *         &lt;element name="GetAirportsResult" type="{http://schemas.datacontract.org/2004/07/FlightService.DataModels}ArrayOfAirportDTO" minOccurs="0"/>
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
    "getAirportsResult"
})
@XmlRootElement(name = "GetAirportsResponse")
public class GetAirportsResponse {

    @XmlElementRef(name = "GetAirportsResult", namespace = "http://flightservice.themaopdracht8.nl", type = JAXBElement.class, required = false)
    protected JAXBElement<ArrayOfAirportDTO> getAirportsResult;

    /**
     * Gets the value of the getAirportsResult property.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link ArrayOfAirportDTO }{@code >}
     *     
     */
    public JAXBElement<ArrayOfAirportDTO> getGetAirportsResult() {
        return getAirportsResult;
    }

    /**
     * Sets the value of the getAirportsResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link ArrayOfAirportDTO }{@code >}
     *     
     */
    public void setGetAirportsResult(JAXBElement<ArrayOfAirportDTO> value) {
        this.getAirportsResult = value;
    }

}
