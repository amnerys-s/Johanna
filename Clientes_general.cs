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
    public partial class Clientes_general : Form
    {
        public Clientes_general()
        {
            InitializeComponent();
        }

        private void Clientes_general_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.clientes_general' Puede moverla o quitarla según sea necesario.
            this.clientes_generalTableAdapter.Fill(this.DataSet1.clientes_general);

            this.reportViewer1.RefreshReport();
        }
    }
}
