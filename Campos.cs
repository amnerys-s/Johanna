using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace johanna
{
    public class Campos
    {

        public Int64 id { get; set; }
        public String Nombres { get; set; }
        public String Apellido { get; set; }
        public String Cedula { get; set; }
        public String Telefono { get; set; }
        public String Estado { get; set; }


        public Campos () { }
        public Campos(Int64 CId, String CNombre, String CApellido,String CCedula, String CTELEFONO, String CESTADO )
        {
            this.id = CId;
            this.Nombres = CNombre;
            this.Apellido = CApellido;
            this.Cedula = CCedula;
            this.Telefono = CTELEFONO;
            this.Estado = CESTADO;
        }
    }
}
