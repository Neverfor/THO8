package flightserviceDTO;

import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;

@XmlRootElement(name="airportObject")
public class airportObject {
	 
		String airport;
		String country;
	 
		public String getAirport() {
			return airport;
		}
	 
		@XmlElement
		public void setAirport(String airport) {
			this.airport = airport;
		}
	 
		public String getCountry() {
			return country;
		}
	 
		@XmlElement
		public void setCountry(String country) {
			this.country = country;
		}
	}