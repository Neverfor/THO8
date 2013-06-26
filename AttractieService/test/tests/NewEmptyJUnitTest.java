/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package tests;

import java.util.List;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import org.junit.After;
import org.junit.AfterClass;
import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;
import booking.*;
import static org.junit.Assert.*;

/**
 *
 * @author Michael
 */
public class NewEmptyJUnitTest {
    static EntityManagerFactory emf;
    public NewEmptyJUnitTest() {
    }
    
    @BeforeClass
    public static void setUpClass() {
        emf = Persistence.createEntityManagerFactory("AttractieServicePU");
        
    }
    
    @AfterClass
    public static void tearDownClass() {
        emf.close();
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
    public void testPersistence(){
        jpa.AttractieJpaController aCon = new jpa.AttractieJpaController(emf);
        Attractie attractie1 = new Attractie();
        attractie1.setNaam("Artis");
        attractie1.setAddress("Ergens in Amsterdam");
        attractie1.setWebsite("www.artis.nl");
        AttractieType attractieType1 = new AttractieType();
        attractieType1.setAttractionTypeName("Dierentuin");
        
        attractie1.setAttractionType(attractieType1);
        TicketType tt = new TicketType();
        tt.setDescription("Volwassene kaarten");
        tt.setPrice(15);
        attractie1.addTicket(tt);
        
        Country country = new Country();
        country.setCountryName("Nederland");
        Region region = new Region();
        region.setRegionName("Noord Holland");
        region.setCountry(country);
        City city = new City();
        city.setCityName("Amsterdam");
        city.setRegion(region);
        
        attractie1.setRegion(region);
        attractie1.setCity(city);
        attractie1.setCountry(country);
        
        aCon.create(attractie1);

        
        List<Attractie> attracties = aCon.findAttractieEntities();
        if(attracties.size() <= 0){
            fail("Attractie niet goed opgeslagen");
        }
    }
}