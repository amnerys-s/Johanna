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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.comprasge' Puede moverla o quitarla según sea necesario.
            this.comprasge1TableAdapter.Fill(this.DataSet1.comprasge1);

            this.reportViewer1.RefreshReport();
        }
    }
}
