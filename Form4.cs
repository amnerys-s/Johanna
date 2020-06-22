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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Productosg' Puede moverla o quitarla según sea necesario.
            this.ProductosgTableAdapter.Fill(this.DataSet1.Productosg);

            this.reportViewer1.RefreshReport();
        }
    }
}
