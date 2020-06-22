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
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.FACTURA_general_REPORT' Puede moverla o quitarla según sea necesario.
            this.FACTURA_general_REPORTTableAdapter.Fill(this.DataSet1.FACTURA_general_REPORT);
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Clientes_REPORGENERAL' Puede moverla o quitarla según sea necesario.
         

            this.reportViewer1.RefreshReport();
        }
    }
}
