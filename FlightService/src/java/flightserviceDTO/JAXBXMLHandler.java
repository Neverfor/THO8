package flightserviceDTO;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.util.List;
import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Marshaller;
import javax.xml.bind.Unmarshaller;
import flightserviceDTO.AirportDTO;
import flightserviceDTO.ArrayOfAirportDTO;
 
public class JAXBXMLHandler {
 
    // Export
    public static void marshal(List<AirportDTO> airportArray, File selectedFile)
            throws IOException, JAXBException {
        JAXBContext context;
        BufferedWriter writer = null;
        writer = new BufferedWriter(new FileWriter(selectedFile));
        context = JAXBContext.newInstance(ArrayOfAirportDTO.class);
        Marshaller m = context.createMarshaller();
        m.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, true);
        m.marshal(new ArrayOfAirportDTO(airportArray), writer);
        writer.close();
    }
 
    // Import
    public static List<AirportDTO> unmarshal(File importFile) throws JAXBException {
        ArrayOfAirportDTO airportArray = new ArrayOfAirportDTO();
 
        JAXBContext context = JAXBContext.newInstance(ArrayOfAirportDTO.class);
        Unmarshaller um = context.createUnmarshaller();
        airportArray = (ArrayOfAirportDTO) um.unmarshal(importFile);
 
        return airportArray.getAirports();
    }
}