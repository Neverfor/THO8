package flightservice;

import javax.xml.ws.Endpoint;

import flightservice.FlightService_Service;
import flightservice.FlightService;
import flightservice.FlightServiceGetAirportsExceptionFaultFaultMessage;

public class FlightServicePublisher {
	
	public static void main(String[] args) throws FlightServiceGetAirportsExceptionFaultFaultMessage {
		 
		FlightService_Service flightService = new FlightService_Service();
		FlightService flight = flightService.getBasicHttpBindingFlightService();
 
		System.out.println(flight.toString());
		
		Endpoint.publish("http://localhost:9999/ws/flight", new FlightService_Service());
    }
}