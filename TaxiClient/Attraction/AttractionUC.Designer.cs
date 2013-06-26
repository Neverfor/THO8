namespace TaxiClient.Attraction
{
    partial class AttractionUC
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbBookTickets = new System.Windows.Forms.GroupBox();
            this.btnBookTickets = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.gbSearchAttraction = new System.Windows.Forms.GroupBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.linkWebsite = new System.Windows.Forms.LinkLabel();
            this.lblAddress_data = new System.Windows.Forms.Label();
            this.lblWebsite = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.dgAttractions = new System.Windows.Forms.DataGridView();
            this.attractionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attractieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblAttractionType = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.cbAttractionType = new System.Windows.Forms.ComboBox();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbTicketType = new System.Windows.Forms.ComboBox();
            this.rtbTicketTypes = new System.Windows.Forms.RichTextBox();
            this.nudTypeAmount = new System.Windows.Forms.NumericUpDown();
            this.btnChoose = new System.Windows.Forms.Button();
            this.lblTicketType = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbBookTickets.SuspendLayout();
            this.gbSearchAttraction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAttractions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attractieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTypeAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(4, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(963, 638);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbBookTickets);
            this.tabPage1.Controls.Add(this.gbSearchAttraction);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(955, 612);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Boek attractie";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbBookTickets
            // 
            this.gbBookTickets.Controls.Add(this.lblTicketType);
            this.gbBookTickets.Controls.Add(this.btnChoose);
            this.gbBookTickets.Controls.Add(this.nudTypeAmount);
            this.gbBookTickets.Controls.Add(this.rtbTicketTypes);
            this.gbBookTickets.Controls.Add(this.cbTicketType);
            this.gbBookTickets.Controls.Add(this.btnBookTickets);
            this.gbBookTickets.Controls.Add(this.lblDate);
            this.gbBookTickets.Controls.Add(this.dtpDate);
            this.gbBookTickets.Location = new System.Drawing.Point(15, 329);
            this.gbBookTickets.Name = "gbBookTickets";
            this.gbBookTickets.Size = new System.Drawing.Size(921, 268);
            this.gbBookTickets.TabIndex = 1;
            this.gbBookTickets.TabStop = false;
            this.gbBookTickets.Text = "Boek tickets";
            // 
            // btnBookTickets
            // 
            this.btnBookTickets.Enabled = false;
            this.btnBookTickets.Location = new System.Drawing.Point(733, 223);
            this.btnBookTickets.Name = "btnBookTickets";
            this.btnBookTickets.Size = new System.Drawing.Size(75, 23);
            this.btnBookTickets.TabIndex = 27;
            this.btnBookTickets.Text = "Boek";
            this.btnBookTickets.UseVisualStyleBackColor = true;
            this.btnBookTickets.Click += new System.EventHandler(this.btnBookTickets_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Enabled = false;
            this.lblDate.Location = new System.Drawing.Point(52, 33);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 13);
            this.lblDate.TabIndex = 19;
            this.lblDate.Text = "Datum";
            // 
            // dtpDate
            // 
            this.dtpDate.Enabled = false;
            this.dtpDate.Location = new System.Drawing.Point(107, 30);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 0;
            // 
            // gbSearchAttraction
            // 
            this.gbSearchAttraction.Controls.Add(this.rtbDescription);
            this.gbSearchAttraction.Controls.Add(this.linkWebsite);
            this.gbSearchAttraction.Controls.Add(this.lblAddress_data);
            this.gbSearchAttraction.Controls.Add(this.lblWebsite);
            this.gbSearchAttraction.Controls.Add(this.lblAddress);
            this.gbSearchAttraction.Controls.Add(this.lblDescription);
            this.gbSearchAttraction.Controls.Add(this.dgAttractions);
            this.gbSearchAttraction.Controls.Add(this.lblAttractionType);
            this.gbSearchAttraction.Controls.Add(this.lblCity);
            this.gbSearchAttraction.Controls.Add(this.lblRegion);
            this.gbSearchAttraction.Controls.Add(this.cbAttractionType);
            this.gbSearchAttraction.Controls.Add(this.cbCity);
            this.gbSearchAttraction.Controls.Add(this.cbRegion);
            this.gbSearchAttraction.Controls.Add(this.cbCountry);
            this.gbSearchAttraction.Controls.Add(this.lblCountry);
            this.gbSearchAttraction.Location = new System.Drawing.Point(15, 15);
            this.gbSearchAttraction.Name = "gbSearchAttraction";
            this.gbSearchAttraction.Size = new System.Drawing.Size(921, 307);
            this.gbSearchAttraction.TabIndex = 0;
            this.gbSearchAttraction.TabStop = false;
            this.gbSearchAttraction.Text = "Zoek attractie";
            // 
            // rtbDescription
            // 
            this.rtbDescription.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDescription.Location = new System.Drawing.Point(512, 133);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ReadOnly = true;
            this.rtbDescription.Size = new System.Drawing.Size(296, 119);
            this.rtbDescription.TabIndex = 18;
            this.rtbDescription.Text = "";
            // 
            // linkWebsite
            // 
            this.linkWebsite.AutoSize = true;
            this.linkWebsite.Location = new System.Drawing.Point(509, 268);
            this.linkWebsite.Name = "linkWebsite";
            this.linkWebsite.Size = new System.Drawing.Size(0, 13);
            this.linkWebsite.TabIndex = 17;
            // 
            // lblAddress_data
            // 
            this.lblAddress_data.AutoSize = true;
            this.lblAddress_data.Location = new System.Drawing.Point(509, 255);
            this.lblAddress_data.Name = "lblAddress_data";
            this.lblAddress_data.Size = new System.Drawing.Size(0, 13);
            this.lblAddress_data.TabIndex = 15;
            // 
            // lblWebsite
            // 
            this.lblWebsite.AutoSize = true;
            this.lblWebsite.Location = new System.Drawing.Point(436, 268);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(49, 13);
            this.lblWebsite.TabIndex = 13;
            this.lblWebsite.Text = "Website:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(436, 255);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(37, 13);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Adres:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(436, 133);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(70, 13);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Omschrijving:";
            // 
            // dgAttractions
            // 
            this.dgAttractions.AllowUserToAddRows = false;
            this.dgAttractions.AllowUserToDeleteRows = false;
            this.dgAttractions.AllowUserToResizeColumns = false;
            this.dgAttractions.AllowUserToResizeRows = false;
            this.dgAttractions.AutoGenerateColumns = false;
            this.dgAttractions.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgAttractions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgAttractions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAttractions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attractionIDDataGridViewTextBoxColumn,
            this.naamDataGridViewTextBoxColumn});
            this.dgAttractions.DataSource = this.attractieBindingSource;
            this.dgAttractions.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgAttractions.Location = new System.Drawing.Point(107, 112);
            this.dgAttractions.MultiSelect = false;
            this.dgAttractions.Name = "dgAttractions";
            this.dgAttractions.ReadOnly = true;
            this.dgAttractions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAttractions.Size = new System.Drawing.Size(323, 169);
            this.dgAttractions.TabIndex = 8;
            this.dgAttractions.VirtualMode = true;
            this.dgAttractions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAttractions_SelectionChanged);
            // 
            // attractionIDDataGridViewTextBoxColumn
            // 
            this.attractionIDDataGridViewTextBoxColumn.DataPropertyName = "attractionID";
            this.attractionIDDataGridViewTextBoxColumn.HeaderText = "Nr";
            this.attractionIDDataGridViewTextBoxColumn.Name = "attractionIDDataGridViewTextBoxColumn";
            this.attractionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.attractionIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // naamDataGridViewTextBoxColumn
            // 
            this.naamDataGridViewTextBoxColumn.DataPropertyName = "naam";
            this.naamDataGridViewTextBoxColumn.HeaderText = "Naam";
            this.naamDataGridViewTextBoxColumn.Name = "naamDataGridViewTextBoxColumn";
            this.naamDataGridViewTextBoxColumn.ReadOnly = true;
            this.naamDataGridViewTextBoxColumn.Width = 232;
            // 
            // attractieBindingSource
            // 
            this.attractieBindingSource.DataSource = typeof(TaxiClient.AttractionService.attractie);
            // 
            // lblAttractionType
            // 
            this.lblAttractionType.AutoSize = true;
            this.lblAttractionType.Location = new System.Drawing.Point(234, 88);
            this.lblAttractionType.Name = "lblAttractionType";
            this.lblAttractionType.Size = new System.Drawing.Size(69, 13);
            this.lblAttractionType.TabIndex = 7;
            this.lblAttractionType.Text = "Attractie type";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(66, 88);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(29, 13);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "Stad";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(66, 61);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(35, 13);
            this.lblRegion.TabIndex = 5;
            this.lblRegion.Text = "Regio";
            // 
            // cbAttractionType
            // 
            this.cbAttractionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAttractionType.FormattingEnabled = true;
            this.cbAttractionType.Location = new System.Drawing.Point(309, 85);
            this.cbAttractionType.Name = "cbAttractionType";
            this.cbAttractionType.Size = new System.Drawing.Size(121, 21);
            this.cbAttractionType.TabIndex = 4;
            this.cbAttractionType.SelectedIndexChanged += new System.EventHandler(this.cbAttractionType_SelectedIndexChanged);
            // 
            // cbCity
            // 
            this.cbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(107, 85);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(121, 21);
            this.cbCity.TabIndex = 3;
            this.cbCity.SelectedIndexChanged += new System.EventHandler(this.cbCity_SelectedIndexChanged);
            // 
            // cbRegion
            // 
            this.cbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Location = new System.Drawing.Point(107, 58);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(121, 21);
            this.cbRegion.TabIndex = 2;
            this.cbRegion.SelectedIndexChanged += new System.EventHandler(this.cbRegion_SelectedIndexChanged);
            // 
            // cbCountry
            // 
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(107, 31);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(121, 21);
            this.cbCountry.TabIndex = 1;
            this.cbCountry.SelectedIndexChanged += new System.EventHandler(this.cbCountry_SelectedIndexChanged);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(66, 34);
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
            this.tabPage2.Size = new System.Drawing.Size(955, 612);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Boeking overzicht";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbTicketType
            // 
            this.cbTicketType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTicketType.FormattingEnabled = true;
            this.cbTicketType.Location = new System.Drawing.Point(107, 56);
            this.cbTicketType.Name = "cbTicketType";
            this.cbTicketType.Size = new System.Drawing.Size(200, 21);
            this.cbTicketType.TabIndex = 19;
            this.cbTicketType.SelectedIndexChanged += new System.EventHandler(this.cbTicketType_SelectedIndexChanged);
            // 
            // rtbTicketTypes
            // 
            this.rtbTicketTypes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtbTicketTypes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbTicketTypes.Location = new System.Drawing.Point(107, 83);
            this.rtbTicketTypes.Name = "rtbTicketTypes";
            this.rtbTicketTypes.ReadOnly = true;
            this.rtbTicketTypes.Size = new System.Drawing.Size(323, 163);
            this.rtbTicketTypes.TabIndex = 19;
            this.rtbTicketTypes.Text = "";
            // 
            // nudTypeAmount
            // 
            this.nudTypeAmount.Enabled = false;
            this.nudTypeAmount.Location = new System.Drawing.Point(313, 56);
            this.nudTypeAmount.Name = "nudTypeAmount";
            this.nudTypeAmount.Size = new System.Drawing.Size(50, 20);
            this.nudTypeAmount.TabIndex = 28;
            // 
            // btnChoose
            // 
            this.btnChoose.Enabled = false;
            this.btnChoose.Location = new System.Drawing.Point(369, 53);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(61, 23);
            this.btnChoose.TabIndex = 29;
            this.btnChoose.Text = "Kies";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // lblTicketType
            // 
            this.lblTicketType.AutoSize = true;
            this.lblTicketType.Enabled = false;
            this.lblTicketType.Location = new System.Drawing.Point(52, 59);
            this.lblTicketType.Name = "lblTicketType";
            this.lblTicketType.Size = new System.Drawing.Size(31, 13);
            this.lblTicketType.TabIndex = 30;
            this.lblTicketType.Text = "Type";
            // 
            // AttractionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl);
            this.Name = "AttractionUC";
            this.Size = new System.Drawing.Size(970, 645);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbBookTickets.ResumeLayout(false);
            this.gbBookTickets.PerformLayout();
            this.gbSearchAttraction.ResumeLayout(false);
            this.gbSearchAttraction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAttractions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attractieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTypeAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbSearchAttraction;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Label lblAttractionType;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.ComboBox cbAttractionType;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.DataGridView dgAttractions;
        private System.Windows.Forms.BindingSource attractieBindingSource;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.LinkLabel linkWebsite;
        private System.Windows.Forms.Label lblAddress_data;
        private System.Windows.Forms.Label lblWebsite;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn attractionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naamDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gbBookTickets;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnBookTickets;
        private System.Windows.Forms.Label lblTicketType;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.NumericUpDown nudTypeAmount;
        private System.Windows.Forms.RichTextBox rtbTicketTypes;
        private System.Windows.Forms.ComboBox cbTicketType;
    }
}
