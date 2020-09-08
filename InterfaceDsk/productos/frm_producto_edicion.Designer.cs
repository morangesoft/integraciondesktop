namespace interfacedsk.productos
{
    partial class frm_producto_edicion
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
            this.txtprecio = new dhsoft.TextBoxNew(this.components);
            this.txtcantidadstock = new dhsoft.TextBoxNew(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.txtfechaexpiracion = new dhsoft.MaskedTextBoxNew();
            this.txtfechaingreso = new dhsoft.MaskedTextBoxNew();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmarca = new dhsoft.TextBoxNew(this.components);
            this.txtpeso = new dhsoft.TextBoxNew(this.components);
            this.txtfotoprincipal = new dhsoft.TextBoxNew(this.components);
            this.txtcodproducto = new dhsoft.TextBoxNew(this.components);
            this.txttiempogarantia = new dhsoft.TextBoxNew(this.components);
            this.txtmodelo = new dhsoft.TextBoxNew(this.components);
            this.txtvolumen = new dhsoft.TextBoxNew(this.components);
            this.txtancho = new dhsoft.TextBoxNew(this.components);
            this.txtaltura = new dhsoft.TextBoxNew(this.components);
            this.txttamanio = new dhsoft.TextBoxNew(this.components);
            this.txtcolor = new dhsoft.TextBoxNew(this.components);
            this.txtespecificaciones = new dhsoft.TextBoxNew(this.components);
            this.txtdescripcion = new dhsoft.TextBoxNew(this.components);
            this.txtnombre = new dhsoft.TextBoxNew(this.components);
            this.txtrucproveedordesc = new dhsoft.TextBoxNew(this.components);
            this.txtrucproveedor = new dhsoft.TextBoxNew(this.components);
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btngrabar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 39);
            this.toolStrip1.TabIndex = 1;
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
            this.groupBox1.Controls.Add(this.txtprecio);
            this.groupBox1.Controls.Add(this.txtcantidadstock);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtfechaexpiracion);
            this.groupBox1.Controls.Add(this.txtfechaingreso);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtmarca);
            this.groupBox1.Controls.Add(this.txtpeso);
            this.groupBox1.Controls.Add(this.txtfotoprincipal);
            this.groupBox1.Controls.Add(this.txtcodproducto);
            this.groupBox1.Controls.Add(this.txttiempogarantia);
            this.groupBox1.Controls.Add(this.txtmodelo);
            this.groupBox1.Controls.Add(this.txtvolumen);
            this.groupBox1.Controls.Add(this.txtancho);
            this.groupBox1.Controls.Add(this.txtaltura);
            this.groupBox1.Controls.Add(this.txttamanio);
            this.groupBox1.Controls.Add(this.txtcolor);
            this.groupBox1.Controls.Add(this.txtespecificaciones);
            this.groupBox1.Controls.Add(this.txtdescripcion);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.txtrucproveedordesc);
            this.groupBox1.Controls.Add(this.txtrucproveedor);
            this.groupBox1.Location = new System.Drawing.Point(0, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "datos";
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
            this.txtprecio.Location = new System.Drawing.Point(109, 121);
            this.txtprecio.MaskFormat = "";
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Requiere = false;
            this.txtprecio.Size = new System.Drawing.Size(102, 20);
            this.txtprecio.TabIndex = 13;
            this.txtprecio.Text = "0.00";
            this.txtprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.txtcantidadstock.Location = new System.Drawing.Point(620, 121);
            this.txtcantidadstock.MaskFormat = "";
            this.txtcantidadstock.Name = "txtcantidadstock";
            this.txtcantidadstock.Requiere = false;
            this.txtcantidadstock.Size = new System.Drawing.Size(102, 20);
            this.txtcantidadstock.TabIndex = 19;
            this.txtcantidadstock.Text = "0.00";
            this.txtcantidadstock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(740, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtfechaexpiracion
            // 
            this.txtfechaexpiracion.IsValueDate = false;
            this.txtfechaexpiracion.Location = new System.Drawing.Point(454, 118);
            this.txtfechaexpiracion.Mask = "00/00/0000";
            this.txtfechaexpiracion.Name = "txtfechaexpiracion";
            this.txtfechaexpiracion.Requiere = false;
            this.txtfechaexpiracion.Size = new System.Drawing.Size(65, 20);
            this.txtfechaexpiracion.TabIndex = 17;
            this.txtfechaexpiracion.ValidatingType = typeof(System.DateTime);
            // 
            // txtfechaingreso
            // 
            this.txtfechaingreso.IsValueDate = false;
            this.txtfechaingreso.Location = new System.Drawing.Point(292, 118);
            this.txtfechaingreso.Mask = "00/00/0000";
            this.txtfechaingreso.Name = "txtfechaingreso";
            this.txtfechaingreso.Requiere = false;
            this.txtfechaingreso.Size = new System.Drawing.Size(65, 20);
            this.txtfechaingreso.TabIndex = 15;
            this.txtfechaingreso.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(360, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Fecha expiración";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(217, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Fecha ingreso";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(534, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Cantidad Stock";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(417, 173);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Marca";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(255, 173);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Peso";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(408, 225);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 13);
            this.label20.TabIndex = 40;
            this.label20.Text = "Foto principal";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(408, 199);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "Código";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(4, 225);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(98, 13);
            this.label19.TabIndex = 38;
            this.label19.Text = "Tiempo de garantia";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(49, 199);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Modelo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(43, 173);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Volumen";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(568, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Ancho";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(402, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Altura";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(240, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Tamaño";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Especificaciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proveedor";
            // 
            // txtmarca
            // 
            this.txtmarca.Contenido = dhsoft.Enums.TipoTexto.NormalText;
            this.txtmarca.DecimalPrecision = 0;
            this.txtmarca.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txtmarca.DisabledForeColor = System.Drawing.Color.Black;
            this.txtmarca.Enganche = null;
            this.txtmarca.EnterEmuleTab = true;
            this.txtmarca.IsDecimalNegative = false;
            this.txtmarca.LinkKeyDown = null;
            this.txtmarca.Location = new System.Drawing.Point(454, 170);
            this.txtmarca.MaskFormat = null;
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Requiere = false;
            this.txtmarca.Size = new System.Drawing.Size(334, 20);
            this.txtmarca.TabIndex = 33;
            // 
            // txtpeso
            // 
            this.txtpeso.Contenido = dhsoft.Enums.TipoTexto.NormalText;
            this.txtpeso.DecimalPrecision = 0;
            this.txtpeso.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txtpeso.DisabledForeColor = System.Drawing.Color.Black;
            this.txtpeso.Enganche = null;
            this.txtpeso.EnterEmuleTab = true;
            this.txtpeso.IsDecimalNegative = false;
            this.txtpeso.LinkKeyDown = null;
            this.txtpeso.Location = new System.Drawing.Point(292, 170);
            this.txtpeso.MaskFormat = null;
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Requiere = false;
            this.txtpeso.Size = new System.Drawing.Size(102, 20);
            this.txtpeso.TabIndex = 31;
            // 
            // txtfotoprincipal
            // 
            this.txtfotoprincipal.Contenido = dhsoft.Enums.TipoTexto.NormalText;
            this.txtfotoprincipal.DecimalPrecision = 0;
            this.txtfotoprincipal.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txtfotoprincipal.DisabledForeColor = System.Drawing.Color.Black;
            this.txtfotoprincipal.Enganche = null;
            this.txtfotoprincipal.EnterEmuleTab = true;
            this.txtfotoprincipal.IsDecimalNegative = false;
            this.txtfotoprincipal.LinkKeyDown = null;
            this.txtfotoprincipal.Location = new System.Drawing.Point(486, 222);
            this.txtfotoprincipal.MaskFormat = null;
            this.txtfotoprincipal.Name = "txtfotoprincipal";
            this.txtfotoprincipal.Requiere = false;
            this.txtfotoprincipal.Size = new System.Drawing.Size(248, 20);
            this.txtfotoprincipal.TabIndex = 41;
            // 
            // txtcodproducto
            // 
            this.txtcodproducto.Contenido = dhsoft.Enums.TipoTexto.NormalText;
            this.txtcodproducto.DecimalPrecision = 0;
            this.txtcodproducto.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txtcodproducto.DisabledForeColor = System.Drawing.Color.Black;
            this.txtcodproducto.Enganche = null;
            this.txtcodproducto.EnterEmuleTab = true;
            this.txtcodproducto.IsDecimalNegative = false;
            this.txtcodproducto.LinkKeyDown = null;
            this.txtcodproducto.Location = new System.Drawing.Point(454, 196);
            this.txtcodproducto.MaskFormat = null;
            this.txtcodproducto.Name = "txtcodproducto";
            this.txtcodproducto.Requiere = false;
            this.txtcodproducto.Size = new System.Drawing.Size(334, 20);
            this.txtcodproducto.TabIndex = 37;
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
            this.txttiempogarantia.Location = new System.Drawing.Point(109, 222);
            this.txttiempogarantia.MaskFormat = null;
            this.txttiempogarantia.Name = "txttiempogarantia";
            this.txttiempogarantia.Requiere = false;
            this.txttiempogarantia.Size = new System.Drawing.Size(285, 20);
            this.txttiempogarantia.TabIndex = 39;
            // 
            // txtmodelo
            // 
            this.txtmodelo.Contenido = dhsoft.Enums.TipoTexto.NormalText;
            this.txtmodelo.DecimalPrecision = 0;
            this.txtmodelo.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txtmodelo.DisabledForeColor = System.Drawing.Color.Black;
            this.txtmodelo.Enganche = null;
            this.txtmodelo.EnterEmuleTab = true;
            this.txtmodelo.IsDecimalNegative = false;
            this.txtmodelo.LinkKeyDown = null;
            this.txtmodelo.Location = new System.Drawing.Point(109, 196);
            this.txtmodelo.MaskFormat = null;
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Requiere = false;
            this.txtmodelo.Size = new System.Drawing.Size(285, 20);
            this.txtmodelo.TabIndex = 35;
            // 
            // txtvolumen
            // 
            this.txtvolumen.Contenido = dhsoft.Enums.TipoTexto.NormalText;
            this.txtvolumen.DecimalPrecision = 0;
            this.txtvolumen.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txtvolumen.DisabledForeColor = System.Drawing.Color.Black;
            this.txtvolumen.Enganche = null;
            this.txtvolumen.EnterEmuleTab = true;
            this.txtvolumen.IsDecimalNegative = false;
            this.txtvolumen.LinkKeyDown = null;
            this.txtvolumen.Location = new System.Drawing.Point(109, 170);
            this.txtvolumen.MaskFormat = null;
            this.txtvolumen.Name = "txtvolumen";
            this.txtvolumen.Requiere = false;
            this.txtvolumen.Size = new System.Drawing.Size(102, 20);
            this.txtvolumen.TabIndex = 29;
            // 
            // txtancho
            // 
            this.txtancho.Contenido = dhsoft.Enums.TipoTexto.NormalText;
            this.txtancho.DecimalPrecision = 0;
            this.txtancho.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txtancho.DisabledForeColor = System.Drawing.Color.Black;
            this.txtancho.Enganche = null;
            this.txtancho.EnterEmuleTab = true;
            this.txtancho.IsDecimalNegative = false;
            this.txtancho.LinkKeyDown = null;
            this.txtancho.Location = new System.Drawing.Point(620, 144);
            this.txtancho.MaskFormat = null;
            this.txtancho.Name = "txtancho";
            this.txtancho.Requiere = false;
            this.txtancho.Size = new System.Drawing.Size(102, 20);
            this.txtancho.TabIndex = 27;
            // 
            // txtaltura
            // 
            this.txtaltura.Contenido = dhsoft.Enums.TipoTexto.NormalText;
            this.txtaltura.DecimalPrecision = 0;
            this.txtaltura.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txtaltura.DisabledForeColor = System.Drawing.Color.Black;
            this.txtaltura.Enganche = null;
            this.txtaltura.EnterEmuleTab = true;
            this.txtaltura.IsDecimalNegative = false;
            this.txtaltura.LinkKeyDown = null;
            this.txtaltura.Location = new System.Drawing.Point(454, 144);
            this.txtaltura.MaskFormat = null;
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Requiere = false;
            this.txtaltura.Size = new System.Drawing.Size(102, 20);
            this.txtaltura.TabIndex = 25;
            // 
            // txttamanio
            // 
            this.txttamanio.Contenido = dhsoft.Enums.TipoTexto.NormalText;
            this.txttamanio.DecimalPrecision = 0;
            this.txttamanio.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txttamanio.DisabledForeColor = System.Drawing.Color.Black;
            this.txttamanio.Enganche = null;
            this.txttamanio.EnterEmuleTab = true;
            this.txttamanio.IsDecimalNegative = false;
            this.txttamanio.LinkKeyDown = null;
            this.txttamanio.Location = new System.Drawing.Point(292, 144);
            this.txttamanio.MaskFormat = null;
            this.txttamanio.Name = "txttamanio";
            this.txttamanio.Requiere = false;
            this.txttamanio.Size = new System.Drawing.Size(102, 20);
            this.txttamanio.TabIndex = 23;
            // 
            // txtcolor
            // 
            this.txtcolor.Contenido = dhsoft.Enums.TipoTexto.NormalText;
            this.txtcolor.DecimalPrecision = 0;
            this.txtcolor.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txtcolor.DisabledForeColor = System.Drawing.Color.Black;
            this.txtcolor.Enganche = null;
            this.txtcolor.EnterEmuleTab = true;
            this.txtcolor.IsDecimalNegative = false;
            this.txtcolor.LinkKeyDown = null;
            this.txtcolor.Location = new System.Drawing.Point(109, 144);
            this.txtcolor.MaskFormat = null;
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Requiere = false;
            this.txtcolor.Size = new System.Drawing.Size(102, 20);
            this.txtcolor.TabIndex = 21;
            // 
            // txtespecificaciones
            // 
            this.txtespecificaciones.Contenido = dhsoft.Enums.TipoTexto.NormalText;
            this.txtespecificaciones.DecimalPrecision = 0;
            this.txtespecificaciones.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txtespecificaciones.DisabledForeColor = System.Drawing.Color.Black;
            this.txtespecificaciones.Enganche = null;
            this.txtespecificaciones.EnterEmuleTab = true;
            this.txtespecificaciones.IsDecimalNegative = false;
            this.txtespecificaciones.LinkKeyDown = null;
            this.txtespecificaciones.Location = new System.Drawing.Point(109, 92);
            this.txtespecificaciones.MaskFormat = null;
            this.txtespecificaciones.Name = "txtespecificaciones";
            this.txtespecificaciones.Requiere = false;
            this.txtespecificaciones.Size = new System.Drawing.Size(679, 20);
            this.txtespecificaciones.TabIndex = 11;
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
            this.txtdescripcion.Location = new System.Drawing.Point(109, 69);
            this.txtdescripcion.MaskFormat = null;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Requiere = false;
            this.txtdescripcion.Size = new System.Drawing.Size(679, 20);
            this.txtdescripcion.TabIndex = 9;
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
            this.txtnombre.Location = new System.Drawing.Point(109, 43);
            this.txtnombre.MaskFormat = null;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Requiere = false;
            this.txtnombre.Size = new System.Drawing.Size(679, 20);
            this.txtnombre.TabIndex = 7;
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
            this.txtrucproveedordesc.Location = new System.Drawing.Point(204, 17);
            this.txtrucproveedordesc.MaskFormat = null;
            this.txtrucproveedordesc.Name = "txtrucproveedordesc";
            this.txtrucproveedordesc.Requiere = false;
            this.txtrucproveedordesc.Size = new System.Drawing.Size(584, 20);
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
            this.txtrucproveedor.Location = new System.Drawing.Point(109, 17);
            this.txtrucproveedor.MaskFormat = null;
            this.txtrucproveedor.Name = "txtrucproveedor";
            this.txtrucproveedor.Requiere = false;
            this.txtrucproveedor.Size = new System.Drawing.Size(89, 20);
            this.txtrucproveedor.TabIndex = 1;
            this.txtrucproveedor.TextChanged += new System.EventHandler(this.txtrucproveedor_TextChanged);
            this.txtrucproveedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtrucproveedor_KeyDown);
            // 
            // frm_producto_edicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 314);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_producto_edicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.frm_producto_edicion_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btngrabar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private dhsoft.TextBoxNew txtespecificaciones;
        private dhsoft.TextBoxNew txtdescripcion;
        private dhsoft.TextBoxNew txtnombre;
        private dhsoft.TextBoxNew txtrucproveedor;
        private dhsoft.TextBoxNew txtrucproveedordesc;
        private System.Windows.Forms.Button button1;
        private dhsoft.MaskedTextBoxNew txtfechaexpiracion;
        private dhsoft.MaskedTextBoxNew txtfechaingreso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private dhsoft.TextBoxNew txtmarca;
        private dhsoft.TextBoxNew txtpeso;
        private dhsoft.TextBoxNew txtfotoprincipal;
        private dhsoft.TextBoxNew txtcodproducto;
        private dhsoft.TextBoxNew txttiempogarantia;
        private dhsoft.TextBoxNew txtmodelo;
        private dhsoft.TextBoxNew txtvolumen;
        private dhsoft.TextBoxNew txtancho;
        private dhsoft.TextBoxNew txtaltura;
        private dhsoft.TextBoxNew txttamanio;
        private dhsoft.TextBoxNew txtcolor;
        internal dhsoft.TextBoxNew txtprecio;
        internal dhsoft.TextBoxNew txtcantidadstock;
    }
}