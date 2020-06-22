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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Int32 hola2 { get; set; }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.producto_nombre_id' Puede moverla o quitarla según sea necesario.
            this.PRODUCTO_ESPECIFICO_ACTIVADOTableAdapter.Fill(this.DataSet1.PRODUCTO_ESPECIFICO_ACTIVADO, hola2);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
