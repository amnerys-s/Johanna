namespace johanna
{
    partial class Form11
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txt_IdProveedor = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtCod_Art = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtPrecio_u = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.HH = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtID_COMPRA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtArticlo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txtCargarLista = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HH)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(23, 25);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(210, 26);
            this.Fecha.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.txtEmpresa);
            this.groupBox3.Controls.Add(this.txt_IdProveedor);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(47, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(336, 122);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Proveedor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(125, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "ID";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(108, 58);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 15);
            this.label17.TabIndex = 14;
            this.label17.Text = "Empresa";
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(236, 24);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(77, 25);
            this.button9.TabIndex = 13;
            this.button9.Text = "Buscar";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(236, 73);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(77, 25);
            this.button10.TabIndex = 11;
            this.button10.Text = "Registrar";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(59, 77);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(152, 26);
            this.txtEmpresa.TabIndex = 10;
            this.txtEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_IdProveedor
            // 
            this.txt_IdProveedor.Location = new System.Drawing.Point(92, 29);
            this.txt_IdProveedor.Name = "txt_IdProveedor";
            this.txt_IdProveedor.Size = new System.Drawing.Size(91, 26);
            this.txt_IdProveedor.TabIndex = 9;
            this.txt_IdProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_IdProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IdProveedor_KeyPress);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::johanna.Properties.Resources.grupo;
            this.pictureBox3.Location = new System.Drawing.Point(15, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(280, 219);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(50, 20);
            this.txtCantidad.TabIndex = 47;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // txtCod_Art
            // 
            this.txtCod_Art.Location = new System.Drawing.Point(52, 219);
            this.txtCod_Art.Name = "txtCod_Art";
            this.txtCod_Art.Size = new System.Drawing.Size(50, 20);
            this.txtCod_Art.TabIndex = 46;
            this.txtCod_Art.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCod_Art.TextChanged += new System.EventHandler(this.txtCod_Art_TextChanged);
            this.txtCod_Art.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCod_Art_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(163, 448);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 19);
            this.label16.TabIndex = 44;
            this.label16.Text = "Total $";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(240, 449);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(55, 20);
            this.txttotal.TabIndex = 41;
            // 
            // txtPrecio_u
            // 
            this.txtPrecio_u.Location = new System.Drawing.Point(343, 220);
            this.txtPrecio_u.Name = "txtPrecio_u";
            this.txtPrecio_u.Size = new System.Drawing.Size(81, 20);
            this.txtPrecio_u.TabIndex = 38;
            this.txtPrecio_u.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrecio_u.TextChanged += new System.EventHandler(this.txtPrecio_u_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(346, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 19);
            this.label10.TabIndex = 35;
            this.label10.Text = "Precio/U.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(269, 197);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 19);
            this.label15.TabIndex = 34;
            this.label15.Text = "Cantidad";
            // 
            // HH
            // 
            this.HH.AllowUserToAddRows = false;
            this.HH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HH.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.HH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.HH.Location = new System.Drawing.Point(47, 245);
            this.HH.Name = "HH";
            this.HH.RowHeadersVisible = false;
            this.HH.Size = new System.Drawing.Size(459, 195);
            this.HH.TabIndex = 32;
            this.HH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HH_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cod_Art";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Articulo";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio_U";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Sub_Total";
            this.Column5.Name = "Column5";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtID_COMPRA);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Fecha);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(419, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 97);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Referencias:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::johanna.Properties.Resources.comercio__2_;
            this.button1.Location = new System.Drawing.Point(248, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 39);
            this.button1.TabIndex = 31;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtID_COMPRA
            // 
            this.txtID_COMPRA.Location = new System.Drawing.Point(156, 61);
            this.txtID_COMPRA.Name = "txtID_COMPRA";
            this.txtID_COMPRA.Size = new System.Drawing.Size(75, 26);
            this.txtID_COMPRA.TabIndex = 11;
            this.txtID_COMPRA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID_COMPRA.TextChanged += new System.EventHandler(this.txtID_COMPRA_TextChanged);
            this.txtID_COMPRA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_COMPRA_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "No de la compra";
            // 
            // txtArticlo
            // 
            this.txtArticlo.Location = new System.Drawing.Point(162, 219);
            this.txtArticlo.Name = "txtArticlo";
            this.txtArticlo.Size = new System.Drawing.Size(112, 20);
            this.txtArticlo.TabIndex = 51;
            this.txtArticlo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtArticlo.TextChanged += new System.EventHandler(this.txtArticlo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 52;
            this.label3.Text = "Articulo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(51, 197);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 19);
            this.label14.TabIndex = 45;
            this.label14.Text = "Cod.Art";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.txtCargarLista);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(575, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 195);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::johanna.Properties.Resources.basura__3_1;
            this.button4.Location = new System.Drawing.Point(29, 129);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 38);
            this.button4.TabIndex = 30;
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // txtCargarLista
            // 
            this.txtCargarLista.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargarLista.Image = global::johanna.Properties.Resources.mas__1_;
            this.txtCargarLista.Location = new System.Drawing.Point(29, 81);
            this.txtCargarLista.Name = "txtCargarLista";
            this.txtCargarLista.Size = new System.Drawing.Size(57, 42);
            this.txtCargarLista.TabIndex = 27;
            this.txtCargarLista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtCargarLista.UseVisualStyleBackColor = true;
            this.txtCargarLista.Click += new System.EventHandler(this.txtCargarLista_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::johanna.Properties.Resources.disco_flexible1;
            this.button3.Location = new System.Drawing.Point(29, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 42);
            this.button3.TabIndex = 24;
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::johanna.Properties.Resources.paquete_o_empaquetar__1_;
            this.button5.Location = new System.Drawing.Point(441, 206);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(43, 34);
            this.button5.TabIndex = 31;
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::johanna.Properties.Resources.investigacion1;
            this.button2.Location = new System.Drawing.Point(121, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 33);
            this.button2.TabIndex = 54;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Serif Black", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 31);
            this.label1.TabIndex = 55;
            this.label1.Text = "Registro de compras";
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(766, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtArticlo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtCod_Art);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtPrecio_u);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.HH);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form11";
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HH)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        public System.Windows.Forms.TextBox txtEmpresa;
        public System.Windows.Forms.TextBox txt_IdProveedor;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.TextBox txtCantidad;
        public System.Windows.Forms.TextBox txtCod_Art;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txttotal;
        public System.Windows.Forms.TextBox txtPrecio_u;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView HH;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txtArticlo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtID_COMPRA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button txtCargarLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
    }
}