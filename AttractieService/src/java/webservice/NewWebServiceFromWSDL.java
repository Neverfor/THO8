/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package webservice;

import javax.jws.WebService;

/**
 *
 * @author Michael
 */
@WebService(serviceName = "AttractionImplementationService", portName = "AttractionImplementationPort", endpointInterface = "booking.AttractionImplementation", targetNamespace = "http://booking/", wsdlLocation = "WEB-INF/wsdl/NewWebServiceFromWSDL/AttractionService.wsdl")
public class NewWebServiceFromWSDL {

    public java.util.List<booking.AttractieType> getAttractionTypes() {
        //TODO implement this method
        throw new UnsupportedOperationException("Not implemented yet.");
    }

    public int bookAttraction(int arg0, java.util.List<booking.OrderedTicket> arg1, javax.xml.datatype.XMLGregorianCalendar arg2, java.lang.String arg3) {
        //TODO implement this method
        throw new UnsupportedOperationException("Not implemented yet.");
    }

    public java.util.List<booking.Attractie> getAttractions(java.lang.String arg0, int arg1, int arg2, int arg3) {
        //TODO implement this method
        throw new UnsupportedOperationException("Not implemented yet.");
    }

    public java.util.List<booking.Region> getRegions(java.lang.String arg0) {
        //TODO implement this method
        throw new UnsupportedOperationException("Not implemented yet.");
    }

    public java.util.List<booking.City> getCities(int arg0) {
        //TODO implement this method
        throw new UnsupportedOperationException("Not implemented yet.");
    }

    public java.util.List<booking.Booking> getBooking(int arg0, java.lang.String arg1) {
        //TODO implement this method
        throw new UnsupportedOperationException("Not implemented yet.");
    }

    public java.util.List<booking.Country> getCountries() {
        //TODO implement this method
        throw new UnsupportedOperationException("Not implemented yet.");
    }
    
}
