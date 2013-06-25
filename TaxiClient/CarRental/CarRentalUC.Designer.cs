namespace TaxiClient.CarRental
{
    partial class CarRentalUC
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbRentCar = new System.Windows.Forms.GroupBox();
            this.lblEndDay = new System.Windows.Forms.Label();
            this.lblStartDay = new System.Windows.Forms.Label();
            this.dtpEndDay = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDay = new System.Windows.Forms.DateTimePicker();
            this.lblPricePerDay_data = new System.Windows.Forms.Label();
            this.lblLicense_data = new System.Windows.Forms.Label();
            this.lblBrand_data = new System.Windows.Forms.Label();
            this.lblCarType_data = new System.Windows.Forms.Label();
            this.lblMaxPersons_data = new System.Windows.Forms.Label();
            this.lblDateOfPurchase_data = new System.Windows.Forms.Label();
            this.lblMaxPersons = new System.Windows.Forms.Label();
            this.lblPricePerDay = new System.Windows.Forms.Label();
            this.lblCarType = new System.Windows.Forms.Label();
            this.lblDateOfPurchase = new System.Windows.Forms.Label();
            this.lblLicense = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.btnBookCar = new System.Windows.Forms.Button();
            this.gbSelectCar = new System.Windows.Forms.GroupBox();
            this.lblCar = new System.Windows.Forms.Label();
            this.cbCar = new System.Windows.Forms.ComboBox();
            this.lblDealer = new System.Windows.Forms.Label();
            this.cbDealer = new System.Windows.Forms.ComboBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.userBookingsDG = new System.Windows.Forms.DataGridView();
            this.carBookingIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carBookingContractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carContractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbRentCar.SuspendLayout();
            this.gbSelectCar.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBookingsDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBookingContractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carContractBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ItemSize = new System.Drawing.Size(70, 18);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(944, 616);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbRentCar);
            this.tabPage1.Controls.Add(this.gbSelectCar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(936, 590);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Boek auto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbRentCar
            // 
            this.gbRentCar.Controls.Add(this.lblEndDay);
            this.gbRentCar.Controls.Add(this.lblStartDay);
            this.gbRentCar.Controls.Add(this.dtpEndDay);
            this.gbRentCar.Controls.Add(this.dtpStartDay);
            this.gbRentCar.Controls.Add(this.lblPricePerDay_data);
            this.gbRentCar.Controls.Add(this.lblLicense_data);
            this.gbRentCar.Controls.Add(this.lblBrand_data);
            this.gbRentCar.Controls.Add(this.lblCarType_data);
            this.gbRentCar.Controls.Add(this.lblMaxPersons_data);
            this.gbRentCar.Controls.Add(this.lblDateOfPurchase_data);
            this.gbRentCar.Controls.Add(this.lblMaxPersons);
            this.gbRentCar.Controls.Add(this.lblPricePerDay);
            this.gbRentCar.Controls.Add(this.lblCarType);
            this.gbRentCar.Controls.Add(this.lblDateOfPurchase);
            this.gbRentCar.Controls.Add(this.lblLicense);
            this.gbRentCar.Controls.Add(this.lblBrand);
            this.gbRentCar.Controls.Add(this.btnBookCar);
            this.gbRentCar.Location = new System.Drawing.Point(345, 15);
            this.gbRentCar.Name = "gbRentCar";
            this.gbRentCar.Size = new System.Drawing.Size(585, 286);
            this.gbRentCar.TabIndex = 4;
            this.gbRentCar.TabStop = false;
            this.gbRentCar.Text = "Auto boeken";
            // 
            // lblEndDay
            // 
            this.lblEndDay.AutoSize = true;
            this.lblEndDay.Enabled = false;
            this.lblEndDay.Location = new System.Drawing.Point(57, 162);
            this.lblEndDay.Name = "lblEndDay";
            this.lblEndDay.Size = new System.Drawing.Size(52, 13);
            this.lblEndDay.TabIndex = 19;
            this.lblEndDay.Text = "Eind dag:";
            // 
            // lblStartDay
            // 
            this.lblStartDay.AutoSize = true;
            this.lblStartDay.Enabled = false;
            this.lblStartDay.Location = new System.Drawing.Point(57, 136);
            this.lblStartDay.Name = "lblStartDay";
            this.lblStartDay.Size = new System.Drawing.Size(53, 13);
            this.lblStartDay.TabIndex = 18;
            this.lblStartDay.Text = "Start dag:";
            // 
            // dtpEndDay
            // 
            this.dtpEndDay.Enabled = false;
            this.dtpEndDay.Location = new System.Drawing.Point(115, 162);
            this.dtpEndDay.Name = "dtpEndDay";
            this.dtpEndDay.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDay.TabIndex = 17;
            this.dtpEndDay.Value = new System.DateTime(2013, 6, 25, 0, 0, 0, 0);
            // 
            // dtpStartDay
            // 
            this.dtpStartDay.Enabled = false;
            this.dtpStartDay.Location = new System.Drawing.Point(116, 136);
            this.dtpStartDay.Name = "dtpStartDay";
            this.dtpStartDay.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDay.TabIndex = 16;
            this.dtpStartDay.Value = new System.DateTime(2013, 6, 25, 23, 59, 59, 0);
            // 
            // lblPricePerDay_data
            // 
            this.lblPricePerDay_data.AutoSize = true;
            this.lblPricePerDay_data.Location = new System.Drawing.Point(159, 96);
            this.lblPricePerDay_data.Name = "lblPricePerDay_data";
            this.lblPricePerDay_data.Size = new System.Drawing.Size(0, 13);
            this.lblPricePerDay_data.TabIndex = 15;
            // 
            // lblLicense_data
            // 
            this.lblLicense_data.AutoSize = true;
            this.lblLicense_data.Location = new System.Drawing.Point(159, 83);
            this.lblLicense_data.Name = "lblLicense_data";
            this.lblLicense_data.Size = new System.Drawing.Size(0, 13);
            this.lblLicense_data.TabIndex = 14;
            // 
            // lblBrand_data
            // 
            this.lblBrand_data.AutoSize = true;
            this.lblBrand_data.Location = new System.Drawing.Point(159, 31);
            this.lblBrand_data.Name = "lblBrand_data";
            this.lblBrand_data.Size = new System.Drawing.Size(0, 13);
            this.lblBrand_data.TabIndex = 13;
            // 
            // lblCarType_data
            // 
            this.lblCarType_data.AutoSize = true;
            this.lblCarType_data.Location = new System.Drawing.Point(159, 44);
            this.lblCarType_data.Name = "lblCarType_data";
            this.lblCarType_data.Size = new System.Drawing.Size(0, 13);
            this.lblCarType_data.TabIndex = 12;
            // 
            // lblMaxPersons_data
            // 
            this.lblMaxPersons_data.AutoSize = true;
            this.lblMaxPersons_data.Location = new System.Drawing.Point(159, 57);
            this.lblMaxPersons_data.Name = "lblMaxPersons_data";
            this.lblMaxPersons_data.Size = new System.Drawing.Size(0, 13);
            this.lblMaxPersons_data.TabIndex = 11;
            // 
            // lblDateOfPurchase_data
            // 
            this.lblDateOfPurchase_data.AutoSize = true;
            this.lblDateOfPurchase_data.Location = new System.Drawing.Point(159, 70);
            this.lblDateOfPurchase_data.Name = "lblDateOfPurchase_data";
            this.lblDateOfPurchase_data.Size = new System.Drawing.Size(0, 13);
            this.lblDateOfPurchase_data.TabIndex = 10;
            // 
            // lblMaxPersons
            // 
            this.lblMaxPersons.AutoSize = true;
            this.lblMaxPersons.Enabled = false;
            this.lblMaxPersons.Location = new System.Drawing.Point(57, 57);
            this.lblMaxPersons.Name = "lblMaxPersons";
            this.lblMaxPersons.Size = new System.Drawing.Size(50, 13);
            this.lblMaxPersons.TabIndex = 9;
            this.lblMaxPersons.Text = "Zitruimte:";
            // 
            // lblPricePerDay
            // 
            this.lblPricePerDay.AutoSize = true;
            this.lblPricePerDay.Enabled = false;
            this.lblPricePerDay.Location = new System.Drawing.Point(57, 96);
            this.lblPricePerDay.Name = "lblPricePerDay";
            this.lblPricePerDay.Size = new System.Drawing.Size(68, 13);
            this.lblPricePerDay.TabIndex = 8;
            this.lblPricePerDay.Text = "Prijs per dag:";
            // 
            // lblCarType
            // 
            this.lblCarType.AutoSize = true;
            this.lblCarType.Enabled = false;
            this.lblCarType.Location = new System.Drawing.Point(57, 44);
            this.lblCarType.Name = "lblCarType";
            this.lblCarType.Size = new System.Drawing.Size(55, 13);
            this.lblCarType.TabIndex = 7;
            this.lblCarType.Text = "Auto type:";
            // 
            // lblDateOfPurchase
            // 
            this.lblDateOfPurchase.AutoSize = true;
            this.lblDateOfPurchase.Enabled = false;
            this.lblDateOfPurchase.Location = new System.Drawing.Point(57, 70);
            this.lblDateOfPurchase.Name = "lblDateOfPurchase";
            this.lblDateOfPurchase.Size = new System.Drawing.Size(96, 13);
            this.lblDateOfPurchase.TabIndex = 6;
            this.lblDateOfPurchase.Text = "Dag van aankoop:";
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.Enabled = false;
            this.lblLicense.Location = new System.Drawing.Point(57, 83);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(56, 13);
            this.lblLicense.TabIndex = 5;
            this.lblLicense.Text = "Kenteken:";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Enabled = false;
            this.lblBrand.Location = new System.Drawing.Point(57, 31);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(32, 13);
            this.lblBrand.TabIndex = 4;
            this.lblBrand.Text = "Auto:";
            // 
            // btnBookCar
            // 
            this.btnBookCar.Enabled = false;
            this.btnBookCar.Location = new System.Drawing.Point(504, 257);
            this.btnBookCar.Name = "btnBookCar";
            this.btnBookCar.Size = new System.Drawing.Size(75, 23);
            this.btnBookCar.TabIndex = 3;
            this.btnBookCar.Text = "Boek auto";
            this.btnBookCar.UseVisualStyleBackColor = true;
            this.btnBookCar.Click += new System.EventHandler(this.btnBookCar_Click);
            // 
            // gbSelectCar
            // 
            this.gbSelectCar.Controls.Add(this.lblCar);
            this.gbSelectCar.Controls.Add(this.cbCar);
            this.gbSelectCar.Controls.Add(this.lblDealer);
            this.gbSelectCar.Controls.Add(this.cbDealer);
            this.gbSelectCar.Controls.Add(this.lblCity);
            this.gbSelectCar.Controls.Add(this.cbCity);
            this.gbSelectCar.Controls.Add(this.cbCountry);
            this.gbSelectCar.Controls.Add(this.lblCountry);
            this.gbSelectCar.Location = new System.Drawing.Point(15, 15);
            this.gbSelectCar.Name = "gbSelectCar";
            this.gbSelectCar.Size = new System.Drawing.Size(324, 286);
            this.gbSelectCar.TabIndex = 2;
            this.gbSelectCar.TabStop = false;
            this.gbSelectCar.Text = "Selecteer een auto";
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Location = new System.Drawing.Point(57, 103);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(29, 13);
            this.lblCar.TabIndex = 6;
            this.lblCar.Text = "Auto";
            // 
            // cbCar
            // 
            this.cbCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCar.Location = new System.Drawing.Point(101, 100);
            this.cbCar.Name = "cbCar";
            this.cbCar.Size = new System.Drawing.Size(121, 21);
            this.cbCar.TabIndex = 5;
            this.cbCar.SelectedIndexChanged += new System.EventHandler(this.cbCar_SelectedIndexChanged);
            // 
            // lblDealer
            // 
            this.lblDealer.AutoSize = true;
            this.lblDealer.Location = new System.Drawing.Point(57, 76);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(38, 13);
            this.lblDealer.TabIndex = 4;
            this.lblDealer.Text = "Dealer";
            // 
            // cbDealer
            // 
            this.cbDealer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDealer.Location = new System.Drawing.Point(101, 73);
            this.cbDealer.Name = "cbDealer";
            this.cbDealer.Size = new System.Drawing.Size(121, 21);
            this.cbDealer.TabIndex = 3;
            this.cbDealer.SelectedIndexChanged += new System.EventHandler(this.cbDealer_SelectedIndexChanged);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(57, 49);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(29, 13);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "Stad";
            // 
            // cbCity
            // 
            this.cbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCity.Location = new System.Drawing.Point(101, 46);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(121, 21);
            this.cbCity.TabIndex = 1;
            this.cbCity.SelectedIndexChanged += new System.EventHandler(this.cbCity_SelectedIndexChanged);
            // 
            // cbCountry
            // 
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.Location = new System.Drawing.Point(101, 19);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(121, 21);
            this.cbCountry.TabIndex = 0;
            this.cbCountry.SelectedIndexChanged += new System.EventHandler(this.cbCountry_SelectedIndexChanged);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(57, 22);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(31, 13);
            this.lblCountry.TabIndex = 0;
            this.lblCountry.Text = "Land";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCancelBooking);
            this.tabPage2.Controls.Add(this.userBookingsDG);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(936, 590);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Boeking overzicht";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.Location = new System.Drawing.Point(660, 404);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(106, 23);
            this.btnCancelBooking.TabIndex = 2;
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
            this.carBookingIdDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.priceDataGridViewTextBoxColumn});
            this.userBookingsDG.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.carContractBindingSource, "Brand", true));
            this.userBookingsDG.DataSource = this.carBookingContractBindingSource;
            this.userBookingsDG.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.userBookingsDG.Location = new System.Drawing.Point(6, 6);
            this.userBookingsDG.MultiSelect = false;
            this.userBookingsDG.Name = "userBookingsDG";
            this.userBookingsDG.ReadOnly = true;
            this.userBookingsDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userBookingsDG.Size = new System.Drawing.Size(760, 392);
            this.userBookingsDG.TabIndex = 1;
            this.userBookingsDG.VirtualMode = true;
            // 
            // carBookingIdDataGridViewTextBoxColumn
            // 
            this.carBookingIdDataGridViewTextBoxColumn.DataPropertyName = "CarBookingId";
            this.carBookingIdDataGridViewTextBoxColumn.HeaderText = "Nr";
            this.carBookingIdDataGridViewTextBoxColumn.Name = "carBookingIdDataGridViewTextBoxColumn";
            this.carBookingIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Car";
            this.dataGridViewTextBoxColumn1.HeaderText = "Auto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 140;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "StartDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "Start dag";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 180;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EndDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "Eind dag";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 180;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Prijs";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 118;
            // 
            // carBookingContractBindingSource
            // 
            this.carBookingContractBindingSource.DataSource = typeof(TaxiClient.CarRentalService.CarBookingContract);
            // 
            // carContractBindingSource
            // 
            this.carContractBindingSource.DataSource = typeof(TaxiClient.CarRentalService.CarContract);
            // 
            // CarRentalUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "CarRentalUC";
            this.Size = new System.Drawing.Size(970, 645);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbRentCar.ResumeLayout(false);
            this.gbRentCar.PerformLayout();
            this.gbSelectCar.ResumeLayout(false);
            this.gbSelectCar.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userBookingsDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBookingContractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carContractBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbSelectCar;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.ComboBox cbCar;
        private System.Windows.Forms.Label lblDealer;
        private System.Windows.Forms.ComboBox cbDealer;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Button btnBookCar;
        private System.Windows.Forms.GroupBox gbRentCar;
        private System.Windows.Forms.Label lblDateOfPurchase;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblCarType;
        private System.Windows.Forms.Label lblMaxPersons;
        private System.Windows.Forms.Label lblPricePerDay;
        private System.Windows.Forms.Label lblPricePerDay_data;
        private System.Windows.Forms.Label lblLicense_data;
        private System.Windows.Forms.Label lblBrand_data;
        private System.Windows.Forms.Label lblCarType_data;
        private System.Windows.Forms.Label lblMaxPersons_data;
        private System.Windows.Forms.Label lblDateOfPurchase_data;
        private System.Windows.Forms.Label lblEndDay;
        private System.Windows.Forms.Label lblStartDay;
        private System.Windows.Forms.DateTimePicker dtpEndDay;
        private System.Windows.Forms.DateTimePicker dtpStartDay;
        private System.Windows.Forms.DataGridView userBookingsDG;
        private System.Windows.Forms.Button btnCancelBooking;
        private System.Windows.Forms.BindingSource carBookingContractBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn carBookingIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource carContractBindingSource;
    }
}
