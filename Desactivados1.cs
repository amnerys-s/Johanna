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
    
    public partial class Desactivados1 : Form
    {
        int compa = 0;
        public Desactivados1()
        {
            InitializeComponent();
            Mostrardatos();
            
        }

        private void Desactivados1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void Mostrardatos()
        {
            using (SqlConnection conn = Conexion.obtenerconexion())
            {

                SqlDataAdapter datos = new SqlDataAdapter("SELECT Id_Cliente,Nombre,Apellido,Cedula,Telefono FROM Clientes where ESTADO ='DESACTIVADO'", conn);
                DataSet hola = new DataSet();
                datos.Fill(hola, "Clientes");
                this.bueno.DataSource = hola.Tables[0];
            }
        }
        int PosX = 0;
        int PosY = 0;
        private void Desactivados1_MouseMove(object sender, MouseEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = Conexion.obtenerconexion())
            {
                string queryUpdate = "UPDATE Clientes SET ESTADO = 'ACTIVADO' WHERE Id_Cliente = @ID";
                SqlCommand update = new SqlCommand(queryUpdate, con);
                con.Open();
                update.Parameters.AddWithValue("@ID", textBox1.Text);
                update.ExecuteNonQuery();
                con.Close();
                compa++;
                Mostrardatos();
               
                
            }
    }
}
}
