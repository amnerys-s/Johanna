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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
            mostrardatos();
            txtId_Proveedor.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void Form12_Load(object sender, EventArgs e)
        {
            txtId_Proveedor.Focus();
        }

        private void button2_Click(object sender, EventArgs e)

        {
            if (txtEmpresa.Text == "" && txtTelefono.Text == "")
            {
                MessageBox.Show("Debe introducir los datos importantes", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                using (SqlConnection conn = Conexion.obtenerconexion())

                {
                    conn.Open();
                    string query = "Insert into Proveedor (Empresa,Telefono,Direccion, Representante,ESTADO) Values (@Empresa, @Tel, @Dire,@Repre,'ACTIVADO')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Empresa", txtEmpresa.Text);
                    cmd.Parameters.AddWithValue("@Tel", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@Dire", txtDireccion.Text);
                    cmd.Parameters.AddWithValue("@Repre", txtRepresentante.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("El Registro ha sido guardado correctamente", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    mostrardatos();
                    txtId_Proveedor.Text = "";

                    txtEmpresa.Text = "";
                    txtTelefono.Text = "";
                    txtRepresentante.Text = "";
                    txtDireccion.Text = "";


                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {



        }



        void mostrardatos()
        {
            using (SqlConnection conn = Conexion.obtenerconexion())
            {
                SqlDataAdapter data = new SqlDataAdapter("Select Id_Proveedor,Empresa,Telefono,Direccion,Representante from Proveedor WHERE ESTADO = 'ACTIVADO' ", conn);
                DataSet hola = new DataSet();
                data.Fill(hola, "Proveedor");
                this.H.DataSource = hola.Tables[0];

            }
        }

        private void button4_Click(object sender, EventArgs e)
        { if (txtId_Proveedor.Text == "")
            {
                MessageBox.Show("Debe insertar un identificador", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Update();
                mostrardatos();
            }

        }
        void Update()
        {
            using (SqlConnection conn = Conexion.obtenerconexion())
            {
                string UPDATE = "UPDATE Proveedor SET Empresa = @Empresa, Telefono = @Telefono, Direccion = @Direccion, Representante = @Representante WHERE Id_Proveedor =@ID_Proveedor";
                conn.Open();
                SqlCommand dd = new SqlCommand(UPDATE, conn);
                dd.Parameters.AddWithValue("@Empresa", txtEmpresa.Text);
                dd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                dd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                dd.Parameters.AddWithValue("@Representante", txtRepresentante.Text);
                dd.Parameters.AddWithValue("@ID_Proveedor", txtId_Proveedor.Text);
                dd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("El registro ha sido actualizado correctamente", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);






            }

        }

        private void button1_Click(object sender, EventArgs e)
        {







        }


        void Llenar()
        {

            using (SqlConnection conn = Conexion.obtenerconexion())
            {
                SqlCommand uu = new SqlCommand(" SELECT * FROM Proveedor WHERE Id_Proveedor  = @Empresa AND ESTADO = 'ACTIVADO'", conn);
                uu.Parameters.AddWithValue("@Empresa", txtId_Proveedor.Text);
                conn.Open();
                SqlDataReader Registro = uu.ExecuteReader();
                if (Registro.Read())
                {

                    txtEmpresa.Text = Registro["Empresa"].ToString();
                    txtRepresentante.Text = Registro["Representante"].ToString();
                    txtTelefono.Text = Registro["Telefono"].ToString();
                    txtDireccion.Text = Registro["Direccion"].ToString();

                    conn.Close();




                }


                else
                {
                    DialogResult OO = MessageBox.Show("El registro está deshabilitado", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (DialogResult.OK == OO)
                    {
                        
                
                
                            
                            
                                DialogResult yesno = MessageBox.Show("¿Desea activarlo?", "Información Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (DialogResult.Yes== yesno)
                                {
                                    using (SqlConnection oo = Conexion.obtenerconexion())
                                    {
                                        String query = "UPDATE Proveedor  set ESTADO = 'ACTIVADO' WHERE Id_Proveedor = @identificador";
                                        SqlCommand iu = new SqlCommand(query, oo);
                                        iu.Parameters.AddWithValue("@identificador", txtId_Proveedor.Text);
                                oo.Open();
                                iu.ExecuteNonQuery();
                                       
                                        Llenar();
                                        mostrardatos();
                                        conn.Close();
                                    }

                                }
                            }



                        } } } 

        void Buscar()
        {
            using (SqlConnection conn = Conexion.obtenerconexion())
            {

                SqlDataAdapter datos = new SqlDataAdapter("Select  Id_Proveedor,Empresa,Telefono,Direccion From Proveedor Where  ESTADO= 'ACTIVADO' AND Id_Proveedor =" + this.txtId_Proveedor.Text + "", conn);
                DataSet hola = new DataSet();
                datos.Fill(hola, "Proveedor");
                this.H.DataSource = hola.Tables[0];
                



            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        void Eliminar()


        {
            if (txtId_Proveedor.Text == "")
            {
                MessageBox.Show("Debe insertar un identificador", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {



                using (SqlConnection conn = Conexion.obtenerconexion())
                {

                    conn.Open();
                    SqlCommand dd = new SqlCommand("UPDATE  Proveedor SET ESTADO= 'DESACTIVADO' WHERE Id_Proveedor = @IDPROVEEDOR", conn);
                    dd.Parameters.AddWithValue("@IDPROVEEDOR", Convert.ToInt64(txtId_Proveedor.Text));
                    dd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("El registro se ha desactivado correctamente!!", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                }


            }
        }



        void buscarid()
        {
            using (SqlConnection conn = Conexion.obtenerconexion())
            {
                conn.Open();
                string UU = "SELECT Id_Proveedor from Proveedor where Id_Proveedor = @identificador ";
                SqlCommand oo = new SqlCommand(UU,conn);
                oo.Parameters.AddWithValue("@identificador",txtId_Proveedor.Text);
                oo.ExecuteNonQuery();
                SqlDataReader registro = oo.ExecuteReader();
                if (registro.Read())
                {
                    BuscarId();
                    
                }
                else
                {
                    MessageBox.Show("El identificador no está asociado con ningún suplidor", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtId_Proveedor.Text = "";

                }
            }
        }
        void BuscarId()
        {
            using (SqlConnection conn = Conexion.obtenerconexion())
            {


                SqlCommand OO = new SqlCommand("Select Id_Proveedor from Proveedor where Id_Proveedor = @ID_Pro and ESTADO = 'ACTIVADO' ", conn);
                OO.Parameters.AddWithValue("@ID_Pro", txtId_Proveedor.Text);
                conn.Open();
                OO.ExecuteNonQuery();
                SqlDataReader Registro = OO.ExecuteReader();
                if (Registro.Read())
                {
                    Buscar();
                    Llenar();



                }

                else
                {

                    DialogResult Options1 = MessageBox.Show("El suplidor está desahibilitado", "Información Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (Options1 == DialogResult.OK)
                    {
                        DialogResult LECTURA = MessageBox.Show("¿Desea activarlo?", "Información importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (LECTURA == DialogResult.Yes)
                        {
                            using (SqlConnection con = Conexion.obtenerconexion())
                            {
                                con.Open();
                                string QUERY = "Update Proveedor  set ESTADO= 'ACTIVADO' where Id_Proveedor = @identificador";
                                SqlCommand update = new SqlCommand(QUERY, con);

                                update.Parameters.AddWithValue("@identificador", txtId_Proveedor.Text);
                                update.ExecuteNonQuery();

                                Buscar();
                                Llenar();
                                con.Close();
                            }
                        }
                        else
                        {

                            txtEmpresa.Text = "";
                            txtDireccion.Text = "";
                            txtRepresentante.Text = "";
                            txtTelefono.Text = "";


                        }
                    }

                }
            }
        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtId_Proveedor.Text = "";
           
            txtEmpresa.Text = "";
            txtTelefono.Text = "";
            txtRepresentante.Text = "";
            txtDireccion.Text = "";
            mostrardatos();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Eliminar();
            txtId_Proveedor.Text = "";
            txtEmpresa.Text = "";
            txtTelefono.Text = "";
            txtRepresentante.Text = "";
            txtDireccion.Text = "";
            mostrardatos();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtId_Proveedor.Text== "")
            {
                MessageBox.Show("Debe insertar un identificador", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                buscarid();
                
            }
            
        }

        private void H_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach(DataGridViewRow ROW in H.SelectedRows)
                {
                string a, b= "";
                a = this.H.CurrentRow.Cells[0].Value.ToString();
                b = this.H.CurrentRow.Cells[1].Value.ToString();

                Form11 suplidor = new Form11();
                foreach(Form ocle in Application.OpenForms)
                {
                   if (ocle.Name == "Form11")
                    {
                        suplidor = (Form11)ocle;

                        suplidor.txt_IdProveedor.Text = a;
                        suplidor.txtEmpresa.Text = b;
                        this.Hide();

                    }
                }


            }










        }

        private void H_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            H.Rows[e.RowIndex].Selected = true;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            mostrardatos();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Desactivados3 COL = new Desactivados3();
            COL.Show();
        }
    }








}
