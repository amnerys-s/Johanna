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
    public partial class Desactivados3 : Form
    {
        public Desactivados3()
        {
            InitializeComponent();
            mostrardatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Conexion.obtenerconexion())
            {

                conn.Open();
                SqlCommand dd = new SqlCommand("UPDATE  Proveedor SET ESTADO= 'ACTIVADO' WHERE Id_Proveedor = @IDPROVEEDOR", conn);
                dd.Parameters.AddWithValue("@IDPROVEEDOR", Convert.ToInt64(textBox1.Text));
                dd.ExecuteNonQuery();
                mostrardatos();
                conn.Close();
                


            }
        }

        private void H_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void mostrardatos()
        {
            using (SqlConnection conn = Conexion.obtenerconexion())
            {
                SqlDataAdapter data = new SqlDataAdapter("Select Id_Proveedor,Empresa,Telefono,Direccion,Representante from Proveedor WHERE ESTADO = 'DESACTIVADO' ", conn);
                DataSet hola = new DataSet();
                data.Fill(hola, "Proveedor");
                this.H.DataSource = hola.Tables[0];

            }
        }
        int PosX = 0;
        int PosY = 0;
        private void Desactivados3_MouseMove(object sender, MouseEventArgs e)
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
    }


}
