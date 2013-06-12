using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace To8Libraries.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual List<TaxiBooking> Bookings { get; set; }

        public override bool Equals(object obj)
        {
            // If parameter is null return false.
            if (obj == null)
            {
                return false;
            }

            // If parameter cannot be cast to Point return false.
            User u = obj as User;
            if ((System.Object)u == null)
            {
                return false;
            }

            // Return true if the fields match:
            return UserName == u.UserName;
        }

        public override int GetHashCode()
        {
            return UserName.GetHashCode();
        }

    }
}
