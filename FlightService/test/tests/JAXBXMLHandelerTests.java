/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package tests;

import java.util.ArrayList;
import java.util.List;
import javax.xml.bind.JAXBElement;
import org.datacontract.schemas._2004._07.flightservice.AirportDTO;
import org.junit.After;
import org.junit.AfterClass;
import org.junit.Before;
import org.junit.BeforeClass;

/**
 *
 * @author Michael
 */
public class JAXBXMLHandelerTests {
    
    public JAXBXMLHandelerTests() {
    }
    
    @BeforeClass
    public static void setUpClass() {
    }
    
    @AfterClass
    public static void tearDownClass() {
    }
    
    @Before
    public void setUp() {
        List<AirportDTO> airports = new ArrayList<AirportDTO>();
        AirportDTO airport1 = new AirportDTO();
//        JAXBElement<String> element = new JAXBElement<String>();
//        element.setValue(null);
//        airport1.setLatitude(new JAXBElement<String>("test"));
//        airport1.setLongitude(111111);
//        airport1.setName("Schiphol");
//        airports.add(airport1);
        
    }
    
    @After
    public void tearDown() {
    }
    // TODO add test methods here.
    // The methods must be annotated with annotation @Test. For example:
    //
    // @Test
    // public void hello() {}
}