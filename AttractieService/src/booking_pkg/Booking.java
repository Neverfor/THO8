/**
 * Booking.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package booking_pkg;

public class Booking  implements java.io.Serializable {
    private booking_pkg.Attractie attraction;

    private booking_pkg.OrderedTicket[] orderedTickets;

    private double price;

    private java.lang.String status;

    private java.util.Calendar datum;

    public Booking() {
    }

    public Booking(
           booking_pkg.Attractie attraction,
           booking_pkg.OrderedTicket[] orderedTickets,
           double price,
           java.lang.String status,
           java.util.Calendar datum) {
           this.attraction = attraction;
           this.orderedTickets = orderedTickets;
           this.price = price;
           this.status = status;
           this.datum = datum;
    }


    /**
     * Gets the attraction value for this Booking.
     * 
     * @return attraction
     */
    public booking_pkg.Attractie getAttraction() {
        return attraction;
    }


    /**
     * Sets the attraction value for this Booking.
     * 
     * @param attraction
     */
    public void setAttraction(booking_pkg.Attractie attraction) {
        this.attraction = attraction;
    }


    /**
     * Gets the orderedTickets value for this Booking.
     * 
     * @return orderedTickets
     */
    public booking_pkg.OrderedTicket[] getOrderedTickets() {
        return orderedTickets;
    }


    /**
     * Sets the orderedTickets value for this Booking.
     * 
     * @param orderedTickets
     */
    public void setOrderedTickets(booking_pkg.OrderedTicket[] orderedTickets) {
        this.orderedTickets = orderedTickets;
    }

    public booking_pkg.OrderedTicket getOrderedTickets(int i) {
        return this.orderedTickets[i];
    }

    public void setOrderedTickets(int i, booking_pkg.OrderedTicket _value) {
        this.orderedTickets[i] = _value;
    }


    /**
     * Gets the price value for this Booking.
     * 
     * @return price
     */
    public double getPrice() {
        return price;
    }


    /**
     * Sets the price value for this Booking.
     * 
     * @param price
     */
    public void setPrice(double price) {
        this.price = price;
    }


    /**
     * Gets the status value for this Booking.
     * 
     * @return status
     */
    public java.lang.String getStatus() {
        return status;
    }


    /**
     * Sets the status value for this Booking.
     * 
     * @param status
     */
    public void setStatus(java.lang.String status) {
        this.status = status;
    }


    /**
     * Gets the datum value for this Booking.
     * 
     * @return datum
     */
    public java.util.Calendar getDatum() {
        return datum;
    }


    /**
     * Sets the datum value for this Booking.
     * 
     * @param datum
     */
    public void setDatum(java.util.Calendar datum) {
        this.datum = datum;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof Booking)) return false;
        Booking other = (Booking) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.attraction==null && other.getAttraction()==null) || 
             (this.attraction!=null &&
              this.attraction.equals(other.getAttraction()))) &&
            ((this.orderedTickets==null && other.getOrderedTickets()==null) || 
             (this.orderedTickets!=null &&
              java.util.Arrays.equals(this.orderedTickets, other.getOrderedTickets()))) &&
            this.price == other.getPrice() &&
            ((this.status==null && other.getStatus()==null) || 
             (this.status!=null &&
              this.status.equals(other.getStatus()))) &&
            ((this.datum==null && other.getDatum()==null) || 
             (this.datum!=null &&
              this.datum.equals(other.getDatum())));
        __equalsCalc = null;
        return _equals;
    }

    private boolean __hashCodeCalc = false;
    public synchronized int hashCode() {
        if (__hashCodeCalc) {
            return 0;
        }
        __hashCodeCalc = true;
        int _hashCode = 1;
        if (getAttraction() != null) {
            _hashCode += getAttraction().hashCode();
        }
        if (getOrderedTickets() != null) {
            for (int i=0;
                 i<java.lang.reflect.Array.getLength(getOrderedTickets());
                 i++) {
                java.lang.Object obj = java.lang.reflect.Array.get(getOrderedTickets(), i);
                if (obj != null &&
                    !obj.getClass().isArray()) {
                    _hashCode += obj.hashCode();
                }
            }
        }
        _hashCode += new Double(getPrice()).hashCode();
        if (getStatus() != null) {
            _hashCode += getStatus().hashCode();
        }
        if (getDatum() != null) {
            _hashCode += getDatum().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(Booking.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://booking/", "booking"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("attraction");
        elemField.setXmlName(new javax.xml.namespace.QName("", "attraction"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://booking/", "attractie"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("orderedTickets");
        elemField.setXmlName(new javax.xml.namespace.QName("", "orderedTickets"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://booking/", "orderedTicket"));
        elemField.setMinOccurs(0);
        elemField.setNillable(true);
        elemField.setMaxOccursUnbounded(true);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("price");
        elemField.setXmlName(new javax.xml.namespace.QName("", "price"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "double"));
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("status");
        elemField.setXmlName(new javax.xml.namespace.QName("", "status"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("datum");
        elemField.setXmlName(new javax.xml.namespace.QName("", "datum"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "dateTime"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
    }

    /**
     * Return type metadata object
     */
    public static org.apache.axis.description.TypeDesc getTypeDesc() {
        return typeDesc;
    }

    /**
     * Get Custom Serializer
     */
    public static org.apache.axis.encoding.Serializer getSerializer(
           java.lang.String mechType, 
           java.lang.Class _javaType,  
           javax.xml.namespace.QName _xmlType) {
        return 
          new  org.apache.axis.encoding.ser.BeanSerializer(
            _javaType, _xmlType, typeDesc);
    }

    /**
     * Get Custom Deserializer
     */
    public static org.apache.axis.encoding.Deserializer getDeserializer(
           java.lang.String mechType, 
           java.lang.Class _javaType,  
           javax.xml.namespace.QName _xmlType) {
        return 
          new  org.apache.axis.encoding.ser.BeanDeserializer(
            _javaType, _xmlType, typeDesc);
    }

}
