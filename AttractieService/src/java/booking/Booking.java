
package booking;

import java.io.Serializable;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlSchemaType;
import javax.xml.bind.annotation.XmlType;
import javax.xml.datatype.XMLGregorianCalendar;
import javax.persistence.*;
import javax.xml.bind.annotation.XmlTransient;

/**
 * <p>Java class for booking complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="booking">
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="attraction" type="{http://booking/}attractie" minOccurs="0"/>
 *         &lt;element name="orderedTickets" type="{http://booking/}orderedTicket" maxOccurs="unbounded" minOccurs="0"/>
 *         &lt;element name="price" type="{http://www.w3.org/2001/XMLSchema}double"/>
 *         &lt;element name="status" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="datum" type="{http://www.w3.org/2001/XMLSchema}dateTime" minOccurs="0"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "booking", propOrder = {
    "attraction",
    "orderedTickets",
    "price",
    "status",
    "datum"
})
@Entity
@NamedQueries({
    @NamedQuery(name="Booking.findAll", query="SELECT b FROM Booking b"),
    @NamedQuery(name="Booking.findByStatus", query="SELECT b FROM Booking b WHERE b.status = :status"),    
})
public class Booking implements Serializable{

    @Id
    @GeneratedValue
    @XmlTransient
    protected int bookingID;

    public int getiD() {
        return bookingID;
    }

    public void setiD(int iD) {
        this.bookingID = iD;
    }
    @ManyToOne(cascade = CascadeType.ALL)
    @JoinColumn(name="attractionID", nullable=false)
    protected Attractie attraction;
    @XmlElement(nillable = true)
    @OneToMany(orphanRemoval=true)
    @JoinColumn(name="bookingID") 
    protected List<OrderedTicket> orderedTickets;
    protected double price;
    protected String status;
    @Transient
    @XmlSchemaType(name = "dateTime")
    protected XMLGregorianCalendar datum;
    
    @XmlTransient
    protected int userID;
    
    @Temporal(javax.persistence.TemporalType.DATE)
    @XmlTransient
    protected Date datumDate;

    public Date getDatumDate() {
        return datumDate;
    }

    public void setDatumDate(Date datumDate) {
        this.datumDate = datumDate;
    }

    /**
     * Gets the value of the attraction property.
     * 
     * @return
     *     possible object is
     *     {@link Attractie }
     *     
     */
    public Attractie getAttraction() {
        return attraction;
    }

    /**
     * Sets the value of the attraction property.
     * 
     * @param value
     *     allowed object is
     *     {@link Attractie }
     *     
     */
    public void setAttraction(Attractie value) {
        this.attraction = value;
    }

    /**
     * Gets the value of the orderedTickets property.
     * 
     * <p>
     * This accessor method returns a reference to the live list,
     * not a snapshot. Therefore any modification you make to the
     * returned list will be present inside the JAXB object.
     * This is why there is not a <CODE>set</CODE> method for the orderedTickets property.
     * 
     * <p>
     * For example, to add a new item, do as follows:
     * <pre>
     *    getOrderedTickets().add(newItem);
     * </pre>
     * 
     * 
     * <p>
     * Objects of the following type(s) are allowed in the list
     * {@link OrderedTicket }
     * 
     * 
     */
    public List<OrderedTicket> getOrderedTickets() {
        if (orderedTickets == null) {
            orderedTickets = new ArrayList<OrderedTicket>();
        }
        return this.orderedTickets;
    }

    /**
     * Gets the value of the price property.
     * 
     */
    public double getPrice() {
        return price;
    }

    /**
     * Sets the value of the price property.
     * 
     */
    public void setPrice(double value) {
        this.price = value;
    }

    /**
     * Gets the value of the status property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getStatus() {
        return status;
    }

    /**
     * Sets the value of the status property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setStatus(String value) {
        this.status = value;
    }

    /**
     * Gets the value of the datum property.
     * 
     * @return
     *     possible object is
     *     {@link XMLGregorianCalendar }
     *     
     */
    public XMLGregorianCalendar getDatum() {
        return datum;
    }

    /**
     * Sets the value of the datum property.
     * 
     * @param value
     *     allowed object is
     *     {@link XMLGregorianCalendar }
     *     
     */
    public void setDatum(XMLGregorianCalendar value) {
        this.datum = value;
    }

}
