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
    public partial class Parametro2 : Form
    {
        public Parametro2()
        {
            InitializeComponent();
            //textBox1.Enabled = false;
            textBox1.Enabled = true;
        }

        private void Parametro2_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox2.Checked)
            //{
            //    checkBox1.Enabled = false;
            //    textBox1.Enabled = true;
            //}
            //else
            //{
            //    checkBox1.Enabled = true;
            //    textBox1.Enabled = false;

            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (checkBox1.Checked)
            //{
            if (checkBox1.Checked)
            {
                Producto_identificador ide = new Producto_identificador();
                ide.identificador = Convert.ToInt32(textBox1.Text);
                ide.Show();
        }
            else if (checkBox2.Checked)
            {
                nombre_producto producto = new nombre_producto();
        producto.Nombre = Convert.ToInt32(textBox1.Text);
                producto.Show();
            }

    //}
    //else if (checkBox2.Checked)
    //{
    //    nombre_producto producto = new nombre_producto();
    //    producto.Nombre = Convert.ToInt32(textBox1.Text);
    //    producto.Show();
    //}
}

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox1.Checked)
            //{
            //    checkBox2.Enabled = false;
            //    textBox1.Enabled = true;
            //}
            //else
            //{
                
            //    checkBox2.Enabled = true;
            //    textBox1.Enabled = false;

                
            //}
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if(checkBox1.Checked)
            //{
            if (checkBox1.Checked)
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if (checkBox2.Checked)
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            //}
            //else if (checkBox2.Checked)
            //{
            //    if (Char.IsControl(e.KeyChar))
            //    {
            //        e.Handled = false;
            //    }
            //    else if (Char.IsDigit(e.KeyChar))
            //    {
            //        e.Handled = false;
            //    }
            //    else
            //    {
            //        e.Handled = true;
            //    }
            //}
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Enabled = false;
                textBox1.Enabled = true;
            }
            else
            {

                checkBox2.Enabled = true;
                textBox1.Enabled = true;


            }
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Enabled = false;
                textBox1.Enabled = true;
            }
            else
            {
                checkBox1.Enabled = true;
                textBox1.Enabled = true;

            }
        }
    }
}
