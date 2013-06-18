using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To8Libraries.Domain;

namespace To8Libraries
{
    public class UserHelper
    {
        /*
        * Gets user based on userToken
        * @return: User object
        */
        public static User GetUser(string userToken)
        {
            Team2.UserService us = new Team2.UserServiceClient();
            var userResponse = us.GetUser(userToken); //get user response object

            User rtnUser = new User();
            rtnUser.FirstName = userResponse.Firstname;
            rtnUser.LastName = userResponse.Surname;
            rtnUser.Password = userResponse.Password;
            rtnUser.UserName = userResponse.Username;
            rtnUser.Bookings = null;

            return rtnUser;
        }

        /*
         * Logs in the user with username and password
         * @return: string userToken
         */
        public static string LoginUser(string userName, string password)
        {
            Team2.UserService us = new Team2.UserServiceClient();
            return us.Login(userName, password);
        }
    }
}
