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
                cbRegion.DisplayMember = "cityName";

                FillDataGrid();
            }
        }

        private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (AttractionImplementationClient client = new AttractionImplementationClient())
            {
                FillDataGrid();
            }
        }

        private void cbAttractionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (AttractionImplementationClient client = new AttractionImplementationClient())
            {
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
            rtbDescription.Text = attraction.description;
            lblAddress_data.Text = attraction.address;
            linkWebsite.Text = attraction.website;
        }

        private void clearAttractionData()
        {
            rtbDescription.Text = "";
            lblAddress_data.Text = "";
            linkWebsite.Text = "";
        }

    }
}
