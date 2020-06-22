using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace johanna
{
    public partial class Form6 : Form
    {
        int boton = 0; 
        int bo = 1;
        int Coneto = 0;


        public Form6()
        {
            InitializeComponent();
            pictureBox5.Visible = true;
            pictureBox4.Visible = false;
            linkLabel1.Visible = false;

            

           
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                logear(this.textBox1.Text, textBox3.Text);

           
               

            
          

        

        }


        void acceso (){
            int conteo = 0;
            if (textBox1.Text!= "")
            {
                button1.Enabled = true;



            }
           
            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            acceso();
            

            
            
          





        }

        private void textBox1_Enter(object sender, EventArgs e)
        {


            if (textBox1.Text == "USUARIO")
            {
                textBox1.Text = "";

            }


    


            }

        private void textBox1_Leave(object sender, EventArgs e)
        {

          
            if (textBox1.Text =="")
            {
                textBox1.Text = "USUARIO";
            }


            

            
    }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.UseSystemPasswordChar = true;
            if (textBox3.UseSystemPasswordChar == true)
            { 
                textBox3.Text = "CONTRASEÑA";
             textBox3.Text = "";


              

            }

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
           
            if (textBox3.Text == "")
            {
                textBox3.Text = "CONTRASEÑA";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            boton++;
            if (boton == boton)
            {
                textBox3.UseSystemPasswordChar = true;
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
            }



            
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            textBox3.UseSystemPasswordChar = false;
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;

            if (pictureBox5.Visible == false)
            {
                boton++;
            }


        }



        public void logear (string usuario, string contraseña)
        {
            try
            {
                using (SqlConnection conn = Conexion.obtenerconexion())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select *  from Usuarios where Usuario = @Usuarios and Contraseña = @Contraseña", conn);
                    cmd.Parameters.AddWithValue("Usuarios", usuario);
                    cmd.Parameters.AddWithValue("Contraseña", contraseña);
                    SqlDataAdapter data =new  SqlDataAdapter(cmd);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);


                    if (textBox1.Text == "" && textBox3.Text == "")
                    {
                        MessageBox.Show("No está ingresando ninguna información ", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        bo = 0;
                    }
                    else if (textBox1.Text != "" && textBox3.Text == "")
                    {
                        MessageBox.Show("Solo está ingresando el usuario ", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox3.Focus();
                    }

                    else if (textBox1.Text != "" && textBox3.Text == "")
                    {
                        MessageBox.Show("Solo está ingresando el usuario ", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox1.Focus();
                    }
                    else   if (tabla.Rows.Count == 1)
                    {
                        this.Hide();
                        Form8 oo = new Form8();
                        oo.Show();
                    }
                    else
                    {
                        MessageBox.Show("El usuario y/o contraseña que intenta ingresar son incorrectos.","Información importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Coneto++;



                        if(Coneto >3)
                            {


                          DialogResult respuestas =  MessageBox.Show("¿Desea obtener una nueva contraseña?", "Información importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            
                            if (respuestas == DialogResult.Yes)
                            {

                                Contraseña recuperar = new Contraseña();
                                recuperar.Show();


                            }
                            else
                            {
                                Coneto = 0; 
                            }



                        }

                        if (Coneto ==2)
                        {
                            linkLabel1.Visible = true;
                        }








                    }




                }




            }

        catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

         

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           


        }

        private void checkBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Contraseña recuperar = new Contraseña();
            recuperar.Show();
        }
    }

}


