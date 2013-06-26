/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package tests;

import java.util.ArrayList;
import java.util.List;
import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import javax.xml.datatype.XMLGregorianCalendar;
import org.junit.After;
import org.junit.AfterClass;
import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;
import static org.junit.Assert.*;
import webclient.Attractie;
import webclient.AttractieType;
import webclient.AttractionImplementation;
import webclient.AttractionImplementationService;
import webclient.OrderedTicket;

/**
 *
 * @author michael
 */
public class WebClientTests {
    static AttractionImplementation client;
    public WebClientTests() {
        
    }
    
    @BeforeClass
    public static void setUpClass() {
        AttractionImplementationService impl = new AttractionImplementationService();
        client = impl.getAttractionImplementationPort();
    }
    
    @AfterClass
    public static void tearDownClass() {
    }
    
    @Before
    public void setUp() {
    }
    
    @After
    public void tearDown() {
    }
    // TODO add test methods here.
    // The methods must be annotated with annotation @Test. For example:
    //
    // @Test
    // public void hello() {}
    
    @Test
    public void RetrieveAttractieTypesTest(){
        List<AttractieType> attractionTypes = client.getAttractionTypes();
        if(attractionTypes.size() <= 0)
            fail("Geen attractietypes terug gekregen");
    }
    
      @Test
    public void RetrieveAttractiesTest(){
        List<Attractie> attractionTypes = client.getAttractions(null, 0, 0, 0);
        if(attractionTypes.size() <= 0)
            fail("Geen attractietypes terug gekregen");
    }
      
      @Test
      public void BookAttractieTest(){
          List<Attractie> attractions = client.getAttractions(null, 0, 0, 0);
          List<OrderedTicket> ots = new ArrayList<OrderedTicket>();
          OrderedTicket ot = new OrderedTicket();
          ot.setAmount(1);
          ot.setTicketTypeID(attractions.get(0).getAttractionType().getAttractionTypeID());
          ots.add(ot);
          
          
          int bookId = client.bookAttraction(1, ots, null, "44vBHwxwddwAL98DkNd/TOBzcFbZbG/8ioJb/Wqu5Pnv2eTy28uBYF0tiDw7Bfxm" );
          if(bookId == 0)
              fail("Lol, fail");
          
      }
}