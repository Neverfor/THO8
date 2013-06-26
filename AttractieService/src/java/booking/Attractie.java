
package booking;

import java.io.Serializable;
import java.util.ArrayList;
import java.util.List;
import javax.persistence.*;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlTransient;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for attractie complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="attractie">
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="attractionID" type="{http://www.w3.org/2001/XMLSchema}int"/>
 *         &lt;element name="naam" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="address" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="description" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="pictures" type="{http://www.w3.org/2001/XMLSchema}string" maxOccurs="unbounded" minOccurs="0"/>
 *         &lt;element name="website" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="attractionType" type="{http://booking/}attractieType" minOccurs="0"/>
 *         &lt;element name="tickets" type="{http://booking/}ticketType" maxOccurs="unbounded" minOccurs="0"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "attractie", propOrder = {
    "attractionID",
    "naam",
    "address",
    "description",
    "pictures",
    "website",
    "attractionType",
    "tickets"
})

@Entity
@NamedQueries({
    @NamedQuery(name="Attractie.findAll", query="SELECT a FROM Attractie a"),
    @NamedQuery(name="Attractie.findByNaam", query="SELECT a FROM Attractie a WHERE a.naam = :naam"),
    @NamedQuery(name="Attractie.findById", query="SELECT a FROM Attractie a WHERE a.attractionID = :id")
})
public class Attractie implements Serializable{

    @Id
    @GeneratedValue
    protected int attractionID;
    protected String naam;
    protected String address;
    protected String description;
    @XmlElement(nillable = true)
    protected List<String> pictures;
    protected String website;
    @ManyToOne(cascade = CascadeType.ALL)
    @JoinColumn(name="attractionTypeID", nullable=false)
    protected AttractieType attractionType;
    
    @XmlElement(nillable = true)
    @OneToMany(orphanRemoval=true, cascade = CascadeType.ALL)
    @JoinColumn(name="attractionID") 
    protected List<TicketType> tickets;
    @ManyToOne(cascade = CascadeType.ALL)
    @JoinColumn(name="regionID", nullable=false)
    @XmlTransient
    protected Region region;
    @ManyToOne(cascade = CascadeType.ALL)
    @JoinColumn(name="cityID", nullable=false)
    @XmlTransient
    protected City city;

    public City getCity() {
        return city;
    }

    public void setCity(City city) {
        this.city = city;
    }

    public Country getCountry() {
        return country;
    }

    public void setCountry(Country country) {
        this.country = country;
    }
    @ManyToOne(cascade = CascadeType.ALL)
    @JoinColumn(name="countryID", nullable=false)
    @XmlTransient
    protected Country country;

    public void addTicket(TicketType tt){
        if(tickets == null)
            tickets = new ArrayList<>();
        tickets.add(tt);
    }

    /**
     * Gets the value of the attractionID property.
     * 
     */
    public int getAttractionID() {
        return attractionID;
    }

    /**
     * Sets the value of the attractionID property.
     * 
     */
    public void setAttractionID(int value) {
        this.attractionID = value;
    }

    /**
     * Gets the value of the naam property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getNaam() {
        return naam;
    }

    /**
     * Sets the value of the naam property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setNaam(String value) {
        this.naam = value;
    }

    /**
     * Gets the value of the address property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getAddress() {
        return address;
    }

    /**
     * Sets the value of the address property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setAddress(String value) {
        this.address = value;
    }

    /**
     * Gets the value of the description property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getDescription() {
        return description;
    }

    /**
     * Sets the value of the description property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setDescription(String value) {
        this.description = value;
    }

    /**
     * Gets the value of the pictures property.
     * 
     * <p>
     * This accessor method returns a reference to the live list,
     * not a snapshot. Therefore any modification you make to the
     * returned list will be present inside the JAXB object.
     * This is why there is not a <CODE>set</CODE> method for the pictures property.
     * 
     * <p>
     * For example, to add a new item, do as follows:
     * <pre>
     *    getPictures().add(newItem);
     * </pre>
     * 
     * 
     * <p>
     * Objects of the following type(s) are allowed in the list
     * {@link String }
     * 
     * 
     */
    public List<String> getPictures() {
        if (pictures == null) {
            pictures = new ArrayList<String>();
        }
        return this.pictures;
    }

    /**
     * Gets the value of the website property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getWebsite() {
        return website;
    }

    /**
     * Sets the value of the website property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setWebsite(String value) {
        this.website = value;
    }

    /**
     * Gets the value of the attractionType property.
     * 
     * @return
     *     possible object is
     *     {@link AttractieType }
     *     
     */
    public AttractieType getAttractionType() {
        return attractionType;
    }

    /**
     * Sets the value of the attractionType property.
     * 
     * @param value
     *     allowed object is
     *     {@link AttractieType }
     *     
     */
    public void setAttractionType(AttractieType value) {
        this.attractionType = value;
    }

    /**
     * Gets the value of the tickets property.
     * 
     * <p>
     * This accessor method returns a reference to the live list,
     * not a snapshot. Therefore any modification you make to the
     * returned list will be present inside the JAXB object.
     * This is why there is not a <CODE>set</CODE> method for the tickets property.
     * 
     * <p>
     * For example, to add a new item, do as follows:
     * <pre>
     *    getTickets().add(newItem);
     * </pre>
     * 
     * 
     * <p>
     * Objects of the following type(s) are allowed in the list
     * {@link TicketType }
     * 
     * 
     */
    public List<TicketType> getTickets() {
        if (tickets == null) {
            tickets = new ArrayList<TicketType>();
        }
        return this.tickets;
    }
    
     public Region getRegion() {
        return region;
    }

    public void setRegion(Region region) {
        this.region = region;
    }

}
