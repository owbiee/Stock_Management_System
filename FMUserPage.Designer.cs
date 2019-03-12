namespace StockControl
{
    partial class FMUserPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMUserPage));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receivedStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuedStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receivedStockToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.issuedStockToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stockBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receivedReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuedReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facilityToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stockBalanceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.receivedReportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.issuedReportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.SpringGreen;
            this.menuStrip.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maintenanceToolStripMenuItem,
            this.facilityToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1836, 31);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receivedStockToolStripMenuItem,
            this.issuedStockToolStripMenuItem});
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(113, 27);
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
            // 
            // receivedStockToolStripMenuItem
            // 
            this.receivedStockToolStripMenuItem.Name = "receivedStockToolStripMenuItem";
            this.receivedStockToolStripMenuItem.Size = new System.Drawing.Size(193, 28);
            this.receivedStockToolStripMenuItem.Text = "Received Stock";
            this.receivedStockToolStripMenuItem.Click += new System.EventHandler(this.receivedStockToolStripMenuItem_Click);
            // 
            // issuedStockToolStripMenuItem
            // 
            this.issuedStockToolStripMenuItem.Name = "issuedStockToolStripMenuItem";
            this.issuedStockToolStripMenuItem.Size = new System.Drawing.Size(193, 28);
            this.issuedStockToolStripMenuItem.Text = "Issued Stock";
            this.issuedStockToolStripMenuItem.Click += new System.EventHandler(this.issuedStockToolStripMenuItem_Click);
            // 
            // facilityToolStripMenuItem
            // 
            this.facilityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receivedStockToolStripMenuItem1,
            this.issuedStockToolStripMenuItem1});
            this.facilityToolStripMenuItem.Name = "facilityToolStripMenuItem";
            this.facilityToolStripMenuItem.Size = new System.Drawing.Size(79, 27);
            this.facilityToolStripMenuItem.Text = "Facility";
            // 
            // receivedStockToolStripMenuItem1
            // 
            this.receivedStockToolStripMenuItem1.Name = "receivedStockToolStripMenuItem1";
            this.receivedStockToolStripMenuItem1.Size = new System.Drawing.Size(193, 28);
            this.receivedStockToolStripMenuItem1.Text = "Received Stock";
            this.receivedStockToolStripMenuItem1.Click += new System.EventHandler(this.receivedStockToolStripMenuItem1_Click);
            // 
            // issuedStockToolStripMenuItem1
            // 
            this.issuedStockToolStripMenuItem1.Name = "issuedStockToolStripMenuItem1";
            this.issuedStockToolStripMenuItem1.Size = new System.Drawing.Size(193, 28);
            this.issuedStockToolStripMenuItem1.Text = "Issued Stock";
            this.issuedStockToolStripMenuItem1.Click += new System.EventHandler(this.issuedStockToolStripMenuItem1_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maintenanceToolStripMenuItem1,
            this.facilityToolStripMenuItem1});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(73, 27);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // maintenanceToolStripMenuItem1
            // 
            this.maintenanceToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockBalanceToolStripMenuItem,
            this.receivedReportToolStripMenuItem,
            this.issuedReportToolStripMenuItem});
            this.maintenanceToolStripMenuItem1.Name = "maintenanceToolStripMenuItem1";
            this.maintenanceToolStripMenuItem1.Size = new System.Drawing.Size(171, 28);
            this.maintenanceToolStripMenuItem1.Text = "Maintenance";
            // 
            // stockBalanceToolStripMenuItem
            // 
            this.stockBalanceToolStripMenuItem.Name = "stockBalanceToolStripMenuItem";
            this.stockBalanceToolStripMenuItem.Size = new System.Drawing.Size(201, 28);
            this.stockBalanceToolStripMenuItem.Text = "Stock Balance";
            this.stockBalanceToolStripMenuItem.Click += new System.EventHandler(this.stockBalanceToolStripMenuItem_Click);
            // 
            // receivedReportToolStripMenuItem
            // 
            this.receivedReportToolStripMenuItem.Name = "receivedReportToolStripMenuItem";
            this.receivedReportToolStripMenuItem.Size = new System.Drawing.Size(201, 28);
            this.receivedReportToolStripMenuItem.Text = "Received Report";
            this.receivedReportToolStripMenuItem.Click += new System.EventHandler(this.receivedReportToolStripMenuItem_Click);
            // 
            // issuedReportToolStripMenuItem
            // 
            this.issuedReportToolStripMenuItem.Name = "issuedReportToolStripMenuItem";
            this.issuedReportToolStripMenuItem.Size = new System.Drawing.Size(201, 28);
            this.issuedReportToolStripMenuItem.Text = "Issued Report";
            this.issuedReportToolStripMenuItem.Click += new System.EventHandler(this.issuedReportToolStripMenuItem_Click);
            // 
            // facilityToolStripMenuItem1
            // 
            this.facilityToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockBalanceToolStripMenuItem1,
            this.receivedReportToolStripMenuItem1,
            this.issuedReportToolStripMenuItem1});
            this.facilityToolStripMenuItem1.Name = "facilityToolStripMenuItem1";
            this.facilityToolStripMenuItem1.Size = new System.Drawing.Size(171, 28);
            this.facilityToolStripMenuItem1.Text = "Facility";
            // 
            // stockBalanceToolStripMenuItem1
            // 
            this.stockBalanceToolStripMenuItem1.Name = "stockBalanceToolStripMenuItem1";
            this.stockBalanceToolStripMenuItem1.Size = new System.Drawing.Size(201, 28);
            this.stockBalanceToolStripMenuItem1.Text = "Stock Balance";
            this.stockBalanceToolStripMenuItem1.Click += new System.EventHandler(this.stockBalanceToolStripMenuItem1_Click);
            // 
            // receivedReportToolStripMenuItem1
            // 
            this.receivedReportToolStripMenuItem1.Name = "receivedReportToolStripMenuItem1";
            this.receivedReportToolStripMenuItem1.Size = new System.Drawing.Size(201, 28);
            this.receivedReportToolStripMenuItem1.Text = "Received Report";
            this.receivedReportToolStripMenuItem1.Click += new System.EventHandler(this.receivedReportToolStripMenuItem1_Click);
            // 
            // issuedReportToolStripMenuItem1
            // 
            this.issuedReportToolStripMenuItem1.Name = "issuedReportToolStripMenuItem1";
            this.issuedReportToolStripMenuItem1.Size = new System.Drawing.Size(201, 28);
            this.issuedReportToolStripMenuItem1.Text = "Issued Report";
            this.issuedReportToolStripMenuItem1.Click += new System.EventHandler(this.issuedReportToolStripMenuItem1_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 746);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1836, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SpringGreen;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1322, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SpringGreen;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1745, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Log Out";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FMUserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1836, 768);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FMUserPage";
            this.Text = "FMUserPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FMUserPage_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receivedStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuedStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receivedStockToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem issuedStockToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stockBalanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receivedReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuedReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facilityToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stockBalanceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem receivedReportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem issuedReportToolStripMenuItem1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}



