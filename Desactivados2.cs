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
    public partial class Desactivados2 : Form
    {
        public Desactivados2()
        {
            InitializeComponent();

            Mostrardatos();
        }

        private void Desactivados2_Load(object sender, EventArgs e)
        {

        }
        int PosX = 0;
        int PosY = 0;
        private void Desactivados2_MouseMove(object sender, MouseEventArgs e)
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
        void Mostrardatos()
        {
            using (SqlConnection conn = Conexion.obtenerconexion())
            {


                SqlDataAdapter cc = new SqlDataAdapter("SELECT  ID_Pro, Articulo, Cantidad,Precio_U,Id_Proveedor FROM Producto where ESTADO = 'DESACTIVADO'", conn);
                DataSet gg = new DataSet();
                cc.Fill(gg, "Producto");
                this.HH.DataSource = gg.Tables[0];


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                using (SqlConnection con = Conexion.obtenerconexion())
                {
                    con.Open();
                    string QUERY = "Update Producto  set ESTADO= 'ACTIVADO' where ID_Pro = @identificador";
                    SqlCommand update = new SqlCommand(QUERY, con);

                    update.Parameters.AddWithValue("@identificador",textBox1.Text);
                    update.ExecuteNonQuery();
                Mostrardatos();

                    
                    con.Close();
                }
    
}

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}