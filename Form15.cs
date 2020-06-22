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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Proveedorgeneral' Puede moverla o quitarla según sea necesario.
            this.ProveedorgeneralTableAdapter.Fill(this.DataSet1.Proveedorgeneral);

            this.reportViewer1.RefreshReport();
        }
    }
}
