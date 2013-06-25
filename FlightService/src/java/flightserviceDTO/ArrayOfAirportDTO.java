
package flightserviceDTO;

import java.util.List;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;

@XmlRootElement(name = "ArrayOfAirportDTO")
@XmlAccessorType(XmlAccessType.FIELD)
public class ArrayOfAirportDTO {

    @XmlElement(name = "AirportDTO", type = AirportDTO.class)
    private List<AirportDTO> airportArray;

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
}
