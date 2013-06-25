
package flightserviceDTO;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlRootElement;

@XmlAccessorType(XmlAccessType.FIELD)
@XmlRootElement(name = "AirportDTO")
public class AirportDTO {

    private Integer airportId;
    private String name;

    public String getName() {
        return name;
    }
    
    public int getAirportId() {
        return airportId;
    }
 
    public void setAirportId(int airportid) {
        this.airportId = airportid;
    }

    public void setName(String value) {
        this.name = value;
    }
}
