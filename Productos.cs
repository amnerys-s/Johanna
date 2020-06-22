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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.PRODUCS_GENERAL' Puede moverla o quitarla según sea necesario.
            this.PRODUCS_GENERALTableAdapter.Fill(this.DataSet1.PRODUCS_GENERAL);

            this.reportViewer1.RefreshReport();
        }
    }
}
