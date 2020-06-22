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
    public partial class Cliente_identificador : Form
    {
        public Cliente_identificador()
        {
            InitializeComponent();
        }
        public Int32 Identificador { get; set; }

        private void Cliente_identificador_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Cliente_identificador' Puede moverla o quitarla según sea necesario.
            this.Cliente_identificador2TableAdapter.Fill(this.DataSet1.Cliente_identificador2,Identificador);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
