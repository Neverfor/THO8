
package flightservice;

import java.net.MalformedURLException;
import java.net.URL;
import javax.xml.namespace.QName;
import javax.xml.ws.Service;
import javax.xml.ws.WebEndpoint;
import javax.xml.ws.WebServiceClient;
import javax.xml.ws.WebServiceException;
import javax.xml.ws.WebServiceFeature;


/**
 * This class was generated by the JAX-WS RI.
 * JAX-WS RI 2.2.4-b01
 * Generated source version: 2.2
 * 
 */
@WebServiceClient(name = "FlightService", targetNamespace = "http://flightservice.themaopdracht8.nl", wsdlLocation = "http://flightservice.devworks.nl/FlightService.svc?singleWsdl")
public class FlightService_Service
    extends Service
{

    private final static URL FLIGHTSERVICE_WSDL_LOCATION;
    private final static WebServiceException FLIGHTSERVICE_EXCEPTION;
    private final static QName FLIGHTSERVICE_QNAME = new QName("http://flightservice.themaopdracht8.nl", "FlightService");

    static {
        URL url = null;
        WebServiceException e = null;
        try {
            url = new URL("http://flightservice.devworks.nl/FlightService.svc?singleWsdl");
        } catch (MalformedURLException ex) {
            e = new WebServiceException(ex);
        }
        FLIGHTSERVICE_WSDL_LOCATION = url;
        FLIGHTSERVICE_EXCEPTION = e;
    }

    public FlightService_Service() {
        super(__getWsdlLocation(), FLIGHTSERVICE_QNAME);
    }

    public FlightService_Service(WebServiceFeature... features) {
        super(__getWsdlLocation(), FLIGHTSERVICE_QNAME, features);
    }

    public FlightService_Service(URL wsdlLocation) {
        super(wsdlLocation, FLIGHTSERVICE_QNAME);
    }

    public FlightService_Service(URL wsdlLocation, WebServiceFeature... features) {
        super(wsdlLocation, FLIGHTSERVICE_QNAME, features);
    }

    public FlightService_Service(URL wsdlLocation, QName serviceName) {
        super(wsdlLocation, serviceName);
    }

    public FlightService_Service(URL wsdlLocation, QName serviceName, WebServiceFeature... features) {
        super(wsdlLocation, serviceName, features);
    }

    /**
     * 
     * @return
     *     returns FlightService
     */
    @WebEndpoint(name = "BasicHttpBinding_FlightService")
    public FlightService getBasicHttpBindingFlightService() {
        return super.getPort(new QName("http://flightservice.themaopdracht8.nl", "BasicHttpBinding_FlightService"), FlightService.class);
    }

    /**
     * 
     * @param features
     *     A list of {@link javax.xml.ws.WebServiceFeature} to configure on the proxy.  Supported features not in the <code>features</code> parameter will have their default values.
     * @return
     *     returns FlightService
     */
    @WebEndpoint(name = "BasicHttpBinding_FlightService")
    public FlightService getBasicHttpBindingFlightService(WebServiceFeature... features) {
        return super.getPort(new QName("http://flightservice.themaopdracht8.nl", "BasicHttpBinding_FlightService"), FlightService.class, features);
    }

    private static URL __getWsdlLocation() {
        if (FLIGHTSERVICE_EXCEPTION!= null) {
            throw FLIGHTSERVICE_EXCEPTION;
        }
        return FLIGHTSERVICE_WSDL_LOCATION;
    }

}
