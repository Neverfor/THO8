﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxiClient.TaxiService;
using System.ServiceModel;
using System.Diagnostics;

namespace TaxiClient.Taxi
{
    public partial class TaxiUC : UserControl
    {
        Form parentContainer;
        public TaxiUC(Form parentContainer)
        {
            this.parentContainer = parentContainer;
            InitializeComponent();
            FillDataGrid();
        }

        private void FillDataGrid()
        {
            using (WebServiceClient client = new WebServiceClient())
            {
                UserBookingsRequest req = new UserBookingsRequest();
                req.UserToken = Session.UserToken;
                UserBookings userBookings = client.GetUserBookings(req);
                userBookingsDG.DataSource = userBookings.TaxiBookings;
            }
        }

        private void btnFindTaxi_Click(object sender, EventArgs e)
        {
            TaxiPriceInfoRequest tpirequest;
            TaxiPriceInfo response;

            using (WebServiceClient client = new WebServiceClient())
            {
                try
                {
                    Address departureAddress = new Address();
                    departureAddress.Street = tbDepStreet.Text;
                    departureAddress.Number = Convert.ToInt32(tbDepNumber.Text);
                    departureAddress.ZipCode = tbDepZipCode.Text;
                    departureAddress.City = tbDepCity.Text;
                    departureAddress.Country = tbDepCountry.Text;

                    Address destinationAddress = new Address();
                    destinationAddress.Street = tbDestStreet.Text;
                    destinationAddress.Number = Convert.ToInt32(tbDestNumber.Text);
                    destinationAddress.ZipCode = tbDestZipCode.Text;
                    destinationAddress.City = tbDestCity.Text;
                    destinationAddress.Country = tbDestCountry.Text;

                    DateTime dateTime = new DateTime(
                            dtpDate.Value.Year,
                            dtpDate.Value.Month,
                            dtpDate.Value.Day,
                            dtpTime.Value.Hour,
                            dtpTime.Value.Minute,
                            0);

                    tpirequest = new TaxiPriceInfoRequest();
                    tpirequest.DepartureAddress = departureAddress;
                    tpirequest.DestinationAddress = destinationAddress;
                    tpirequest.DateTime = dateTime;
                    if (rbDeparture.Checked) tpirequest.IsDepartureTime = true;
                    else tpirequest.IsDepartureTime = false;
                    tpirequest.AmountOfPassengers = Convert.ToInt32(tbPassengers.Text);


                    response = client.GetTaxiPriceInfo(tpirequest);

                    Address a1 = response.DepartureAddress;
                    Address a2 = response.DestinationAddress;

                    string sDepartureAddress = string.Format("{0} {1} {2} {3} {4}", a1.Street, a1.Number, a1.ZipCode, a1.City, a1.Country);
                    string sDestinationAddress = string.Format("{0} {1} {2} {3} {4}", a2.Street, a2.Number, a2.ZipCode, a2.City, a2.Country);
                    DialogResult result = MessageBox.Show(
                        String.Format("Er is een beschikbare taxi gevonden: \n\nTaxi Id.:\t\t{0} \nTaxi type:\t\t{1} \nPrijs:\t\t{2} \nVan:\t\t{3} \nNaar:\t\t{4} \nvanaf:\t\t{5} \nTot:\t\t{6} \nAantal passagiers:\t{7} \n\nWilt u deze taxi boeken?",
                            response.TaxiId,
                            response.TaxiType,
                            response.Price,
                            sDepartureAddress,
                            sDestinationAddress,
                            response.DepartureTime,
                            response.ArrivalTime,
                            response.AmountOfPassengers),
                        "Mogelijke taxi",
                        MessageBoxButtons.YesNo
                        );
                    if (result == DialogResult.Yes)
                    {
                        TaxiBookingRequest tbrequest = new TaxiBookingRequest();
                        tbrequest.UserToken = Session.UserToken;
                        tbrequest.DepartureAddress = response.DepartureAddress;
                        tbrequest.DestinationAddress = response.DestinationAddress;
                        tbrequest.DepartureTime = response.DepartureTime;
                        tbrequest.ArrivalTime = response.ArrivalTime;
                        tbrequest.TaxiId = response.TaxiId;
                        //tbrequest.TaxiType = response.TaxiType;       //not really necessary
                        tbrequest.Price = response.Price;
                        tbrequest.AmountOfPassengers = response.AmountOfPassengers;
                        client.DoTaxiBooking(tbrequest);

                        tabTaxi.SelectedTab = tabPage2;
                        FillDataGrid();
                    }
                }
                catch (FormatException fe)
                {
                    MessageBox.Show("U dient in sommige velden een numerieke waarde in te voeren");
                }
                catch (FaultException fe)
                {
                    MessageBox.Show(fe.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }        

        private void tabPage2_Click(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            int selectedRow = userBookingsDG.SelectedRows[0].Index;
            int selectedId = Convert.ToInt32(userBookingsDG.Rows[selectedRow].Cells[0].Value.ToString());

            try
            {
                using (WebServiceClient client = new WebServiceClient())
                {
                    CancelBookingRequest cbrequest = new CancelBookingRequest();
                    cbrequest.BookingId = Convert.ToInt32(selectedId);
                    cbrequest.UserToken = Session.UserToken;
                    client.CancelBooking(cbrequest);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            FillDataGrid();
        }



    }
}
