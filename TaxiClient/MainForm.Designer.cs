namespace TaxiClient
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.flightBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotelBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taxiBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoBoekingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.attractieBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(992, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flightBookingToolStripMenuItem,
            this.hotelBookingToolStripMenuItem,
            this.taxiBookingToolStripMenuItem,
            this.autoBoekingToolStripMenuItem,
            this.attractieBookingToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(86, 20);
            this.toolStripMenuItem1.Text = "Kies Boeking";
            this.toolStripMenuItem1.ToolTipText = "Chose of one of the many bookings that you can do through our client!";
            // 
            // flightBookingToolStripMenuItem
            // 
            this.flightBookingToolStripMenuItem.Name = "flightBookingToolStripMenuItem";
            this.flightBookingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.flightBookingToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.flightBookingToolStripMenuItem.Text = "Vlucht Boeking";
            this.flightBookingToolStripMenuItem.Click += new System.EventHandler(this.flightBookingToolStripMenuItem_Click);
            // 
            // hotelBookingToolStripMenuItem
            // 
            this.hotelBookingToolStripMenuItem.Name = "hotelBookingToolStripMenuItem";
            this.hotelBookingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.hotelBookingToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.hotelBookingToolStripMenuItem.Text = "Hotel Boeking";
            this.hotelBookingToolStripMenuItem.Click += new System.EventHandler(this.hotelBookingToolStripMenuItem_Click);
            // 
            // taxiBookingToolStripMenuItem
            // 
            this.taxiBookingToolStripMenuItem.Name = "taxiBookingToolStripMenuItem";
            this.taxiBookingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.taxiBookingToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.taxiBookingToolStripMenuItem.Text = "Taxi Boeking";
            this.taxiBookingToolStripMenuItem.Click += new System.EventHandler(this.taxiBookingToolStripMenuItem_Click);
            // 
            // autoBoekingToolStripMenuItem
            // 
            this.autoBoekingToolStripMenuItem.Name = "autoBoekingToolStripMenuItem";
            this.autoBoekingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.autoBoekingToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.autoBoekingToolStripMenuItem.Text = "Auto Boeking";
            this.autoBoekingToolStripMenuItem.Click += new System.EventHandler(this.autoBoekingToolStripMenuItem_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Location = new System.Drawing.Point(12, 36);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(970, 645);
            this.mainPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome, to the new(B)ooking system!";
            // 
            // attractieBookingToolStripMenuItem
            // 
            this.attractieBookingToolStripMenuItem.Name = "attractieBookingToolStripMenuItem";
            this.attractieBookingToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.attractieBookingToolStripMenuItem.Text = "Attractie booking";
            this.attractieBookingToolStripMenuItem.Click += new System.EventHandler(this.attractieBookingToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 693);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boeking Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem flightBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotelBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taxiBookingToolStripMenuItem;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem autoBoekingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attractieBookingToolStripMenuItem;
    }
}