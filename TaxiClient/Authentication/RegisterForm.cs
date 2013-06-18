using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiClient.Authentication
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try {

                string gender = "";
                if (rbMale.Checked) gender = "male";
                if (rbFemale.Checked) gender = "female";

                using (Team2.UserServiceClient userClient = new Team2.UserServiceClient())
                {
                    Team2.User user = new Team2.User();

                    user.Username = tbUsername.Text;
                    user.Password = tbPassword.Text;
                    user.Firstname = tbFirstName.Text;
                    user.Surname = tbSurname.Text;
                    user.Sex = gender;
                    user.DateOfBirth = dtpDateOfBirth.Value;
                    user.Address = tbAddress.Text;
                    user.City = tbCity.Text;
                    user.Country = tbCountry.Text;
                    user.Email = tbEmail.Text;
                    user.PhoneNumber = tbPhone.Text;

                    user = userClient.GetUser(userClient.Register(user));
                    MessageBox.Show(string.Format("Gebruikersnaam:\t{0}\nWachtwoord:\t{1}", user.Username, user.Password));
                    this.Close();
                    new LoginForm().Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
