namespace johanna
{
    partial class proveedor_nombre
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet1 = new johanna.DataSet1();
            this.PROVEEDOR_ESPECIFICO_DESACTIVADO1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PROVEEDOR_ESPECIFICO_DESACTIVADO1TableAdapter = new johanna.DataSet1TableAdapters.PROVEEDOR_ESPECIFICO_DESACTIVADO1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PROVEEDOR_ESPECIFICO_DESACTIVADO1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PROVEEDOR_ESPECIFICO_DESACTIVADO1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "johanna.Report18.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(813, 387);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PROVEEDOR_ESPECIFICO_DESACTIVADO1BindingSource
            // 
            this.PROVEEDOR_ESPECIFICO_DESACTIVADO1BindingSource.DataMember = "PROVEEDOR_ESPECIFICO_DESACTIVADO1";
            this.PROVEEDOR_ESPECIFICO_DESACTIVADO1BindingSource.DataSource = this.DataSet1;
            // 
            // PROVEEDOR_ESPECIFICO_DESACTIVADO1TableAdapter
            // 
            this.PROVEEDOR_ESPECIFICO_DESACTIVADO1TableAdapter.ClearBeforeFill = true;
            // 
            // proveedor_nombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 387);
            this.Controls.Add(this.reportViewer1);
            this.Name = "proveedor_nombre";
            this.Text = "Reporte específico de los proveedores";
            this.Load += new System.EventHandler(this.proveedor_nombre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PROVEEDOR_ESPECIFICO_DESACTIVADO1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PROVEEDOR_ESPECIFICO_DESACTIVADO1BindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.PROVEEDOR_ESPECIFICO_DESACTIVADO1TableAdapter PROVEEDOR_ESPECIFICO_DESACTIVADO1TableAdapter;
    }
}