namespace TaxiClient.Taxi
{
    partial class TaxiUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.taxiBookingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBookingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.userBookingsDG = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnFindTaxi = new System.Windows.Forms.Button();
            this.lblPassengers = new System.Windows.Forms.Label();
            this.tbPassengers = new System.Windows.Forms.TextBox();
            this.rbArrival = new System.Windows.Forms.RadioButton();
            this.rbDeparture = new System.Windows.Forms.RadioButton();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.gbDestinationAddress = new System.Windows.Forms.GroupBox();
            this.lblDestCountry = new System.Windows.Forms.Label();
            this.lblDestCity = new System.Windows.Forms.Label();
            this.lblDestZipCode = new System.Windows.Forms.Label();
            this.lblDestNumber = new System.Windows.Forms.Label();
            this.lblDestStreet = new System.Windows.Forms.Label();
            this.tbDestCountry = new System.Windows.Forms.TextBox();
            this.tbDestCity = new System.Windows.Forms.TextBox();
            this.tbDestZipCode = new System.Windows.Forms.TextBox();
            this.tbDestNumber = new System.Windows.Forms.TextBox();
            this.tbDestStreet = new System.Windows.Forms.TextBox();
            this.gbDepartureAddress = new System.Windows.Forms.GroupBox();
            this.lblDepCountry = new System.Windows.Forms.Label();
            this.lblDepCity = new System.Windows.Forms.Label();
            this.lblDepZipCode = new System.Windows.Forms.Label();
            this.lblDepNumber = new System.Windows.Forms.Label();
            this.lblDepStreet = new System.Windows.Forms.Label();
            this.tbDepCountry = new System.Windows.Forms.TextBox();
            this.tbDepCity = new System.Windows.Forms.TextBox();
            this.tbDepZipCode = new System.Windows.Forms.TextBox();
            this.tbDepNumber = new System.Windows.Forms.TextBox();
            this.tbDepStreet = new System.Windows.Forms.TextBox();
            this.tabTaxi = new System.Windows.Forms.TabControl();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTokenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountOfPassengersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxiIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxiTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.taxiBookingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBookingsBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBookingsDG)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.gbDestinationAddress.SuspendLayout();
            this.gbDepartureAddress.SuspendLayout();
            this.tabTaxi.SuspendLayout();
            this.SuspendLayout();
            // 
            // taxiBookingsBindingSource
            // 
            this.taxiBookingsBindingSource.DataMember = "TaxiBookings";
            this.taxiBookingsBindingSource.DataSource = this.userBookingsBindingSource;
            // 
            // userBookingsBindingSource
            // 
            this.userBookingsBindingSource.DataSource = typeof(TaxiClient.TaxiService.UserBookings);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCancelBooking);
            this.tabPage2.Controls.Add(this.userBookingsDG);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(943, 605);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Boeking overzicht";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.Location = new System.Drawing.Point(660, 410);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(106, 23);
            this.btnCancelBooking.TabIndex = 1;
            this.btnCancelBooking.Text = "Annuleer boeking";
            this.btnCancelBooking.UseVisualStyleBackColor = true;
            this.btnCancelBooking.Click += new System.EventHandler(this.btnCancelBooking_Click);
            // 
            // userBookingsDG
            // 
            this.userBookingsDG.AllowUserToAddRows = false;
            this.userBookingsDG.AllowUserToDeleteRows = false;
            this.userBookingsDG.AllowUserToResizeColumns = false;
            this.userBookingsDG.AllowUserToResizeRows = false;
            this.userBookingsDG.AutoGenerateColumns = false;
            this.userBookingsDG.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.userBookingsDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userBookingsDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userBookingsDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.userTokenDataGridViewTextBoxColumn,
            this.amountOfPassengersDataGridViewTextBoxColumn,
            this.departureAddressDataGridViewTextBoxColumn,
            this.destinationAddressDataGridViewTextBoxColumn,
            this.departureTimeDataGridViewTextBoxColumn,
            this.arrivalTimeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.taxiIdDataGridViewTextBoxColumn,
            this.taxiTypeDataGridViewTextBoxColumn});
            this.userBookingsDG.DataSource = this.taxiBookingsBindingSource;
            this.userBookingsDG.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.userBookingsDG.Location = new System.Drawing.Point(6, 6);
            this.userBookingsDG.MultiSelect = false;
            this.userBookingsDG.Name = "userBookingsDG";
            this.userBookingsDG.ReadOnly = true;
            this.userBookingsDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userBookingsDG.Size = new System.Drawing.Size(760, 392);
            this.userBookingsDG.TabIndex = 0;
            this.userBookingsDG.VirtualMode = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnFindTaxi);
            this.tabPage1.Controls.Add(this.lblPassengers);
            this.tabPage1.Controls.Add(this.tbPassengers);
            this.tabPage1.Controls.Add(this.rbArrival);
            this.tabPage1.Controls.Add(this.rbDeparture);
            this.tabPage1.Controls.Add(this.dtpTime);
            this.tabPage1.Controls.Add(this.lblTime);
            this.tabPage1.Controls.Add(this.lblDate);
            this.tabPage1.Controls.Add(this.dtpDate);
            this.tabPage1.Controls.Add(this.gbDestinationAddress);
            this.tabPage1.Controls.Add(this.gbDepartureAddress);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(943, 605);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Boek taxi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnFindTaxi
            // 
            this.btnFindTaxi.Location = new System.Drawing.Point(423, 397);
            this.btnFindTaxi.Name = "btnFindTaxi";
            this.btnFindTaxi.Size = new System.Drawing.Size(75, 23);
            this.btnFindTaxi.TabIndex = 20;
            this.btnFindTaxi.Text = "Zoek taxi";
            this.btnFindTaxi.UseVisualStyleBackColor = true;
            this.btnFindTaxi.Click += new System.EventHandler(this.btnFindTaxi_Click);
            // 
            // lblPassengers
            // 
            this.lblPassengers.AutoSize = true;
            this.lblPassengers.Location = new System.Drawing.Point(54, 370);
            this.lblPassengers.Name = "lblPassengers";
            this.lblPassengers.Size = new System.Drawing.Size(57, 13);
            this.lblPassengers.TabIndex = 18;
            this.lblPassengers.Text = "passagiers";
            // 
            // tbPassengers
            // 
            this.tbPassengers.Location = new System.Drawing.Point(121, 367);
            this.tbPassengers.Name = "tbPassengers";
            this.tbPassengers.Size = new System.Drawing.Size(46, 20);
            this.tbPassengers.TabIndex = 19;
            // 
            // rbArrival
            // 
            this.rbArrival.AutoSize = true;
            this.rbArrival.Location = new System.Drawing.Point(186, 344);
            this.rbArrival.Name = "rbArrival";
            this.rbArrival.Size = new System.Drawing.Size(71, 17);
            this.rbArrival.TabIndex = 18;
            this.rbArrival.Text = "aankomst";
            this.rbArrival.UseVisualStyleBackColor = true;
            // 
            // rbDeparture
            // 
            this.rbDeparture.AutoSize = true;
            this.rbDeparture.Checked = true;
            this.rbDeparture.Location = new System.Drawing.Point(121, 344);
            this.rbDeparture.Name = "rbDeparture";
            this.rbDeparture.Size = new System.Drawing.Size(58, 17);
            this.rbDeparture.TabIndex = 15;
            this.rbDeparture.TabStop = true;
            this.rbDeparture.Text = "vertrek";
            this.rbDeparture.UseVisualStyleBackColor = true;
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "HH:mm ";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(320, 317);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(57, 20);
            this.dtpTime.TabIndex = 14;
            this.dtpTime.Value = new System.DateTime(2013, 6, 19, 12, 29, 4, 375);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(299, 318);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(20, 13);
            this.lblTime.TabIndex = 13;
            this.lblTime.Text = "tijd";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(79, 318);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "datum";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(121, 317);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(172, 20);
            this.dtpDate.TabIndex = 11;
            this.dtpDate.Value = new System.DateTime(2013, 6, 19, 12, 29, 4, 384);
            // 
            // gbDestinationAddress
            // 
            this.gbDestinationAddress.Controls.Add(this.lblDestCountry);
            this.gbDestinationAddress.Controls.Add(this.lblDestCity);
            this.gbDestinationAddress.Controls.Add(this.lblDestZipCode);
            this.gbDestinationAddress.Controls.Add(this.lblDestNumber);
            this.gbDestinationAddress.Controls.Add(this.lblDestStreet);
            this.gbDestinationAddress.Controls.Add(this.tbDestCountry);
            this.gbDestinationAddress.Controls.Add(this.tbDestCity);
            this.gbDestinationAddress.Controls.Add(this.tbDestZipCode);
            this.gbDestinationAddress.Controls.Add(this.tbDestNumber);
            this.gbDestinationAddress.Controls.Add(this.tbDestStreet);
            this.gbDestinationAddress.Location = new System.Drawing.Point(19, 168);
            this.gbDestinationAddress.Name = "gbDestinationAddress";
            this.gbDestinationAddress.Size = new System.Drawing.Size(479, 143);
            this.gbDestinationAddress.TabIndex = 10;
            this.gbDestinationAddress.TabStop = false;
            this.gbDestinationAddress.Text = "Naar";
            // 
            // lblDestCountry
            // 
            this.lblDestCountry.AutoSize = true;
            this.lblDestCountry.Location = new System.Drawing.Point(69, 100);
            this.lblDestCountry.Name = "lblDestCountry";
            this.lblDestCountry.Size = new System.Drawing.Size(27, 13);
            this.lblDestCountry.TabIndex = 9;
            this.lblDestCountry.Text = "land";
            // 
            // lblDestCity
            // 
            this.lblDestCity.AutoSize = true;
            this.lblDestCity.Location = new System.Drawing.Point(35, 74);
            this.lblDestCity.Name = "lblDestCity";
            this.lblDestCity.Size = new System.Drawing.Size(61, 13);
            this.lblDestCity.TabIndex = 8;
            this.lblDestCity.Text = "woonplaats";
            // 
            // lblDestZipCode
            // 
            this.lblDestZipCode.AutoSize = true;
            this.lblDestZipCode.Location = new System.Drawing.Point(45, 48);
            this.lblDestZipCode.Name = "lblDestZipCode";
            this.lblDestZipCode.Size = new System.Drawing.Size(51, 13);
            this.lblDestZipCode.TabIndex = 7;
            this.lblDestZipCode.Text = "postcode";
            // 
            // lblDestNumber
            // 
            this.lblDestNumber.AutoSize = true;
            this.lblDestNumber.Location = new System.Drawing.Point(251, 22);
            this.lblDestNumber.Name = "lblDestNumber";
            this.lblDestNumber.Size = new System.Drawing.Size(44, 13);
            this.lblDestNumber.TabIndex = 6;
            this.lblDestNumber.Text = "nummer";
            // 
            // lblDestStreet
            // 
            this.lblDestStreet.AutoSize = true;
            this.lblDestStreet.Location = new System.Drawing.Point(63, 22);
            this.lblDestStreet.Name = "lblDestStreet";
            this.lblDestStreet.Size = new System.Drawing.Size(33, 13);
            this.lblDestStreet.TabIndex = 5;
            this.lblDestStreet.Text = "straat";
            // 
            // tbDestCountry
            // 
            this.tbDestCountry.Location = new System.Drawing.Point(102, 97);
            this.tbDestCountry.Name = "tbDestCountry";
            this.tbDestCountry.Size = new System.Drawing.Size(143, 20);
            this.tbDestCountry.TabIndex = 9;
            // 
            // tbDestCity
            // 
            this.tbDestCity.Location = new System.Drawing.Point(102, 71);
            this.tbDestCity.Name = "tbDestCity";
            this.tbDestCity.Size = new System.Drawing.Size(143, 20);
            this.tbDestCity.TabIndex = 8;
            // 
            // tbDestZipCode
            // 
            this.tbDestZipCode.Location = new System.Drawing.Point(102, 45);
            this.tbDestZipCode.Name = "tbDestZipCode";
            this.tbDestZipCode.Size = new System.Drawing.Size(69, 20);
            this.tbDestZipCode.TabIndex = 7;
            // 
            // tbDestNumber
            // 
            this.tbDestNumber.Location = new System.Drawing.Point(301, 19);
            this.tbDestNumber.Name = "tbDestNumber";
            this.tbDestNumber.Size = new System.Drawing.Size(47, 20);
            this.tbDestNumber.TabIndex = 6;
            // 
            // tbDestStreet
            // 
            this.tbDestStreet.Location = new System.Drawing.Point(102, 19);
            this.tbDestStreet.Name = "tbDestStreet";
            this.tbDestStreet.Size = new System.Drawing.Size(143, 20);
            this.tbDestStreet.TabIndex = 5;
            // 
            // gbDepartureAddress
            // 
            this.gbDepartureAddress.Controls.Add(this.lblDepCountry);
            this.gbDepartureAddress.Controls.Add(this.lblDepCity);
            this.gbDepartureAddress.Controls.Add(this.lblDepZipCode);
            this.gbDepartureAddress.Controls.Add(this.lblDepNumber);
            this.gbDepartureAddress.Controls.Add(this.lblDepStreet);
            this.gbDepartureAddress.Controls.Add(this.tbDepCountry);
            this.gbDepartureAddress.Controls.Add(this.tbDepCity);
            this.gbDepartureAddress.Controls.Add(this.tbDepZipCode);
            this.gbDepartureAddress.Controls.Add(this.tbDepNumber);
            this.gbDepartureAddress.Controls.Add(this.tbDepStreet);
            this.gbDepartureAddress.Location = new System.Drawing.Point(19, 19);
            this.gbDepartureAddress.Name = "gbDepartureAddress";
            this.gbDepartureAddress.Size = new System.Drawing.Size(479, 143);
            this.gbDepartureAddress.TabIndex = 0;
            this.gbDepartureAddress.TabStop = false;
            this.gbDepartureAddress.Text = "Van";
            // 
            // lblDepCountry
            // 
            this.lblDepCountry.AutoSize = true;
            this.lblDepCountry.Location = new System.Drawing.Point(69, 100);
            this.lblDepCountry.Name = "lblDepCountry";
            this.lblDepCountry.Size = new System.Drawing.Size(27, 13);
            this.lblDepCountry.TabIndex = 9;
            this.lblDepCountry.Text = "land";
            // 
            // lblDepCity
            // 
            this.lblDepCity.AutoSize = true;
            this.lblDepCity.Location = new System.Drawing.Point(35, 74);
            this.lblDepCity.Name = "lblDepCity";
            this.lblDepCity.Size = new System.Drawing.Size(61, 13);
            this.lblDepCity.TabIndex = 8;
            this.lblDepCity.Text = "woonplaats";
            // 
            // lblDepZipCode
            // 
            this.lblDepZipCode.AutoSize = true;
            this.lblDepZipCode.Location = new System.Drawing.Point(45, 48);
            this.lblDepZipCode.Name = "lblDepZipCode";
            this.lblDepZipCode.Size = new System.Drawing.Size(51, 13);
            this.lblDepZipCode.TabIndex = 7;
            this.lblDepZipCode.Text = "postcode";
            // 
            // lblDepNumber
            // 
            this.lblDepNumber.AutoSize = true;
            this.lblDepNumber.Location = new System.Drawing.Point(251, 22);
            this.lblDepNumber.Name = "lblDepNumber";
            this.lblDepNumber.Size = new System.Drawing.Size(44, 13);
            this.lblDepNumber.TabIndex = 6;
            this.lblDepNumber.Text = "nummer";
            // 
            // lblDepStreet
            // 
            this.lblDepStreet.AutoSize = true;
            this.lblDepStreet.Location = new System.Drawing.Point(63, 22);
            this.lblDepStreet.Name = "lblDepStreet";
            this.lblDepStreet.Size = new System.Drawing.Size(33, 13);
            this.lblDepStreet.TabIndex = 5;
            this.lblDepStreet.Text = "straat";
            // 
            // tbDepCountry
            // 
            this.tbDepCountry.Location = new System.Drawing.Point(102, 97);
            this.tbDepCountry.Name = "tbDepCountry";
            this.tbDepCountry.Size = new System.Drawing.Size(143, 20);
            this.tbDepCountry.TabIndex = 4;
            // 
            // tbDepCity
            // 
            this.tbDepCity.Location = new System.Drawing.Point(102, 71);
            this.tbDepCity.Name = "tbDepCity";
            this.tbDepCity.Size = new System.Drawing.Size(143, 20);
            this.tbDepCity.TabIndex = 3;
            // 
            // tbDepZipCode
            // 
            this.tbDepZipCode.Location = new System.Drawing.Point(102, 45);
            this.tbDepZipCode.Name = "tbDepZipCode";
            this.tbDepZipCode.Size = new System.Drawing.Size(69, 20);
            this.tbDepZipCode.TabIndex = 2;
            // 
            // tbDepNumber
            // 
            this.tbDepNumber.Location = new System.Drawing.Point(301, 19);
            this.tbDepNumber.Name = "tbDepNumber";
            this.tbDepNumber.Size = new System.Drawing.Size(47, 20);
            this.tbDepNumber.TabIndex = 1;
            // 
            // tbDepStreet
            // 
            this.tbDepStreet.Location = new System.Drawing.Point(102, 19);
            this.tbDepStreet.Name = "tbDepStreet";
            this.tbDepStreet.Size = new System.Drawing.Size(143, 20);
            this.tbDepStreet.TabIndex = 0;
            // 
            // tabTaxi
            // 
            this.tabTaxi.Controls.Add(this.tabPage1);
            this.tabTaxi.Controls.Add(this.tabPage2);
            this.tabTaxi.Location = new System.Drawing.Point(6, 11);
            this.tabTaxi.Name = "tabTaxi";
            this.tabTaxi.SelectedIndex = 0;
            this.tabTaxi.Size = new System.Drawing.Size(951, 631);
            this.tabTaxi.TabIndex = 2;
            this.tabTaxi.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // userTokenDataGridViewTextBoxColumn
            // 
            this.userTokenDataGridViewTextBoxColumn.DataPropertyName = "UserToken";
            this.userTokenDataGridViewTextBoxColumn.HeaderText = "UserToken";
            this.userTokenDataGridViewTextBoxColumn.Name = "userTokenDataGridViewTextBoxColumn";
            this.userTokenDataGridViewTextBoxColumn.ReadOnly = true;
            this.userTokenDataGridViewTextBoxColumn.Visible = false;
            // 
            // amountOfPassengersDataGridViewTextBoxColumn
            // 
            this.amountOfPassengersDataGridViewTextBoxColumn.DataPropertyName = "AmountOfPassengers";
            this.amountOfPassengersDataGridViewTextBoxColumn.HeaderText = "Passagiers";
            this.amountOfPassengersDataGridViewTextBoxColumn.Name = "amountOfPassengersDataGridViewTextBoxColumn";
            this.amountOfPassengersDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountOfPassengersDataGridViewTextBoxColumn.Width = 70;
            // 
            // departureAddressDataGridViewTextBoxColumn
            // 
            this.departureAddressDataGridViewTextBoxColumn.DataPropertyName = "DepartureAddress.Street";
            this.departureAddressDataGridViewTextBoxColumn.HeaderText = "Vertrek adres";
            this.departureAddressDataGridViewTextBoxColumn.Name = "departureAddressDataGridViewTextBoxColumn";
            this.departureAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.departureAddressDataGridViewTextBoxColumn.Width = 135;
            // 
            // destinationAddressDataGridViewTextBoxColumn
            // 
            this.destinationAddressDataGridViewTextBoxColumn.DataPropertyName = "DestinationAddress";
            this.destinationAddressDataGridViewTextBoxColumn.HeaderText = "Aankomst adres";
            this.destinationAddressDataGridViewTextBoxColumn.Name = "destinationAddressDataGridViewTextBoxColumn";
            this.destinationAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.destinationAddressDataGridViewTextBoxColumn.Width = 135;
            // 
            // departureTimeDataGridViewTextBoxColumn
            // 
            this.departureTimeDataGridViewTextBoxColumn.DataPropertyName = "DepartureTime";
            this.departureTimeDataGridViewTextBoxColumn.HeaderText = "Vertrek tijd";
            this.departureTimeDataGridViewTextBoxColumn.Name = "departureTimeDataGridViewTextBoxColumn";
            this.departureTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.departureTimeDataGridViewTextBoxColumn.Width = 120;
            // 
            // arrivalTimeDataGridViewTextBoxColumn
            // 
            this.arrivalTimeDataGridViewTextBoxColumn.DataPropertyName = "ArrivalTime";
            this.arrivalTimeDataGridViewTextBoxColumn.HeaderText = "Aankomst tijd";
            this.arrivalTimeDataGridViewTextBoxColumn.Name = "arrivalTimeDataGridViewTextBoxColumn";
            this.arrivalTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.arrivalTimeDataGridViewTextBoxColumn.Width = 120;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Prijs";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 40;
            // 
            // taxiIdDataGridViewTextBoxColumn
            // 
            this.taxiIdDataGridViewTextBoxColumn.DataPropertyName = "TaxiId";
            this.taxiIdDataGridViewTextBoxColumn.HeaderText = "Taxi nr.";
            this.taxiIdDataGridViewTextBoxColumn.Name = "taxiIdDataGridViewTextBoxColumn";
            this.taxiIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.taxiIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // taxiTypeDataGridViewTextBoxColumn
            // 
            this.taxiTypeDataGridViewTextBoxColumn.DataPropertyName = "TaxiType";
            this.taxiTypeDataGridViewTextBoxColumn.HeaderText = "Taxi type";
            this.taxiTypeDataGridViewTextBoxColumn.Name = "taxiTypeDataGridViewTextBoxColumn";
            this.taxiTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TaxiUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabTaxi);
            this.Name = "TaxiUC";
            this.Size = new System.Drawing.Size(970, 645);
            this.Click += new System.EventHandler(this.btnCancelBooking_Click);
            ((System.ComponentModel.ISupportInitialize)(this.taxiBookingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBookingsBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userBookingsDG)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbDestinationAddress.ResumeLayout(false);
            this.gbDestinationAddress.PerformLayout();
            this.gbDepartureAddress.ResumeLayout(false);
            this.gbDepartureAddress.PerformLayout();
            this.tabTaxi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource taxiBookingsBindingSource;
        private System.Windows.Forms.BindingSource userBookingsBindingSource;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCancelBooking;
        private System.Windows.Forms.DataGridView userBookingsDG;
        private System.Windows.Forms.Button btnFindTaxi;
        private System.Windows.Forms.Label lblPassengers;
        private System.Windows.Forms.TextBox tbPassengers;
        private System.Windows.Forms.RadioButton rbArrival;
        private System.Windows.Forms.RadioButton rbDeparture;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.GroupBox gbDestinationAddress;
        private System.Windows.Forms.Label lblDestCountry;
        private System.Windows.Forms.Label lblDestCity;
        private System.Windows.Forms.Label lblDestZipCode;
        private System.Windows.Forms.Label lblDestNumber;
        private System.Windows.Forms.Label lblDestStreet;
        private System.Windows.Forms.TextBox tbDestCountry;
        private System.Windows.Forms.TextBox tbDestCity;
        private System.Windows.Forms.TextBox tbDestZipCode;
        private System.Windows.Forms.TextBox tbDestNumber;
        private System.Windows.Forms.TextBox tbDestStreet;
        private System.Windows.Forms.GroupBox gbDepartureAddress;
        private System.Windows.Forms.Label lblDepCountry;
        private System.Windows.Forms.Label lblDepCity;
        private System.Windows.Forms.Label lblDepZipCode;
        private System.Windows.Forms.Label lblDepNumber;
        private System.Windows.Forms.Label lblDepStreet;
        private System.Windows.Forms.TextBox tbDepCountry;
        private System.Windows.Forms.TextBox tbDepCity;
        private System.Windows.Forms.TextBox tbDepZipCode;
        private System.Windows.Forms.TextBox tbDepNumber;
        private System.Windows.Forms.TextBox tbDepStreet;
        private System.Windows.Forms.TabControl tabTaxi;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTokenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountOfPassengersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxiIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxiTypeDataGridViewTextBoxColumn;
    }
}
