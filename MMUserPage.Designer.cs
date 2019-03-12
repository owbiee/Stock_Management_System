namespace StockControl
{
    partial class MMUserPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MMUserPage));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receivedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receivedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.issuedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.approvalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.maintenanceToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.searchItemToolStripMenuItem,
            this.approvalsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1842, 31);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStockToolStripMenuItem,
            this.receivedToolStripMenuItem,
            this.issuedToolStripMenuItem});
            this.maintenanceToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(113, 27);
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
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
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockToolStripMenuItem,
            this.receivedToolStripMenuItem1,
            this.issuedToolStripMenuItem1});
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(80, 27);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(145, 28);
            this.stockToolStripMenuItem.Text = "Stock";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // receivedToolStripMenuItem1
            // 
            this.receivedToolStripMenuItem1.Name = "receivedToolStripMenuItem1";
            this.receivedToolStripMenuItem1.Size = new System.Drawing.Size(145, 28);
            this.receivedToolStripMenuItem1.Text = "Received";
            this.receivedToolStripMenuItem1.Click += new System.EventHandler(this.receivedToolStripMenuItem1_Click);
            // 
            // issuedToolStripMenuItem1
            // 
            this.issuedToolStripMenuItem1.Name = "issuedToolStripMenuItem1";
            this.issuedToolStripMenuItem1.Size = new System.Drawing.Size(145, 28);
            this.issuedToolStripMenuItem1.Text = "Issued";
            this.issuedToolStripMenuItem1.Click += new System.EventHandler(this.issuedToolStripMenuItem1_Click);
            // 
            // searchItemToolStripMenuItem
            // 
            this.searchItemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maintenanceItemsToolStripMenuItem});
            this.searchItemToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.searchItemToolStripMenuItem.Name = "searchItemToolStripMenuItem";
            this.searchItemToolStripMenuItem.Size = new System.Drawing.Size(113, 27);
            this.searchItemToolStripMenuItem.Text = "Search Item";
            // 
            // maintenanceItemsToolStripMenuItem
            // 
            this.maintenanceItemsToolStripMenuItem.Name = "maintenanceItemsToolStripMenuItem";
            this.maintenanceItemsToolStripMenuItem.Size = new System.Drawing.Size(218, 28);
            this.maintenanceItemsToolStripMenuItem.Text = "Maintenance Items";
            this.maintenanceItemsToolStripMenuItem.Click += new System.EventHandler(this.maintenanceItemsToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 613);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1842, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SpringGreen;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1370, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SpringGreen;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1674, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Log Out";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // approvalsToolStripMenuItem
            // 
            this.approvalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maintenanceToolStripMenuItem1});
            this.approvalsToolStripMenuItem.Name = "approvalsToolStripMenuItem";
            this.approvalsToolStripMenuItem.Size = new System.Drawing.Size(96, 27);
            this.approvalsToolStripMenuItem.Text = "Approvals";
            // 
            // maintenanceToolStripMenuItem1
            // 
            this.maintenanceToolStripMenuItem1.Name = "maintenanceToolStripMenuItem1";
            this.maintenanceToolStripMenuItem1.Size = new System.Drawing.Size(180, 28);
            this.maintenanceToolStripMenuItem1.Text = "Maintenance";
            this.maintenanceToolStripMenuItem1.Click += new System.EventHandler(this.maintenanceToolStripMenuItem1_Click);
            // 
            // MMUserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1842, 635);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MMUserPage";
            this.Text = "MMUserPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MMUserPage_FormClosing);
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
        private System.Windows.Forms.ToolStripMenuItem newStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receivedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receivedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem issuedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceItemsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem approvalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem1;
    }
}



