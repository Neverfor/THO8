/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package webservice;

import flightserviceDTO.JAXBXMLHandler;
import flightserviceDTO.AirportDTO;
import flightserviceDTO.ArrayOfAirportDTO;
import java.io.File;
import java.util.ArrayList;
import java.util.List;
import javax.jws.WebService;
import javax.xml.bind.JAXBException;

/**
 *
 * @author Michael
 */
@WebService(serviceName = "FlightService", portName = "BasicHttpBinding_FlightService", endpointInterface = "org.tempuri.FlightService", targetNamespace = "http://tempuri.org/", wsdlLocation = "WEB-INF/wsdl/FlightService/FlightService.svc.wsdl")
public class FlightService {

    public flightserviceDTO.ArrayOfFlightDTO showFlightsByDeparture(java.lang.Integer departureId, java.lang.Integer destinationId, javax.xml.datatype.XMLGregorianCalendar departureDate, java.lang.Integer passengers) throws org.tempuri.FlightServiceShowFlightsByDepartureExceptionFaultFaultMessage {
        //TODO implement this method
        throw new UnsupportedOperationException("Not implemented yet.");
    }

    public flightserviceDTO.ArrayOfFlightDTO showFlightsByArrival(java.lang.Integer departureId, java.lang.Integer destinationId, javax.xml.datatype.XMLGregorianCalendar arrivalDate, java.lang.Integer passengers) throws org.tempuri.FlightServiceShowFlightsByArrivalExceptionFaultFaultMessage {
        //TODO implement this method
        throw new UnsupportedOperationException("Not implemented yet.");
    }

    public flightserviceDTO.ArrayOfAirportDTO getAirports(java.lang.String searchValue) throws org.tempuri.FlightServiceGetAirportsExceptionFaultFaultMessage {
        List<AirportDTO> airportArray = new ArrayList<AirportDTO>();
	List<AirportDTO> airportArray2 = new ArrayList<AirportDTO>();

	try {
		airportArray = JAXBXMLHandler.unmarshal(new File("airports.xml"));
        } catch (JAXBException e) {
		e.printStackTrace();
	}
	ArrayOfAirportDTO arrayDTO = new ArrayOfAirportDTO();

	System.out.println("searchvalue: " + searchValue);
	while (airportArray.iterator().hasNext())
	{
		if( airportArray.iterator().next().getName().equals(searchValue) ) {
			airportArray2.add(airportArray.iterator().next());
			arrayDTO.setAirports(airportArray2);
			return arrayDTO;
		}
	}
	return arrayDTO;
    }

    public flightserviceDTO.BookingDTO bookFlight(java.lang.Integer flightId, org.datacontract.schemas._2004._07.flightservice.ArrayOfPassengerDTO passengers, java.lang.String userToken) throws org.tempuri.FlightServiceBookFlightExceptionFaultFaultMessage {
        //TODO implement this method
        throw new UnsupportedOperationException("Not implemented yet.");
    }

    public flightserviceDTO.ArrayOfBookingDTO getPersonalBookings(java.lang.String userToken) throws org.tempuri.FlightServiceGetPersonalBookingsExceptionFaultFaultMessage {
        //TODO implement this method
        throw new UnsupportedOperationException("Not implemented yet.");
    }

    public flightserviceDTO.FlightDTO getFlightById(java.lang.Integer flightId) throws org.tempuri.FlightServiceGetFlightByIdExceptionFaultFaultMessage {
        //TODO implement this method
        throw new UnsupportedOperationException("Not implemented yet.");
    }
    
}
