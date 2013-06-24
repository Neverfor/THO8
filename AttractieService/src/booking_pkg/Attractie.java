/**
 * Attractie.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package booking_pkg;

import javax.persistence.*;

@Entity
@NamedQueries({
	@NamedQuery(name="Attractie.findAll", query="SELECT a FROM Attractie a"),
	@NamedQuery(name="Attractie.findByNaam", query="SELECT a FROM Attractie a WHERE a.naam = :naam"),
	@NamedQuery(name="Attractie.findById", query="SELECT a FROM Attractie a WHERE a.attractionID = :id")
})
public class Attractie  implements java.io.Serializable {
	@Id
	@GeneratedValue
    private int attractionID;

    private java.lang.String naam;

    private java.lang.String address;

    private java.lang.String description;

    private java.lang.String[] pictures;

    private java.lang.String website;

    @ManyToOne
    @JoinColumn(name="attractionTypeID", nullable=false)
    private booking_pkg.AttractieType attractionType;

    private booking_pkg.TicketType[] tickets;

    public Attractie() {
    }

    public Attractie(
           int attractionID,
           java.lang.String naam,
           java.lang.String address,
           java.lang.String description,
           java.lang.String[] pictures,
           java.lang.String website,
           booking_pkg.AttractieType attractionType,
           booking_pkg.TicketType[] tickets) {
           this.attractionID = attractionID;
           this.naam = naam;
           this.address = address;
           this.description = description;
           this.pictures = pictures;
           this.website = website;
           this.attractionType = attractionType;
           this.tickets = tickets;
    }


    /**
     * Gets the attractionID value for this Attractie.
     * 
     * @return attractionID
     */
    public int getAttractionID() {
        return attractionID;
    }


    /**
     * Sets the attractionID value for this Attractie.
     * 
     * @param attractionID
     */
    public void setAttractionID(int attractionID) {
        this.attractionID = attractionID;
    }


    /**
     * Gets the naam value for this Attractie.
     * 
     * @return naam
     */
    public java.lang.String getNaam() {
        return naam;
    }


    /**
     * Sets the naam value for this Attractie.
     * 
     * @param naam
     */
    public void setNaam(java.lang.String naam) {
        this.naam = naam;
    }


    /**
     * Gets the address value for this Attractie.
     * 
     * @return address
     */
    public java.lang.String getAddress() {
        return address;
    }


    /**
     * Sets the address value for this Attractie.
     * 
     * @param address
     */
    public void setAddress(java.lang.String address) {
        this.address = address;
    }


    /**
     * Gets the description value for this Attractie.
     * 
     * @return description
     */
    public java.lang.String getDescription() {
        return description;
    }


    /**
     * Sets the description value for this Attractie.
     * 
     * @param description
     */
    public void setDescription(java.lang.String description) {
        this.description = description;
    }


    /**
     * Gets the pictures value for this Attractie.
     * 
     * @return pictures
     */
    public java.lang.String[] getPictures() {
        return pictures;
    }


    /**
     * Sets the pictures value for this Attractie.
     * 
     * @param pictures
     */
    public void setPictures(java.lang.String[] pictures) {
        this.pictures = pictures;
    }

    public java.lang.String getPictures(int i) {
        return this.pictures[i];
    }

    public void setPictures(int i, java.lang.String _value) {
        this.pictures[i] = _value;
    }


    /**
     * Gets the website value for this Attractie.
     * 
     * @return website
     */
    public java.lang.String getWebsite() {
        return website;
    }


    /**
     * Sets the website value for this Attractie.
     * 
     * @param website
     */
    public void setWebsite(java.lang.String website) {
        this.website = website;
    }


    /**
     * Gets the attractionType value for this Attractie.
     * 
     * @return attractionType
     */
    public booking_pkg.AttractieType getAttractionType() {
        return attractionType;
    }


    /**
     * Sets the attractionType value for this Attractie.
     * 
     * @param attractionType
     */
    public void setAttractionType(booking_pkg.AttractieType attractionType) {
        this.attractionType = attractionType;
    }


    /**
     * Gets the tickets value for this Attractie.
     * 
     * @return tickets
     */
    public booking_pkg.TicketType[] getTickets() {
        return tickets;
    }


    /**
     * Sets the tickets value for this Attractie.
     * 
     * @param tickets
     */
    public void setTickets(booking_pkg.TicketType[] tickets) {
        this.tickets = tickets;
    }

    public booking_pkg.TicketType getTickets(int i) {
        return this.tickets[i];
    }

    public void setTickets(int i, booking_pkg.TicketType _value) {
        this.tickets[i] = _value;
    }
    @Transient
    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof Attractie)) return false;
        Attractie other = (Attractie) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            this.attractionID == other.getAttractionID() &&
            ((this.naam==null && other.getNaam()==null) || 
             (this.naam!=null &&
              this.naam.equals(other.getNaam()))) &&
            ((this.address==null && other.getAddress()==null) || 
             (this.address!=null &&
              this.address.equals(other.getAddress()))) &&
            ((this.description==null && other.getDescription()==null) || 
             (this.description!=null &&
              this.description.equals(other.getDescription()))) &&
            ((this.pictures==null && other.getPictures()==null) || 
             (this.pictures!=null &&
              java.util.Arrays.equals(this.pictures, other.getPictures()))) &&
            ((this.website==null && other.getWebsite()==null) || 
             (this.website!=null &&
              this.website.equals(other.getWebsite()))) &&
            ((this.attractionType==null && other.getAttractionType()==null) || 
             (this.attractionType!=null &&
              this.attractionType.equals(other.getAttractionType()))) &&
            ((this.tickets==null && other.getTickets()==null) || 
             (this.tickets!=null &&
              java.util.Arrays.equals(this.tickets, other.getTickets())));
        __equalsCalc = null;
        return _equals;
    }
    @Transient
    private boolean __hashCodeCalc = false;
    public synchronized int hashCode() {
        if (__hashCodeCalc) {
            return 0;
        }
        __hashCodeCalc = true;
        int _hashCode = 1;
        _hashCode += getAttractionID();
        if (getNaam() != null) {
            _hashCode += getNaam().hashCode();
        }
        if (getAddress() != null) {
            _hashCode += getAddress().hashCode();
        }
        if (getDescription() != null) {
            _hashCode += getDescription().hashCode();
        }
        if (getPictures() != null) {
            for (int i=0;
                 i<java.lang.reflect.Array.getLength(getPictures());
                 i++) {
                java.lang.Object obj = java.lang.reflect.Array.get(getPictures(), i);
                if (obj != null &&
                    !obj.getClass().isArray()) {
                    _hashCode += obj.hashCode();
                }
            }
        }
        if (getWebsite() != null) {
            _hashCode += getWebsite().hashCode();
        }
        if (getAttractionType() != null) {
            _hashCode += getAttractionType().hashCode();
        }
        if (getTickets() != null) {
            for (int i=0;
                 i<java.lang.reflect.Array.getLength(getTickets());
                 i++) {
                java.lang.Object obj = java.lang.reflect.Array.get(getTickets(), i);
                if (obj != null &&
                    !obj.getClass().isArray()) {
                    _hashCode += obj.hashCode();
                }
            }
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(Attractie.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://booking/", "attractie"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("attractionID");
        elemField.setXmlName(new javax.xml.namespace.QName("", "attractionID"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"));
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("naam");
        elemField.setXmlName(new javax.xml.namespace.QName("", "naam"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("address");
        elemField.setXmlName(new javax.xml.namespace.QName("", "address"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("description");
        elemField.setXmlName(new javax.xml.namespace.QName("", "description"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("pictures");
        elemField.setXmlName(new javax.xml.namespace.QName("", "pictures"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(true);
        elemField.setMaxOccursUnbounded(true);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("website");
        elemField.setXmlName(new javax.xml.namespace.QName("", "website"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("attractionType");
        elemField.setXmlName(new javax.xml.namespace.QName("", "attractionType"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://booking/", "attractieType"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("tickets");
        elemField.setXmlName(new javax.xml.namespace.QName("", "tickets"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://booking/", "ticketType"));
        elemField.setMinOccurs(0);
        elemField.setNillable(true);
        elemField.setMaxOccursUnbounded(true);
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
