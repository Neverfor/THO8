package webservice;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Marshaller;
import javax.xml.bind.Unmarshaller;
import org.datacontract.schemas._2004._07.flightservice.*;
 
public class JAXBXMLHandler {
 
    // Export
    public static void marshal(List<AirportDTO> airportArray, File selectedFile)
            throws IOException, JAXBException {
        JAXBContext context;
        BufferedWriter writer = null;
        writer = new BufferedWriter(new FileWriter(selectedFile));
        context = JAXBContext.newInstance(List.class);
        Marshaller m = context.createMarshaller();
        m.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, true);
        m.marshal(airportArray, writer);
        writer.close();
    }
 
    // Import
    public static List<AirportDTO> unmarshal(File importFile) throws JAXBException {
 
        JAXBContext context = JAXBContext.newInstance(List.class);
        Unmarshaller um = context.createUnmarshaller();
        List<AirportDTO> airportArray = (List)um.unmarshal(importFile);
 
        return airportArray;
    }
}