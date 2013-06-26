
package booking;

import java.io.Serializable;
import javax.persistence.CascadeType;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToMany;
import javax.persistence.ManyToOne;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlTransient;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for region complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="region">
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="regionID" type="{http://www.w3.org/2001/XMLSchema}int"/>
 *         &lt;element name="regionName" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "region", propOrder = {
    "regionID",
    "regionName"
})
@Entity
@NamedQueries({
    @NamedQuery(name="Region.findAll", query="SELECT r FROM Region r"),
    @NamedQuery(name="Region.findByName", query="SELECT r FROM Region r WHERE r.regionName = :regionName"),
})
public class Region implements Serializable {
    @Id
    @GeneratedValue
    protected int regionID;
    protected String regionName;
    
    @ManyToOne(cascade = CascadeType.ALL)
    @JoinColumn(name="countryID", nullable=false)
    @XmlTransient
    protected Country country;

    public Country getCountry() {
        return country;
    }

    public void setCountry(Country country) {
        this.country = country;
    }

    /**
     * Gets the value of the regionID property.
     * 
     */
    public int getRegionID() {
        return regionID;
    }

    /**
     * Sets the value of the regionID property.
     * 
     */
    public void setRegionID(int value) {
        this.regionID = value;
    }

    /**
     * Gets the value of the regionName property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getRegionName() {
        return regionName;
    }

    /**
     * Sets the value of the regionName property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setRegionName(String value) {
        this.regionName = value;
    }

}
