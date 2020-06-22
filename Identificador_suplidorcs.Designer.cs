namespace johanna
{
    partial class Identificador_suplidorcs
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
            this.PROVEEDOR_ESPECIFICO_ACTIVADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PROVEEDOR_ESPECIFICO_ACTIVADOTableAdapter = new johanna.DataSet1TableAdapters.PROVEEDOR_ESPECIFICO_ACTIVADOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PROVEEDOR_ESPECIFICO_ACTIVADOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PROVEEDOR_ESPECIFICO_ACTIVADOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "johanna.Report21.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(878, 376);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PROVEEDOR_ESPECIFICO_ACTIVADOBindingSource
            // 
            this.PROVEEDOR_ESPECIFICO_ACTIVADOBindingSource.DataMember = "PROVEEDOR_ESPECIFICO_ACTIVADO";
            this.PROVEEDOR_ESPECIFICO_ACTIVADOBindingSource.DataSource = this.DataSet1;
            // 
            // PROVEEDOR_ESPECIFICO_ACTIVADOTableAdapter
            // 
            this.PROVEEDOR_ESPECIFICO_ACTIVADOTableAdapter.ClearBeforeFill = true;
            // 
            // Identificador_suplidorcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 376);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Identificador_suplidorcs";
            this.Text = "Identificador_suplidorcs";
            this.Load += new System.EventHandler(this.Identificador_suplidorcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PROVEEDOR_ESPECIFICO_ACTIVADOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PROVEEDOR_ESPECIFICO_ACTIVADOBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.PROVEEDOR_ESPECIFICO_ACTIVADOTableAdapter PROVEEDOR_ESPECIFICO_ACTIVADOTableAdapter;
    }
}