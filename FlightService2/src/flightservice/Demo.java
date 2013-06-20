package flightservice;

import java.io.File;

import flightserviceDTO.AirportDTO;
import flightserviceDTO.ArrayOfAirportDTO;
 
import javax.xml.bind.JAXBContext;
import javax.xml.bind.Marshaller;
import javax.xml.bind.Unmarshaller;
 
public class Demo {
 
    public static void main(String[] args) throws Exception {
        JAXBContext jc = JAXBContext.newInstance(ArrayOfAirportDTO.class);
 
        Unmarshaller unmarshaller = jc.createUnmarshaller();
        ArrayOfAirportDTO airportArray = (ArrayOfAirportDTO) unmarshaller.unmarshal(new File("airports.xml"));
        
        System.out.println(airportArray.getAirportDTO());
        
        Marshaller marshaller = jc.createMarshaller();
        marshaller.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, true);
        marshaller.marshal(airportArray, System.out);
        
        // ---
        JAXBContext jc2 = JAXBContext.newInstance(AirportDTO.class);
        
        Unmarshaller unmarshaller2 = jc2.createUnmarshaller();
        AirportDTO airportdto = (AirportDTO) unmarshaller2.unmarshal(new File("airports.xml"));
 
        System.out.println("code:  " + airportdto.getAirportId());
        System.out.println("airport:   " + airportdto.getName());
//        System.out.println("country:   " + item.getCountry());
 
        Marshaller marshaller2 = jc2.createMarshaller();
        marshaller2.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, true);
        marshaller2.marshal(airportdto, System.out);
    }
}