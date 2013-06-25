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
@WebService(serviceName = "FlightService", portName = "BasicHttpBinding_FlightService", endpointInterface = "org.tempuri.FlightService", targetNamespace = "http://tempuri.org/", wsdlLocation = "WEB-INF/wsdl/FlightService/FlightService.svc.wsdl")
public class FlightService {

    public org.datacontract.schemas._2004._07.flightservice.ArrayOfFlightDTO showFlightsByDeparture(java.lang.Integer departureId, java.lang.Integer destinationId, javax.xml.datatype.XMLGregorianCalendar departureDate, java.lang.Integer passengers) throws org.tempuri.FlightServiceShowFlightsByDepartureExceptionFaultFaultMessage {
        //TODO implement this method
        throw new UnsupportedOperationException("Not implemented yet.");
    }

    public org.datacontract.schemas._2004._07.flightservice.ArrayOfFlightDTO showFlightsByArrival(java.lang.Integer departureId, java.lang.Integer destinationId, javax.xml.datatype.XMLGregorianCalendar arrivalDate, java.lang.Integer passengers) throws org.tempuri.FlightServiceShowFlightsByArrivalExceptionFaultFaultMessage {
        //TODO implement this method
        throw new UnsupportedOperationException("Not implemented yet.");
    }

    public org.datacontract.schemas._2004._07.flightservice.ArrayOfAirportDTO getAirports(java.lang.String searchValue) throws org.tempuri.FlightServiceGetAirportsExceptionFaultFaultMessage {
        //TODO implement this method
        throw new UnsupportedOperationException("Not implemented yet.");
    }

    public org.datacontract.schemas._2004._07.flightservice.BookingDTO bookFlight(java.lang.Integer flightId, org.datacontract.schemas._2004._07.flightservice.ArrayOfPassengerDTO passengers, java.lang.String userToken) throws org.tempuri.FlightServiceBookFlightExceptionFaultFaultMessage {
        //TODO implement this method
        throw new UnsupportedOperationException("Not implemented yet.");
    }

    public org.datacontract.schemas._2004._07.flightservice.ArrayOfBookingDTO getPersonalBookings(java.lang.String userToken) throws org.tempuri.FlightServiceGetPersonalBookingsExceptionFaultFaultMessage {
        //TODO implement this method
        throw new UnsupportedOperationException("Not implemented yet.");
    }

    public org.datacontract.schemas._2004._07.flightservice.FlightDTO getFlightById(java.lang.Integer flightId) throws org.tempuri.FlightServiceGetFlightByIdExceptionFaultFaultMessage {
        //TODO implement this method
        throw new UnsupportedOperationException("Not implemented yet.");
    }
    
}
