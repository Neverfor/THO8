
package flightservice;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElementRef;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;

@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "", propOrder = {"searchValue"})
@XmlRootElement(name = "GetAirports")
public class GetAirports {

    @XmlElementRef(name = "searchValue", namespace = "http://flightservice.themaopdracht8.nl", type = JAXBElement.class, required = false)
    protected JAXBElement<String> searchValue;

    public JAXBElement<String> getSearchValue() {
        return searchValue;
    }

    public void setSearchValue(JAXBElement<String> value) {
        this.searchValue = value;
    }
}