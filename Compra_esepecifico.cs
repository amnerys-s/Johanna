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
    public partial class Compra_esepecifico : Form
    {
        public Compra_esepecifico()
        {
            InitializeComponent();
        }

        public DateTime Fecha1 { get; set; }
        public DateTime Fecha2 { get; set; }
        private void Compra_esepecifico_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Compras_especi2' Puede moverla o quitarla según sea necesario.
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            Fecha1 = F1.Value;
            Fecha2 = F2.Value;

            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Compras_especi' Puede moverla o quitarla según sea necesario.
            this.Compras_especi2TableAdapter.Fill(this.DataSet1.Compras_especi2,Fecha1,Fecha2);

            this.reportViewer1.RefreshReport();
        }

        int Posx = 0;
        int Posy = 0;

        private void Compra_esepecifico_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button != MouseButtons.Left)
            {

                Posx = e.X;
                Posy = e.Y;

            } 



            else
            {
                Left = Left + (e.X - Posx);
                Top = Top + (e.Y - Posy);
            }

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
