package flightserviceDTO;

import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;
 
@XmlRootElement
@XmlType(propOrder={"code", "airport", "country"})
public class Item {
 
    private int code;
    private String airport;
    private String country;
 
    public int getCode() {
        return code;
    }
 
    public void setCode(int code) {
        this.code = code;
    }
 
    public String getAirport() {
        return airport;
    }
 
    public void setAirport(String airport) {
        this.airport = airport;
    }

	public String getCountry() {
		return country;
	}

	public void setCountry(String country) {
		this.country = country;
	}
 
}