﻿using System;
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
    public partial class Proveedor : Form
    {
        public Proveedor()
        {
            InitializeComponent();
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Proveedor' Puede moverla o quitarla según sea necesario.
            this.ProveedorTableAdapter.Fill(this.DataSet1.Proveedor);

            this.reportViewer1.RefreshReport();
        }
    }
}
