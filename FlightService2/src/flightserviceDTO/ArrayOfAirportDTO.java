
package flightserviceDTO;

import java.util.ArrayList;
import java.util.List;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;

/**
 * <p>Java class for ArrayOfAirportDTO complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="ArrayOfAirportDTO">
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="AirportDTO" type="{http://schemas.datacontract.org/2004/07/FlightService.DataModels}AirportDTO" maxOccurs="unbounded" minOccurs="0"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */

@XmlRootElement(name = "ArrayOfAirportDTO") //S
@XmlAccessorType(XmlAccessType.FIELD)
// @XmlType(name = "ArrayOfAirportDTO", propOrder = {"airportDTO"})
public class ArrayOfAirportDTO {

    @XmlElement(name = "AirportDTO", type = AirportDTO.class)
    private List<AirportDTO> airportArray;

    /**
     * Gets the value of the airportDTO property.
     * 
     * <p>
     * This accessor method returns a reference to the live list,
     * not a snapshot. Therefore any modification you make to the
     * returned list will be present inside the JAXB object.
     * This is why there is not a <CODE>set</CODE> method for the airportDTO property.
     * 
     * <p>
     * For example, to add a new item, do as follows:
     * <pre>
     *    getAirportDTO().add(newItem);
     * </pre>
     * 
     * 
     * <p>
     * Objects of the following type(s) are allowed in the list
     * {@link AirportDTO }
     * 
     * 
     */
    public ArrayOfAirportDTO() {}
    
    public ArrayOfAirportDTO(List<AirportDTO> airportArray) {
    	this.airportArray = airportArray;
    }
    
    public List<AirportDTO> getAirports() {
    	return airportArray;
    }
    
    public void setAirports(List<AirportDTO> airportArray) {
    	this.airportArray = airportArray;
    }
    
//    public List<AirportDTO> getAirportDTO() {
//        if (airportDTO == null) {
//            airportDTO = new ArrayList<AirportDTO>();
//        }
//        return this.airportDTO;
//    }
//    
//    public boolean addAirportDTO(AirportDTO Airport) {
//    	if(airportDTO.add(Airport)){
//    		return true;
//    	}
//		return false;
//    }
}
