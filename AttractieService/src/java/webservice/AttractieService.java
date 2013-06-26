/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package webservice;

import booking.*;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.jws.WebService;
import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import javax.persistence.criteria.CriteriaBuilder;
import javax.persistence.criteria.CriteriaQuery;
import javax.persistence.criteria.Join;
import javax.persistence.criteria.Predicate;
import javax.persistence.criteria.Root;
import nl.th08.userservice.UserServiceGetUserFaultExceptionFaultFaultMessage;

/**
 *
 * @author Michael
 */
@WebService(serviceName = "AttractionImplementationService", portName = "AttractionImplementationPort", endpointInterface = "booking.AttractionImplementation", targetNamespace = "http://booking/", wsdlLocation = "WEB-INF/wsdl/localhost_8080/AttractieService/AttractionImplementationService.wsdl")
public class AttractieService {
    private EntityManagerFactory emf;
    private EntityManager em;

    public AttractieService() {
        
    }
    
    public java.util.List<booking.AttractieType> getAttractionTypes() {
        emf = Persistence.createEntityManagerFactory("AttractieServicePU");
        em = emf.createEntityManager();
        List<booking.AttractieType> rtn = em.createNamedQuery("AttractieType.findAll", AttractieType.class).getResultList();        
        emf.close();
        return rtn;
    }

    public int bookAttraction(int attractionID, java.util.List<booking.OrderedTicket> orderedTickets, javax.xml.datatype.XMLGregorianCalendar date, java.lang.String userToken) {
        emf = Persistence.createEntityManagerFactory("AttractieServicePU");
        em = emf.createEntityManager();
        em.getTransaction().begin();
        nl.th08.userservice.UserService_Service s = new nl.th08.userservice.UserService_Service();
        nl.th08.userservice.UserService userv = s.getBasicHttpBindingUserService();
        int userID = 0;
        try {
            userID = userv.getUser(userToken).getUserId();
        } catch (UserServiceGetUserFaultExceptionFaultFaultMessage ex) {
            Logger.getLogger(AttractieService.class.getName()).log(Level.SEVERE, null, ex);
        }
        Booking booking = new Booking();
        Attractie a = em.createNamedQuery("Attractie.findById", Attractie.class).setParameter("id", attractionID).getSingleResult();
        booking.setAttraction(a);
        booking.setDatum(date);
        double price = 0;
        System.out.println(orderedTickets.size());
        for(OrderedTicket ot : orderedTickets){
            System.out.println(ot.getTicketTypeID());
            
            TicketType tt = em.createNamedQuery("TicketType.findById", TicketType.class).setParameter("id", ot.getTicketTypeID()).getSingleResult();
            price += tt.getPrice();
        }
        booking.setPrice(price);
        booking.setStatus("ordered");
        em.persist(booking);
        em.getTransaction().commit();
        em.close();
        emf.close();
        return booking.getiD();
    }

    public java.util.List<booking.Attractie> getAttractions(java.lang.String countryCode, int regionId, int cityId, int attractionTypeId) {
        emf = Persistence.createEntityManagerFactory("AttractieServicePU");
        em = emf.createEntityManager();
        CriteriaBuilder cb = em.getCriteriaBuilder();
        CriteriaQuery<Attractie> criteria = cb.createQuery(Attractie.class);
        Root<Attractie> attractie = criteria.from(Attractie.class);
        criteria.select(attractie);
        Predicate condition = cb.conjunction();
        
        if(cityId != 0){
            Join<Attractie,City> join = attractie.join(Attractie_.city);
            cb.and(condition, cb.equal(join.get(City_.cityID), cityId));
        }
        if(attractionTypeId != 0){
            Join<Attractie,AttractieType> join = attractie.join(Attractie_.attractionType);
            cb.and(condition, cb.equal(join.get(AttractieType_.attractionTypeID), attractionTypeId));
        }
        if(regionId != 0){
            Join<Attractie,Region> join = attractie.join(Attractie_.region);
            cb.and(condition, cb.equal(join.get(Region_.regionID), regionId));
        }
        if(countryCode != null && !countryCode.isEmpty()){
            Join<Attractie,Country> join = attractie.join(Attractie_.country);
            cb.and(condition, cb.equal(join.get(Country_.countryCode), countryCode));
        }
        
        criteria.where(condition);
        
        List<Attractie> result = em.createQuery(criteria).getResultList();
        emf.close();
        return result;
    }

    public java.util.List<booking.Region> getRegions(java.lang.String countryCode) {
        emf = Persistence.createEntityManagerFactory("AttractieServicePU");
        em = emf.createEntityManager();
        CriteriaBuilder cb = em.getCriteriaBuilder();
        CriteriaQuery<Region> criteria = cb.createQuery(Region.class);
        Root<Region> region = criteria.from(Region.class);
        criteria.select(region);
        
        if(countryCode != null && !countryCode.isEmpty()){
            Join<Region,Country> join = region.join(Region_.country);            
            criteria.where(cb.equal(join.get(Country_.countryID), countryCode));
        }
                
        List<Region> result = em.createQuery(criteria).getResultList();
        emf.close();
        return result;
    }

    public java.util.List<booking.City> getCities(int regionID) {
        emf = Persistence.createEntityManagerFactory("AttractieServicePU");
        em = emf.createEntityManager();
        CriteriaBuilder cb = em.getCriteriaBuilder();
        CriteriaQuery<City> criteria = cb.createQuery(City.class);
        Root<City> city = criteria.from(City.class);
        criteria.select(city);
        
        if(regionID != 0){
            Join<City,Region> join = city.join(City_.region);            
            criteria.where(cb.equal(join.get(Region_.regionID), regionID));
        }
                
        List<City> result = em.createQuery(criteria).getResultList();
        emf.close();
        return result;
    }

    public java.util.List<booking.Booking> getBooking(int bookingID, java.lang.String userToken) {
        emf = Persistence.createEntityManagerFactory("AttractieServicePU");
        em = emf.createEntityManager();
        nl.th08.userservice.UserService_Service s = new nl.th08.userservice.UserService_Service();
        nl.th08.userservice.UserService userv = s.getBasicHttpBindingUserService();
        int userID = 0;
        try {
            userID = userv.getUser(userToken).getUserId();
        } catch (UserServiceGetUserFaultExceptionFaultFaultMessage ex) {
            Logger.getLogger(AttractieService.class.getName()).log(Level.SEVERE, null, ex);
        }
        
        CriteriaBuilder cb = em.getCriteriaBuilder();
        CriteriaQuery<Booking> criteria = cb.createQuery(Booking.class);
        Root<Booking> booking = criteria.from(Booking.class);
        criteria.select(booking);
        Predicate condition = cb.conjunction();        
        if(bookingID != 0){
            cb.and(condition, cb.equal(booking.get(Booking_.bookingID), userID));
        }
        List<Booking> result = em.createQuery(criteria).getResultList();
        emf.close();
        return result;
    }

    public java.util.List<booking.Country> getCountries() {
        emf = Persistence.createEntityManagerFactory("AttractieServicePU");
        em = emf.createEntityManager();
        List<booking.Country> rtn = em.createNamedQuery("Country.findAll", Country.class).getResultList();        
        emf.close();
        return rtn;
    }
    
}
