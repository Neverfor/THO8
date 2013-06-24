/**
 * 
 */
package tests;

import static org.junit.Assert.*;

import java.util.List;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;

import org.junit.AfterClass;
import org.junit.BeforeClass;
import org.junit.Test;

import booking_pkg.Attractie;
import booking_pkg.AttractieType;

/**
 * @author Michael
 *
 */
public class AttractieTests {

	private static EntityManagerFactory emf;
    private static EntityManager em;
    
	/**
	 * @throws java.lang.Exception
	 */
	@BeforeClass
	public static void setUpBeforeClass() throws Exception {
        emf = Persistence.createEntityManagerFactory("attractieDB");
        em = emf.createEntityManager();
	}

	/**
	 * @throws java.lang.Exception
	 */
	@AfterClass
	public static void tearDownAfterClass() throws Exception {
	}

	@Test
	public void test() {
		Attractie a = new Attractie();
		a.setAddress("Ergens in Amsterdam");
		AttractieType at = new AttractieType();
		at.setAttractionTypeName("Dierentuin");
		a.setAttractionType(at);
		em.persist(at);
		a.setDescription("Een leuke dierentuin in de stad Amsterdam");
		a.setNaam("Artis");
		a.setWebsite("www.artis.nl");
		a.setPictures(new String[2]);
		a.setPictures(0, "http://www.studio-evenaar.nl/dierenpark/images/aap-pinche02.jpg");
		em.persist(a);
		
		List<Attractie> listAts = em.createNamedQuery("Attractie.findAll", Attractie.class).getResultList();
		if(listAts.isEmpty() || listAts.size() == 0)
			fail("Lijst is nul");
	}

}
