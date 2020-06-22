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
    public partial class Factura_especifico : Form
    {
        public Factura_especifico()
        {
            InitializeComponent();
        }

        public DateTime Fecha1 { get; set; }
        public DateTime Fecha2 { get; set; }

        private void Factura_especifico_Load(object sender, EventArgs e)
        {
           
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Fecha1 = F1.Value;
            Fecha2 = F2.Value;

            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Factura_fecha' Puede moverla o quitarla según sea necesario.


            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Factura_fecha2' Puede moverla o quitarla según sea necesario.
            this.Factura_fecha2TableAdapter.Fill(this.DataSet1.Factura_fecha2, Fecha1,Fecha2);
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Cliente_identificador' Puede moverla o quitarla según sea necesario.
            //




            this.reportViewer1.RefreshReport();


        }




        private void label1_Click(object sender, EventArgs e)
        {

        }
        //declaracion de las variables para el movimiento del screen
        int PosX = 0;
        int PosY = 0;
        private void Factura_especifico_MouseMove(object sender, MouseEventArgs e)
        {

            // call the buttom,  and  mouse button of the user left(parts that enable the movement)
            if(e.Button != MouseButtons.Left)
            {

                // take the position

                PosX = e.X;
                PosY = e.Y;
                     

            }

            else
            {
                Left = Left + (PosX - e.X);
                Top = Top + (PosY - e.Y);


            }

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
