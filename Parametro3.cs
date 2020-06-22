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
    public partial class Parametro3 : Form
    {
        public Parametro3()
        {
            InitializeComponent();
            //textBox1.Enabled = false;
        }

        //private void checkBox1_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkBox1.Checked)
        //    {
        //        checkBox2.Enabled = false;
        //        textBox1.Enabled = true;
        //    }
        //    else
        //    {
        //        checkBox1.Enabled = true;
        //        checkBox2.Enabled = true;
        //        textBox1.Enabled = false;
        //        textBox1.Text = "";
        //    }
        //}

        private void button2_Click(object sender, EventArgs e)
        {





            ////

            if (checkBox1.Checked)
            {

                proveedor_nombre NOMBRE = new proveedor_nombre();
                NOMBRE.nombre = Convert.ToInt32(textBox1.Text);
                NOMBRE.Show();
            }
            else
            {
                Identificador_suplidorcs identificador = new Identificador_suplidorcs();
                identificador.INT = Convert.ToInt32(textBox1.Text);
                identificador.Show();
            }
            //
            //                else
            //                {
            //                    Identificador_suplidorcs identificador = new Identificador_suplidorcs();
            //        identificador.INT = Convert.ToInt32(textBox1.Text);
            //                    identificador.Show();
            //                }

            //            else
            //                {
            //                    MessageBox.Show("Necesita suplir el parámetro ", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                    textBox1.Focus();
            //                }

            //                }

            //    else
            //    {
            //        Identificador_suplidorcs identificador = new Identificador_suplidorcs();
            //            identificador.INT = Convert.ToInt32(textBox1.Text);
            //        identificador.Show();
            //    }
            //else
            //    {
            //        MessageBox.Show("Necesita suplir el parámetro ", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        textBox1.Focus();
            //    }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Enabled = false;
                textBox1.Enabled = true;
            }
            else
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                textBox1.Enabled = false;
                textBox1.Text = "";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (checkBox1.Checked)
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
           
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Parametro3_Load(object sender, EventArgs e)
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
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                textBox1.Enabled = false;
                textBox1.Text = "";
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
                checkBox2.Enabled = true;
                textBox1.Enabled = false;
                textBox1.Text = "";
            }
        }
    }
}
