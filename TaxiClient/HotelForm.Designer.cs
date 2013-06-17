namespace TaxiClient
{
    partial class HotelForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chooseBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotelBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taxiBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zoek Flight";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Locatie";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naam";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(72, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 20);
            this.textBox2.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseBookingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 5;
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
            // HotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HotelForm";
            this.Text = "Hotel Boeking";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chooseBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flightBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotelBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taxiBookingToolStripMenuItem;
    }
}