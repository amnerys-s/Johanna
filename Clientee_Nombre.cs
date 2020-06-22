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
    public partial class Clientee_Nombre : Form
    {
        public Clientee_Nombre()
        {
            InitializeComponent();
        }
        public Int32 Nombre { get; set; }
        private void Clientee_Nombre_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Cliente_Nombre' Puede moverla o quitarla según sea necesario.
            this.clientes_desactivadosTableAdapter.Fill(this.DataSet1.clientes_desactivados, Nombre);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
