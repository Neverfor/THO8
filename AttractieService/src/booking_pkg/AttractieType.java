/**
 * AttractieType.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package booking_pkg;

import javax.annotation.*;
import javax.persistence.Entity;
import javax.persistence.FetchType;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;
import javax.persistence.Transient;

@Entity
public class AttractieType  implements java.io.Serializable {
    private java.lang.String attractionTypeName;

    @Id
	@GeneratedValue
    private int attractionTypeID;

    public AttractieType() {
    }

    public AttractieType(
           java.lang.String attractionTypeName,
           int attractionTypeID) {
           this.attractionTypeName = attractionTypeName;
           this.attractionTypeID = attractionTypeID;
    }


    /**
     * Gets the attractionTypeName value for this AttractieType.
     * 
     * @return attractionTypeName
     */
    public java.lang.String getAttractionTypeName() {
        return attractionTypeName;
    }


    /**
     * Sets the attractionTypeName value for this AttractieType.
     * 
     * @param attractionTypeName
     */
    public void setAttractionTypeName(java.lang.String attractionTypeName) {
        this.attractionTypeName = attractionTypeName;
    }


    /**
     * Gets the attractionTypeID value for this AttractieType.
     * 
     * @return attractionTypeID
     */
    public int getAttractionTypeID() {
        return attractionTypeID;
    }


    /**
     * Sets the attractionTypeID value for this AttractieType.
     * 
     * @param attractionTypeID
     */
    public void setAttractionTypeID(int attractionTypeID) {
        this.attractionTypeID = attractionTypeID;
    }
    @Transient
    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof AttractieType)) return false;
        AttractieType other = (AttractieType) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.attractionTypeName==null && other.getAttractionTypeName()==null) || 
             (this.attractionTypeName!=null &&
              this.attractionTypeName.equals(other.getAttractionTypeName()))) &&
            this.attractionTypeID == other.getAttractionTypeID();
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
        if (getAttractionTypeName() != null) {
            _hashCode += getAttractionTypeName().hashCode();
        }
        _hashCode += getAttractionTypeID();
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(AttractieType.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://booking/", "attractieType"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("attractionTypeName");
        elemField.setXmlName(new javax.xml.namespace.QName("", "attractionTypeName"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("attractionTypeID");
        elemField.setXmlName(new javax.xml.namespace.QName("", "attractionTypeID"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"));
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
