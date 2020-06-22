using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace johanna
{
    public class CAMPOIN1
        
    {
        public static int Agregar(Campos CCampos)
        {
            
            int retorno = 0;
            using (SqlConnection conn = Conexion.obtenerconexion())
            {
                conn.Open();
                SqlCommand Comando = new SqlCommand(String.Format("Insert Into Clientes (Nombre,Apellido, Cedula, Telefono ,ESTADO) values ('{0}','{1}','{2}','{3}','ACTIVADO')",
                    CCampos.Nombres, CCampos.Apellido, CCampos.Cedula, CCampos.Telefono,  CCampos.Estado ), conn);
                retorno = Comando.ExecuteNonQuery();
                conn.Close();




         
            }
            return retorno;





        }
    }
}
