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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbCarInfo = new System.Windows.Forms.GroupBox();
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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbCarInfo.SuspendLayout();
            this.gbSelectCar.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.gbCarInfo);
            this.tabPage1.Controls.Add(this.gbSelectCar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(936, 590);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Boek auto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbCarInfo
            // 
            this.gbCarInfo.Controls.Add(this.lblMaxPersons);
            this.gbCarInfo.Controls.Add(this.lblPricePerDay);
            this.gbCarInfo.Controls.Add(this.lblCarType);
            this.gbCarInfo.Controls.Add(this.lblDateOfPurchase);
            this.gbCarInfo.Controls.Add(this.lblLicense);
            this.gbCarInfo.Controls.Add(this.lblBrand);
            this.gbCarInfo.Controls.Add(this.btnBookCar);
            this.gbCarInfo.Location = new System.Drawing.Point(345, 15);
            this.gbCarInfo.Name = "gbCarInfo";
            this.gbCarInfo.Size = new System.Drawing.Size(585, 286);
            this.gbCarInfo.TabIndex = 4;
            this.gbCarInfo.TabStop = false;
            this.gbCarInfo.Text = "Auto Informatie";
            // 
            // lblMaxPersons
            // 
            this.lblMaxPersons.AutoSize = true;
            this.lblMaxPersons.Location = new System.Drawing.Point(100, 56);
            this.lblMaxPersons.Name = "lblMaxPersons";
            this.lblMaxPersons.Size = new System.Drawing.Size(0, 13);
            this.lblMaxPersons.TabIndex = 9;
            // 
            // lblPricePerDay
            // 
            this.lblPricePerDay.AutoSize = true;
            this.lblPricePerDay.Location = new System.Drawing.Point(100, 95);
            this.lblPricePerDay.Name = "lblPricePerDay";
            this.lblPricePerDay.Size = new System.Drawing.Size(0, 13);
            this.lblPricePerDay.TabIndex = 8;
            // 
            // lblCarType
            // 
            this.lblCarType.AutoSize = true;
            this.lblCarType.Location = new System.Drawing.Point(100, 43);
            this.lblCarType.Name = "lblCarType";
            this.lblCarType.Size = new System.Drawing.Size(0, 13);
            this.lblCarType.TabIndex = 7;
            // 
            // lblDateOfPurchase
            // 
            this.lblDateOfPurchase.AutoSize = true;
            this.lblDateOfPurchase.Location = new System.Drawing.Point(100, 69);
            this.lblDateOfPurchase.Name = "lblDateOfPurchase";
            this.lblDateOfPurchase.Size = new System.Drawing.Size(0, 13);
            this.lblDateOfPurchase.TabIndex = 6;
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.Location = new System.Drawing.Point(100, 82);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(0, 13);
            this.lblLicense.TabIndex = 5;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(100, 30);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(0, 13);
            this.lblBrand.TabIndex = 4;
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
            this.gbSelectCar.Text = "Boek een auto";
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Location = new System.Drawing.Point(66, 103);
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
            this.lblCity.Location = new System.Drawing.Point(66, 49);
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
            this.lblCountry.Location = new System.Drawing.Point(64, 22);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(31, 13);
            this.lblCountry.TabIndex = 0;
            this.lblCountry.Text = "Land";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(936, 590);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Boeking overzicht";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.gbCarInfo.ResumeLayout(false);
            this.gbCarInfo.PerformLayout();
            this.gbSelectCar.ResumeLayout(false);
            this.gbSelectCar.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbCarInfo;
        private System.Windows.Forms.Label lblDateOfPurchase;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblCarType;
        private System.Windows.Forms.Label lblMaxPersons;
        private System.Windows.Forms.Label lblPricePerDay;
    }
}
