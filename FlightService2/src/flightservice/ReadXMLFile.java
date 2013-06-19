package flightservice;

import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Unmarshaller;

import flightserviceDTO.airportObject;

import java.io.File;

public class ReadXMLFile {

	public static void main(String argv[]) {

		try {
			 
			File file = new File("C:/Users/SpenQ/Desktop/Airports/airports1.xml");
			JAXBContext jaxbContext = JAXBContext.newInstance(airportObject.class);
	 
			Unmarshaller jaxbUnmarshaller = jaxbContext.createUnmarshaller();
			airportObject airport = (airportObject) jaxbUnmarshaller.unmarshal(file);
			System.out.println(airport);
	 
		  } catch (JAXBException e) {
			e.printStackTrace();
		  }
	}

}