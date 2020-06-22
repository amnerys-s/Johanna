namespace johanna
{
    partial class Clientes_general
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
            this.clientes_generalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new johanna.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.clientes_generalTableAdapter = new johanna.DataSet1TableAdapters.clientes_generalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clientes_generalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // clientes_generalBindingSource
            // 
            this.clientes_generalBindingSource.DataMember = "clientes_general";
            this.clientes_generalBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.clientes_generalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "johanna.CGENERAL.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(772, 357);
            this.reportViewer1.TabIndex = 0;
            // 
            // clientes_generalTableAdapter
            // 
            this.clientes_generalTableAdapter.ClearBeforeFill = true;
            // 
            // Clientes_general
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 357);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Clientes_general";
            this.Text = "Reporte general de los clientes";
            this.Load += new System.EventHandler(this.Clientes_general_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientes_generalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource clientes_generalBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.clientes_generalTableAdapter clientes_generalTableAdapter;
    }
}