namespace TaxiClient.Hotel
{
    partial class HotelUC
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
            this.numPersons = new System.Windows.Forms.NumericUpDown();
            this.bookBTN = new System.Windows.Forms.Button();
            this.roomTypeCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.departureDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.arrivalDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hotelsCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.locationTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPersons)).BeginInit();
            this.SuspendLayout();
            // 
            // numPersons
            // 
            this.numPersons.Location = new System.Drawing.Point(137, 147);
            this.numPersons.Name = "numPersons";
            this.numPersons.Size = new System.Drawing.Size(74, 20);
            this.numPersons.TabIndex = 33;
            this.numPersons.ValueChanged += new System.EventHandler(this.numPersons_ValueChanged);
            // 
            // bookBTN
            // 
            this.bookBTN.Location = new System.Drawing.Point(42, 289);
            this.bookBTN.Name = "bookBTN";
            this.bookBTN.Size = new System.Drawing.Size(271, 27);
            this.bookBTN.TabIndex = 32;
            this.bookBTN.Text = "Book Hotel";
            this.bookBTN.UseVisualStyleBackColor = true;
            this.bookBTN.Click += new System.EventHandler(this.bookBTN_Click);
            // 
            // roomTypeCB
            // 
            this.roomTypeCB.FormattingEnabled = true;
            this.roomTypeCB.Location = new System.Drawing.Point(137, 247);
            this.roomTypeCB.Name = "roomTypeCB";
            this.roomTypeCB.Size = new System.Drawing.Size(176, 21);
            this.roomTypeCB.TabIndex = 31;
            this.roomTypeCB.Visible = false;
            this.roomTypeCB.SelectedIndexChanged += new System.EventHandler(this.roomTypeCB_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Kamer type";
            // 
            // departureDate
            // 
            this.departureDate.Location = new System.Drawing.Point(137, 213);
            this.departureDate.Name = "departureDate";
            this.departureDate.Size = new System.Drawing.Size(176, 20);
            this.departureDate.TabIndex = 29;
            this.departureDate.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Vertrek datum";
            // 
            // arrivalDate
            // 
            this.arrivalDate.Location = new System.Drawing.Point(137, 179);
            this.arrivalDate.Name = "arrivalDate";
            this.arrivalDate.Size = new System.Drawing.Size(176, 20);
            this.arrivalDate.TabIndex = 27;
            this.arrivalDate.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Aankomst datum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Aantal personen";
            // 
            // hotelsCB
            // 
            this.hotelsCB.FormattingEnabled = true;
            this.hotelsCB.Location = new System.Drawing.Point(98, 110);
            this.hotelsCB.Name = "hotelsCB";
            this.hotelsCB.Size = new System.Drawing.Size(114, 21);
            this.hotelsCB.TabIndex = 24;
            this.hotelsCB.Visible = false;
            this.hotelsCB.SelectedIndexChanged += new System.EventHandler(this.hotelsCB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Hotel";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(98, 71);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(114, 20);
            this.nameTB.TabIndex = 22;
            // 
            // locationTB
            // 
            this.locationTB.Location = new System.Drawing.Point(98, 35);
            this.locationTB.Name = "locationTB";
            this.locationTB.Size = new System.Drawing.Size(114, 20);
            this.locationTB.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Naam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Locatie";
            // 
            // searchBTN
            // 
            this.searchBTN.Location = new System.Drawing.Point(225, 38);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(88, 88);
            this.searchBTN.TabIndex = 18;
            this.searchBTN.Text = "Zoek Hotel";
            this.searchBTN.UseVisualStyleBackColor = true;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // HotelUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numPersons);
            this.Controls.Add(this.bookBTN);
            this.Controls.Add(this.roomTypeCB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.departureDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.arrivalDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hotelsCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.locationTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBTN);
            this.Name = "HotelUC";
            this.Size = new System.Drawing.Size(970, 645);
            this.Load += new System.EventHandler(this.HotelUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPersons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numPersons;
        private System.Windows.Forms.Button bookBTN;
        private System.Windows.Forms.ComboBox roomTypeCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker departureDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker arrivalDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox hotelsCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox locationTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchBTN;
    }
}
