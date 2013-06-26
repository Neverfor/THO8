namespace TaxiClient.Flight
{
    partial class FlightUC
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
            this.babiesNB = new System.Windows.Forms.NumericUpDown();
            this.childrenNB = new System.Windows.Forms.NumericUpDown();
            this.adultsNB = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.KlasseCombo = new System.Windows.Forms.ComboBox();
            this.departureDate = new System.Windows.Forms.DateTimePicker();
            this.destinationAirportNameTB = new System.Windows.Forms.TextBox();
            this.departureAirportNameTB = new System.Windows.Forms.TextBox();
            this.vluchtTypeCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ZoekButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.babiesNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adultsNB)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(948, 616);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.babiesNB);
            this.tabPage1.Controls.Add(this.childrenNB);
            this.tabPage1.Controls.Add(this.adultsNB);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.KlasseCombo);
            this.tabPage1.Controls.Add(this.departureDate);
            this.tabPage1.Controls.Add(this.destinationAirportNameTB);
            this.tabPage1.Controls.Add(this.departureAirportNameTB);
            this.tabPage1.Controls.Add(this.vluchtTypeCombo);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.ZoekButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(940, 590);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Zoek Vlucht";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // babiesNB
            // 
            this.babiesNB.Location = new System.Drawing.Point(148, 200);
            this.babiesNB.Name = "babiesNB";
            this.babiesNB.Size = new System.Drawing.Size(29, 20);
            this.babiesNB.TabIndex = 18;
            // 
            // childrenNB
            // 
            this.childrenNB.Location = new System.Drawing.Point(148, 174);
            this.childrenNB.Name = "childrenNB";
            this.childrenNB.Size = new System.Drawing.Size(29, 20);
            this.childrenNB.TabIndex = 17;
            // 
            // adultsNB
            // 
            this.adultsNB.Location = new System.Drawing.Point(148, 148);
            this.adultsNB.Name = "adultsNB";
            this.adultsNB.Size = new System.Drawing.Size(29, 20);
            this.adultsNB.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Babies";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Kinderen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Volwassenen";
            // 
            // KlasseCombo
            // 
            this.KlasseCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KlasseCombo.FormattingEnabled = true;
            this.KlasseCombo.Items.AddRange(new object[] {
            "Economy",
            "Business"});
            this.KlasseCombo.Location = new System.Drawing.Point(148, 230);
            this.KlasseCombo.Name = "KlasseCombo";
            this.KlasseCombo.Size = new System.Drawing.Size(121, 21);
            this.KlasseCombo.TabIndex = 12;
            // 
            // departureDate
            // 
            this.departureDate.Location = new System.Drawing.Point(148, 103);
            this.departureDate.Name = "departureDate";
            this.departureDate.Size = new System.Drawing.Size(121, 20);
            this.departureDate.TabIndex = 10;
            // 
            // destinationAirportNameTB
            // 
            this.destinationAirportNameTB.Location = new System.Drawing.Point(148, 49);
            this.destinationAirportNameTB.Name = "destinationAirportNameTB";
            this.destinationAirportNameTB.Size = new System.Drawing.Size(121, 20);
            this.destinationAirportNameTB.TabIndex = 9;
            // 
            // departureAirportNameTB
            // 
            this.departureAirportNameTB.Location = new System.Drawing.Point(148, 23);
            this.departureAirportNameTB.Name = "departureAirportNameTB";
            this.departureAirportNameTB.Size = new System.Drawing.Size(121, 20);
            this.departureAirportNameTB.TabIndex = 8;
            // 
            // vluchtTypeCombo
            // 
            this.vluchtTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vluchtTypeCombo.FormattingEnabled = true;
            this.vluchtTypeCombo.Items.AddRange(new object[] {
            "Retour",
            "Enkel"});
            this.vluchtTypeCombo.Location = new System.Drawing.Point(148, 76);
            this.vluchtTypeCombo.Name = "vluchtTypeCombo";
            this.vluchtTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.vluchtTypeCombo.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Klasse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(12, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Aantal passagiers:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vertrek datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vlucht type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bestemming";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vertrek punt";
            // 
            // ZoekButton
            // 
            this.ZoekButton.Location = new System.Drawing.Point(284, 268);
            this.ZoekButton.Name = "ZoekButton";
            this.ZoekButton.Size = new System.Drawing.Size(75, 23);
            this.ZoekButton.TabIndex = 0;
            this.ZoekButton.Text = "Zoek Vlucht";
            this.ZoekButton.UseVisualStyleBackColor = true;
            this.ZoekButton.Click += new System.EventHandler(this.ZoekButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(940, 590);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Boekingen Overzicht";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(668, 224);
            this.dataGridView1.TabIndex = 0;
            // 
            // FlightUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "FlightUC";
            this.Size = new System.Drawing.Size(970, 645);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.babiesNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adultsNB)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown babiesNB;
        private System.Windows.Forms.NumericUpDown childrenNB;
        private System.Windows.Forms.NumericUpDown adultsNB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox KlasseCombo;
        private System.Windows.Forms.DateTimePicker departureDate;
        private System.Windows.Forms.TextBox destinationAirportNameTB;
        private System.Windows.Forms.TextBox departureAirportNameTB;
        private System.Windows.Forms.ComboBox vluchtTypeCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ZoekButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
