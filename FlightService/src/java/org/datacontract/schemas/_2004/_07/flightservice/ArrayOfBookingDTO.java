
package org.datacontract.schemas._2004._07.flightservice;

import java.util.ArrayList;
import java.util.List;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for ArrayOfBookingDTO complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="ArrayOfBookingDTO">
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="BookingDTO" type="{http://schemas.datacontract.org/2004/07/FlightService.DataModels}BookingDTO" maxOccurs="unbounded" minOccurs="0"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "ArrayOfBookingDTO", propOrder = {
    "bookingDTO"
})
public class ArrayOfBookingDTO {

    @XmlElement(name = "BookingDTO", nillable = true)
    protected List<BookingDTO> bookingDTO;

    /**
     * Gets the value of the bookingDTO property.
     * 
     * <p>
     * This accessor method returns a reference to the live list,
     * not a snapshot. Therefore any modification you make to the
     * returned list will be present inside the JAXB object.
     * This is why there is not a <CODE>set</CODE> method for the bookingDTO property.
     * 
     * <p>
     * For example, to add a new item, do as follows:
     * <pre>
     *    getBookingDTO().add(newItem);
     * </pre>
     * 
     * 
     * <p>
     * Objects of the following type(s) are allowed in the list
     * {@link BookingDTO }
     * 
     * 
     */
    public List<BookingDTO> getBookingDTO() {
        if (bookingDTO == null) {
            bookingDTO = new ArrayList<BookingDTO>();
        }
        return this.bookingDTO;
    }

}
