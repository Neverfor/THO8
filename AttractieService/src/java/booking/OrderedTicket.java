
package booking;

import java.io.Serializable;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlType;
import javax.persistence.*;

/**
 * <p>Java class for orderedTicket complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="orderedTicket">
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="ticketTypeID" type="{http://www.w3.org/2001/XMLSchema}int"/>
 *         &lt;element name="amount" type="{http://www.w3.org/2001/XMLSchema}int"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "orderedTicket", propOrder = {
    "ticketTypeID",
    "amount"
})

@Entity
@NamedQueries({
    @NamedQuery(name="OrderedTicket.findAll", query="SELECT ot FROM OrderedTicket ot"),
})
public class OrderedTicket implements Serializable{

    @Id
    @GeneratedValue
    protected int ticketTypeID;
    protected int amount;

    /**
     * Gets the value of the ticketTypeID property.
     * 
     */
    public int getTicketTypeID() {
        return ticketTypeID;
    }

    /**
     * Sets the value of the ticketTypeID property.
     * 
     */
    public void setTicketTypeID(int value) {
        this.ticketTypeID = value;
    }

    /**
     * Gets the value of the amount property.
     * 
     */
    public int getAmount() {
        return amount;
    }

    /**
     * Sets the value of the amount property.
     * 
     */
    public void setAmount(int value) {
        this.amount = value;
    }

}
