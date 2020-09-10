namespace interfacedsk.facrturacion
{
    partial class frm_facturacion_edicion
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
            this.cbomoneda = new System.Windows.Forms.ComboBox();
            this.txttipocambio = new dhsoft.TextBoxNew(this.components);
            this.cbocomprobamte = new System.Windows.Forms.ComboBox();
            this.txtfechaemision = new dhsoft.MaskedTextBoxNew();
            this.label23 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnumero = new dhsoft.TextBoxNew(this.components);
            this.txtserie = new dhsoft.TextBoxNew(this.components);
            this.txtclienterucdnides = new dhsoft.TextBoxNew(this.components);
            this.txtclienterucdni = new dhsoft.TextBoxNew(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.lbldescripcionproser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtunidadmedida = new dhsoft.TextBoxNew(this.components);
            this.txtproducto = new dhsoft.TextBoxNew(this.components);
            this.TxtItNum = new dhsoft.TextBoxNew(this.components);
            this.GbxResumen = new System.Windows.Forms.GroupBox();
            this.Label34 = new System.Windows.Forms.Label();
            this.Label40 = new System.Windows.Forms.Label();
            this.TxtRsISC = new dhsoft.TextBoxNew(this.components);
            this.Label32 = new System.Windows.Forms.Label();
            this.TxtRsValExporta = new dhsoft.TextBoxNew(this.components);
            this.TxtRsBaseImponible = new dhsoft.TextBoxNew(this.components);
            this.TxtRsInAfecta = new dhsoft.TextBoxNew(this.components);
            this.TxtRsIGVMonto = new dhsoft.TextBoxNew(this.components);
            this.TxtRsOtrosTribCarg = new dhsoft.TextBoxNew(this.components);
            this.TxtRsIGVPorc = new dhsoft.TextBoxNew(this.components);
            this.TxtRsExonerada = new dhsoft.TextBoxNew(this.components);
            this.Label28 = new System.Windows.Forms.Label();
            this.Label36 = new System.Windows.Forms.Label();
            this.Label33 = new System.Windows.Forms.Label();
            this.Label35 = new System.Windows.Forms.Label();
            this.TxtRsImporteTotal = new dhsoft.TextBoxNew(this.components);
            this.Label31 = new System.Windows.Forms.Label();
            this.ChkOtrosTribCarg = new dhsoft.CheckBoxNew();
            this.gbdetalle = new System.Windows.Forms.GroupBox();
            this.cbotipo = new System.Windows.Forms.ComboBox();
            this.TxtItCantidad = new dhsoft.TextBoxNew(this.components);
            this.Label26 = new System.Windows.Forms.Label();
            this.TxtItImporte = new dhsoft.TextBoxNew(this.components);
            this.TxtPrecunitario = new dhsoft.TextBoxNew(this.components);
            this.label25 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtproductodesc = new dhsoft.TextBoxNew(this.components);
            this.BtnDtGrabar = new System.Windows.Forms.Button();
            this.BtnDtNuevo = new System.Windows.Forms.Button();
            this.BtnDtEliminar = new System.Windows.Forms.Button();
            this.BtnDtEditar = new System.Windows.Forms.Button();
            this.DgvDetalle = new DevExpress.XtraGrid.GridControl();
            this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GbxResumen.SuspendLayout();
            this.gbdetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btngrabar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(939, 39);
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbomoneda);
            this.groupBox1.Controls.Add(this.txttipocambio);
            this.groupBox1.Controls.Add(this.cbocomprobamte);
            this.groupBox1.Controls.Add(this.txtfechaemision);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtnumero);
            this.groupBox1.Controls.Add(this.txtserie);
            this.groupBox1.Controls.Add(this.txtclienterucdnides);
            this.groupBox1.Controls.Add(this.txtclienterucdni);
            this.groupBox1.Location = new System.Drawing.Point(0, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "datos";
            // 
            // cbomoneda
            // 
            this.cbomoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomoneda.FormattingEnabled = true;
            this.cbomoneda.Location = new System.Drawing.Point(400, 19);
            this.cbomoneda.Name = "cbomoneda";
            this.cbomoneda.Size = new System.Drawing.Size(104, 21);
            this.cbomoneda.TabIndex = 1;
            this.cbomoneda.SelectedIndexChanged += new System.EventHandler(this.cbomoneda_SelectedIndexChanged);
            // 
            // txttipocambio
            // 
            this.txttipocambio.Contenido = dhsoft.Enums.TipoTexto.OnlyDecimal;
            this.txttipocambio.DecimalPrecision = 3;
            this.txttipocambio.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txttipocambio.DisabledForeColor = System.Drawing.Color.Black;
            this.txttipocambio.Enabled = false;
            this.txttipocambio.Enganche = null;
            this.txttipocambio.EnterEmuleTab = true;
            this.txttipocambio.IsDecimalNegative = false;
            this.txttipocambio.LinkKeyDown = null;
            this.txttipocambio.Location = new System.Drawing.Point(595, 17);
            this.txttipocambio.MaskFormat = "";
            this.txttipocambio.MaxLength = 4;
            this.txttipocambio.Name = "txttipocambio";
            this.txttipocambio.Requiere = false;
            this.txttipocambio.Size = new System.Drawing.Size(75, 20);
            this.txttipocambio.TabIndex = 8;
            this.txttipocambio.Text = "1.000";
            this.txttipocambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txttipocambio.TextChanged += new System.EventHandler(this.TxtItCantidad_TextChanged);
            this.txttipocambio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtItCantidad_KeyDown);
            // 
            // cbocomprobamte
            // 
            this.cbocomprobamte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocomprobamte.FormattingEnabled = true;
            this.cbocomprobamte.Location = new System.Drawing.Point(78, 18);
            this.cbocomprobamte.Name = "cbocomprobamte";
            this.cbocomprobamte.Size = new System.Drawing.Size(252, 21);
            this.cbocomprobamte.TabIndex = 1;
            // 
            // txtfechaemision
            // 
            this.txtfechaemision.IsValueDate = false;
            this.txtfechaemision.Location = new System.Drawing.Point(457, 45);
            this.txtfechaemision.Mask = "00/00/0000";
            this.txtfechaemision.Name = "txtfechaemision";
            this.txtfechaemision.Requiere = false;
            this.txtfechaemision.Size = new System.Drawing.Size(65, 20);
            this.txtfechaemision.TabIndex = 7;
            this.txtfechaemision.ValidatingType = typeof(System.DateTime);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(382, 48);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(75, 13);
            this.label23.TabIndex = 6;
            this.label23.Text = "Fecha emisión";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(509, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tipo de cambio";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(140, 48);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(44, 13);
            this.label22.TabIndex = 4;
            this.label22.Text = "Número";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Moneda";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(47, 48);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "Serie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Comprobante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "cliente";
            // 
            // txtnumero
            // 
            this.txtnumero.Contenido = dhsoft.Enums.TipoTexto.NormalText;
            this.txtnumero.DecimalPrecision = 0;
            this.txtnumero.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txtnumero.DisabledForeColor = System.Drawing.Color.Black;
            this.txtnumero.Enganche = null;
            this.txtnumero.EnterEmuleTab = true;
            this.txtnumero.IsDecimalNegative = false;
            this.txtnumero.LinkKeyDown = null;
            this.txtnumero.Location = new System.Drawing.Point(184, 45);
            this.txtnumero.MaskFormat = null;
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Requiere = false;
            this.txtnumero.Size = new System.Drawing.Size(196, 20);
            this.txtnumero.TabIndex = 5;
            this.txtnumero.Leave += new System.EventHandler(this.txtnumero_Leave);
            // 
            // txtserie
            // 
            this.txtserie.Contenido = dhsoft.Enums.TipoTexto.NormalText;
            this.txtserie.DecimalPrecision = 0;
            this.txtserie.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txtserie.DisabledForeColor = System.Drawing.Color.Black;
            this.txtserie.Enganche = null;
            this.txtserie.EnterEmuleTab = true;
            this.txtserie.IsDecimalNegative = false;
            this.txtserie.LinkKeyDown = null;
            this.txtserie.Location = new System.Drawing.Point(78, 45);
            this.txtserie.MaskFormat = null;
            this.txtserie.Name = "txtserie";
            this.txtserie.Requiere = false;
            this.txtserie.Size = new System.Drawing.Size(57, 20);
            this.txtserie.TabIndex = 3;
            this.txtserie.Leave += new System.EventHandler(this.txtserie_Leave);
            // 
            // txtclienterucdnides
            // 
            this.txtclienterucdnides.Contenido = dhsoft.Enums.TipoTexto.NormalText;
            this.txtclienterucdnides.DecimalPrecision = 0;
            this.txtclienterucdnides.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txtclienterucdnides.DisabledForeColor = System.Drawing.Color.Black;
            this.txtclienterucdnides.Enabled = false;
            this.txtclienterucdnides.Enganche = null;
            this.txtclienterucdnides.EnterEmuleTab = true;
            this.txtclienterucdnides.IsDecimalNegative = false;
            this.txtclienterucdnides.LinkKeyDown = null;
            this.txtclienterucdnides.Location = new System.Drawing.Point(169, 74);
            this.txtclienterucdnides.MaskFormat = null;
            this.txtclienterucdnides.Name = "txtclienterucdnides";
            this.txtclienterucdnides.Requiere = false;
            this.txtclienterucdnides.Size = new System.Drawing.Size(506, 20);
            this.txtclienterucdnides.TabIndex = 10;
            // 
            // txtclienterucdni
            // 
            this.txtclienterucdni.Contenido = dhsoft.Enums.TipoTexto.NormalText;
            this.txtclienterucdni.DecimalPrecision = 0;
            this.txtclienterucdni.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txtclienterucdni.DisabledForeColor = System.Drawing.Color.Black;
            this.txtclienterucdni.Enganche = null;
            this.txtclienterucdni.EnterEmuleTab = true;
            this.txtclienterucdni.IsDecimalNegative = false;
            this.txtclienterucdni.LinkKeyDown = null;
            this.txtclienterucdni.Location = new System.Drawing.Point(78, 74);
            this.txtclienterucdni.MaskFormat = null;
            this.txtclienterucdni.Name = "txtclienterucdni";
            this.txtclienterucdni.Requiere = false;
            this.txtclienterucdni.Size = new System.Drawing.Size(89, 20);
            this.txtclienterucdni.TabIndex = 9;
            this.txtclienterucdni.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtclienterucdni_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Unidad de medida";
            // 
            // lbldescripcionproser
            // 
            this.lbldescripcionproser.AutoSize = true;
            this.lbldescripcionproser.Location = new System.Drawing.Point(234, 17);
            this.lbldescripcionproser.Name = "lbldescripcionproser";
            this.lbldescripcionproser.Size = new System.Drawing.Size(50, 13);
            this.lbldescripcionproser.TabIndex = 4;
            this.lbldescripcionproser.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Item";
            // 
            // txtunidadmedida
            // 
            this.txtunidadmedida.Contenido = dhsoft.Enums.TipoTexto.NormalText;
            this.txtunidadmedida.DecimalPrecision = 0;
            this.txtunidadmedida.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txtunidadmedida.DisabledForeColor = System.Drawing.Color.Black;
            this.txtunidadmedida.Enabled = false;
            this.txtunidadmedida.Enganche = null;
            this.txtunidadmedida.EnterEmuleTab = true;
            this.txtunidadmedida.IsDecimalNegative = false;
            this.txtunidadmedida.LinkKeyDown = null;
            this.txtunidadmedida.Location = new System.Drawing.Point(113, 39);
            this.txtunidadmedida.MaskFormat = null;
            this.txtunidadmedida.Name = "txtunidadmedida";
            this.txtunidadmedida.Requiere = false;
            this.txtunidadmedida.Size = new System.Drawing.Size(279, 20);
            this.txtunidadmedida.TabIndex = 8;
            // 
            // txtproducto
            // 
            this.txtproducto.Contenido = dhsoft.Enums.TipoTexto.NormalText;
            this.txtproducto.DecimalPrecision = 0;
            this.txtproducto.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txtproducto.DisabledForeColor = System.Drawing.Color.Black;
            this.txtproducto.Enganche = null;
            this.txtproducto.EnterEmuleTab = true;
            this.txtproducto.IsDecimalNegative = false;
            this.txtproducto.LinkKeyDown = null;
            this.txtproducto.Location = new System.Drawing.Point(291, 14);
            this.txtproducto.MaskFormat = null;
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Requiere = false;
            this.txtproducto.Size = new System.Drawing.Size(95, 20);
            this.txtproducto.TabIndex = 5;
            this.txtproducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtproducto_KeyDown);
            // 
            // TxtItNum
            // 
            this.TxtItNum.Contenido = dhsoft.Enums.TipoTexto.NormalText;
            this.TxtItNum.DecimalPrecision = 0;
            this.TxtItNum.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.TxtItNum.DisabledForeColor = System.Drawing.Color.Black;
            this.TxtItNum.Enabled = false;
            this.TxtItNum.Enganche = null;
            this.TxtItNum.EnterEmuleTab = true;
            this.TxtItNum.IsDecimalNegative = false;
            this.TxtItNum.LinkKeyDown = null;
            this.TxtItNum.Location = new System.Drawing.Point(46, 15);
            this.TxtItNum.MaskFormat = null;
            this.TxtItNum.Name = "TxtItNum";
            this.TxtItNum.Requiere = false;
            this.TxtItNum.Size = new System.Drawing.Size(30, 20);
            this.TxtItNum.TabIndex = 1;
            // 
            // GbxResumen
            // 
            this.GbxResumen.Controls.Add(this.Label34);
            this.GbxResumen.Controls.Add(this.Label40);
            this.GbxResumen.Controls.Add(this.TxtRsISC);
            this.GbxResumen.Controls.Add(this.Label32);
            this.GbxResumen.Controls.Add(this.TxtRsValExporta);
            this.GbxResumen.Controls.Add(this.TxtRsBaseImponible);
            this.GbxResumen.Controls.Add(this.TxtRsInAfecta);
            this.GbxResumen.Controls.Add(this.TxtRsIGVMonto);
            this.GbxResumen.Controls.Add(this.TxtRsOtrosTribCarg);
            this.GbxResumen.Controls.Add(this.TxtRsIGVPorc);
            this.GbxResumen.Controls.Add(this.TxtRsExonerada);
            this.GbxResumen.Controls.Add(this.Label28);
            this.GbxResumen.Controls.Add(this.Label36);
            this.GbxResumen.Controls.Add(this.Label33);
            this.GbxResumen.Controls.Add(this.Label35);
            this.GbxResumen.Controls.Add(this.TxtRsImporteTotal);
            this.GbxResumen.Controls.Add(this.Label31);
            this.GbxResumen.Controls.Add(this.ChkOtrosTribCarg);
            this.GbxResumen.Location = new System.Drawing.Point(687, 42);
            this.GbxResumen.Name = "GbxResumen";
            this.GbxResumen.Size = new System.Drawing.Size(224, 205);
            this.GbxResumen.TabIndex = 6;
            this.GbxResumen.TabStop = false;
            this.GbxResumen.Text = "Resumen";
            // 
            // Label34
            // 
            this.Label34.AutoSize = true;
            this.Label34.BackColor = System.Drawing.Color.Transparent;
            this.Label34.Location = new System.Drawing.Point(2, 129);
            this.Label34.Name = "Label34";
            this.Label34.Size = new System.Drawing.Size(34, 13);
            this.Label34.TabIndex = 16;
            this.Label34.Text = "I.G.V.";
            // 
            // Label40
            // 
            this.Label40.AutoSize = true;
            this.Label40.BackColor = System.Drawing.Color.Transparent;
            this.Label40.Location = new System.Drawing.Point(2, 107);
            this.Label40.Name = "Label40";
            this.Label40.Size = new System.Drawing.Size(33, 13);
            this.Label40.TabIndex = 14;
            this.Label40.Text = "I.S.C.";
            // 
            // TxtRsISC
            // 
            this.TxtRsISC.Contenido = dhsoft.Enums.TipoTexto.OnlyDecimal;
            this.TxtRsISC.DecimalPrecision = 2;
            this.TxtRsISC.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.TxtRsISC.DisabledForeColor = System.Drawing.Color.Black;
            this.TxtRsISC.Enabled = false;
            this.TxtRsISC.Enganche = null;
            this.TxtRsISC.EnterEmuleTab = true;
            this.TxtRsISC.IsDecimalNegative = false;
            this.TxtRsISC.LinkKeyDown = null;
            this.TxtRsISC.Location = new System.Drawing.Point(113, 104);
            this.TxtRsISC.MaskFormat = "";
            this.TxtRsISC.Name = "TxtRsISC";
            this.TxtRsISC.Requiere = false;
            this.TxtRsISC.Size = new System.Drawing.Size(105, 20);
            this.TxtRsISC.TabIndex = 15;
            this.TxtRsISC.Text = "0.00";
            this.TxtRsISC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label32
            // 
            this.Label32.AutoSize = true;
            this.Label32.BackColor = System.Drawing.Color.Transparent;
            this.Label32.Location = new System.Drawing.Point(2, 63);
            this.Label32.Name = "Label32";
            this.Label32.Size = new System.Drawing.Size(58, 13);
            this.Label32.TabIndex = 10;
            this.Label32.Text = "Exonerada";
            // 
            // TxtRsValExporta
            // 
            this.TxtRsValExporta.Contenido = dhsoft.Enums.TipoTexto.OnlyDecimal;
            this.TxtRsValExporta.DecimalPrecision = 2;
            this.TxtRsValExporta.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.TxtRsValExporta.DisabledForeColor = System.Drawing.Color.Black;
            this.TxtRsValExporta.Enabled = false;
            this.TxtRsValExporta.Enganche = null;
            this.TxtRsValExporta.EnterEmuleTab = true;
            this.TxtRsValExporta.IsDecimalNegative = false;
            this.TxtRsValExporta.LinkKeyDown = null;
            this.TxtRsValExporta.Location = new System.Drawing.Point(113, 17);
            this.TxtRsValExporta.MaskFormat = "";
            this.TxtRsValExporta.Name = "TxtRsValExporta";
            this.TxtRsValExporta.Requiere = false;
            this.TxtRsValExporta.Size = new System.Drawing.Size(105, 20);
            this.TxtRsValExporta.TabIndex = 7;
            this.TxtRsValExporta.Text = "0.00";
            this.TxtRsValExporta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtRsBaseImponible
            // 
            this.TxtRsBaseImponible.Contenido = dhsoft.Enums.TipoTexto.OnlyDecimal;
            this.TxtRsBaseImponible.DecimalPrecision = 2;
            this.TxtRsBaseImponible.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.TxtRsBaseImponible.DisabledForeColor = System.Drawing.Color.Black;
            this.TxtRsBaseImponible.Enabled = false;
            this.TxtRsBaseImponible.Enganche = null;
            this.TxtRsBaseImponible.EnterEmuleTab = true;
            this.TxtRsBaseImponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRsBaseImponible.IsDecimalNegative = false;
            this.TxtRsBaseImponible.LinkKeyDown = null;
            this.TxtRsBaseImponible.Location = new System.Drawing.Point(113, 39);
            this.TxtRsBaseImponible.MaskFormat = "";
            this.TxtRsBaseImponible.Name = "TxtRsBaseImponible";
            this.TxtRsBaseImponible.Requiere = false;
            this.TxtRsBaseImponible.Size = new System.Drawing.Size(105, 20);
            this.TxtRsBaseImponible.TabIndex = 9;
            this.TxtRsBaseImponible.Text = "0.00";
            this.TxtRsBaseImponible.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtRsInAfecta
            // 
            this.TxtRsInAfecta.Contenido = dhsoft.Enums.TipoTexto.OnlyDecimal;
            this.TxtRsInAfecta.DecimalPrecision = 2;
            this.TxtRsInAfecta.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.TxtRsInAfecta.DisabledForeColor = System.Drawing.Color.Black;
            this.TxtRsInAfecta.Enabled = false;
            this.TxtRsInAfecta.Enganche = null;
            this.TxtRsInAfecta.EnterEmuleTab = true;
            this.TxtRsInAfecta.IsDecimalNegative = false;
            this.TxtRsInAfecta.LinkKeyDown = null;
            this.TxtRsInAfecta.Location = new System.Drawing.Point(113, 82);
            this.TxtRsInAfecta.MaskFormat = "";
            this.TxtRsInAfecta.Name = "TxtRsInAfecta";
            this.TxtRsInAfecta.Requiere = false;
            this.TxtRsInAfecta.Size = new System.Drawing.Size(105, 20);
            this.TxtRsInAfecta.TabIndex = 13;
            this.TxtRsInAfecta.Text = "0.00";
            this.TxtRsInAfecta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtRsIGVMonto
            // 
            this.TxtRsIGVMonto.Contenido = dhsoft.Enums.TipoTexto.OnlyDecimal;
            this.TxtRsIGVMonto.DecimalPrecision = 2;
            this.TxtRsIGVMonto.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.TxtRsIGVMonto.DisabledForeColor = System.Drawing.Color.Black;
            this.TxtRsIGVMonto.Enabled = false;
            this.TxtRsIGVMonto.Enganche = null;
            this.TxtRsIGVMonto.EnterEmuleTab = true;
            this.TxtRsIGVMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRsIGVMonto.IsDecimalNegative = false;
            this.TxtRsIGVMonto.LinkKeyDown = null;
            this.TxtRsIGVMonto.Location = new System.Drawing.Point(113, 126);
            this.TxtRsIGVMonto.MaskFormat = "";
            this.TxtRsIGVMonto.Name = "TxtRsIGVMonto";
            this.TxtRsIGVMonto.Requiere = false;
            this.TxtRsIGVMonto.Size = new System.Drawing.Size(105, 20);
            this.TxtRsIGVMonto.TabIndex = 19;
            this.TxtRsIGVMonto.Text = "0.00";
            this.TxtRsIGVMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtRsOtrosTribCarg
            // 
            this.TxtRsOtrosTribCarg.Contenido = dhsoft.Enums.TipoTexto.OnlyDecimal;
            this.TxtRsOtrosTribCarg.DecimalPrecision = 2;
            this.TxtRsOtrosTribCarg.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.TxtRsOtrosTribCarg.DisabledForeColor = System.Drawing.Color.Black;
            this.TxtRsOtrosTribCarg.Enabled = false;
            this.TxtRsOtrosTribCarg.Enganche = null;
            this.TxtRsOtrosTribCarg.EnterEmuleTab = true;
            this.TxtRsOtrosTribCarg.IsDecimalNegative = false;
            this.TxtRsOtrosTribCarg.LinkKeyDown = null;
            this.TxtRsOtrosTribCarg.Location = new System.Drawing.Point(113, 147);
            this.TxtRsOtrosTribCarg.MaskFormat = "";
            this.TxtRsOtrosTribCarg.Name = "TxtRsOtrosTribCarg";
            this.TxtRsOtrosTribCarg.Requiere = false;
            this.TxtRsOtrosTribCarg.Size = new System.Drawing.Size(105, 20);
            this.TxtRsOtrosTribCarg.TabIndex = 21;
            this.TxtRsOtrosTribCarg.Text = "0.00";
            this.TxtRsOtrosTribCarg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtRsIGVPorc
            // 
            this.TxtRsIGVPorc.Contenido = dhsoft.Enums.TipoTexto.OnlyDecimal;
            this.TxtRsIGVPorc.DecimalPrecision = 2;
            this.TxtRsIGVPorc.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.TxtRsIGVPorc.DisabledForeColor = System.Drawing.Color.Black;
            this.TxtRsIGVPorc.Enabled = false;
            this.TxtRsIGVPorc.Enganche = null;
            this.TxtRsIGVPorc.EnterEmuleTab = true;
            this.TxtRsIGVPorc.IsDecimalNegative = false;
            this.TxtRsIGVPorc.LinkKeyDown = null;
            this.TxtRsIGVPorc.Location = new System.Drawing.Point(41, 126);
            this.TxtRsIGVPorc.MaskFormat = "";
            this.TxtRsIGVPorc.Name = "TxtRsIGVPorc";
            this.TxtRsIGVPorc.Requiere = false;
            this.TxtRsIGVPorc.Size = new System.Drawing.Size(37, 20);
            this.TxtRsIGVPorc.TabIndex = 17;
            this.TxtRsIGVPorc.Text = "0.00";
            this.TxtRsIGVPorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtRsExonerada
            // 
            this.TxtRsExonerada.Contenido = dhsoft.Enums.TipoTexto.OnlyDecimal;
            this.TxtRsExonerada.DecimalPrecision = 2;
            this.TxtRsExonerada.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.TxtRsExonerada.DisabledForeColor = System.Drawing.Color.Black;
            this.TxtRsExonerada.Enabled = false;
            this.TxtRsExonerada.Enganche = null;
            this.TxtRsExonerada.EnterEmuleTab = true;
            this.TxtRsExonerada.IsDecimalNegative = false;
            this.TxtRsExonerada.LinkKeyDown = null;
            this.TxtRsExonerada.Location = new System.Drawing.Point(113, 60);
            this.TxtRsExonerada.MaskFormat = "";
            this.TxtRsExonerada.Name = "TxtRsExonerada";
            this.TxtRsExonerada.Requiere = false;
            this.TxtRsExonerada.Size = new System.Drawing.Size(105, 20);
            this.TxtRsExonerada.TabIndex = 11;
            this.TxtRsExonerada.Text = "0.00";
            this.TxtRsExonerada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label28
            // 
            this.Label28.AutoSize = true;
            this.Label28.BackColor = System.Drawing.Color.Transparent;
            this.Label28.Location = new System.Drawing.Point(2, 20);
            this.Label28.Name = "Label28";
            this.Label28.Size = new System.Drawing.Size(88, 13);
            this.Label28.TabIndex = 6;
            this.Label28.Text = "Val. Fact. Export.";
            // 
            // Label36
            // 
            this.Label36.AutoSize = true;
            this.Label36.BackColor = System.Drawing.Color.Transparent;
            this.Label36.Location = new System.Drawing.Point(3, 176);
            this.Label36.Name = "Label36";
            this.Label36.Size = new System.Drawing.Size(69, 13);
            this.Label36.TabIndex = 22;
            this.Label36.Text = "Importe Total";
            // 
            // Label33
            // 
            this.Label33.AutoSize = true;
            this.Label33.BackColor = System.Drawing.Color.Transparent;
            this.Label33.Location = new System.Drawing.Point(2, 85);
            this.Label33.Name = "Label33";
            this.Label33.Size = new System.Drawing.Size(46, 13);
            this.Label33.TabIndex = 12;
            this.Label33.Text = "Inafecta";
            // 
            // Label35
            // 
            this.Label35.AutoSize = true;
            this.Label35.BackColor = System.Drawing.Color.Transparent;
            this.Label35.Location = new System.Drawing.Point(81, 129);
            this.Label35.Name = "Label35";
            this.Label35.Size = new System.Drawing.Size(15, 13);
            this.Label35.TabIndex = 18;
            this.Label35.Text = "%";
            // 
            // TxtRsImporteTotal
            // 
            this.TxtRsImporteTotal.Contenido = dhsoft.Enums.TipoTexto.OnlyDecimal;
            this.TxtRsImporteTotal.DecimalPrecision = 2;
            this.TxtRsImporteTotal.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.TxtRsImporteTotal.DisabledForeColor = System.Drawing.Color.Black;
            this.TxtRsImporteTotal.Enabled = false;
            this.TxtRsImporteTotal.Enganche = null;
            this.TxtRsImporteTotal.EnterEmuleTab = true;
            this.TxtRsImporteTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRsImporteTotal.IsDecimalNegative = false;
            this.TxtRsImporteTotal.LinkKeyDown = null;
            this.TxtRsImporteTotal.Location = new System.Drawing.Point(94, 171);
            this.TxtRsImporteTotal.MaskFormat = "";
            this.TxtRsImporteTotal.Name = "TxtRsImporteTotal";
            this.TxtRsImporteTotal.Requiere = false;
            this.TxtRsImporteTotal.Size = new System.Drawing.Size(124, 22);
            this.TxtRsImporteTotal.TabIndex = 23;
            this.TxtRsImporteTotal.Text = "0.00";
            this.TxtRsImporteTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label31
            // 
            this.Label31.AutoSize = true;
            this.Label31.BackColor = System.Drawing.Color.Transparent;
            this.Label31.Location = new System.Drawing.Point(2, 41);
            this.Label31.Name = "Label31";
            this.Label31.Size = new System.Drawing.Size(104, 13);
            this.Label31.TabIndex = 8;
            this.Label31.Text = "Base Imponible O.G.";
            // 
            // ChkOtrosTribCarg
            // 
            this.ChkOtrosTribCarg.AutoSize = true;
            this.ChkOtrosTribCarg.BackColor = System.Drawing.Color.Transparent;
            this.ChkOtrosTribCarg.Location = new System.Drawing.Point(4, 150);
            this.ChkOtrosTribCarg.Name = "ChkOtrosTribCarg";
            this.ChkOtrosTribCarg.Size = new System.Drawing.Size(113, 17);
            this.ChkOtrosTribCarg.TabIndex = 20;
            this.ChkOtrosTribCarg.Text = "O.Tributos/Cargos";
            this.ChkOtrosTribCarg.UseVisualStyleBackColor = false;
            this.ChkOtrosTribCarg.CheckedChanged += new System.EventHandler(this.ChkOtrosTribCarg_CheckedChanged);
            // 
            // gbdetalle
            // 
            this.gbdetalle.Controls.Add(this.cbotipo);
            this.gbdetalle.Controls.Add(this.TxtItCantidad);
            this.gbdetalle.Controls.Add(this.Label26);
            this.gbdetalle.Controls.Add(this.TxtItImporte);
            this.gbdetalle.Controls.Add(this.TxtPrecunitario);
            this.gbdetalle.Controls.Add(this.label25);
            this.gbdetalle.Controls.Add(this.label27);
            this.gbdetalle.Controls.Add(this.TxtItNum);
            this.gbdetalle.Controls.Add(this.label3);
            this.gbdetalle.Controls.Add(this.label4);
            this.gbdetalle.Controls.Add(this.txtproductodesc);
            this.gbdetalle.Controls.Add(this.lbldescripcionproser);
            this.gbdetalle.Controls.Add(this.txtproducto);
            this.gbdetalle.Controls.Add(this.txtunidadmedida);
            this.gbdetalle.Controls.Add(this.label6);
            this.gbdetalle.Location = new System.Drawing.Point(0, 149);
            this.gbdetalle.Name = "gbdetalle";
            this.gbdetalle.Size = new System.Drawing.Size(681, 98);
            this.gbdetalle.TabIndex = 1;
            this.gbdetalle.TabStop = false;
            this.gbdetalle.Text = "detalles";
            // 
            // cbotipo
            // 
            this.cbotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipo.FormattingEnabled = true;
            this.cbotipo.Location = new System.Drawing.Point(113, 13);
            this.cbotipo.Name = "cbotipo";
            this.cbotipo.Size = new System.Drawing.Size(117, 21);
            this.cbotipo.TabIndex = 3;
            this.cbotipo.SelectedIndexChanged += new System.EventHandler(this.cbotipo_SelectedIndexChanged);
            // 
            // TxtItCantidad
            // 
            this.TxtItCantidad.Contenido = dhsoft.Enums.TipoTexto.OnlyDecimal;
            this.TxtItCantidad.DecimalPrecision = 2;
            this.TxtItCantidad.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.TxtItCantidad.DisabledForeColor = System.Drawing.Color.Black;
            this.TxtItCantidad.Enganche = null;
            this.TxtItCantidad.EnterEmuleTab = true;
            this.TxtItCantidad.IsDecimalNegative = false;
            this.TxtItCantidad.LinkKeyDown = null;
            this.TxtItCantidad.Location = new System.Drawing.Point(447, 39);
            this.TxtItCantidad.MaskFormat = "";
            this.TxtItCantidad.MaxLength = 5;
            this.TxtItCantidad.Name = "TxtItCantidad";
            this.TxtItCantidad.Requiere = false;
            this.TxtItCantidad.Size = new System.Drawing.Size(75, 20);
            this.TxtItCantidad.TabIndex = 10;
            this.TxtItCantidad.Text = "0.00";
            this.TxtItCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtItCantidad.TextChanged += new System.EventHandler(this.TxtItCantidad_TextChanged);
            this.TxtItCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtItCantidad_KeyDown);
            this.TxtItCantidad.Validating += new System.ComponentModel.CancelEventHandler(this.TxtItCantidad_Validating);
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.BackColor = System.Drawing.Color.Transparent;
            this.Label26.Location = new System.Drawing.Point(526, 45);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(39, 13);
            this.Label26.TabIndex = 11;
            this.Label26.Text = "P.U.N.";
            // 
            // TxtItImporte
            // 
            this.TxtItImporte.Contenido = dhsoft.Enums.TipoTexto.OnlyDecimal;
            this.TxtItImporte.DecimalPrecision = 2;
            this.TxtItImporte.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.TxtItImporte.DisabledForeColor = System.Drawing.Color.Black;
            this.TxtItImporte.Enabled = false;
            this.TxtItImporte.Enganche = null;
            this.TxtItImporte.EnterEmuleTab = true;
            this.TxtItImporte.IsDecimalNegative = false;
            this.TxtItImporte.LinkKeyDown = null;
            this.TxtItImporte.Location = new System.Drawing.Point(113, 65);
            this.TxtItImporte.MaskFormat = "";
            this.TxtItImporte.MaxLength = 5;
            this.TxtItImporte.Name = "TxtItImporte";
            this.TxtItImporte.Requiere = true;
            this.TxtItImporte.Size = new System.Drawing.Size(83, 20);
            this.TxtItImporte.TabIndex = 14;
            this.TxtItImporte.Text = "0.00";
            this.TxtItImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtPrecunitario
            // 
            this.TxtPrecunitario.Contenido = dhsoft.Enums.TipoTexto.OnlyDecimal;
            this.TxtPrecunitario.DecimalPrecision = 2;
            this.TxtPrecunitario.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.TxtPrecunitario.DisabledForeColor = System.Drawing.Color.Black;
            this.TxtPrecunitario.Enabled = false;
            this.TxtPrecunitario.Enganche = null;
            this.TxtPrecunitario.EnterEmuleTab = true;
            this.TxtPrecunitario.IsDecimalNegative = false;
            this.TxtPrecunitario.LinkKeyDown = null;
            this.TxtPrecunitario.Location = new System.Drawing.Point(573, 40);
            this.TxtPrecunitario.MaskFormat = "";
            this.TxtPrecunitario.MaxLength = 5;
            this.TxtPrecunitario.Name = "TxtPrecunitario";
            this.TxtPrecunitario.Requiere = false;
            this.TxtPrecunitario.Size = new System.Drawing.Size(102, 20);
            this.TxtPrecunitario.TabIndex = 12;
            this.TxtPrecunitario.Text = "0.00";
            this.TxtPrecunitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Location = new System.Drawing.Point(397, 43);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(49, 13);
            this.label25.TabIndex = 9;
            this.label25.Text = "Cantidad";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Location = new System.Drawing.Point(70, 68);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(42, 13);
            this.label27.TabIndex = 13;
            this.label27.Text = "Importe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "tipo";
            // 
            // txtproductodesc
            // 
            this.txtproductodesc.Contenido = dhsoft.Enums.TipoTexto.NormalText;
            this.txtproductodesc.DecimalPrecision = 0;
            this.txtproductodesc.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txtproductodesc.DisabledForeColor = System.Drawing.Color.Black;
            this.txtproductodesc.Enabled = false;
            this.txtproductodesc.Enganche = null;
            this.txtproductodesc.EnterEmuleTab = true;
            this.txtproductodesc.IsDecimalNegative = false;
            this.txtproductodesc.LinkKeyDown = null;
            this.txtproductodesc.Location = new System.Drawing.Point(392, 14);
            this.txtproductodesc.MaskFormat = null;
            this.txtproductodesc.Name = "txtproductodesc";
            this.txtproductodesc.Requiere = false;
            this.txtproductodesc.Size = new System.Drawing.Size(283, 20);
            this.txtproductodesc.TabIndex = 6;
            // 
            // BtnDtGrabar
            // 
            this.BtnDtGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDtGrabar.Location = new System.Drawing.Point(142, 253);
            this.BtnDtGrabar.Name = "BtnDtGrabar";
            this.BtnDtGrabar.Size = new System.Drawing.Size(70, 23);
            this.BtnDtGrabar.TabIndex = 15;
            this.BtnDtGrabar.Text = "Agregar";
            this.BtnDtGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDtGrabar.UseVisualStyleBackColor = true;
            this.BtnDtGrabar.Click += new System.EventHandler(this.BtnDtGrabar_Click);
            // 
            // BtnDtNuevo
            // 
            this.BtnDtNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDtNuevo.Location = new System.Drawing.Point(4, 253);
            this.BtnDtNuevo.Name = "BtnDtNuevo";
            this.BtnDtNuevo.Size = new System.Drawing.Size(70, 23);
            this.BtnDtNuevo.TabIndex = 2;
            this.BtnDtNuevo.Text = "Nuevo";
            this.BtnDtNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDtNuevo.UseVisualStyleBackColor = true;
            this.BtnDtNuevo.Click += new System.EventHandler(this.BtnDtNuevo_Click);
            // 
            // BtnDtEliminar
            // 
            this.BtnDtEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDtEliminar.Location = new System.Drawing.Point(211, 253);
            this.BtnDtEliminar.Name = "BtnDtEliminar";
            this.BtnDtEliminar.Size = new System.Drawing.Size(70, 23);
            this.BtnDtEliminar.TabIndex = 63;
            this.BtnDtEliminar.Text = "Quitar";
            this.BtnDtEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDtEliminar.UseVisualStyleBackColor = true;
            this.BtnDtEliminar.Click += new System.EventHandler(this.BtnDtEliminar_Click);
            // 
            // BtnDtEditar
            // 
            this.BtnDtEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDtEditar.Location = new System.Drawing.Point(73, 253);
            this.BtnDtEditar.Name = "BtnDtEditar";
            this.BtnDtEditar.Size = new System.Drawing.Size(70, 23);
            this.BtnDtEditar.TabIndex = 62;
            this.BtnDtEditar.Text = "Editar";
            this.BtnDtEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDtEditar.UseVisualStyleBackColor = true;
            this.BtnDtEditar.Click += new System.EventHandler(this.BtnDtEditar_Click);
            // 
            // DgvDetalle
            // 
            this.DgvDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvDetalle.Cursor = System.Windows.Forms.Cursors.Default;
            this.DgvDetalle.Location = new System.Drawing.Point(0, 282);
            this.DgvDetalle.MainView = this.GridView1;
            this.DgvDetalle.Name = "DgvDetalle";
            this.DgvDetalle.Size = new System.Drawing.Size(903, 233);
            this.DgvDetalle.TabIndex = 64;
            this.DgvDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridView1});
            // 
            // GridView1
            // 
            this.GridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(87)))), ((int)(((byte)(138)))));
            this.GridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(87)))), ((int)(((byte)(138)))));
            this.GridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.GridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.GridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.GridView1.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.GridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(109)))), ((int)(((byte)(158)))));
            this.GridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(109)))), ((int)(((byte)(158)))));
            this.GridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.GridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.GridView1.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.GridView1.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.GridView1.Appearance.Empty.Options.UseBackColor = true;
            this.GridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.GridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.GridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.GridView1.Appearance.EvenRow.Options.UseForeColor = true;
            this.GridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(87)))), ((int)(((byte)(138)))));
            this.GridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(87)))), ((int)(((byte)(138)))));
            this.GridView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.GridView1.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.GridView1.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.GridView1.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.GridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.GridView1.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.GridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(87)))), ((int)(((byte)(138)))));
            this.GridView1.Appearance.FilterPanel.Options.UseBackColor = true;
            this.GridView1.Appearance.FilterPanel.Options.UseForeColor = true;
            this.GridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(178)))), ((int)(((byte)(185)))));
            this.GridView1.Appearance.FixedLine.Options.UseBackColor = true;
            this.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.GridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.GridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.GridView1.Appearance.FocusedCell.Options.UseForeColor = true;
            this.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(87)))), ((int)(((byte)(138)))));
            this.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.GridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.GridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.GridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(87)))), ((int)(((byte)(138)))));
            this.GridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(87)))), ((int)(((byte)(138)))));
            this.GridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.GridView1.Appearance.FooterPanel.Options.UseBackColor = true;
            this.GridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.GridView1.Appearance.FooterPanel.Options.UseForeColor = true;
            this.GridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(87)))), ((int)(((byte)(138)))));
            this.GridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(87)))), ((int)(((byte)(138)))));
            this.GridView1.Appearance.GroupButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.GridView1.Appearance.GroupButton.Options.UseBackColor = true;
            this.GridView1.Appearance.GroupButton.Options.UseBorderColor = true;
            this.GridView1.Appearance.GroupButton.Options.UseForeColor = true;
            this.GridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(109)))), ((int)(((byte)(158)))));
            this.GridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(109)))), ((int)(((byte)(158)))));
            this.GridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.GridView1.Appearance.GroupFooter.Options.UseBackColor = true;
            this.GridView1.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.GridView1.Appearance.GroupFooter.Options.UseForeColor = true;
            this.GridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.GridView1.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.GridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.GridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.GridView1.Appearance.GroupPanel.Options.UseForeColor = true;
            this.GridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(109)))), ((int)(((byte)(158)))));
            this.GridView1.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(109)))), ((int)(((byte)(158)))));
            this.GridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.GridView1.Appearance.GroupRow.Options.UseBackColor = true;
            this.GridView1.Appearance.GroupRow.Options.UseBorderColor = true;
            this.GridView1.Appearance.GroupRow.Options.UseForeColor = true;
            this.GridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(109)))), ((int)(((byte)(158)))));
            this.GridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(109)))), ((int)(((byte)(158)))));
            this.GridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
            this.GridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.GridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.GridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.GridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.GridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(153)))), ((int)(((byte)(195)))));
            this.GridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.GridView1.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.GridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(178)))), ((int)(((byte)(185)))));
            this.GridView1.Appearance.HorzLine.Options.UseBackColor = true;
            this.GridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.GridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.GridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.GridView1.Appearance.OddRow.Options.UseForeColor = true;
            this.GridView1.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.GridView1.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.GridView1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(87)))), ((int)(((byte)(138)))));
            this.GridView1.Appearance.Preview.Options.UseBackColor = true;
            this.GridView1.Appearance.Preview.Options.UseFont = true;
            this.GridView1.Appearance.Preview.Options.UseForeColor = true;
            this.GridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.GridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 7.5F);
            this.GridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.GridView1.Appearance.Row.Options.UseBackColor = true;
            this.GridView1.Appearance.Row.Options.UseFont = true;
            this.GridView1.Appearance.Row.Options.UseForeColor = true;
            this.GridView1.Appearance.Row.Options.UseTextOptions = true;
            this.GridView1.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.GridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.GridView1.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.GridView1.Appearance.RowSeparator.Options.UseBackColor = true;
            this.GridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(133)))), ((int)(((byte)(179)))));
            this.GridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.GridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.GridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.GridView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.GridView1.Appearance.TopNewRow.Options.UseBackColor = true;
            this.GridView1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(178)))), ((int)(((byte)(185)))));
            this.GridView1.Appearance.VertLine.Options.UseBackColor = true;
            this.GridView1.ColumnPanelRowHeight = 20;
            this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.GridView1.GridControl = this.DgvDetalle;
            this.GridView1.Name = "GridView1";
            this.GridView1.OptionsView.ColumnAutoWidth = false;
            this.GridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.GridView1.OptionsView.EnableAppearanceOddRow = true;
            this.GridView1.OptionsView.ShowAutoFilterRow = true;
            this.GridView1.OptionsView.ShowGroupPanel = false;
            this.GridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GridView1_RowClick);
            // 
            // GridColumn1
            // 
            this.GridColumn1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.5F);
            this.GridColumn1.AppearanceCell.Options.UseFont = true;
            this.GridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
            this.GridColumn1.AppearanceHeader.Options.UseFont = true;
            this.GridColumn1.Caption = "Nº";
            this.GridColumn1.FieldName = "id_det";
            this.GridColumn1.Name = "GridColumn1";
            this.GridColumn1.OptionsColumn.AllowEdit = false;
            this.GridColumn1.OptionsColumn.FixedWidth = true;
            this.GridColumn1.Visible = true;
            this.GridColumn1.VisibleIndex = 0;
            this.GridColumn1.Width = 45;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Producto - Servicio";
            this.gridColumn2.FieldName = "productodesc";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 324;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Unidad de medida";
            this.gridColumn3.FieldName = "unidad_medida_desc";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 191;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Cantidad";
            this.gridColumn4.FieldName = "cantidad";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Precio Unitario";
            this.gridColumn5.FieldName = "precio_unitario";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 109;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Total";
            this.gridColumn6.FieldName = "total_det";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Tipo";
            this.gridColumn7.FieldName = "tipo_bien_servicio_desc";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            this.gridColumn7.Width = 98;
            // 
            // frm_facturacion_edicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 527);
            this.Controls.Add(this.DgvDetalle);
            this.Controls.Add(this.BtnDtGrabar);
            this.Controls.Add(this.BtnDtNuevo);
            this.Controls.Add(this.BtnDtEliminar);
            this.Controls.Add(this.BtnDtEditar);
            this.Controls.Add(this.gbdetalle);
            this.Controls.Add(this.GbxResumen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frm_facturacion_edicion";
            this.Text = "Facturación";
            this.Load += new System.EventHandler(this.frm_facturacion_edicion_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GbxResumen.ResumeLayout(false);
            this.GbxResumen.PerformLayout();
            this.gbdetalle.ResumeLayout(false);
            this.gbdetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btngrabar;
        private System.Windows.Forms.GroupBox groupBox1;
        private dhsoft.MaskedTextBoxNew txtfechaemision;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private dhsoft.TextBoxNew txtnumero;
        private dhsoft.TextBoxNew txtserie;
        private dhsoft.TextBoxNew txtclienterucdnides;
        private dhsoft.TextBoxNew txtclienterucdni;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbldescripcionproser;
        private System.Windows.Forms.Label label3;
        private dhsoft.TextBoxNew txtunidadmedida;
        private dhsoft.TextBoxNew txtproducto;
        private dhsoft.TextBoxNew TxtItNum;
        internal System.Windows.Forms.GroupBox GbxResumen;
        internal System.Windows.Forms.Label Label34;
        internal System.Windows.Forms.Label Label40;
        internal dhsoft.TextBoxNew TxtRsISC;
        internal System.Windows.Forms.Label Label32;
        internal dhsoft.TextBoxNew TxtRsValExporta;
        internal dhsoft.TextBoxNew TxtRsBaseImponible;
        internal dhsoft.TextBoxNew TxtRsInAfecta;
        internal dhsoft.TextBoxNew TxtRsIGVMonto;
        internal dhsoft.TextBoxNew TxtRsOtrosTribCarg;
        internal dhsoft.TextBoxNew TxtRsIGVPorc;
        internal dhsoft.TextBoxNew TxtRsExonerada;
        internal System.Windows.Forms.Label Label28;
        internal System.Windows.Forms.Label Label36;
        internal System.Windows.Forms.Label Label33;
        internal System.Windows.Forms.Label Label35;
        internal dhsoft.TextBoxNew TxtRsImporteTotal;
        internal System.Windows.Forms.Label Label31;
        internal dhsoft.CheckBoxNew ChkOtrosTribCarg;
        private System.Windows.Forms.GroupBox gbdetalle;
        internal dhsoft.TextBoxNew TxtItCantidad;
        internal System.Windows.Forms.Label Label26;
        internal dhsoft.TextBoxNew TxtItImporte;
        internal dhsoft.TextBoxNew TxtPrecunitario;
        internal System.Windows.Forms.Label label25;
        internal System.Windows.Forms.Label label27;
        private dhsoft.TextBoxNew txtproductodesc;
        internal System.Windows.Forms.Button BtnDtGrabar;
        internal System.Windows.Forms.Button BtnDtNuevo;
        internal System.Windows.Forms.Button BtnDtEliminar;
        internal System.Windows.Forms.Button BtnDtEditar;
        internal DevExpress.XtraGrid.GridControl DgvDetalle;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn1;
        private System.Windows.Forms.ComboBox cbocomprobamte;
        private System.Windows.Forms.ComboBox cbotipo;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private System.Windows.Forms.ComboBox cbomoneda;
        private System.Windows.Forms.Label label5;
        internal dhsoft.TextBoxNew txttipocambio;
        internal System.Windows.Forms.Label label7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
    }
}