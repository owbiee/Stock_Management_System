namespace StockControl
{
    partial class PFMUserPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PFMUserPage));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.facilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receivedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receivedReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuedReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facilityToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.approvalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.SpringGreen;
            this.menuStrip.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facilityToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.searchItemToolStripMenuItem,
            this.approvalToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1837, 31);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // facilityToolStripMenuItem
            // 
            this.facilityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStockToolStripMenuItem,
            this.receivedToolStripMenuItem,
            this.issuedToolStripMenuItem});
            this.facilityToolStripMenuItem.Name = "facilityToolStripMenuItem";
            this.facilityToolStripMenuItem.Size = new System.Drawing.Size(79, 27);
            this.facilityToolStripMenuItem.Text = "Facility";
            // 
            // newStockToolStripMenuItem
            // 
            this.newStockToolStripMenuItem.Name = "newStockToolStripMenuItem";
            this.newStockToolStripMenuItem.Size = new System.Drawing.Size(160, 28);
            this.newStockToolStripMenuItem.Text = "New Stock";
            this.newStockToolStripMenuItem.Click += new System.EventHandler(this.newStockToolStripMenuItem_Click);
            // 
            // receivedToolStripMenuItem
            // 
            this.receivedToolStripMenuItem.Name = "receivedToolStripMenuItem";
            this.receivedToolStripMenuItem.Size = new System.Drawing.Size(160, 28);
            this.receivedToolStripMenuItem.Text = "Received";
            this.receivedToolStripMenuItem.Click += new System.EventHandler(this.receivedToolStripMenuItem_Click);
            // 
            // issuedToolStripMenuItem
            // 
            this.issuedToolStripMenuItem.Name = "issuedToolStripMenuItem";
            this.issuedToolStripMenuItem.Size = new System.Drawing.Size(160, 28);
            this.issuedToolStripMenuItem.Text = "Issued";
            this.issuedToolStripMenuItem.Click += new System.EventHandler(this.issuedToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockReportToolStripMenuItem,
            this.receivedReportToolStripMenuItem,
            this.issuedReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(73, 27);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // stockReportToolStripMenuItem
            // 
            this.stockReportToolStripMenuItem.Name = "stockReportToolStripMenuItem";
            this.stockReportToolStripMenuItem.Size = new System.Drawing.Size(201, 28);
            this.stockReportToolStripMenuItem.Text = "Stock Report";
            this.stockReportToolStripMenuItem.Click += new System.EventHandler(this.stockReportToolStripMenuItem_Click);
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
            // searchItemToolStripMenuItem
            // 
            this.searchItemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facilityToolStripMenuItem1});
            this.searchItemToolStripMenuItem.Name = "searchItemToolStripMenuItem";
            this.searchItemToolStripMenuItem.Size = new System.Drawing.Size(113, 27);
            this.searchItemToolStripMenuItem.Text = "Search Item";
            // 
            // facilityToolStripMenuItem1
            // 
            this.facilityToolStripMenuItem1.Name = "facilityToolStripMenuItem1";
            this.facilityToolStripMenuItem1.Size = new System.Drawing.Size(137, 28);
            this.facilityToolStripMenuItem1.Text = "Facility";
            this.facilityToolStripMenuItem1.Click += new System.EventHandler(this.facilityToolStripMenuItem1_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 708);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1837, 22);
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
            this.label1.Location = new System.Drawing.Point(1555, 0);
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
            this.label2.Location = new System.Drawing.Point(1757, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Log Out";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // approvalToolStripMenuItem
            // 
            this.approvalToolStripMenuItem.Name = "approvalToolStripMenuItem";
            this.approvalToolStripMenuItem.Size = new System.Drawing.Size(89, 27);
            this.approvalToolStripMenuItem.Text = "Approval";
            this.approvalToolStripMenuItem.Click += new System.EventHandler(this.approvalToolStripMenuItem_Click);
            // 
            // PFMUserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1837, 730);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "PFMUserPage";
            this.Text = "PFMUserPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PFMUserPage_FormClosing);
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
        private System.Windows.Forms.ToolStripMenuItem facilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receivedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receivedReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuedReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facilityToolStripMenuItem1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem approvalToolStripMenuItem;
    }
}



