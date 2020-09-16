namespace interfacedsk.reportes
{
    partial class frm_reporte_ventas_detallado
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
            this.btnnuevo = new System.Windows.Forms.ToolStripButton();
            this.btnexportar = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnverreporte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfechahasta = new dhsoft.MaskedTextBoxNew();
            this.txtclienterucdnides = new dhsoft.TextBoxNew(this.components);
            this.txtclienterucdni = new dhsoft.TextBoxNew(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtfechainicio = new dhsoft.MaskedTextBoxNew();
            this.label23 = new System.Windows.Forms.Label();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField3 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField4 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField5 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField6 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField7 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField8 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField9 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField10 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField11 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField12 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField13 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField14 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField15 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField16 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnnuevo,
            this.btnexportar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1133, 39);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnnuevo
            // 
            this.btnnuevo.Image = global::interfacedsk.Properties.Resources.nuevo;
            this.btnnuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnnuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(125, 36);
            this.btnnuevo.Text = "Vista preliminar";
            // 
            // btnexportar
            // 
            this.btnexportar.Image = global::interfacedsk.Properties.Resources.exportar;
            this.btnexportar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnexportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(86, 36);
            this.btnexportar.Text = "Exportar";
            this.btnexportar.Click += new System.EventHandler(this.btnexportar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnverreporte);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtfechahasta);
            this.groupBox1.Controls.Add(this.txtclienterucdnides);
            this.groupBox1.Controls.Add(this.txtclienterucdni);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtfechainicio);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1133, 37);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btnverreporte
            // 
            this.btnverreporte.Location = new System.Drawing.Point(722, 8);
            this.btnverreporte.Name = "btnverreporte";
            this.btnverreporte.Size = new System.Drawing.Size(75, 23);
            this.btnverreporte.TabIndex = 7;
            this.btnverreporte.Text = "Ver";
            this.btnverreporte.UseVisualStyleBackColor = true;
            this.btnverreporte.Click += new System.EventHandler(this.btnverreporte_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "cliente";
            // 
            // txtfechahasta
            // 
            this.txtfechahasta.IsValueDate = false;
            this.txtfechahasta.Location = new System.Drawing.Point(152, 10);
            this.txtfechahasta.Mask = "00/00/0000";
            this.txtfechahasta.Name = "txtfechahasta";
            this.txtfechahasta.Requiere = false;
            this.txtfechahasta.Size = new System.Drawing.Size(65, 20);
            this.txtfechahasta.TabIndex = 3;
            this.txtfechahasta.ValidatingType = typeof(System.DateTime);
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
            this.txtclienterucdnides.Location = new System.Drawing.Point(358, 10);
            this.txtclienterucdnides.MaskFormat = null;
            this.txtclienterucdnides.Name = "txtclienterucdnides";
            this.txtclienterucdnides.Requiere = false;
            this.txtclienterucdnides.Size = new System.Drawing.Size(358, 20);
            this.txtclienterucdnides.TabIndex = 6;
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
            this.txtclienterucdni.Location = new System.Drawing.Point(267, 10);
            this.txtclienterucdni.MaskFormat = null;
            this.txtclienterucdni.Name = "txtclienterucdni";
            this.txtclienterucdni.Requiere = false;
            this.txtclienterucdni.Size = new System.Drawing.Size(89, 20);
            this.txtclienterucdni.TabIndex = 5;
            this.txtclienterucdni.TextChanged += new System.EventHandler(this.txtclienterucdni_TextChanged);
            this.txtclienterucdni.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtclienterucdni_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta";
            // 
            // txtfechainicio
            // 
            this.txtfechainicio.IsValueDate = false;
            this.txtfechainicio.Location = new System.Drawing.Point(46, 10);
            this.txtfechainicio.Mask = "00/00/0000";
            this.txtfechainicio.Name = "txtfechainicio";
            this.txtfechainicio.Requiere = false;
            this.txtfechainicio.Size = new System.Drawing.Size(65, 20);
            this.txtfechainicio.TabIndex = 1;
            this.txtfechainicio.ValidatingType = typeof(System.DateTime);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(7, 13);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(38, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "Desde";
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Appearance.ColumnHeaderArea.ForeColor = System.Drawing.Color.Black;
            this.pivotGridControl1.Appearance.ColumnHeaderArea.Options.UseForeColor = true;
            this.pivotGridControl1.Appearance.FieldHeader.ForeColor = System.Drawing.Color.Black;
            this.pivotGridControl1.Appearance.FieldHeader.Options.UseForeColor = true;
            this.pivotGridControl1.Appearance.FieldValue.ForeColor = System.Drawing.Color.Black;
            this.pivotGridControl1.Appearance.FieldValue.Options.UseForeColor = true;
            this.pivotGridControl1.Appearance.FieldValueTotal.ForeColor = System.Drawing.Color.Black;
            this.pivotGridControl1.Appearance.FieldValueTotal.Options.UseForeColor = true;
            this.pivotGridControl1.Appearance.FilterHeaderArea.ForeColor = System.Drawing.Color.Black;
            this.pivotGridControl1.Appearance.FilterHeaderArea.Options.UseForeColor = true;
            this.pivotGridControl1.Appearance.HeaderArea.ForeColor = System.Drawing.Color.Black;
            this.pivotGridControl1.Appearance.HeaderArea.Options.UseForeColor = true;
            this.pivotGridControl1.Appearance.Lines.ForeColor = System.Drawing.Color.Black;
            this.pivotGridControl1.Appearance.Lines.Options.UseForeColor = true;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pivotGridField1,
            this.pivotGridField2,
            this.pivotGridField3,
            this.pivotGridField4,
            this.pivotGridField5,
            this.pivotGridField6,
            this.pivotGridField7,
            this.pivotGridField8,
            this.pivotGridField9,
            this.pivotGridField10,
            this.pivotGridField11,
            this.pivotGridField12,
            this.pivotGridField13,
            this.pivotGridField14,
            this.pivotGridField15,
            this.pivotGridField16});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 76);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(1133, 481);
            this.pivotGridControl1.TabIndex = 6;
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.AreaIndex = 1;
            this.pivotGridField1.Caption = "Comprobante";
            this.pivotGridField1.FieldName = "comprobante_desc";
            this.pivotGridField1.Name = "pivotGridField1";
            this.pivotGridField1.Options.AllowEdit = false;
            // 
            // pivotGridField2
            // 
            this.pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField2.AreaIndex = 1;
            this.pivotGridField2.Caption = "Serie";
            this.pivotGridField2.FieldName = "serie";
            this.pivotGridField2.Name = "pivotGridField2";
            this.pivotGridField2.Options.AllowEdit = false;
            // 
            // pivotGridField3
            // 
            this.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField3.AreaIndex = 2;
            this.pivotGridField3.Caption = "Número";
            this.pivotGridField3.FieldName = "numero";
            this.pivotGridField3.Name = "pivotGridField3";
            this.pivotGridField3.Options.AllowEdit = false;
            // 
            // pivotGridField4
            // 
            this.pivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField4.AreaIndex = 0;
            this.pivotGridField4.Caption = "Fecha emisión";
            this.pivotGridField4.FieldName = "fechaEmision";
            this.pivotGridField4.Name = "pivotGridField4";
            this.pivotGridField4.Options.AllowEdit = false;
            // 
            // pivotGridField5
            // 
            this.pivotGridField5.AreaIndex = 5;
            this.pivotGridField5.Caption = "Cliente";
            this.pivotGridField5.FieldName = "cliente_desc";
            this.pivotGridField5.Name = "pivotGridField5";
            this.pivotGridField5.Options.AllowEdit = false;
            // 
            // pivotGridField6
            // 
            this.pivotGridField6.AreaIndex = 0;
            this.pivotGridField6.Caption = "RUC/DNI";
            this.pivotGridField6.FieldName = "cliente_dniRuc";
            this.pivotGridField6.Name = "pivotGridField6";
            this.pivotGridField6.Options.AllowEdit = false;
            // 
            // pivotGridField7
            // 
            this.pivotGridField7.AreaIndex = 2;
            this.pivotGridField7.Caption = "Moneda";
            this.pivotGridField7.FieldName = "modena_desc";
            this.pivotGridField7.Name = "pivotGridField7";
            this.pivotGridField7.Options.AllowEdit = false;
            // 
            // pivotGridField8
            // 
            this.pivotGridField8.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField8.AreaIndex = 0;
            this.pivotGridField8.Caption = "Total gravada";
            this.pivotGridField8.FieldName = "total_gravada";
            this.pivotGridField8.Name = "pivotGridField8";
            this.pivotGridField8.Options.AllowEdit = false;
            // 
            // pivotGridField9
            // 
            this.pivotGridField9.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField9.AreaIndex = 1;
            this.pivotGridField9.Caption = "Total exonerada";
            this.pivotGridField9.FieldName = "total_exonerada";
            this.pivotGridField9.Name = "pivotGridField9";
            this.pivotGridField9.Options.AllowEdit = false;
            // 
            // pivotGridField10
            // 
            this.pivotGridField10.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField10.AreaIndex = 2;
            this.pivotGridField10.Caption = "Total igv";
            this.pivotGridField10.FieldName = "total_igv";
            this.pivotGridField10.Name = "pivotGridField10";
            this.pivotGridField10.Options.AllowEdit = false;
            // 
            // pivotGridField11
            // 
            this.pivotGridField11.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField11.AreaIndex = 3;
            this.pivotGridField11.Caption = "Total";
            this.pivotGridField11.FieldName = "total_cab";
            this.pivotGridField11.Name = "pivotGridField11";
            this.pivotGridField11.Options.AllowEdit = false;
            // 
            // pivotGridField12
            // 
            this.pivotGridField12.AreaIndex = 6;
            this.pivotGridField12.Caption = "Tipo";
            this.pivotGridField12.FieldName = "tipo_bien_servicio_desc";
            this.pivotGridField12.Name = "pivotGridField12";
            this.pivotGridField12.Options.AllowEdit = false;
            // 
            // pivotGridField13
            // 
            this.pivotGridField13.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField13.AreaIndex = 3;
            this.pivotGridField13.Caption = "Producto/Servicio";
            this.pivotGridField13.FieldName = "productodesc";
            this.pivotGridField13.Name = "pivotGridField13";
            this.pivotGridField13.Options.AllowEdit = false;
            // 
            // pivotGridField14
            // 
            this.pivotGridField14.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField14.AreaIndex = 4;
            this.pivotGridField14.Caption = "Cantidad";
            this.pivotGridField14.FieldName = "cantidad";
            this.pivotGridField14.Name = "pivotGridField14";
            this.pivotGridField14.Options.AllowEdit = false;
            // 
            // pivotGridField15
            // 
            this.pivotGridField15.AreaIndex = 4;
            this.pivotGridField15.Caption = "Precio Unitario";
            this.pivotGridField15.FieldName = "precio_unitario";
            this.pivotGridField15.Name = "pivotGridField15";
            this.pivotGridField15.Options.AllowEdit = false;
            // 
            // pivotGridField16
            // 
            this.pivotGridField16.AreaIndex = 3;
            this.pivotGridField16.Caption = "Total Detalle";
            this.pivotGridField16.FieldName = "total_det";
            this.pivotGridField16.Name = "pivotGridField16";
            this.pivotGridField16.Options.AllowEdit = false;
            // 
            // frm_reporte_ventas_detallado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 557);
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frm_reporte_ventas_detallado";
            this.Text = "Reporte detallado";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnnuevo;
        private System.Windows.Forms.ToolStripButton btnexportar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnverreporte;
        private System.Windows.Forms.Label label1;
        private dhsoft.MaskedTextBoxNew txtfechahasta;
        private dhsoft.TextBoxNew txtclienterucdnides;
        private dhsoft.TextBoxNew txtclienterucdni;
        private System.Windows.Forms.Label label2;
        private dhsoft.MaskedTextBoxNew txtfechainicio;
        private System.Windows.Forms.Label label23;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField2;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField3;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField4;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField5;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField6;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField7;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField8;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField9;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField10;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField11;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField12;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField13;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField14;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField15;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField16;
    }
}