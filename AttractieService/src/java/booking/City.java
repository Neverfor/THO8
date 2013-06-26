
package booking;

import java.io.Serializable;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlType;
import javax.persistence.*;
import javax.xml.bind.annotation.XmlTransient;

/**
 * <p>Java class for city complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="city">
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="cityID" type="{http://www.w3.org/2001/XMLSchema}int"/>
 *         &lt;element name="cityName" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "city", propOrder = {
    "cityID",
    "cityName"
})
@Entity
@NamedQueries({
    @NamedQuery(name="City.findAll", query="SELECT c FROM City c"),
    @NamedQuery(name="City.findByName", query="SELECT c FROM City c WHERE c.cityName = :cityName"),    
})
public class City implements Serializable{
    @Id
    @GeneratedValue
    protected int cityID;
    protected String cityName;
    
    
    @ManyToOne(cascade = CascadeType.ALL)
    @JoinColumn(name="regionID", nullable=false)
    @XmlTransient
    protected Region region;

    public Region getRegion() {
        return region;
    }

    public void setRegion(Region region) {
        this.region = region;
    }

    /**
     * Gets the value of the cityID property.
     * 
     */
    public int getCityID() {
        return cityID;
    }

    /**
     * Sets the value of the cityID property.
     * 
     */
    public void setCityID(int value) {
        this.cityID = value;
    }

    /**
     * Gets the value of the cityName property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getCityName() {
        return cityName;
    }

    /**
     * Sets the value of the cityName property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setCityName(String value) {
        this.cityName = value;
    }

}
