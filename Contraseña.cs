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
    public partial class Contraseña : Form
    {
        public Contraseña()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Contraseña_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "CORREO ELECTRÓNICO")
            {
                textBox1.Text = "";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "CORREO ELECTRÓNICO";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Correo_Electronico(this.textBox2.Text, this.textBox1.Text);
        }

        void Correo_Electronico(string Usuario, string Correo)
        {
            try
            {
                using (SqlConnection conn = Conexion.obtenerconexion())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select *  from Usuarios where Usuario = @Usuarios and Correo = @Correo", conn);
                    cmd.Parameters.AddWithValue("Usuarios", Usuario);
                    cmd.Parameters.AddWithValue("Correo", Correo);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);


                    if (tabla.Rows.Count == 1)
                    {
                        correo1(textBox1.Text);
                    }
                    else
                    {
                        MessageBox.Show("El usuario y/o contraseña que intenta ingresar son incorrectos.", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Error);





                    }

                }
            }


            catch (Exception j)
            {
                MessageBox.Show(j.Message);
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text ==  "USUARIO")
            {
                textBox2.Text = "";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "USUARIO";
            }
        }

        public void correo1(string email)
        {
            Random rd = new Random(DateTime.Now.Millisecond);
            int Nuevacontraseña = rd.Next(100000, 999999);
            using (SqlConnection conn = Conexion.obtenerconexion())
            {
                SqlCommand contraseña = new SqlCommand("Update Usuarios set Contraseña = @Nuevacontraseña where Correo= @Correo", conn);
                contraseña.Parameters.AddWithValue("@Nuevacontraseña",Nuevacontraseña);
                contraseña.Parameters.AddWithValue("@Correo", textBox1.Text);
               

                try
                {
                    conn.Open();
                    int FilasAfectadas = contraseña.ExecuteNonQuery();
                    if (FilasAfectadas!= 0)
                    {
                        Enviar_correo(Nuevacontraseña, this.textBox1.Text);
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
                catch (Exception y)
                {
                    MessageBox.Show(y.Message);
                }


            }
        }
        private void textBox1_Layout(object sender, LayoutEventArgs e)
        {

        }





        public void Enviar_correo(int Contraseñanueva, string correo)
        {
           
            string contraseña = "BuenosDias1";
            string mensaje = string.Empty;
            // creando el correo
            string destinario = correo;
            //cambiara dependiendo del coreo jejejjernjerhejr
            string remitente = "isabelsantosdls@hotmail.com";
            string asunto = "Nueva contraseña";
            string cuerpodelmensaje = "Su nueva contraseña es" + " "+ Convert.ToString(Contraseñanueva);
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage(remitente,destinario,asunto,cuerpodelmensaje);

            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient("smtp.live.com",587);
            cliente.EnableSsl = true;
            cliente.Credentials = new System.Net.NetworkCredential("isabelsantosdls@hotmail.com",contraseña);

            try
            {
                Task.Run(() =>
                {
                    cliente.Send(msg);
                    msg.Dispose();
                    MessageBox.Show("Se ha enviado una información a su dirección de correo","Información importante",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                );
                MessageBox.Show("La ejecución de la tarea puede tardar unos segundos","Información importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception v)
            {
                MessageBox.Show(v.Message);
            }




        }
    }

}
