/**
 * AttractionImplementationPortBindingSkeleton.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package booking_pkg;

public class AttractionImplementationPortBindingSkeleton implements booking_pkg.AttractionImplementation, org.apache.axis.wsdl.Skeleton {
    private booking_pkg.AttractionImplementation impl;
    private static java.util.Map _myOperations = new java.util.Hashtable();
    private static java.util.Collection _myOperationsList = new java.util.ArrayList();

    /**
    * Returns List of OperationDesc objects with this name
    */
    public static java.util.List getOperationDescByName(java.lang.String methodName) {
        return (java.util.List)_myOperations.get(methodName);
    }

    /**
    * Returns Collection of OperationDescs
    */
    public static java.util.Collection getOperationDescs() {
        return _myOperationsList;
    }

    static {
        org.apache.axis.description.OperationDesc _oper;
        org.apache.axis.description.FaultDesc _fault;
        org.apache.axis.description.ParameterDesc [] _params;
        _params = new org.apache.axis.description.ParameterDesc [] {
        };
        _oper = new org.apache.axis.description.OperationDesc("getAttractionTypes", _params, new javax.xml.namespace.QName("", "return"));
        _oper.setReturnType(new javax.xml.namespace.QName("http://booking/", "attractieType"));
        _oper.setElementQName(new javax.xml.namespace.QName("http://booking/", "getAttractionTypes"));
        _oper.setSoapAction("");
        _myOperationsList.add(_oper);
        if (_myOperations.get("getAttractionTypes") == null) {
            _myOperations.put("getAttractionTypes", new java.util.ArrayList());
        }
        ((java.util.List)_myOperations.get("getAttractionTypes")).add(_oper);
        _params = new org.apache.axis.description.ParameterDesc [] {
            new org.apache.axis.description.ParameterDesc(new javax.xml.namespace.QName("", "arg0"), org.apache.axis.description.ParameterDesc.IN, new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"), int.class, false, false), 
            new org.apache.axis.description.ParameterDesc(new javax.xml.namespace.QName("", "arg1"), org.apache.axis.description.ParameterDesc.IN, new javax.xml.namespace.QName("http://booking/", "orderedTicket"), booking_pkg.OrderedTicket[].class, false, false), 
            new org.apache.axis.description.ParameterDesc(new javax.xml.namespace.QName("", "arg2"), org.apache.axis.description.ParameterDesc.IN, new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "dateTime"), java.util.Calendar.class, false, false), 
            new org.apache.axis.description.ParameterDesc(new javax.xml.namespace.QName("", "arg3"), org.apache.axis.description.ParameterDesc.IN, new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"), java.lang.String.class, false, false), 
        };
        _oper = new org.apache.axis.description.OperationDesc("bookAttraction", _params, new javax.xml.namespace.QName("", "return"));
        _oper.setReturnType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"));
        _oper.setElementQName(new javax.xml.namespace.QName("http://booking/", "bookAttraction"));
        _oper.setSoapAction("");
        _myOperationsList.add(_oper);
        if (_myOperations.get("bookAttraction") == null) {
            _myOperations.put("bookAttraction", new java.util.ArrayList());
        }
        ((java.util.List)_myOperations.get("bookAttraction")).add(_oper);
        _params = new org.apache.axis.description.ParameterDesc [] {
            new org.apache.axis.description.ParameterDesc(new javax.xml.namespace.QName("", "arg0"), org.apache.axis.description.ParameterDesc.IN, new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"), java.lang.String.class, false, false), 
            new org.apache.axis.description.ParameterDesc(new javax.xml.namespace.QName("", "arg1"), org.apache.axis.description.ParameterDesc.IN, new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"), int.class, false, false), 
            new org.apache.axis.description.ParameterDesc(new javax.xml.namespace.QName("", "arg2"), org.apache.axis.description.ParameterDesc.IN, new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"), int.class, false, false), 
            new org.apache.axis.description.ParameterDesc(new javax.xml.namespace.QName("", "arg3"), org.apache.axis.description.ParameterDesc.IN, new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"), int.class, false, false), 
        };
        _oper = new org.apache.axis.description.OperationDesc("getAttractions", _params, new javax.xml.namespace.QName("", "return"));
        _oper.setReturnType(new javax.xml.namespace.QName("http://booking/", "attractie"));
        _oper.setElementQName(new javax.xml.namespace.QName("http://booking/", "getAttractions"));
        _oper.setSoapAction("");
        _myOperationsList.add(_oper);
        if (_myOperations.get("getAttractions") == null) {
            _myOperations.put("getAttractions", new java.util.ArrayList());
        }
        ((java.util.List)_myOperations.get("getAttractions")).add(_oper);
        _params = new org.apache.axis.description.ParameterDesc [] {
            new org.apache.axis.description.ParameterDesc(new javax.xml.namespace.QName("", "arg0"), org.apache.axis.description.ParameterDesc.IN, new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"), java.lang.String.class, false, false), 
        };
        _oper = new org.apache.axis.description.OperationDesc("getRegions", _params, new javax.xml.namespace.QName("", "return"));
        _oper.setReturnType(new javax.xml.namespace.QName("http://booking/", "region"));
        _oper.setElementQName(new javax.xml.namespace.QName("http://booking/", "getRegions"));
        _oper.setSoapAction("");
        _myOperationsList.add(_oper);
        if (_myOperations.get("getRegions") == null) {
            _myOperations.put("getRegions", new java.util.ArrayList());
        }
        ((java.util.List)_myOperations.get("getRegions")).add(_oper);
        _params = new org.apache.axis.description.ParameterDesc [] {
            new org.apache.axis.description.ParameterDesc(new javax.xml.namespace.QName("", "arg0"), org.apache.axis.description.ParameterDesc.IN, new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"), int.class, false, false), 
        };
        _oper = new org.apache.axis.description.OperationDesc("getCities", _params, new javax.xml.namespace.QName("", "return"));
        _oper.setReturnType(new javax.xml.namespace.QName("http://booking/", "city"));
        _oper.setElementQName(new javax.xml.namespace.QName("http://booking/", "getCities"));
        _oper.setSoapAction("");
        _myOperationsList.add(_oper);
        if (_myOperations.get("getCities") == null) {
            _myOperations.put("getCities", new java.util.ArrayList());
        }
        ((java.util.List)_myOperations.get("getCities")).add(_oper);
        _params = new org.apache.axis.description.ParameterDesc [] {
            new org.apache.axis.description.ParameterDesc(new javax.xml.namespace.QName("", "arg0"), org.apache.axis.description.ParameterDesc.IN, new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"), int.class, false, false), 
            new org.apache.axis.description.ParameterDesc(new javax.xml.namespace.QName("", "arg1"), org.apache.axis.description.ParameterDesc.IN, new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"), java.lang.String.class, false, false), 
        };
        _oper = new org.apache.axis.description.OperationDesc("getBooking", _params, new javax.xml.namespace.QName("", "return"));
        _oper.setReturnType(new javax.xml.namespace.QName("http://booking/", "booking"));
        _oper.setElementQName(new javax.xml.namespace.QName("http://booking/", "getBooking"));
        _oper.setSoapAction("");
        _myOperationsList.add(_oper);
        if (_myOperations.get("getBooking") == null) {
            _myOperations.put("getBooking", new java.util.ArrayList());
        }
        ((java.util.List)_myOperations.get("getBooking")).add(_oper);
        _params = new org.apache.axis.description.ParameterDesc [] {
        };
        _oper = new org.apache.axis.description.OperationDesc("getCountries", _params, new javax.xml.namespace.QName("", "return"));
        _oper.setReturnType(new javax.xml.namespace.QName("http://booking/", "country"));
        _oper.setElementQName(new javax.xml.namespace.QName("http://booking/", "getCountries"));
        _oper.setSoapAction("");
        _myOperationsList.add(_oper);
        if (_myOperations.get("getCountries") == null) {
            _myOperations.put("getCountries", new java.util.ArrayList());
        }
        ((java.util.List)_myOperations.get("getCountries")).add(_oper);
    }

    public AttractionImplementationPortBindingSkeleton() {
        this.impl = new booking_pkg.AttractionImplementationPortBindingImpl();
    }

    public AttractionImplementationPortBindingSkeleton(booking_pkg.AttractionImplementation impl) {
        this.impl = impl;
    }
    public booking_pkg.AttractieType[] getAttractionTypes() throws java.rmi.RemoteException
    {
        booking_pkg.AttractieType[] ret = impl.getAttractionTypes();
        return ret;
    }

    public int bookAttraction(int arg0, booking_pkg.OrderedTicket[] arg1, java.util.Calendar arg2, java.lang.String arg3) throws java.rmi.RemoteException
    {
        int ret = impl.bookAttraction(arg0, arg1, arg2, arg3);
        return ret;
    }

    public booking_pkg.Attractie[] getAttractions(java.lang.String arg0, int arg1, int arg2, int arg3) throws java.rmi.RemoteException
    {
        booking_pkg.Attractie[] ret = impl.getAttractions(arg0, arg1, arg2, arg3);
        return ret;
    }

    public booking_pkg.Region[] getRegions(java.lang.String arg0) throws java.rmi.RemoteException
    {
        booking_pkg.Region[] ret = impl.getRegions(arg0);
        return ret;
    }

    public booking_pkg.City[] getCities(int arg0) throws java.rmi.RemoteException
    {
        booking_pkg.City[] ret = impl.getCities(arg0);
        return ret;
    }

    public booking_pkg.Booking[] getBooking(int arg0, java.lang.String arg1) throws java.rmi.RemoteException
    {
        booking_pkg.Booking[] ret = impl.getBooking(arg0, arg1);
        return ret;
    }

    public booking_pkg.Country[] getCountries() throws java.rmi.RemoteException
    {
        booking_pkg.Country[] ret = impl.getCountries();
        return ret;
    }

}
