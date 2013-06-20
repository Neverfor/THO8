/**
 * AttractionImplementationPortBindingImpl.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package booking_pkg;

import org.hibernate.Session;

import utils.HibernateUtil;

public class AttractionImplementationPortBindingImpl implements booking_pkg.AttractionImplementation{
    public booking_pkg.AttractieType[] getAttractionTypes() throws java.rmi.RemoteException {
    	
    	return null;
    }

    public int bookAttraction(int arg0, booking_pkg.OrderedTicket[] arg1, java.util.Calendar arg2, java.lang.String arg3) throws java.rmi.RemoteException {
        return -3;
    }

    public booking_pkg.Attractie[] getAttractions(java.lang.String arg0, int arg1, int arg2, int arg3) throws java.rmi.RemoteException {
        return null;
    }

    public booking_pkg.Region[] getRegions(java.lang.String arg0) throws java.rmi.RemoteException {
        return null;
    }

    public booking_pkg.City[] getCities(int arg0) throws java.rmi.RemoteException {
        return null;
    }

    public booking_pkg.Booking[] getBooking(int arg0, java.lang.String arg1) throws java.rmi.RemoteException {
        return null;
    }

    public booking_pkg.Country[] getCountries() throws java.rmi.RemoteException {
        return null;
    }

}
