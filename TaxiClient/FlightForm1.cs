using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientFlightPart
{
    public partial class FlightForm1 : Form
    {
        public FlightForm1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ZoekButton_Click(object sender, EventArgs e)
        {
            if (isValidated())
            {
                var window = new FlightForm2();
                window.Show();
            }

            else 
            {

            }
            
        }

        bool validated = false;
        public bool isValidated()
        {
            if (KlasseCombo != null &&
                vluchtTypeCombo != null &&
                vertrekTextBox != null &&
                bestemmingTextBox != null)
            {
                validated = true;
            }
            else 
            {
                validated = false;
            }
            return validated;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
