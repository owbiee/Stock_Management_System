namespace StockControl
{
    partial class Form2
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Shipping_DBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Freight365DataSet = new StockControl.Freight365DataSet();
            this.Shipping_DBTableAdapter = new StockControl.Freight365DataSetTableAdapters.Shipping_DBTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.StockControlDataSet17 = new StockControl.StockControlDataSet17();
            this.Facility_IssuedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Facility_IssuedTableAdapter = new StockControl.StockControlDataSet17TableAdapters.Facility_IssuedTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Shipping_DBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Freight365DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockControlDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Facility_IssuedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Shipping_DBBindingSource
            // 
            this.Shipping_DBBindingSource.DataMember = "Shipping_DB";
            this.Shipping_DBBindingSource.DataSource = this.Freight365DataSet;
            // 
            // Freight365DataSet
            // 
            this.Freight365DataSet.DataSetName = "Freight365DataSet";
            this.Freight365DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Shipping_DBTableAdapter
            // 
            this.Shipping_DBTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Facility_IssuedBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "StockControl.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1409, 695);
            this.reportViewer1.TabIndex = 0;
            // 
            // StockControlDataSet17
            // 
            this.StockControlDataSet17.DataSetName = "StockControlDataSet17";
            this.StockControlDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Facility_IssuedBindingSource
            // 
            this.Facility_IssuedBindingSource.DataMember = "Facility_Issued";
            this.Facility_IssuedBindingSource.DataSource = this.StockControlDataSet17;
            // 
            // Facility_IssuedTableAdapter
            // 
            this.Facility_IssuedTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 719);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Shipping_DBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Freight365DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockControlDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Facility_IssuedBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource Shipping_DBBindingSource;
        private Freight365DataSet Freight365DataSet;
        private Freight365DataSetTableAdapters.Shipping_DBTableAdapter Shipping_DBTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Facility_IssuedBindingSource;
        private StockControlDataSet17 StockControlDataSet17;
        private StockControlDataSet17TableAdapters.Facility_IssuedTableAdapter Facility_IssuedTableAdapter;
    }
}