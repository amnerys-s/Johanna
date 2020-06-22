using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace johanna
{
    public partial class producto_prov1 : Form
    {
        public producto_prov1()
        {
            InitializeComponent();
        }
        public Int32 hola { get; set; }
        private void producto_prov1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.producto_nombre2' Puede moverla o quitarla según sea necesario.
            this.PRODUCTO_ESPECIFICO_DESACTIVADOTableAdapter.Fill(this.DataSet1.PRODUCTO_ESPECIFICO_DESACTIVADO, hola);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
