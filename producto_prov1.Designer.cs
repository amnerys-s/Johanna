namespace johanna
{
    partial class producto_prov1
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
            this.PRODUCTO_ESPECIFICO_DESACTIVADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PRODUCTO_ESPECIFICO_DESACTIVADOTableAdapter = new johanna.DataSet1TableAdapters.PRODUCTO_ESPECIFICO_DESACTIVADOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRODUCTO_ESPECIFICO_DESACTIVADOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PRODUCTO_ESPECIFICO_DESACTIVADOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "johanna.Report19.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(754, 370);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PRODUCTO_ESPECIFICO_DESACTIVADOBindingSource
            // 
            this.PRODUCTO_ESPECIFICO_DESACTIVADOBindingSource.DataMember = "PRODUCTO_ESPECIFICO_DESACTIVADO";
            this.PRODUCTO_ESPECIFICO_DESACTIVADOBindingSource.DataSource = this.DataSet1;
            // 
            // PRODUCTO_ESPECIFICO_DESACTIVADOTableAdapter
            // 
            this.PRODUCTO_ESPECIFICO_DESACTIVADOTableAdapter.ClearBeforeFill = true;
            // 
            // producto_prov1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 370);
            this.Controls.Add(this.reportViewer1);
            this.Name = "producto_prov1";
            this.Text = "Reporte específico de los productos";
            this.Load += new System.EventHandler(this.producto_prov1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRODUCTO_ESPECIFICO_DESACTIVADOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PRODUCTO_ESPECIFICO_DESACTIVADOBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.PRODUCTO_ESPECIFICO_DESACTIVADOTableAdapter PRODUCTO_ESPECIFICO_DESACTIVADOTableAdapter;
    }
}