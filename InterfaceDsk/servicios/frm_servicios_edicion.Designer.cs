namespace interfacedsk.servicios
{
    partial class frm_servicios_edicion
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
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btngrabar = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtcantidadstock = new dhsoft.TextBoxNew(this.components);
            this.txtprecio = new dhsoft.TextBoxNew(this.components);
            this.btnbuscarimg = new System.Windows.Forms.Button();
            this.txtfechaexpiracion = new dhsoft.MaskedTextBoxNew();
            this.label21 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txthorariodesc = new dhsoft.TextBoxNew(this.components);
            this.txtidhorario = new dhsoft.TextBoxNew(this.components);
            this.txtfotoprincipal = new dhsoft.TextBoxNew(this.components);
            this.txtcodigo = new dhsoft.TextBoxNew(this.components);
            this.txttiempogarantia = new dhsoft.TextBoxNew(this.components);
            this.txtdescripcion = new dhsoft.TextBoxNew(this.components);
            this.txtnombre = new dhsoft.TextBoxNew(this.components);
            this.txtrucproveedordesc = new dhsoft.TextBoxNew(this.components);
            this.txtrucproveedor = new dhsoft.TextBoxNew(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cbooperacionigv = new System.Windows.Forms.ComboBox();
            this.cbounidadmedida = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btngrabar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 39);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btngrabar
            // 
            this.btngrabar.Image = global::interfacedsk.Properties.Resources.guardar;
            this.btngrabar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btngrabar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btngrabar.Name = "btngrabar";
            this.btngrabar.Size = new System.Drawing.Size(78, 36);
            this.btngrabar.Text = "Grabar";
            this.btngrabar.Click += new System.EventHandler(this.btngrabar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbooperacionigv);
            this.groupBox1.Controls.Add(this.cbounidadmedida);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtcantidadstock);
            this.groupBox1.Controls.Add(this.txtprecio);
            this.groupBox1.Controls.Add(this.btnbuscarimg);
            this.groupBox1.Controls.Add(this.txtfechaexpiracion);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txthorariodesc);
            this.groupBox1.Controls.Add(this.txtidhorario);
            this.groupBox1.Controls.Add(this.txtfotoprincipal);
            this.groupBox1.Controls.Add(this.txtcodigo);
            this.groupBox1.Controls.Add(this.txttiempogarantia);
            this.groupBox1.Controls.Add(this.txtdescripcion);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.txtrucproveedordesc);
            this.groupBox1.Controls.Add(this.txtrucproveedor);
            this.groupBox1.Location = new System.Drawing.Point(0, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "datos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(597, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // txtcantidadstock
            // 
            this.txtcantidadstock.Contenido = dhsoft.Enums.TipoTexto.OnlyDecimal;
            this.txtcantidadstock.DecimalPrecision = 2;
            this.txtcantidadstock.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txtcantidadstock.DisabledForeColor = System.Drawing.Color.Black;
            this.txtcantidadstock.Enganche = null;
            this.txtcantidadstock.EnterEmuleTab = true;
            this.txtcantidadstock.IsDecimalNegative = false;
            this.txtcantidadstock.LinkKeyDown = null;
            this.txtcantidadstock.Location = new System.Drawing.Point(434, 92);
            this.txtcantidadstock.MaskFormat = "";
            this.txtcantidadstock.Name = "txtcantidadstock";
            this.txtcantidadstock.Requiere = false;
            this.txtcantidadstock.Size = new System.Drawing.Size(102, 20);
            this.txtcantidadstock.TabIndex = 18;
            this.txtcantidadstock.Text = "0.00";
            this.txtcantidadstock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtprecio
            // 
            this.txtprecio.Contenido = dhsoft.Enums.TipoTexto.OnlyDecimal;
            this.txtprecio.DecimalPrecision = 2;
            this.txtprecio.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txtprecio.DisabledForeColor = System.Drawing.Color.Black;
            this.txtprecio.Enganche = null;
            this.txtprecio.EnterEmuleTab = true;
            this.txtprecio.IsDecimalNegative = false;
            this.txtprecio.LinkKeyDown = null;
            this.txtprecio.Location = new System.Drawing.Point(75, 93);
            this.txtprecio.MaskFormat = "";
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Requiere = false;
            this.txtprecio.Size = new System.Drawing.Size(102, 20);
            this.txtprecio.TabIndex = 14;
            this.txtprecio.Text = "0.00";
            this.txtprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnbuscarimg
            // 
            this.btnbuscarimg.Location = new System.Drawing.Point(543, 145);
            this.btnbuscarimg.Name = "btnbuscarimg";
            this.btnbuscarimg.Size = new System.Drawing.Size(48, 23);
            this.btnbuscarimg.TabIndex = 25;
            this.btnbuscarimg.Text = "buscar";
            this.btnbuscarimg.UseVisualStyleBackColor = true;
            this.btnbuscarimg.Click += new System.EventHandler(this.btnbuscarimg_Click);
            // 
            // txtfechaexpiracion
            // 
            this.txtfechaexpiracion.IsValueDate = false;
            this.txtfechaexpiracion.Location = new System.Drawing.Point(278, 93);
            this.txtfechaexpiracion.Mask = "00/00/0000";
            this.txtfechaexpiracion.Name = "txtfechaexpiracion";
            this.txtfechaexpiracion.Requiere = false;
            this.txtfechaexpiracion.Size = new System.Drawing.Size(65, 20);
            this.txtfechaexpiracion.TabIndex = 16;
            this.txtfechaexpiracion.ValidatingType = typeof(System.DateTime);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(550, 20);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 13);
            this.label21.TabIndex = 6;
            this.label21.Text = "Horario";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(184, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Fecha expiración";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(348, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Cantidad Stock";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(39, 148);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 13);
            this.label20.TabIndex = 23;
            this.label20.Text = "Foto principal";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(542, 96);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 13);
            this.label18.TabIndex = 19;
            this.label18.Text = "Código";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 122);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(98, 13);
            this.label19.TabIndex = 21;
            this.label19.Text = "Tiempo de garantia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proveedor";
            // 
            // txthorariodesc
            // 
            this.txthorariodesc.Contenido = dhsoft.Enums.TipoTexto.NormalText;
            this.txthorariodesc.DecimalPrecision = 0;
            this.txthorariodesc.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txthorariodesc.DisabledForeColor = System.Drawing.Color.Black;
            this.txthorariodesc.Enabled = false;
            this.txthorariodesc.Enganche = null;
            this.txthorariodesc.EnterEmuleTab = true;
            this.txthorariodesc.IsDecimalNegative = false;
            this.txthorariodesc.LinkKeyDown = null;
            this.txthorariodesc.Location = new System.Drawing.Point(640, 17);
            this.txthorariodesc.MaskFormat = null;
            this.txthorariodesc.Name = "txthorariodesc";
            this.txthorariodesc.Requiere = false;
            this.txthorariodesc.Size = new System.Drawing.Size(154, 20);
            this.txthorariodesc.TabIndex = 8;
            // 
            // txtidhorario
            // 
            this.txtidhorario.Contenido = dhsoft.Enums.TipoTexto.NormalText;
            this.txtidhorario.DecimalPrecision = 0;
            this.txtidhorario.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txtidhorario.DisabledForeColor = System.Drawing.Color.Black;
            this.txtidhorario.Enganche = null;
            this.txtidhorario.EnterEmuleTab = true;
            this.txtidhorario.IsDecimalNegative = false;
            this.txtidhorario.LinkKeyDown = null;
            this.txtidhorario.Location = new System.Drawing.Point(597, 17);
            this.txtidhorario.MaskFormat = null;
            this.txtidhorario.Name = "txtidhorario";
            this.txtidhorario.Requiere = false;
            this.txtidhorario.Size = new System.Drawing.Size(37, 20);
            this.txtidhorario.TabIndex = 7;
            // 
            // txtfotoprincipal
            // 
            this.txtfotoprincipal.Contenido = dhsoft.Enums.TipoTexto.NormalText;
            this.txtfotoprincipal.DecimalPrecision = 0;
            this.txtfotoprincipal.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txtfotoprincipal.DisabledForeColor = System.Drawing.Color.Black;
            this.txtfotoprincipal.Enabled = false;
            this.txtfotoprincipal.Enganche = null;
            this.txtfotoprincipal.EnterEmuleTab = true;
            this.txtfotoprincipal.IsDecimalNegative = false;
            this.txtfotoprincipal.LinkKeyDown = null;
            this.txtfotoprincipal.Location = new System.Drawing.Point(117, 145);
            this.txtfotoprincipal.MaskFormat = null;
            this.txtfotoprincipal.Name = "txtfotoprincipal";
            this.txtfotoprincipal.Requiere = false;
            this.txtfotoprincipal.Size = new System.Drawing.Size(419, 20);
            this.txtfotoprincipal.TabIndex = 24;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Contenido = dhsoft.Enums.TipoTexto.NormalText;
            this.txtcodigo.DecimalPrecision = 0;
            this.txtcodigo.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txtcodigo.DisabledForeColor = System.Drawing.Color.Black;
            this.txtcodigo.Enganche = null;
            this.txtcodigo.EnterEmuleTab = true;
            this.txtcodigo.IsDecimalNegative = false;
            this.txtcodigo.LinkKeyDown = null;
            this.txtcodigo.Location = new System.Drawing.Point(587, 93);
            this.txtcodigo.MaskFormat = null;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Requiere = false;
            this.txtcodigo.Size = new System.Drawing.Size(207, 20);
            this.txtcodigo.TabIndex = 20;
            // 
            // txttiempogarantia
            // 
            this.txttiempogarantia.Contenido = dhsoft.Enums.TipoTexto.NormalText;
            this.txttiempogarantia.DecimalPrecision = 0;
            this.txttiempogarantia.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txttiempogarantia.DisabledForeColor = System.Drawing.Color.Black;
            this.txttiempogarantia.Enganche = null;
            this.txttiempogarantia.EnterEmuleTab = true;
            this.txttiempogarantia.IsDecimalNegative = false;
            this.txttiempogarantia.LinkKeyDown = null;
            this.txttiempogarantia.Location = new System.Drawing.Point(117, 119);
            this.txttiempogarantia.MaskFormat = null;
            this.txttiempogarantia.Name = "txttiempogarantia";
            this.txttiempogarantia.Requiere = false;
            this.txttiempogarantia.Size = new System.Drawing.Size(474, 20);
            this.txttiempogarantia.TabIndex = 22;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Contenido = dhsoft.Enums.TipoTexto.NormalText;
            this.txtdescripcion.DecimalPrecision = 0;
            this.txtdescripcion.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txtdescripcion.DisabledForeColor = System.Drawing.Color.Black;
            this.txtdescripcion.Enganche = null;
            this.txtdescripcion.EnterEmuleTab = true;
            this.txtdescripcion.IsDecimalNegative = false;
            this.txtdescripcion.LinkKeyDown = null;
            this.txtdescripcion.Location = new System.Drawing.Point(76, 67);
            this.txtdescripcion.MaskFormat = null;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Requiere = false;
            this.txtdescripcion.Size = new System.Drawing.Size(718, 20);
            this.txtdescripcion.TabIndex = 12;
            // 
            // txtnombre
            // 
            this.txtnombre.Contenido = dhsoft.Enums.TipoTexto.NormalText;
            this.txtnombre.DecimalPrecision = 0;
            this.txtnombre.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txtnombre.DisabledForeColor = System.Drawing.Color.Black;
            this.txtnombre.Enganche = null;
            this.txtnombre.EnterEmuleTab = true;
            this.txtnombre.IsDecimalNegative = false;
            this.txtnombre.LinkKeyDown = null;
            this.txtnombre.Location = new System.Drawing.Point(76, 41);
            this.txtnombre.MaskFormat = null;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Requiere = false;
            this.txtnombre.Size = new System.Drawing.Size(718, 20);
            this.txtnombre.TabIndex = 10;
            // 
            // txtrucproveedordesc
            // 
            this.txtrucproveedordesc.Contenido = dhsoft.Enums.TipoTexto.NormalText;
            this.txtrucproveedordesc.DecimalPrecision = 0;
            this.txtrucproveedordesc.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txtrucproveedordesc.DisabledForeColor = System.Drawing.Color.Black;
            this.txtrucproveedordesc.Enabled = false;
            this.txtrucproveedordesc.Enganche = null;
            this.txtrucproveedordesc.EnterEmuleTab = true;
            this.txtrucproveedordesc.IsDecimalNegative = false;
            this.txtrucproveedordesc.LinkKeyDown = null;
            this.txtrucproveedordesc.Location = new System.Drawing.Point(184, 17);
            this.txtrucproveedordesc.MaskFormat = null;
            this.txtrucproveedordesc.Name = "txtrucproveedordesc";
            this.txtrucproveedordesc.Requiere = false;
            this.txtrucproveedordesc.Size = new System.Drawing.Size(360, 20);
            this.txtrucproveedordesc.TabIndex = 2;
            // 
            // txtrucproveedor
            // 
            this.txtrucproveedor.Contenido = dhsoft.Enums.TipoTexto.NormalText;
            this.txtrucproveedor.DecimalPrecision = 0;
            this.txtrucproveedor.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txtrucproveedor.DisabledForeColor = System.Drawing.Color.Black;
            this.txtrucproveedor.Enganche = null;
            this.txtrucproveedor.EnterEmuleTab = true;
            this.txtrucproveedor.IsDecimalNegative = false;
            this.txtrucproveedor.LinkKeyDown = null;
            this.txtrucproveedor.Location = new System.Drawing.Point(76, 17);
            this.txtrucproveedor.MaskFormat = null;
            this.txtrucproveedor.MaxLength = 11;
            this.txtrucproveedor.Name = "txtrucproveedor";
            this.txtrucproveedor.Requiere = false;
            this.txtrucproveedor.Size = new System.Drawing.Size(105, 20);
            this.txtrucproveedor.TabIndex = 1;
            this.txtrucproveedor.TextChanged += new System.EventHandler(this.txtrucproveedor_TextChanged);
            this.txtrucproveedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtrucproveedor_KeyDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cbooperacionigv
            // 
            this.cbooperacionigv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbooperacionigv.FormattingEnabled = true;
            this.cbooperacionigv.Location = new System.Drawing.Point(117, 198);
            this.cbooperacionigv.Name = "cbooperacionigv";
            this.cbooperacionigv.Size = new System.Drawing.Size(419, 21);
            this.cbooperacionigv.TabIndex = 46;
            // 
            // cbounidadmedida
            // 
            this.cbounidadmedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbounidadmedida.FormattingEnabled = true;
            this.cbounidadmedida.Location = new System.Drawing.Point(117, 171);
            this.cbounidadmedida.Name = "cbounidadmedida";
            this.cbounidadmedida.Size = new System.Drawing.Size(419, 21);
            this.cbounidadmedida.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Unidad de medida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Operacion del Igv";
            // 
            // frm_servicios_edicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 308);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_servicios_edicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicios";
            this.Load += new System.EventHandler(this.frm_servicios_edicion_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btngrabar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnbuscarimg;
        private dhsoft.MaskedTextBoxNew txtfechaexpiracion;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private dhsoft.TextBoxNew txthorariodesc;
        private dhsoft.TextBoxNew txtidhorario;
        private dhsoft.TextBoxNew txtfotoprincipal;
        private dhsoft.TextBoxNew txtcodigo;
        private dhsoft.TextBoxNew txttiempogarantia;
        private dhsoft.TextBoxNew txtdescripcion;
        private dhsoft.TextBoxNew txtnombre;
        private dhsoft.TextBoxNew txtrucproveedordesc;
        private dhsoft.TextBoxNew txtrucproveedor;
        internal dhsoft.TextBoxNew txtprecio;
        internal dhsoft.TextBoxNew txtcantidadstock;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbooperacionigv;
        private System.Windows.Forms.ComboBox cbounidadmedida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}