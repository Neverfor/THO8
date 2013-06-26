using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxiClient.AttractionService;

namespace TaxiClient.Attraction
{
    public partial class AttractionUC : UserControl
    {
        Form parentContainer;
        List<orderedTicket> tickets = new List<orderedTicket>(); 
        public AttractionUC(Form parentContainer)
        {
            InitializeComponent();
            this.parentContainer = parentContainer;
            using (AttractionImplementationClient client = new AttractionImplementationClient())
            {
                country[] countries = client.getCountries();
                cbCountry.Items.AddRange(countries);
                cbCountry.DisplayMember = "countryName";

                attractieType[] attractions = client.getAttractionTypes();
                cbAttractionType.Items.AddRange(attractions);
                cbAttractionType.DisplayMember = "attractionTypeName";

                FillDataGrid();
            }
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (AttractionImplementationClient client = new AttractionImplementationClient())
            {
                country country = cbCountry.Items[cbCountry.SelectedIndex] as country;
                region[] regions = client.getRegions(country.countryCode);

                cbRegion.Items.Clear();
                cbCity.Items.Clear();

                cbRegion.Items.AddRange(regions);
                cbRegion.DisplayMember = "regionName";

                clearAttractionData();
                FillDataGrid();
            }
        }

        private void cbRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (AttractionImplementationClient client = new AttractionImplementationClient())
            {
                region region = cbRegion.Items[cbRegion.SelectedIndex] as region;
                city[] cities = client.getCities(region.regionID);

                cbCity.Items.Clear();

                cbCity.Items.AddRange(cities);
                cbCity.DisplayMember = "cityName";

                clearAttractionData();
                FillDataGrid();
            }
        }

        private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (AttractionImplementationClient client = new AttractionImplementationClient())
            {
                clearAttractionData();
                FillDataGrid();
            }
        }

        private void cbAttractionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (AttractionImplementationClient client = new AttractionImplementationClient())
            {
                clearAttractionData();
                FillDataGrid();
            }
        }

        private void FillDataGrid()
        {
            using (AttractionImplementationClient client = new AttractionImplementationClient())
            {
                clearAttractionData();

                string country = "";
                int region = 0;
                int city = 0;
                int atType = 0;

                if (cbCountry.SelectedIndex > -1)
                {
                    country c = cbCountry.Items[cbCountry.SelectedIndex] as country;
                    country = c.countryCode;
                }
                if (cbRegion.SelectedIndex > -1)
                {
                    region r = cbRegion.Items[cbRegion.SelectedIndex] as region;
                    region = r.regionID;
                }
                if (cbCity.SelectedIndex > -1)
                {
                    city c = cbCity.Items[cbCity.SelectedIndex] as city;
                    city = c.cityID;
                }
                if (cbAttractionType.SelectedIndex > -1)
                {
                    attractieType a = cbAttractionType.Items[cbAttractionType.SelectedIndex] as attractieType;
                    atType = a.attractionTypeID;
                }

                dgAttractions.DataSource = client.getAttractions(country, region, city, atType);
                dgAttractions.ClearSelection();
            }
        }

        private void dgAttractions_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = dgAttractions.SelectedRows[0].Index;
            attractie attraction = dgAttractions.Rows[selectedRow].DataBoundItem as attractie;
            ticketType[] ticketTypes = attraction.tickets;
            rtbDescription.Text = attraction.description;
            lblAddress_data.Text = attraction.address;
            linkWebsite.Text = attraction.website;

            lblDate.Enabled = true;
            dtpDate.Enabled = true;
            lblTicketType.Enabled = true;
            cbTicketType.Enabled = true;
            cbTicketType.Items.Clear();
            cbTicketType.Items.AddRange(ticketTypes);
            cbTicketType.DisplayMember = "description";
            nudTypeAmount.Enabled = true;
            btnChoose.Enabled = true;
            btnBookTickets.Enabled = true;

            tickets.Clear();
            rtbTicketTypes.Text = "";
        }

        private void clearAttractionData()
        {
            rtbDescription.Text = "";
            lblAddress_data.Text = "";
            linkWebsite.Text = "";

            lblDate.Enabled = false;
            dtpDate.Enabled = false;
            lblTicketType.Enabled = false;
            cbTicketType.Items.Clear();
            cbTicketType.Enabled = false;
            nudTypeAmount.Enabled = false;
            btnChoose.Enabled = false;
            btnBookTickets.Enabled = false;
            rtbTicketTypes.Text = "";
        }

        private void PrintTicketTypes(attractie at)
        {
            rtbTicketTypes.Text = "";
            string name = "";
            foreach (orderedTicket ot in tickets)
            {
                foreach (ticketType tt in at.tickets)
                {
                    if (tt.id == ot.ticketTypeID)
                    {
                        name = tt.description;
                        break;
                    }
                }

                rtbTicketTypes.Text += string.Format("{0} keer: {1}\n", ot.amount, name);
            }
        }

        private void btnBookTickets_Click(object sender, EventArgs e)
        {
            if (tickets.Count > 0 && 
                dtpDate.Value > DateTime.Now)
            {
                int selectedRow = dgAttractions.SelectedRows[0].Index;
                attractie attraction = dgAttractions.Rows[selectedRow].DataBoundItem as attractie;

                DateTime date = dtpDate.Value;
                date = new DateTime(date.Year, date.Month, date.Day);

                using (AttractionImplementationClient client = new AttractionImplementationClient())
                {
                    client.bookAttraction(attraction.attractionID, tickets.ToArray(), date, Session.UserToken);
                }
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            int selectedRow = dgAttractions.SelectedRows[0].Index;
            attractie attraction = dgAttractions.Rows[selectedRow].DataBoundItem as attractie;
            ticketType tt = cbTicketType.Items[cbTicketType.SelectedIndex] as ticketType;
            int amount = (int) nudTypeAmount.Value;
            if (amount > 0)
            {
                bool done = false;
                foreach (orderedTicket ot in tickets)
                {
                    if (ot.ticketTypeID == tt.id)
                    {
                        ot.amount = amount;
                        done = true;
                        break;
                    }
                }
                if (!done)
                {
                    tickets.Add(new orderedTicket()
                    {
                        ticketTypeID = tt.id,
                        amount = amount
                    });
                }
                PrintTicketTypes(attraction);
            }
            else
            {
                orderedTicket ticket = null;
                foreach (orderedTicket ot in tickets)
                {
                    if (ot.ticketTypeID == tt.id)
                    {
                        ticket = ot;
                        break;
                    }
                }
                tickets.Remove(ticket);
                PrintTicketTypes(attraction);
            }
                        
        }

        private void cbTicketType_SelectedIndexChanged(object sender, EventArgs e)
        {
            nudTypeAmount.Value = 0;
        }


    }
}
