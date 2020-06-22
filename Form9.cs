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
using System.Runtime.InteropServices;

namespace johanna
{ /*Controlar cantida insertada del  nombre y del apellido*/
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            Mostrardatos();




        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            



        }

        private void button2_Click(object sender, EventArgs e)
        { if (textBox2.Text == "" && textBox3.Text == "")
            {
                MessageBox.Show("No está supliendo los datos importantes", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                G();
                Mostrardatos();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }




        }

        void G()
        {


            Campos cc = new Campos();

            cc.Nombres = textBox2.Text;
            cc.Apellido = textBox3.Text;
            cc.Cedula = textBox4.Text;
            cc.Telefono = textBox5.Text;

            int resultado = CAMPOIN1.Agregar(cc);
            if (resultado > 0)
            {
                MessageBox.Show("El Registro ha sido guardado correctamente!!", "Imformación importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                    );

            }

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                Modificar();
                Mostrardatos();
            }
            else
            {

                MessageBox.Show("Debe insertar un identificador");
            }
        }

        void Modificar()
        {
            using (SqlConnection conn = Conexion.obtenerconexion())
            {
                conn.Open();
                SqlCommand hh = new SqlCommand("UPDATE Clientes SET Nombre='" + this.textBox2.Text + "',Apellido='" + this.textBox3.Text + "',Cedula='" + this.textBox4.Text + "',Telefono='" +
                    this.textBox5.Text + "' WHERE Id_Cliente= " + Convert.ToInt64(this.textBox1.Text + ""), conn);
                hh.BeginExecuteNonQuery();
                MessageBox.Show("El registro ha sido actualizado correctamente!!", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                    );
                conn.Close();

                Campos cc = new Campos();

                cc.Nombres = textBox2.Text;
                cc.Apellido = textBox3.Text;
                cc.Cedula = textBox4.Text;
                cc.Telefono = textBox5.Text;

            }

        }

        private void button1_Click(object sender, EventArgs e)

        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Debe Ingresar un identificador", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Comprobar_Id();

            }














        }

        void Lectura_id()
        {
            using (SqlConnection conn = Conexion.obtenerconexion())
            {
                SqlCommand uu = new SqlCommand("Select Id_Cliente from Clientes where Id_Cliente = @id and ESTADO = 'ACTIVADO'", conn);
                conn.Open();
                uu.Parameters.AddWithValue("@id", textBox1.Text);
                SqlDataReader Registro = uu.ExecuteReader();
                if (Registro.Read())
                {


                    bUSQUEDAD();



                }

                else
                {


                    DialogResult OPTIONS = MessageBox.Show("El cliete está desactivado", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    if (OPTIONS == DialogResult.OK)
                    {
                        DialogResult OPTIONS1 = MessageBox.Show("¿Desea activarlo?", "Información importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (OPTIONS1 == DialogResult.Yes)
                        {

                            // UPDATE

                            using (SqlConnection con = Conexion.obtenerconexion())
                            {
                                string queryUpdate = "UPDATE Clientes SET ESTADO = 'ACTIVADO' WHERE Id_Cliente = @ID";
                                SqlCommand update = new SqlCommand(queryUpdate, con);
                                con.Open();
                                update.Parameters.AddWithValue("@ID", textBox1.Text);
                                update.ExecuteNonQuery();
                                con.Close();
                                Mostrardatos();
                                llenar();

                            }
                        }


                        else if (OPTIONS1 == DialogResult.No)
                        {
                            textBox1.Text = "";

                        }


                    }
                }
            }



        }


        void bUSQUEDAD()
        {
            using (SqlConnection conn = Conexion.obtenerconexion())
            {
                SqlDataAdapter datos = new SqlDataAdapter("SELECT Id_Cliente,Nombre,Apellido,Cedula,Telefono FROM Clientes WHERE Id_Cliente =" + Convert.ToInt32(this.textBox1.Text
                    + ""), conn);
                DataSet hola = new DataSet();
                datos.Fill(hola, "Clientes");
                this.bueno.DataSource = hola.Tables[0];

                llenar();


            }


        }





        void llenar()
        {

            using (SqlConnection conn = Conexion.obtenerconexion())
            {
                SqlCommand uu = new SqlCommand("SELECT * FROM Clientes WHERE Id_Cliente = @Nombre", conn);
                uu.Parameters.AddWithValue("@Nombre", textBox1.Text);
                conn.Open();
                SqlDataReader Registro = uu.ExecuteReader();
                if (Registro.Read())
                {

                    textBox2.Text = Registro["Nombre"].ToString();
                    textBox3.Text = Registro["Apellido"].ToString();
                    textBox4.Text = Registro["Cedula"].ToString();
                    textBox5.Text = Registro["Telefono"].ToString();



                }
                conn.Close();

            }


        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)

        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Debe insertar un identificador", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                eliominar


                ();
                textBox1.Text = "";
                Mostrardatos();
            }
        }


        void Comprobar_Id()
        {
            using (SqlConnection conn = Conexion.obtenerconexion())
            {
                conn.Open();
                string busquedad = "Select Id_Cliente from Clientes where Id_Cliente = @Identificador";
                SqlCommand oo = new SqlCommand(busquedad, conn);
                oo.Parameters.AddWithValue("@Identificador", textBox1.Text);
                oo.ExecuteNonQuery();
                SqlDataReader roro = oo.ExecuteReader();
                if (roro.Read())
                {

                    Lectura_id();


                }

                else
                {

                    MessageBox.Show("El identificador no pertenece a ningún cliente", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = "";


                }

            }
        }



        void eliominar()
        {

            using (SqlConnection conn = Conexion.obtenerconexion())
            {
                conn.Open();
                SqlCommand hh = new SqlCommand("UPDATE Clientes SET ESTADO = 'DESACTIVADO' Where Id_Cliente =" + Convert.ToInt32(this.textBox1.Text
                    + ""), conn);

                hh.BeginExecuteNonQuery();
                MessageBox.Show("El registro se ha desactivado correctamente!!", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

                conn.Close();





            }
        }

        void Mostrardatos()
        {
            using (SqlConnection conn = Conexion.obtenerconexion())
            {

                SqlDataAdapter datos = new SqlDataAdapter("SELECT Id_Cliente,Nombre,Apellido,Cedula,Telefono FROM Clientes where ESTADO ='ACTIVADO'", conn);
                DataSet hola = new DataSet();
                datos.Fill(hola, "Clientes");
                this.bueno.DataSource = hola.Tables[0];
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            Mostrardatos();

        }

        private void bueno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        void ESTADO()
        {
            using (SqlConnection conn = Conexion.obtenerconexion())
            {
                conn.Open();
                SqlCommand hh = new SqlCommand("UPDATE Clientes SET ESTADO = 'ACTIVADO' Where Nombre =" + Convert.ToString(this.textBox1.Text
                    + ""), conn);

                hh.BeginExecuteNonQuery();



                conn.Close();





            }

        }



        private void Form9_MouseDown(object sender, MouseEventArgs e)
        {

        }
        int PosX = 0;
        int PosY = 0;
        private void Form9_MouseMove(object sender, MouseEventArgs e)
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

        private void bueno_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bueno.Rows[e.RowIndex].Selected = true;
        }

        private void Form9_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void bueno_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (DataGridViewRow row in bueno.SelectedRows)
            {
                string a, b, c = "";
                a = this.bueno.CurrentRow.Cells[0].Value.ToString();
                b = this.bueno.CurrentRow.Cells[1].Value.ToString();
                c = this.bueno.CurrentRow.Cells[2].Value.ToString();
                Form1 Factura = new Form1();
                foreach (Form factura in Application.OpenForms)
                {

                    if (factura.Name == "Form1")
                    {
                        Factura = (Form1)factura;
                        Factura.txtId_Cliente.Text = a;
                        Factura.txtNombre.Text = b;
                        Factura.txtApellido.Text = c;
                        this.Hide();
        }
                }
            } }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                     
            }
            else if (Char.IsControl(e.KeyChar))
            {

                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        // Verifica que no inserte  mas de lo datos
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
            else if (Char.IsControl(e.KeyChar))
            {

                e.Handled = false;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
            else if (Char.IsControl(e.KeyChar))
            {

                e.Handled = false;
            }
            else
            {
                e.Handled =false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Desactivados1 co = new Desactivados1();
            co.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Mostrardatos();
        }
    }
            }
        