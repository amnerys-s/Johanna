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
{
    public partial class Form1 : Form
    {
        int o = 0;
        int u = 0;
        int igualdad = 0;
        int Boton_factura = 0;
        int ok = 0;
        int ok1 = 0;
        int Boton_pro = 0;
        int boton_prod = 0;
        
        
        public Form1()
        {
            InitializeComponent();
           
           //txtArticulo.Enabled = false; 
           // txtApellido.Enabled =  false;
           // txtDevuelto.Enabled = false;
           // txtNombre.Enabled = fals e;
           // txtTotal.Enabled = false;
           // txtPrecio_U.Enabled = false;
           // txtCantidad.Enabled = false;
            Aumentarid();
            txtId_Cliente.Focus();
        }

        public void COSTOAPAGAR()
        {
            float CostoTotal = 0;
            int Conteo = 0;
            int plu = 0;

            Conteo = Datos.RowCount;
            for (int I = 0; I < Conteo; I++)
            {
                                    CostoTotal += float.Parse(Datos.Rows[I].Cells[4].Value.ToString());
                


            }

            txtTotal.Text = CostoTotal.ToString();
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (txtArticulo.Text != "")
            {
                txtCantidad.Enabled = true;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }


      void Aumentarid()
        {
            using (SqlConnection conn = Conexion.obtenerconexion())
            {
            
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT(SELECT distinct top 1  Id_factura FROM Factura order by Id_factura desc) + 1 as Id_factura", conn);

            SqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {

               txtId_Factura.Text = leer["Id_factura"].ToString();
                    
}

           



        }

}

        private void Form1_Load(object sender, EventArgs e)
        {

            txtId_Cliente.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            txtId_Cliente.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtId_Factura.Text = "";
            txtIngresado.Text = "";
            txtTotal.Text = "";
            txtDevuelto.Text = "";
            txtPrecio_U.Text = "";

            txtArticulo.Text = "";
            txtCantidad.Text = "";

            Datos.Rows.Clear();


        }

        private void tot_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {


        }

        string[,] CargarListado = new string[200, 6];
        int Fila = 0;
        private void txtCargarLista_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCod_Ar.Text != "" && txtArticulo.Text != "" && txtCantidad.Text != "" && txtPrecio_U.Text != "")
                {

                    CargarListado[Fila, 0] = txtCod_Ar.Text;
                    CargarListado[Fila, 1] = txtArticulo.Text;
                    CargarListado[Fila, 2] = txtPrecio_U.Text;
                    CargarListado[Fila, 3] = txtCantidad.Text;

                    CargarListado[Fila, 4] = (float.Parse(txtPrecio_U.Text) * float.Parse(txtCantidad.Text)).ToString();

                    Datos.Rows.Add(CargarListado[Fila, 0], CargarListado[Fila, 1], CargarListado[Fila, 2], CargarListado[Fila, 3], CargarListado[Fila, 4]);


                    Fila++;


                    txtCantidad.Text = "";
                    txtArticulo.Text = "";
                    txtPrecio_U.Text = "";
                    txtCod_Ar.Text = "";




                }

                COSTOAPAGAR();


            }
            catch
            {



            }









        }

        private void txtDevuelto_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtIngresado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtId_Cliente.Text == "")
            {
                MessageBox.Show("Debe insertar un indentificador", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

               Buscar();
                
            }






        }




        void Buscar()
        {
            using (SqlConnection conn = Conexion.obtenerconexion())
            {

                SqlCommand uu = new SqlCommand("Select Id_Cliente, Nombre, Apellido from Clientes Where Id_Cliente = @Id_Cliente", conn);
                uu.Parameters.AddWithValue("@Id_Cliente", txtId_Cliente.Text);
                conn.Open();
                uu.ExecuteNonQuery();

                SqlDataReader Lectura = uu.ExecuteReader();
                if (Lectura.Read())
                {
                    DESACTIVAR();
                   

                    conn.Close();

                }
                else
                {
                    MessageBox.Show("El usuario no se encuentra en el sistema!!", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



                    txtApellido.Text = "";
                    txtId_Cliente.Text = "";
                    txtNombre.Text = "";
                    u++;
                    if (u == 2)
                    {
                        DialogResult op = MessageBox.Show("¿Desea consultarlo?", "Información importante", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (op == DialogResult.Yes)
                        {
                            Form9 OO = new Form9();
                            OO.Show();
                            u = 0;
                        }
                    }
                }
            }


        }
        void DESACTIVAR()
        {
            using (SqlConnection oo = Conexion.obtenerconexion())
            {
                string q = "SELECT Id_Cliente, Nombre, Apellido from Clientes where Id_Cliente = @identificador and ESTADO = 'ACTIVADO'";
                SqlCommand co = new SqlCommand(q, oo);
                co.Parameters.AddWithValue("@identificador", txtId_Cliente.Text);
                oo.Open();
                co.ExecuteNonQuery();
                SqlDataReader lector = co.ExecuteReader();
                if(lector.Read())
                {

                    txtNombre.Text = lector["Nombre"].ToString();
                    txtApellido.Text = lector["Apellido"].ToString();
                    Boton_pro = 1;
                }

                else
                {
                   DialogResult op = MessageBox.Show("El cliente está desactivado","Información importante",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    if (op == DialogResult.OK)
                    {
                        DialogResult opi = MessageBox.Show("¿Desea desactivarlo?", "Información importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (opi == DialogResult.Yes)
                        {
                            Form9 CLIENTE = new Form9();
                            CLIENTE.Show();

                        }
                        else
                            {
                            txtId_Cliente.Text = "";
                        }
                    }
                }
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            

        }
       

        private void button4_Click(object sender, EventArgs e)
        {   
            if (txtCod_Ar.Text == "")
            {
                MessageBox.Show("Debe insertar un identificador", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                Producto();
            }


        }
        
        void Producto()
        {

            using (SqlConnection conn = Conexion.obtenerconexion())
            {
                
                SqlCommand uu = new SqlCommand("Select ID_Pro from Producto Where ID_Pro = @Id_Producto", conn);
                uu.Parameters.AddWithValue("@Id_Producto", txtCod_Ar.Text);
                conn.Open();
                uu.ExecuteNonQuery();
                SqlDataReader Lecture = uu.ExecuteReader();
                if (Lecture.Read())
                {

                    desactivar();
                    conn.Close();


                }


                else
                {
                   
                   
                       DialogResult options = MessageBox.Show("El Producto no se encuentra en el sistema!!", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    o++;

                    txtCantidad.Text = "";
                    txtArticulo.Text = "";
                    txtPrecio_U.Text = "";
                    txtCod_Ar.Text = "";
                    if (options == DialogResult.OK && o==2)
                        {
                           DialogResult OPTIONS2 = MessageBox.Show("¿Desea desactivarlo?", "Información importante", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (OPTIONS2 == DialogResult.Yes)
                        {
                            Form10 col = new Form10();
                           col.Show();
                            o = 0;
                        }
                        }
                        
                    }
                }
            



        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form9 oo = new Form9();
            oo.Show();
        }


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {




        }

        int b = 0;

        void desactivar()
        {
            using (SqlConnection COL = Conexion.obtenerconexion())
            {
                string POL = "Select ID_Pro from Producto where ID_Pro = @identificador and ESTADO = 'ACTIVADO' ";
                SqlCommand OO = new SqlCommand(POL, COL);
                OO.Parameters.AddWithValue("@identificador", txtCod_Ar.Text);
                COL.Open();
                OO.ExecuteNonQuery();
               
                SqlDataReader lector = OO.ExecuteReader();
                if (lector.Read())
                {

                    producto_bajo_cero();
                    COL.Close();
                }
                else
                {
                    DialogResult op = MessageBox.Show("El producto seleccionado está desactivado", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (op == DialogResult.OK)
                    {
                        DialogResult opi = MessageBox.Show("¿Desea activarlo?", "Información importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (opi == DialogResult.Yes)
                        {
                            Form10 producto  = new Form10();
                            producto.Show();

                        }
                        else
                        {
                            txtCod_Ar.Text = "";
                        }

                    }





                }
            }
        }

        void Factura()
        {
            using (SqlConnection conn = Conexion.obtenerconexion())
            {

                //if (b == 0)
                //{
                    string query = " insert into Factura (Id_Factura,Id_Cliente,Fecha) values(@Id_factura, @Id_Cliente, @Fecha)";
                    SqlCommand uu = new SqlCommand(query, conn);
                    conn.Open();
                    uu.Parameters.AddWithValue("@Id_factura", txtId_Factura.Text);
                    uu.Parameters.AddWithValue("@Id_Cliente", txtId_Cliente.Text
                        );
                    uu.Parameters.AddWithValue("@Fecha", fecha.Value);

                    uu.ExecuteNonQuery();
                    b++;
                    conn.Close();

                //}
                //else
                //{

                //    MessageBox.Show("El identificador ya se encuentra en el sistema!!", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //}

            }


        }

        void DetalleFactura()
        {
            using (SqlConnection conn = Conexion.obtenerconexion())
            {
                SqlCommand agregar = new SqlCommand("INSERT INTO Detalles_Fac  values( @Identificador, @Identificador_producto, @Cantidad, @Precio_U, @Precio_T)", conn);
                conn.Open();
                try
                {
                    foreach (DataGridViewRow row in Datos.Rows)
                    {

                        agregar.Parameters.Clear();

                        agregar.Parameters.AddWithValue("@Identificador", txtId_Factura.Text);
                        agregar.Parameters.AddWithValue("@Identificador_producto", Convert.ToString(row.Cells["Cod_art"].Value));
                        agregar.Parameters.AddWithValue("@Cantidad", Convert.ToString(row.Cells["Cantidad"].Value));
                        agregar.Parameters.AddWithValue("@Precio_U", Convert.ToString(row.Cells["Precio_U"].Value));
                        agregar.Parameters.AddWithValue("@Precio_T", Convert.ToString(row.Cells["Sub_Total"].Value));
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

        int bol = 0;
        string lectura = string.Empty;


        //Controlar la insercio numerica
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtId_Factura.Text == "")

            { MessageBox.Show("Debe insertar un identificador para la factura", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId_Factura.Focus();
            }
           
            else
            
            
            //if /*(Boton_factura == 1 && Boton_pro == 1)*/
            {
                   
                    Boton_pro = 0;


                    Buscar_id();
                    

              
           // }
           // else
           //         if (Boton_factura == 1 && Boton_pro ==0)
           //     {
           //         MessageBox.Show("Debe comprobar la existencia del identificador", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
           //     button4.Focus();
           //     }
           //else 
           //         if(Boton_pro == 1 && Boton_factura ==0)

           //     {
           //         MessageBox.Show("Debe comprobar la existencia del identificador","Información importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
           //     button9.Focus();
           // }
           //else if (Boton_pro ==0  && Boton_factura ==0)
           // {
           //     MessageBox.Show("Debe comprobar la existencia de ambos identificadores", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
           //     boton_prod = 1;
                
                

           // }
            
                
            }
             }

        
    
        

        private void txtIngresado_TextChanged_1(object sender, EventArgs e)
        {
            hello();
            
        }

        void hello()
        {

        
            try
            {
                txtDevuelto.Text = (float.Parse(txtIngresado.Text) - float.Parse(txtTotal.Text)).ToString();
            }
            catch
            {

            }
        
        }
        private void txtPrecio_U_TextChanged(object sender, EventArgs e)
        {

        }

        void Buscar_id ()
            {
            using (SqlConnection conn = Conexion.obtenerconexion())
            {
                SqlCommand uu = new SqlCommand("Select Id_Factura from Factura where Id_factura = @ID_FACTURA", conn);
                uu.Parameters.AddWithValue("@ID_FACTURA", txtId_Factura.Text);
                conn.Open();
                uu.ExecuteNonQuery();

                SqlDataReader lector = uu.ExecuteReader();
                if (lector.Read())
                {
                    txtId_Factura.Text = lector["Id"].ToString();

                    conn.Close();
                    MessageBox.Show("El identificador se encuentra en el sistema!!", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                       );

                    txtId_Factura.Text = "";
                    txtId_Factura.Focus();
                    ok = 1;
                    
            }

                //else
                //{
                //    if (txtId_Cliente.Text == "")
                //    {
                //        MessageBox.Show("Debe suplir un identificador", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        txtId_Cliente.Focus();
                    //}

                    //else if (Boton_factura == 1)
                    //{
                        else /*(Boton_pro == 1)*/
                        {
                            Factura();
                            DetalleFactura();
                        }
                    //    else
                    //    {
                    //        MessageBox.Show("Necesita comprobar la existencia del identificador", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //        button4.Focus();
                    //    }

                    //}

                    //else
                    //{
                    //    MessageBox.Show("Necesita comprobar la existencia del identificador", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    button9.Focus();
                    //}
                //}

            }
    }
        void Buscarpro()
        { using (SqlConnection conn = Conexion.obtenerconexion())

            {
                conn.Open();
                string q = "Select ID_Pro from Productos where ID_PRO = @ID_PRO";
                SqlCommand UU = new SqlCommand(q, conn);
                UU.Parameters.AddWithValue("@ID_PRO", txtCod_Ar.Text);
                UU.ExecuteNonQuery();
                SqlDataReader REGISTRO = UU.ExecuteReader();
                if (REGISTRO.Read())
                {

                }


            }


        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (igualdad == 0)
            {

                Datos.Rows.Remove(Datos.CurrentRow);
                COSTOAPAGAR();
                igualdad++;
                if (igualdad >0)
                {
                    hello();
                    igualdad = 0;
                    txtDevuelto.Text = "";
                    txtIngresado.Text = "";
                }
                
            }
        }

        private void Datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
        
         private void txtId_Factura_KeyPress(object sender, KeyPressEventArgs e, char key)
        {

            


        }

        private void txtId_Factura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
      if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        private void txtId_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                
            }
            else
                if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

            }

        }
        

                void producto_bajo_cero()
        {
            using (SqlConnection oo = Conexion.obtenerconexion())
            {
                string qo = "Select ID_Pro,Articulo, Cantidad, Precio_U FROM Producto where ID_Pro = @pro and  ESTADO = 'ACTIVADO' AND Cantidad >0";
                SqlCommand col = new SqlCommand(qo, oo);
                col.Parameters.AddWithValue("@pro", txtCod_Ar.Text);
                oo.Open();
                col.ExecuteNonQuery();
                SqlDataReader comi = col.ExecuteReader();
            if (comi.Read())
                {

                    txtArticulo.Text = comi["Articulo"].ToString();
                    txtCantidad.Text = comi["Cantidad"].ToString();
                    txtPrecio_U.Text = comi["Precio_U"].ToString();
                    Boton_pro = 1;



                }
            else
                {

                    


                    MessageBox.Show("No puede realizar la compra;no hay más existencia del producto selecionado", "Información importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCod_Ar.Text = "";

                }



            }
        }

        private void txtCod_Ar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }


        private void button7_Click(object sender, EventArgs e)
        {
            //Aumentarid();
            Conexion.creaa_ticket Ticket1 = new Conexion.creaa_ticket();
            Ticket1.TextoCentro("              * Ferreteria La Solución *    *"); //imprime una linea de descripcion
            //Ticket1.TextoCentro("*****");

            Ticket1.TextoIzquierda("Buenvaventura II, calle Circunvalación ");
            Ticket1.TextoIzquierda("809-333-1222");
            Ticket1.TextoIzquierda("023");
            Ticket1.TextoIzquierda("");
            Ticket1.TextoCentro("Factura de Venta"); //imprime una linea de descripcion
            Ticket1.TextoIzquierda("No.Fac: " + txtId_Factura.Text);
            Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + "" + " Hora:" + DateTime.Now.ToShortTimeString());
            Ticket1.TextoIzquierda("Atendido por: " + "Emiliano Perez " );//////////////////////////////////////////////////
            Ticket1.TextoIzquierda("");
            Conexion.creaa_ticket.LineasGuion();

            Conexion.creaa_ticket.EncabezadoVenta();
            Conexion.creaa_ticket.LineasGuion();
            foreach (DataGridViewRow r in Datos.Rows)
            { //                        Nombre del articulo                Precio                                   Cantidad                                SubTotal 


                Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), double.Parse(r.Cells[2].Value.ToString()), int.Parse(r.Cells[3].Value.ToString()), double.Parse(r.Cells[4].Value.ToString()));//imprime una linea de descripcion
                                                                                                                                                                                                  //imprime una linea de descripcion
            }
            //Ticket1.AgregaArticulo(DesPro.Text,double.Parse (PrecioPro.Text),int.Parse (ca.Text),double.Parse( "123"));

            Conexion.creaa_ticket.LineasGuion();
            //Ticket1.AgregaTotales("Sub-Total", int.Parse("0")); // imprime linea con total
            //Ticket1.AgregaTotales("Menos Descuento", int.Parse("0")); // imprime linea con total
            //Ticket1.AgregaTotales("Mas ITBIS", int.Parse("0")); // imprime linea con total
            //Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Total", int.Parse(txtTotal.Text)); // imprime linea con total
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Efectivo Entregado:", int.Parse(txtIngresado.Text));
            Ticket1.AgregaTotales("Efectivo Devuelto:", int.Parse(txtDevuelto.Text));


            // Ticket1.LineasTotales(); // imprime linea 

            Ticket1.TextoIzquierda(" ");
            //Ticket1.TextoCentro("******");
            Ticket1.TextoCentro("              * Gracias por preferirnos *    *");

            //Ticket1.TextoCentro("******");
            Ticket1.TextoIzquierda(" ");
            string impresora = "Microsoft XPS Document Writer"; //mpueden usar variable
            Ticket1.ImprimirTiket(impresora);
            //hasta aqui el codigo de imprimir



            /*  while (dataGridView1.RowCount > 0)//limpia el dgv
              { dataGridView1.Rows.Remove(dataGridView1.CurrentRow); }
              //LBLIDnuevaFACTURA.Text = ClaseFunciones.ClsFunciones.IDNUEVAFACTURA().ToString();
              txtPago.Text = idproducto.Text = DesPro.Text = PrecioPro.Text = CantidadPro.Text = txtPago.Text = "";
              lblDevolucion.Text = lblTotalAPagar.Text = "$0.00";*/
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Aumentarid();
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            Form10 coco = new Form10();
            coco.Show();
    }
    }
}
