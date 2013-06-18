namespace TaxiClient
{
    partial class TaxiForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabTaxi = new System.Windows.Forms.TabControl();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chooseBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotelBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taxiBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabTaxi.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbDestinationAddress.SuspendLayout();
            this.gbDepartureAddress.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTaxi
            // 
            this.tabTaxi.Controls.Add(this.tabPage1);
            this.tabTaxi.Controls.Add(this.tabPage2);
            this.tabTaxi.Location = new System.Drawing.Point(13, 52);
            this.tabTaxi.Name = "tabTaxi";
            this.tabTaxi.SelectedIndex = 0;
            this.tabTaxi.Size = new System.Drawing.Size(497, 465);
            this.tabTaxi.TabIndex = 0;
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
            this.tabPage1.Size = new System.Drawing.Size(489, 439);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Taxi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnFindTaxi
            // 
            this.btnFindTaxi.Location = new System.Drawing.Point(408, 410);
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
            this.lblPassengers.Location = new System.Drawing.Point(39, 358);
            this.lblPassengers.Name = "lblPassengers";
            this.lblPassengers.Size = new System.Drawing.Size(57, 13);
            this.lblPassengers.TabIndex = 18;
            this.lblPassengers.Text = "passagiers";
            // 
            // tbPassengers
            // 
            this.tbPassengers.Location = new System.Drawing.Point(106, 355);
            this.tbPassengers.Name = "tbPassengers";
            this.tbPassengers.Size = new System.Drawing.Size(46, 20);
            this.tbPassengers.TabIndex = 19;
            // 
            // rbArrival
            // 
            this.rbArrival.AutoSize = true;
            this.rbArrival.Location = new System.Drawing.Point(171, 332);
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
            this.rbDeparture.Location = new System.Drawing.Point(106, 332);
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
            this.dtpTime.Location = new System.Drawing.Point(305, 305);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(57, 20);
            this.dtpTime.TabIndex = 14;
            this.dtpTime.Value = new System.DateTime(2013, 6, 11, 14, 27, 39, 0);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(284, 306);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(20, 13);
            this.lblTime.TabIndex = 13;
            this.lblTime.Text = "tijd";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(64, 306);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "datum";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(106, 305);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(172, 20);
            this.dtpDate.TabIndex = 11;
            this.dtpDate.Value = new System.DateTime(2013, 6, 11, 14, 26, 29, 0);
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
            this.gbDestinationAddress.Location = new System.Drawing.Point(4, 156);
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
            this.gbDepartureAddress.Location = new System.Drawing.Point(4, 7);
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(489, 439);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "...";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseBookingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(522, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chooseBookingToolStripMenuItem
            // 
            this.chooseBookingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flightBookingToolStripMenuItem,
            this.hotelBookingToolStripMenuItem,
            this.taxiBookingToolStripMenuItem});
            this.chooseBookingToolStripMenuItem.Name = "chooseBookingToolStripMenuItem";
            this.chooseBookingToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.chooseBookingToolStripMenuItem.Text = "Kiez Boeking";
            // 
            // flightBookingToolStripMenuItem
            // 
            this.flightBookingToolStripMenuItem.Name = "flightBookingToolStripMenuItem";
            this.flightBookingToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.flightBookingToolStripMenuItem.Text = "Vlucht Boeking";
            this.flightBookingToolStripMenuItem.Click += new System.EventHandler(this.flightBookingToolStripMenuItem_Click);
            // 
            // hotelBookingToolStripMenuItem
            // 
            this.hotelBookingToolStripMenuItem.Name = "hotelBookingToolStripMenuItem";
            this.hotelBookingToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.hotelBookingToolStripMenuItem.Text = "Hotel Boeking";
            this.hotelBookingToolStripMenuItem.Click += new System.EventHandler(this.hotelBookingToolStripMenuItem_Click);
            // 
            // taxiBookingToolStripMenuItem
            // 
            this.taxiBookingToolStripMenuItem.Name = "taxiBookingToolStripMenuItem";
            this.taxiBookingToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.taxiBookingToolStripMenuItem.Text = "Taxi Boeking";
            this.taxiBookingToolStripMenuItem.Click += new System.EventHandler(this.taxiBookingToolStripMenuItem_Click);
            // 
            // TaxiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 529);
            this.Controls.Add(this.tabTaxi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TaxiForm";
            this.Text = "Taxi";
            this.tabTaxi.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbDestinationAddress.ResumeLayout(false);
            this.gbDestinationAddress.PerformLayout();
            this.gbDepartureAddress.ResumeLayout(false);
            this.gbDepartureAddress.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabTaxi;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gbDepartureAddress;
        private System.Windows.Forms.Label lblDepStreet;
        private System.Windows.Forms.TextBox tbDepCountry;
        private System.Windows.Forms.TextBox tbDepCity;
        private System.Windows.Forms.TextBox tbDepZipCode;
        private System.Windows.Forms.TextBox tbDepNumber;
        private System.Windows.Forms.TextBox tbDepStreet;
        private System.Windows.Forms.TabPage tabPage2;
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
        private System.Windows.Forms.Label lblDepCountry;
        private System.Windows.Forms.Label lblDepCity;
        private System.Windows.Forms.Label lblDepZipCode;
        private System.Windows.Forms.Label lblDepNumber;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnFindTaxi;
        private System.Windows.Forms.Label lblPassengers;
        private System.Windows.Forms.TextBox tbPassengers;
        private System.Windows.Forms.RadioButton rbArrival;
        private System.Windows.Forms.RadioButton rbDeparture;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chooseBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flightBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotelBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taxiBookingToolStripMenuItem;
    }
}