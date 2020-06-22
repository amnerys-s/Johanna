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
    public partial class Parametro : Form
    {
        public Parametro()
        {
            InitializeComponent();
            textBox1.Enabled = true;
            //checkBox1.Enabled = false;
            //checkBox2.Enabled = false;
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (checkBox1.Checked == true)
            //{
            if (checkBox1.Checked == true)
            {
                Cliente_identificador IDE = new Cliente_identificador();
                IDE.Identificador = Convert.ToInt32(textBox1.Text);
                IDE.ShowDialog();

            }



            else
            {

                Clientee_Nombre NOM = new Clientee_Nombre();
                NOM.Nombre = Convert.ToInt32(textBox1.Text);
                NOM.ShowDialog();


            }
            //}



            //else
            //{

            //Clientee_Nombre NOM = new Clientee_Nombre();
            //NOM.Nombre = Convert.ToInt32(textBox1.Text);
            //NOM.ShowDialog();


            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox1.Checked
            //   )
            //{
            //    textBox1.Enabled = true;
            //    checkBox2.Enabled = false;
            //}
            //else
            //{
            //    textBox1.Enabled = false;
            //    checkBox2.Enabled = true;
            //}
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (checkBox1.Checked)
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

        }
        


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox2.Checked)
            //{
            //    textBox1.Enabled = true;
            //    checkBox1.Enabled = false;
            //}
            //else
            //{
            //    checkBox1.Enabled = true;
            //    textBox1.Enabled = false;
            //}
        }

        private void Parametro_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox1.Enabled = true;
                checkBox1.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
                textBox1.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked
               )
            {
                textBox1.Enabled = true;
                checkBox2.Enabled = false;
            }
            else
            {
                textBox1.Enabled = false;
                checkBox2.Enabled = true;
            }
        }
    }
}
