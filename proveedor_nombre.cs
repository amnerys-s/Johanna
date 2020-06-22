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
    public partial class proveedor_nombre : Form
    {
        public proveedor_nombre()
        {
            InitializeComponent();
        }
        public Int32  nombre { get; set; }

        private void proveedor_nombre_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.identificador_nombre' Puede moverla o quitarla según sea necesario.
            this.PROVEEDOR_ESPECIFICO_DESACTIVADO1TableAdapter.Fill(this.DataSet1.PROVEEDOR_ESPECIFICO_DESACTIVADO1, nombre);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
