using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace johanna
{
    public partial class Identificador_suplidorcs : Form
    {
        public Identificador_suplidorcs()
        {
            InitializeComponent();
        }
        public Int32 INT {get; set;}
        private void Identificador_suplidorcs_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.proveedor_especifico1' Puede moverla o quitarla según sea necesario.
            this.PROVEEDOR_ESPECIFICO_ACTIVADOTableAdapter.Fill(this.DataSet1.PROVEEDOR_ESPECIFICO_ACTIVADO, INT);

            this.reportViewer1.RefreshReport();
        }
    }
}
