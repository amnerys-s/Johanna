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
    public partial class Suplidor : Form
    {
        public Suplidor()
        {
            InitializeComponent();
        }

        public String Empresa { get; set; }
        public Int32 Ide{ get; set; }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Suplidor_Load(object sender, EventArgs e)
        {
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Identificador.Text != "")
            {
                Ide = Convert.ToInt32(Identificador.Text);

            }

            else
            {
                Empresa = EMPRESA.Text;
                
            }
            

            // TODO: esta línea de código carga datos en la tabla 'DataSet1.proveedor_especifico' Puede moverla o quitarla según sea necesario.
            this.proveedor_especificoTableAdapter.Fill(this.DataSet1.proveedor_especifico, Empresa, Ide);

            this.reportViewer1.RefreshReport();


            
        }
    }
}
