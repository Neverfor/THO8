using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiClient.Flight
{
    public partial class FlightUC : UserControl
    {
        bool validated = false;

        public FlightUC()
        {
            InitializeComponent();
        }

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

        private void ZoekButton_Click(object sender, EventArgs e)
        {
            if (isValidated())
            {
                var window = new FoundFlightsForm();
                window.Show();
            }

            else
            {

            }
        }
    }
}
