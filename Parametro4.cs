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
    public partial class Parametro4 : Form
    {
        public Parametro4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                producto_prov1 col = new producto_prov1();
                col.hola = Convert.ToInt32(textBox1.Text);
                col.Show();
            }
            else
            {
                Form2 form = new Form2();
                form.hola2 = Convert.ToInt32(textBox1.Text);
                form.Show();

            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Parametro4_Load(object sender, EventArgs e)
        {

        }
    }
}
