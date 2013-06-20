

import java.io.Console;
import java.util.List;
import utils.HibernateUtil;
import org.hibernate.*;

public class Main {
   
    public static void main(String[] args) throws Exception {
        Session session = HibernateUtil.getSession();
        
        System.out.println(session.toString());

    }

}