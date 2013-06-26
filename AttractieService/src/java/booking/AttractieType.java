
package booking;

import java.io.Serializable;
import javax.persistence.*;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for attractieType complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="attractieType">
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="attractionTypeName" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="attractionTypeID" type="{http://www.w3.org/2001/XMLSchema}int"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "attractieType", propOrder = {
    "attractionTypeName",
    "attractionTypeID"
})
@Entity
@NamedQueries({
    @NamedQuery(name="AttractieType.findAll", query="SELECT a FROM AttractieType a"),
    @NamedQuery(name="AttractieType.findByNaam", query="SELECT a FROM AttractieType a WHERE a.attractionTypeName = :naam"),
    @NamedQuery(name="AttractieType.findById", query="SELECT a FROM AttractieType a WHERE a.attractionTypeID = :id")
})
public class AttractieType implements Serializable {

    protected String attractionTypeName;
    @Id
    @GeneratedValue
    protected int attractionTypeID;

    /**
     * Gets the value of the attractionTypeName property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getAttractionTypeName() {
        return attractionTypeName;
    }

    /**
     * Sets the value of the attractionTypeName property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setAttractionTypeName(String value) {
        this.attractionTypeName = value;
    }

    /**
     * Gets the value of the attractionTypeID property.
     * 
     */
    public int getAttractionTypeID() {
        return attractionTypeID;
    }

    /**
     * Sets the value of the attractionTypeID property.
     * 
     */
    public void setAttractionTypeID(int value) {
        this.attractionTypeID = value;
    }

}
