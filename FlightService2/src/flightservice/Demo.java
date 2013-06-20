package flightservice;

import java.io.File;

import flightserviceDTO.AirportDTO;
import flightserviceDTO.ArrayOfAirportDTO;
 
import javax.xml.bind.JAXBContext;
import javax.xml.bind.Marshaller;
import javax.xml.bind.Unmarshaller;
 
public class Demo {
 
    public static void main(String[] args) throws Exception {
        JAXBContext jc = JAXBContext.newInstance(AirportDTO.class);
 
        Unmarshaller unmarshaller2 = jc.createUnmarshaller();
        ArrayOfAirportDTO airportArray = (ArrayOfAirportDTO) unmarshaller2.unmarshal(new File("airports.xml"));
        System.out.println(airportArray.getAirportDTO());
        
        Unmarshaller unmarshaller = jc.createUnmarshaller();
        AirportDTO airportdto = (AirportDTO) unmarshaller.unmarshal(new File("airports.xml"));
 
        System.out.println("code:  " + airportdto.getAirportId());
        System.out.println("airport:   " + airportdto.getName());
//        System.out.println("country:   " + item.getCountry());
 
        Marshaller marshaller = jc.createMarshaller();
        marshaller.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, true);
        marshaller.marshal(airportdto, System.out);
    }
}