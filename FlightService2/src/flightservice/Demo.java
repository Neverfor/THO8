package flightservice;

import java.io.File;

import flightserviceDTO.Item;
 
import javax.xml.bind.JAXBContext;
import javax.xml.bind.Marshaller;
import javax.xml.bind.Unmarshaller;
 
public class Demo {
 
    public static void main(String[] args) throws Exception {
        JAXBContext jc = JAXBContext.newInstance(Item.class);
 
        Unmarshaller unmarshaller = jc.createUnmarshaller();
        Item item = (Item) unmarshaller.unmarshal(new File("airports.xml"));
 
        System.out.println("code:  " + item.getCode());
        System.out.println("airport:   " + item.getAirport());
        System.out.println("country:   " + item.getCountry());
 
        Marshaller marshaller = jc.createMarshaller();
        marshaller.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, true);
        marshaller.marshal(item, System.out);
    }
}