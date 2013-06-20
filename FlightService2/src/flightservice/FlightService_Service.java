
package flightservice;

import java.io.File;
import java.util.ArrayList;
import java.util.List;

import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebResult;
import javax.jws.WebService;
import javax.xml.bind.JAXBException;
import javax.xml.datatype.XMLGregorianCalendar;
import javax.xml.ws.RequestWrapper;
import javax.xml.ws.ResponseWrapper;

import flightserviceDTO.AirportDTO;
import flightserviceDTO.ArrayOfAirportDTO;
import flightserviceDTO.ArrayOfBookingDTO;
import flightserviceDTO.ArrayOfFlightDTO;
import flightserviceDTO.ArrayOfPassengerDTO;
import flightserviceDTO.BookingDTO;

//Service Implementation
@WebService(endpointInterface = "flightservice.FlightService")
public class FlightService_Service implements FlightService{

	@Override
	@WebMethod(operationName = "ShowFlightsByDeparture", action = "http://flightservice.themaopdracht8.nl/FlightService/ShowFlightsByDeparture")
	@WebResult(name = "ShowFlightsByDepartureResult", targetNamespace = "http://flightservice.themaopdracht8.nl")
	@RequestWrapper(localName = "ShowFlightsByDeparture", targetNamespace = "http://flightservice.themaopdracht8.nl", className = "nl.themaopdracht8.flightservice.ShowFlightsByDeparture")
	@ResponseWrapper(localName = "ShowFlightsByDepartureResponse", targetNamespace = "http://flightservice.themaopdracht8.nl", className = "nl.themaopdracht8.flightservice.ShowFlightsByDepartureResponse")
	public ArrayOfFlightDTO showFlightsByDeparture(
			@WebParam(name = "departureId", targetNamespace = "http://flightservice.themaopdracht8.nl") Integer departureId,
			@WebParam(name = "destinationId", targetNamespace = "http://flightservice.themaopdracht8.nl") Integer destinationId,
			@WebParam(name = "departureDate", targetNamespace = "http://flightservice.themaopdracht8.nl") XMLGregorianCalendar departureDate,
			@WebParam(name = "passengers", targetNamespace = "http://flightservice.themaopdracht8.nl") Integer passengers)
					throws FlightServiceShowFlightsByDepartureExceptionFaultFaultMessage {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	@WebMethod(operationName = "ShowFlightsByArrival", action = "http://flightservice.themaopdracht8.nl/FlightService/ShowFlightsByArrival")
	@WebResult(name = "ShowFlightsByArrivalResult", targetNamespace = "http://flightservice.themaopdracht8.nl")
	@RequestWrapper(localName = "ShowFlightsByArrival", targetNamespace = "http://flightservice.themaopdracht8.nl", className = "nl.themaopdracht8.flightservice.ShowFlightsByArrival")
	@ResponseWrapper(localName = "ShowFlightsByArrivalResponse", targetNamespace = "http://flightservice.themaopdracht8.nl", className = "nl.themaopdracht8.flightservice.ShowFlightsByArrivalResponse")
	public ArrayOfFlightDTO showFlightsByArrival(
			@WebParam(name = "departureId", targetNamespace = "http://flightservice.themaopdracht8.nl") Integer departureId,
			@WebParam(name = "destinationId", targetNamespace = "http://flightservice.themaopdracht8.nl") Integer destinationId,
			@WebParam(name = "arrivalDate", targetNamespace = "http://flightservice.themaopdracht8.nl") XMLGregorianCalendar arrivalDate,
			@WebParam(name = "passengers", targetNamespace = "http://flightservice.themaopdracht8.nl") Integer passengers)
					throws FlightServiceShowFlightsByArrivalExceptionFaultFaultMessage {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	@WebMethod(operationName = "GetAirports", action = "http://flightservice.themaopdracht8.nl/FlightService/GetAirports")
	@WebResult(name = "GetAirportsResult", targetNamespace = "http://flightservice.themaopdracht8.nl")
	@RequestWrapper(localName = "GetAirports", targetNamespace = "http://flightservice.themaopdracht8.nl", className = "nl.themaopdracht8.flightservice.GetAirports")
	@ResponseWrapper(localName = "GetAirportsResponse", targetNamespace = "http://flightservice.themaopdracht8.nl", className = "nl.themaopdracht8.flightservice.GetAirportsResponse")
	public ArrayOfAirportDTO getAirports(
			@WebParam(name = "searchValue", targetNamespace = "http://flightservice.themaopdracht8.nl") String searchValue)
					throws FlightServiceGetAirportsExceptionFaultFaultMessage {		

		List<AirportDTO> airportArray = new ArrayList<AirportDTO>();

		try {
			airportArray = JAXBXMLHandler.unmarshal(new File("airports.xml"));
		} catch (JAXBException e) {
			e.printStackTrace();
		}
		
		ArrayOfAirportDTO arrayDTO = new ArrayOfAirportDTO();
        arrayDTO.setAirports(airportArray);

		return arrayDTO;
	}

	@Override
	@WebMethod(operationName = "BookFlight", action = "http://flightservice.themaopdracht8.nl/FlightService/BookFlight")
	@WebResult(name = "BookFlightResult", targetNamespace = "http://flightservice.themaopdracht8.nl")
	@RequestWrapper(localName = "BookFlight", targetNamespace = "http://flightservice.themaopdracht8.nl", className = "nl.themaopdracht8.flightservice.BookFlight")
	@ResponseWrapper(localName = "BookFlightResponse", targetNamespace = "http://flightservice.themaopdracht8.nl", className = "nl.themaopdracht8.flightservice.BookFlightResponse")
	public BookingDTO bookFlight(
			@WebParam(name = "flightId", targetNamespace = "http://flightservice.themaopdracht8.nl") Integer flightId,
			@WebParam(name = "passengers", targetNamespace = "http://flightservice.themaopdracht8.nl") ArrayOfPassengerDTO passengers,
			@WebParam(name = "userToken", targetNamespace = "http://flightservice.themaopdracht8.nl") String userToken)
					throws FlightServiceBookFlightExceptionFaultFaultMessage {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	@WebMethod(operationName = "GetPersonalBookings", action = "http://flightservice.themaopdracht8.nl/FlightService/GetPersonalBookings")
	@WebResult(name = "GetPersonalBookingsResult", targetNamespace = "http://flightservice.themaopdracht8.nl")
	@RequestWrapper(localName = "GetPersonalBookings", targetNamespace = "http://flightservice.themaopdracht8.nl", className = "nl.themaopdracht8.flightservice.GetPersonalBookings")
	@ResponseWrapper(localName = "GetPersonalBookingsResponse", targetNamespace = "http://flightservice.themaopdracht8.nl", className = "nl.themaopdracht8.flightservice.GetPersonalBookingsResponse")
	public ArrayOfBookingDTO getPersonalBookings(
			@WebParam(name = "userToken", targetNamespace = "http://flightservice.themaopdracht8.nl") String userToken)
					throws FlightServiceGetPersonalBookingsExceptionFaultFaultMessage {
		// TODO Auto-generated method stub
		return null;
	}

}