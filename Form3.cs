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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.factura_general1' Puede moverla o quitarla según sea necesario.
            this.factura_general3TableAdapter.Fill(this.DataSet1.factura_general3);

            this.reportViewer1.RefreshReport();
        }
    }
}
