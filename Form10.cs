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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            Mostrardatos();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            txtId_PRO.Focus();
                }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { if (txtARTICULO.Text == "" && txtIDPROV.Text == "")


            {
                MessageBox.Show("No está supliendo los datos importantes", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            using (SqlConnection conn = Conexion.obtenerconexion())
            {
                string query = "insert into Producto (Articulo,Cantidad,Precio_U,Id_Proveedor,ESTADO) values (@Articulo, @Cantidad,  @Precio_U, @Id_Proveedor,'ACTIVADO')";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Articulo", txtARTICULO.Text);
                cmd.Parameters.AddWithValue("@Cantidad", txtCANTIDAD.Text);
                cmd.Parameters.AddWithValue("@Precio_U", txtPRECIO.Text);
                cmd.Parameters.AddWithValue("@Id_Proveedor", txtIDPROV.Text
                    );

                cmd.ExecuteNonQuery();


                MessageBox.Show("El Registro ha sido guardado correctamente", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Mostrardatos();

                txtARTICULO.Text = "";
                txtId_PRO.Text = "";
                txtCANTIDAD.Text = "";
                txtIDPROV.Text = "";
                txtPRECIO.Text = "";
                textBox1.Text = "";



            }



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {




        }

        void Mostrardatos()
        {
            using (SqlConnection conn = Conexion.obtenerconexion())
            {


                SqlDataAdapter cc = new SqlDataAdapter("SELECT  ID_Pro, Articulo, Cantidad,Precio_U,Id_Proveedor FROM Producto where ESTADO = 'ACTIVADO'", conn);
                DataSet gg = new DataSet();
                cc.Fill(gg, "Producto");
                this.HH.DataSource = gg.Tables[0];


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtId_PRO.Text == "")
            {
                MessageBox.Show("Debe insertar un identificador", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Update();

                Mostrardatos();
            }


        }

        void Update()
        { using (SqlConnection conn = Conexion.obtenerconexion())
            {
                string query = "UPDATE Producto SET  Articulo = @Articulo, Cantidad = @Cantidad, Precio_U = @Precio_U, Id_Proveedor = @Id_Proveedor WHERE Id_Pro = @Id_Pro";
                SqlCommand ggo = new SqlCommand(query, conn);
                conn.Open();

                ggo.Parameters.AddWithValue("@Id_Pro", txtId_PRO.Text);
                ggo.Parameters.AddWithValue("@Articulo", txtARTICULO.Text);
                ggo.Parameters.AddWithValue("@Cantidad", txtCANTIDAD.Text);
                ggo.Parameters.AddWithValue("@Precio_U", txtPRECIO.Text);
                ggo.Parameters.AddWithValue("@Id_Proveedor", txtIDPROV.Text);
                ggo.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("El registro ha sido actualizado correctamente", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);





            }


        }

        private void button1_Click(object sender, EventArgs e)
        {




        }
        // funciona de la misma forma que Mostrardatoss() 
        void Buscar()
        { using (SqlConnection conn = Conexion.obtenerconexion())
            {
                SqlDataAdapter yy = new SqlDataAdapter(" SELECT ID_Pro ,Articulo,Cantidad,Precio_U,Id_Proveedor FROM Producto WHERE ID_Pro =" + Convert.ToInt32(this.txtId_PRO.Text + ""), conn);
                DataSet dd = new DataSet();
                yy.Fill(dd, "Producto");
                this.HH.DataSource = dd.Tables[0];




            }



        }

        void LlenarCampos()
        {
            using (SqlConnection conn = Conexion.obtenerconexion())
            {
                conn.Open();
                string query = "SELECT Articulo,Cantidad,Precio_U,Id_Proveedor FROM Producto Where Id_Pro = @Identificador and ESTADO= 'ACTIVADO' ";
                SqlCommand uu = new SqlCommand(query, conn);
                uu.Parameters.AddWithValue("@Identificador", txtId_PRO.Text);
                uu.ExecuteNonQuery();
                SqlDataReader Registro = uu.ExecuteReader();
                if (Registro.Read())
                {

                    txtARTICULO.Text = Registro["Articulo"].ToString();
                    txtCANTIDAD.Text = Registro["Cantidad"].ToString();
                    txtPRECIO.Text = Registro["Precio_U"].ToString();
                    txtIDPROV.Text = Registro["Id_Proveedor"].ToString();

                    conn.Close();



                }



            }




        }
        void Eliminar()
        {
            using (SqlConnection conn = Conexion.obtenerconexion())
            {
                conn.Open();
                SqlCommand uu = new SqlCommand("Update Producto  set ESTADO = 'DESACTIVADO' WHERE ID_Pro = @Id_Pro", conn);
                uu.Parameters.AddWithValue("@Id_Pro", Convert.ToInt64(txtId_PRO.Text));
                uu.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("El registro se ha desactivado correctamente!!", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtARTICULO.Text = "";
                txtId_PRO.Text = "";
                txtCANTIDAD.Text = "";
                txtIDPROV.Text = "";
                txtPRECIO.Text = "";

            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            ;
        }

        int PosX = 0;
        int PosY = 0;
        private void Form10_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left
                )
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

        private void button3_Click_1(object sender, EventArgs e)
        {

            txtARTICULO.Text = "";
            txtId_PRO.Text = "";
            txtCANTIDAD.Text = "";
            txtIDPROV.Text = "";
            txtPRECIO.Text = "";
            textBox1.Text = "";
            Mostrardatos();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (txtId_PRO.Text == "")
            {
                MessageBox.Show("Debe insertar un identificador", "Información Importante ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                Busquedad();


            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtId_PRO.Text == "")
            {
                MessageBox.Show("Debe insertar un identificador", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Eliminar();
                txtId_PRO.Text = "";
                Mostrardatos();
            }
        }


        private void HH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void BuscarId()
        { using (SqlConnection conn = Conexion.obtenerconexion())
            {
                
                
                SqlCommand OO = new SqlCommand("Select ID_Pro from Producto where ID_Pro = @ID_Pro and ESTADO = 'ACTIVADO' ",conn);
                OO.Parameters.AddWithValue("@ID_Pro",txtId_PRO.Text);
                conn.Open();
                OO.ExecuteNonQuery();
                SqlDataReader Registro = OO.ExecuteReader();
                if (Registro.Read())
                {
                    LlenarCampos();
                    Buscar();
                    

                   
                }

                else
                {

                   DialogResult Options1= MessageBox.Show("El producto está desahibilitado", "Información Importante",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (Options1 == DialogResult.OK)
                    {
                        DialogResult LECTURA = MessageBox.Show("¿Desea activarlo?", "Información importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (LECTURA == DialogResult.Yes)
                        {
                            using (SqlConnection con = Conexion.obtenerconexion())
                            {
                                con.Open();
                                string QUERY = "Update Producto  set ESTADO= 'ACTIVADO' where ID_Pro = @identificador";
                                SqlCommand update = new SqlCommand(QUERY, con);

                                update.Parameters.AddWithValue("@identificador", txtId_PRO.Text);
                                update.ExecuteNonQuery();


                                LlenarCampos();
                                Buscar();
                                con.Close();
                            }
                        }
                        else
                        {
                           
                            txtARTICULO.Text = "";
                            txtId_PRO.Text = "";
                            txtCANTIDAD.Text = "";
                            txtIDPROV.Text = "";
                            txtPRECIO.Text = "";

                        }
                    }
                 
                }
            }


      

        }
        private void HH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            HH.Rows[e.RowIndex].Selected = true;
        }
        void Busquedad()
        {using (SqlConnection conn = Conexion.obtenerconexion())
            {
                conn.Open();
                string query = "Select ID_Pro from Producto where ID_Pro = @ID_Pro";
                SqlCommand BUSQUEDAD = new SqlCommand(query, conn);
                BUSQUEDAD.Parameters.AddWithValue("@ID_Pro",txtId_PRO.Text);
                
                BUSQUEDAD.ExecuteNonQuery();
                SqlDataReader LECTURA = BUSQUEDAD.ExecuteReader();
                if (LECTURA.Read())
                {
                    BuscarId();

                }
                else
                {
                    MessageBox.Show("El identificador no pertenece a ningún cliente", "Información importante",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void HH_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (DataGridViewRow row in HH.SelectedRows)
                {
                string a, b, c,d = "";
                a = this.HH.CurrentRow.Cells[0].Value.ToString();
                b = this.HH.CurrentRow.Cells[1].Value.ToString();
                c = this.HH.CurrentRow.Cells[2].Value.ToString();
                d = this.HH.CurrentRow.Cells[3].Value.ToString();

                Form1 FACTURA = new Form1();
                Form11 suplidor = new Form11();
                foreach (Form oo in Application.OpenForms)
                {
                    if (oo.Name == "Form1")
                    {
                        FACTURA = (Form1)oo;
                        FACTURA.txtCod_Ar.Text = a;
                        FACTURA.txtArticulo.Text = b;
                        FACTURA.txtPrecio_U.Text = d;
                        this.Hide();
                        // si no hay nada en el stock que no permita la insercion 


                    }

                    else
                    if (oo.Name == "Form11")
                    {


                        suplidor = (Form11)oo;

                        suplidor.txtCod_Art.Text = a;
                        suplidor.txtArticlo.Text = b;
                 
                        suplidor.txtPrecio_u.Text = d;
                        this.Hide();

                    }





                }

            }
        }

        private void Form10_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void groujjpBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conn = Conexion.obtenerconexion())
            {
                SqlCommand yoyo = new SqlCommand("select Empresa from Proveedor where Id_Proveedor = @prov", conn);
                conn.Open();
                yoyo.Parameters.AddWithValue("@prov", txtIDPROV.Text);
                yoyo.ExecuteNonQuery();
                SqlDataReader loo = yoyo.ExecuteReader();
                if (loo.Read())
                {
                    textBox1.Text = loo["Empresa"].ToString();
                }
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Mostrardatos();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Desactivados2 co = new Desactivados2();
            co.Show();
        }
    }

} 
