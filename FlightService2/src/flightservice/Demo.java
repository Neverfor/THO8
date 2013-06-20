
package flightservice;

import java.io.File;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

import flightserviceDTO.AirportDTO;
import flightserviceDTO.ArrayOfAirportDTO;

import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Marshaller;
import javax.xml.bind.Unmarshaller;

public class Demo {

	public static void main(String[] args) throws Exception {
		AirportDTO airport = new AirportDTO();
		airport.setAirportId(1);
		airport.setName("Schiphol");
		
		AirportDTO airport1 = new AirportDTO();
		airport1.setAirportId(2);
		airport1.setName("Eindhoven");
		
		List<AirportDTO> airportArray = new ArrayList<AirportDTO>();
		airportArray.add(airport);
		airportArray.add(airport1);
		//Marshalling
		try {
			JAXBXMLHandler.marshal(airportArray, new File("airports2.xml"));
		} catch (IOException e) {
            e.printStackTrace();
        } catch (JAXBException e) {
            e.printStackTrace();
        }
		System.out.println("joo");

		// Unmarshalling
		try {
            airportArray = JAXBXMLHandler.unmarshal(new File("airports.xml"));
        } catch (JAXBException e) {
            e.printStackTrace();
        }
        System.out.println(airportArray);
        System.out.println(airportArray.get(1).getName());
        

		//        JAXBContext jc = JAXBContext.newInstance(ArrayOfAirportDTO.class);
		// 
		//        Unmarshaller unmarshaller = jc.createUnmarshaller();
		//        File xml = new File("airports.xml");
		//        ArrayOfAirportDTO airportArray = (ArrayOfAirportDTO) unmarshaller.unmarshal(xml);
		//        
		//        // System.out.println(airportArray.getAirportDTO());
		//        
		//        Marshaller marshaller = jc.createMarshaller();
		//        marshaller.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, true);
		//        marshaller.marshal(airportArray, System.out);
		//        
		//        // ---
		//        JAXBContext jc2 = JAXBContext.newInstance(AirportDTO.class);
		//        
		//        Unmarshaller unmarshaller2 = jc2.createUnmarshaller();
		//        AirportDTO airportdto = (AirportDTO) unmarshaller2.unmarshal(new File("airports.xml"));
		// 
		//        System.out.println("code:  " + airportdto.getAirportId());
		//        System.out.println("airport:   " + airportdto.getName());
		////        System.out.println("country:   " + item.getCountry());
		// 
		//        Marshaller marshaller2 = jc2.createMarshaller();
		//        marshaller2.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, true);
		//        marshaller2.marshal(airportdto, System.out);
	}
}