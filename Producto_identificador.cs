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
    public partial class Producto_identificador : Form
    {
        public Producto_identificador()
        {
            InitializeComponent();
        }
        public Int32 identificador { get; set; }

        private void Producto_identificador_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Producto_especifico_Identificador' Puede moverla o quitarla según sea necesario.
            this.Producto_especifico_Identificador3TableAdapter.Fill(this.DataSet1.Producto_especifico_Identificador3, identificador);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
