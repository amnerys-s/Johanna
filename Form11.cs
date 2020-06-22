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
    public partial class Form11 : Form
    {
        int boton = 0;
        int col = 0;
        int d = 0;
        int e1 = 0;
        int e2 = 1;
        int boton1 = 0;
        public Form11()
        {
            InitializeComponent();
            //txtEmpresa.Enabled = false;
            //txtArticlo.Enabled = false;
            txtCantidad.Enabled = true;
            //txtPrecio_u.Enabled = false;
            Aumentarid();
             
        }

        private void Form11_Load(object sender, EventArgs e)
        {


        }

        void Aumentarid()
        {
            using (SqlConnection conn = Conexion.obtenerconexion())
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT(SELECT distinct top 1 ID_Compras FROM Compras order by ID_Compras desc) + 1 as ID_Compras  ", conn);

                SqlDataReader leer = cmd.ExecuteReader();
                if (leer.Read())
                {

                    txtID_COMPRA.Text = leer["ID_Compras"].ToString();

                }




               
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txt_IdProveedor.Text== "")
            {
                MessageBox.Show("Debe insertar un identificador", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                using (SqlConnection conn = Conexion.obtenerconexion())
                {

                    SqlCommand oo = new SqlCommand("Select Id_Proveedor, Empresa  from Proveedor where Id_Proveedor = @Id_Proveedor", conn);
                    oo.Parameters.AddWithValue("@Id_Proveedor", txt_IdProveedor.Text);

                    conn.Open();

                    oo.ExecuteNonQuery();
                    SqlDataReader klk = oo.ExecuteReader();

                    if (klk.Read())
                    {

                        B_Desactivados();


                    }
                    else
                    {
                        col++;
                        MessageBox.Show("El usuario no se encuentra en el sistema!! ", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txt_IdProveedor.Text = "";
                        if (col==2)
                        {
                            DialogResult c = MessageBox.Show("¿Desea Consultarlo", "Información importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (c == DialogResult.Yes)
                            {
                                Form11 COMI = new Form11();
                                COMI.Show();

                            }
                        }

                    }



                }

            }
        }
        void B_Desactivados()
        { using (SqlConnection conn = Conexion.obtenerconexion())
            {
                string desactivados = "Select Id_Proveedor, Empresa from Proveedor where Id_Proveedor = @identificador and ESTADO = 'ACTIVADO'";
                SqlCommand comando = new SqlCommand(desactivados, conn);
                conn.Open();
                comando.Parameters.AddWithValue("@identificador", txt_IdProveedor.Text);
                comando.ExecuteNonQuery();
                SqlDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    boton++;
                    txtEmpresa.Text =  lector["Empresa"].ToString();
                    conn.Close();
                }
                else
                {
                    DialogResult comando2 = MessageBox.Show("El suplidor está desactivado", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (comando2 == DialogResult.OK)
                    {
                        DialogResult comando3 = MessageBox.Show("¿Desea desactivarlo?", "InformacióM importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (comando3 == DialogResult.Yes)
                        {
                            Form12 SUPLIDOR = new Form12();
                            SUPLIDOR.Show();

                        }
                        else
                        {
                            txt_IdProveedor.Text = "";
                        }
                    }
                }
            }



        }
        private void button10_Click(object sender, EventArgs e)
        {
            Form12 oo = new Form12();
            oo.Show();
        }
          int c = 0;
        int a = 1;
        private void button4_Click(object sender, EventArgs e)
        {  

           
            using (SqlConnection conn = Conexion.obtenerconexion())
            {
                SqlCommand uu = new SqlCommand("Select Articulo,Cantidad, Precio_U from Producto Where Id_Pro = @Cod_Art", conn);
                uu.Parameters.AddWithValue("@Cod_Art", txtCod_Art.Text);
                conn.Open();
                uu.ExecuteNonQuery();
                SqlDataReader Lector = uu.ExecuteReader();
                if (c != a)
                {
                    if (Lector.Read())
                    {
                        txtArticlo.Text = Lector["Articulo"].ToString();
                        txtCantidad.Text = Lector["Cantidad"].ToString();
                        txtPrecio_u.Text = Lector["Precio_U"].ToString();
                        conn.Close();
                        c++;



                  }
                }

                else
                {
                    MessageBox.Show("El Producto no se encuentra en el sistema!!", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                

            }

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
           if (txtID_COMPRA.Text != "")
            { txtCantidad.Enabled = true; }
        }

        string[,] cargarlista = new string[200, 6];
        int Fila = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            txtCantidad.Enabled = true;
            if (txtID_COMPRA.Text == "" && txtEmpresa.Text == "" && txt_IdProveedor.Text == "")
            {
                MessageBox.Show("Debe Suplir los datos importantes", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCantidad.Enabled = true;
            }
           
            else
            {
                
                buscarid();
                txtCantidad.Enabled = true;
            }

        }
        void buscarid()
        {using (SqlConnection conn = Conexion.obtenerconexion())
            {
                string buscador = "Select ID_Compras from Compras where ID_Compras = @compras";
                SqlCommand cmd1 = new SqlCommand(buscador, conn);
                cmd1.Parameters.AddWithValue("@compras", txtID_COMPRA.Text);
                conn.Open();
                cmd1.ExecuteNonQuery();
                SqlDataReader lectura1 = cmd1.ExecuteReader();
                if (lectura1.Read())
                {
                    MessageBox.Show("El identificador ya se encuentra registrado en el sistema","Información importante", MessageBoxButtons.OK, MessageBoxIcon.Error
                        
                        );
                    txtID_COMPRA.Text = "";
                }
                else
                {
                    
                    

                        Compras();
                        Detalles_Compra();
                       
                    
                    //else
                    //{
                    //    MessageBox.Show("Necesita buscar el identficador para comprobar su existencia", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    txt_IdProveedor.Text = "";
                    //    button9.Focus();
                    //}
                }
            }
        }

        private void txtCargarLista_Click(object sender, EventArgs e)
        {
            if (txtCod_Art.Text != ""  && txtPrecio_u.Text != "" && txtCantidad.Text != "" && txtArticlo.Text != "")
            {
                try
                {

                    //if (e1 == 1)
                    {



                        cargarlista[Fila, 0] = txtCod_Art.Text;
                        cargarlista[Fila, 1] = txtArticlo.Text;
                        cargarlista[Fila, 2] = txtCantidad.Text;
                        cargarlista[Fila, 3] = txtPrecio_u.Text;
                        cargarlista[Fila, 4] = (float.Parse(txtCantidad.Text) * float.Parse(txtPrecio_u.Text)).ToString();




                      
                        HH.Rows.Add(
         cargarlista[Fila, 0], cargarlista[Fila, 1], cargarlista[Fila, 2], cargarlista[Fila, 3], cargarlista[Fila, 4]);
                        Fila++;

                        txtArticlo.Text = "";
                        txtCantidad.Text = "";
                        txtCod_Art.Text = "";
                        txtPrecio_u.Text = "";
                        e1 = 0;
                        txtCantidad.Enabled = false;
                    }
                    //else
                    //{
                    //    MessageBox.Show("Debe comprobar la existencia del producto seleccionado", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    button2.Focus();
                    //}
                }

                  
                


                catch
                {



                }

                total_klk();
                
            }
            //else
            //{
            //    MessageBox.Show("Debe insertar todos los datos");
            //    txtCod_Art.Text = "";
            //    txtCantidad.Text = "";
            //}
        }






        public void total_klk()
        {
            float total_mi_creizi = 0;
            int conteito = 0;

            conteito = HH.RowCount;
            for (int I = 0; I < conteito; I++)
            {
                total_mi_creizi += float.Parse(HH.Rows[I].Cells[4].Value.ToString());

               
            }

            txttotal.Text = total_mi_creizi.ToString();
        }

        void Compras ()
           {
            using (SqlConnection conn = Conexion.obtenerconexion())
            {
                string query = "INSERT INTO Compras (ID_Compras, Id_Proveedor, Fecha) values (@ID_compras,  @ID_Proveedor, @Fecha)";
                SqlCommand oo = new SqlCommand(query, conn);
                conn.Open();
                oo.Parameters.AddWithValue("@ID_Compras",txtID_COMPRA.Text);
                oo.Parameters.AddWithValue("@Id_Proveedor", txt_IdProveedor.Text);
                oo.Parameters.AddWithValue("@Fecha", Fecha.Value);
                oo.ExecuteNonQuery();
                conn.Close();

               


            }
            
            }

        private void button1_Click(object sender, EventArgs e)
        {
            txtArticlo.Text = "";
            txtCantidad.Text = "";
            txtEmpresa.Text = "";
          
            txtID_COMPRA.Text = "";
            txttotal.Text = "";
            txtPrecio_u.Text = "";
            txtCod_Art.Text = "";
            txt_IdProveedor.Text = "";
            HH.Rows.Clear();
                    
 
        }


        void Detalles_Compra()
        {
            {
                using (SqlConnection conn = Conexion.obtenerconexion())
                {
                    if ( txt_IdProveedor.Text == "")
                    { }
                    SqlCommand agregar = new SqlCommand("INSERT INTO Detalles_Com  values(@Identificador, @Identificador_producto, @Cantidad, @Precio_U, @Precio_T)", conn);
                    conn.Open();
                    try
                    {
                        foreach (DataGridViewRow row in HH.Rows)
                        {

                            agregar.Parameters.Clear();

                            agregar.Parameters.AddWithValue("@Identificador", txtID_COMPRA.Text);
                            agregar.Parameters.AddWithValue("@Identificador_producto", Convert.ToString(row.Cells["Column1"].Value));
                            agregar.Parameters.AddWithValue("@Cantidad", Convert.ToString(row.Cells["Column3"].Value));
                            agregar.Parameters.AddWithValue("@Precio_U", Convert.ToString(row.Cells["Column4"].Value));
                            agregar.Parameters.AddWithValue("@Precio_T", Convert.ToString(row.Cells["Column5"].Value));
                            agregar.ExecuteNonQuery();

                        }
                        MessageBox.Show("El Registro ha sido guardado correctamente!!", "Imformación importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                                               );
                    }

                    catch (Exception i)
                    {
                        MessageBox.Show("Error");
                    }
                    finally
                    {
                        conn.Close();
                    }





                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCantidad.Enabled = true;
            using (SqlConnection conn = Conexion.obtenerconexion())
            {
                SqlCommand uu = new SqlCommand("Select Id_Pro from Producto Where Id_Pro = @Cod_Art", conn);
                uu.Parameters.AddWithValue("@Cod_Art", txtCod_Art.Text);
                conn.Open();
                uu.ExecuteNonQuery();
                SqlDataReader Lector = uu.ExecuteReader();
               
                    if (Lector.Read())
                    {
                        Desactivar();
                        
                    


                    }
                

                else
                {
                    MessageBox.Show("El Producto no se encuentra en el sistema!!", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCod_Art.Text = "";
                   d++;
                    if (d==2)
                    {
                        DialogResult ok = MessageBox.Show("¿Desea consultarlo","Información importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if  (ok == DialogResult.Yes)
                        {
                            Form10 producto = new Form10();
                            producto.Show();
                        }
                    }
                }


            }
        }
        void Desactivar
            ()
        {
            using (SqlConnection conn = Conexion.obtenerconexion())
            {
                SqlCommand cmd = new SqlCommand("select ID_Pro, Articulo, Precio_U from Producto where ID_Pro = @pro and ESTADO ='ACTIVADO'", conn);
               
                cmd.Parameters.AddWithValue("@pro", txtCod_Art.Text);

                    conn.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader lector = cmd.ExecuteReader();
                if(lector.Read())
                {
                   Producto_bajo_cero();
                    conn.Close();
                }
                else
                {
                   DialogResult cim =MessageBox.Show("El producto está desactivado", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (cim == DialogResult.OK)
                    {
                        DialogResult resul = MessageBox.Show("¿Desea activarlo?", "Información importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resul ==DialogResult.Yes)
                        {
                            Form10 producto = new Form10();
                            producto.Show();
                        }
                        else

                        {
                            txtCod_Art.Text = "";
                        }
                    }
                }
            }
        }
        void Producto_bajo_cero()
        {using (SqlConnection conn = Conexion.obtenerconexion())
            {
                SqlCommand cero = new SqlCommand("Select ID_Pro, Articulo, Precio_U FROM Producto where ID_Pro = @pro aND ESTADO ='ACTIVADO'", conn);
                cero.Parameters.AddWithValue("@pro",txtCod_Art.Text);
                conn.Open();
                cero.ExecuteNonQuery();
                SqlDataReader LECTURI = cero.ExecuteReader();
                if(LECTURI.Read())
                {
                    e1 = 1;
                    txtArticlo.Text = LECTURI["Articulo"].ToString();
                    
                    txtPrecio_u.Text = LECTURI["Precio_U"].ToString();
                    
               



                    conn.Close();
                }
                else
                {
                  
                }
            }

        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            HH.Rows.Remove(HH.CurrentRow);
            total_klk();
            int a = 1;
            if (a ==1)
                {
                total_klk();
            }
        }

        private void HH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_IdProveedor_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCod_Art_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsControl(e.KeyChar
                ))
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

        private void txtID_COMPRA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else if (Char.IsDigit (e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;

            }
        }

        private void txtID_COMPRA_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Aumentarid();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form10 coco = new Form10();
            coco.Show();
            txtCantidad.Enabled = true;

        }

        private void txtArticlo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCod_Art_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_u_TextChanged(object sender, EventArgs e)
        {

        }
    }

    }

