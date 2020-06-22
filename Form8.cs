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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {


        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrif(new Form1());

        }

        private void abrif(object f)
        {
            if (this.Menu.Controls.Count > 0)
                this.Menu.Controls.RemoveAt(0);
            Form bb = f as Form;
            bb.TopLevel = false;

            this.Menu.Controls.Add(bb);
            this.Menu.Tag = bb;
            bb.Dock = DockStyle.Fill;
            bb.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;

            }

            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;

            }



        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form dd = new Form6();
            this.Close(
            );
            dd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrif(new Form10());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            abrif(new Form11());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            abrif(new Form12());
        }

        private void cleintesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrif(new Form9());

        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrif(new Form1());
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrif(new Form10());
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrif(new Form11());
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrif(new Form12());
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes_general hola = new Clientes_general();
            hola.Show();
            
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           Form4 oro = new Form4();
            oro.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Form3 hol = new Form3();
            hol.Show();
        }

        private void fechaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fechaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Factura_especifico oo = new Factura_especifico();
            oo.Show();
        }

        private void fechaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Compra_esepecifico boo = new Compra_esepecifico();
            boo.Show();
        
        }

        private void comprasToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form15 prov = new Form15();
            prov.Show();
        }

        private void comprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form14 com = new Form14();
            com.Show();
        }


        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ;
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void facturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Parametro parametro = new Parametro();
            parametro.Show();
        } 

        private void productosToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Parametro2 parametro2 = new Parametro2();
            parametro2.Show();
            
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parametro3 oo = new Parametro3();
            oo.Show();
        }

        private void productosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            abrif(new Form10());

        }

        private void facturasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            abrif(new Form1());
        }

        private void proveedoresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            abrif(new Form12());
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        int PosX = 0;
        int PosY = 0;
        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)


            {

                PosX = e.X;
                PosY = e.Y;


            }
            else
            {
                Left = Left + (e.X - PosX);
                Top = Top + (e.Y - PosY);
            }
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parametro4 form= new Parametro4();
            form.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}



