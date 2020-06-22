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
    public partial class nombre_producto : Form
    {
        public nombre_producto()
        {
            InitializeComponent();
        }
        public Int32 Nombre { get; set; }
        private void nombre_producto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Producto_especifico_Nombre' Puede moverla o quitarla según sea necesario.
            this.producto_f_desactivadoTableAdapter.Fill(this.DataSet1.producto_f_desactivado, Nombre);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
