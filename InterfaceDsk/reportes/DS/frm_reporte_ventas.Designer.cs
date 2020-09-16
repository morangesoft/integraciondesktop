namespace interfacedsk.reportes
{
    partial class frm_reporte_ventas
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvdatos = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnnuevo = new System.Windows.Forms.ToolStripButton();
            this.btnexportar = new System.Windows.Forms.ToolStripButton();
            this.btnverdetalles = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnverreporte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfechahasta = new dhsoft.MaskedTextBoxNew();
            this.txtclienterucdnides = new dhsoft.TextBoxNew(this.components);
            this.txtclienterucdni = new dhsoft.TextBoxNew(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtfechainicio = new dhsoft.MaskedTextBoxNew();
            this.label23 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn18,
            this.gridColumn19,
            this.gridColumn20,
            this.gridColumn21,
            this.gridColumn22});
            this.gridView2.GridControl = this.dgvdatos;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Item";
            this.gridColumn16.FieldName = "id_det";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.OptionsColumn.AllowEdit = false;
            this.gridColumn16.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 0;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "Tipo";
            this.gridColumn17.FieldName = "tipo_bien_servicio_desc";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.OptionsColumn.AllowEdit = false;
            this.gridColumn17.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 1;
            this.gridColumn17.Width = 112;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "Producto / Servicio";
            this.gridColumn18.FieldName = "productodesc";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.OptionsColumn.AllowEdit = false;
            this.gridColumn18.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 2;
            this.gridColumn18.Width = 190;
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "Unidad Medida";
            this.gridColumn19.FieldName = "unidad_medida_desc";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.OptionsColumn.AllowEdit = false;
            this.gridColumn19.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 3;
            this.gridColumn19.Width = 168;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "Cantidad";
            this.gridColumn20.FieldName = "cantidad";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.OptionsColumn.AllowEdit = false;
            this.gridColumn20.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 4;
            this.gridColumn20.Width = 106;
            // 
            // gridColumn21
            // 
            this.gridColumn21.Caption = "Precio Unitario";
            this.gridColumn21.FieldName = "precio_unitario";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.OptionsColumn.AllowEdit = false;
            this.gridColumn21.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 5;
            this.gridColumn21.Width = 115;
            // 
            // gridColumn22
            // 
            this.gridColumn22.Caption = "Total";
            this.gridColumn22.FieldName = "total_det";
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.OptionsColumn.AllowEdit = false;
            this.gridColumn22.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn22.Visible = true;
            this.gridColumn22.VisibleIndex = 6;
            this.gridColumn22.Width = 110;
            // 
            // dgvdatos
            // 
            this.dgvdatos.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode1.RelationName = "Detalle_Ventas";
            this.dgvdatos.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.dgvdatos.Location = new System.Drawing.Point(0, 76);
            this.dgvdatos.MainView = this.gridView1;
            this.dgvdatos.Name = "dgvdatos";
            this.dgvdatos.Size = new System.Drawing.Size(1133, 481);
            this.dgvdatos.TabIndex = 5;
            this.dgvdatos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15});
            this.gridView1.GridControl = this.dgvdatos;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Comprobante";
            this.gridColumn1.FieldName = "comprobante_desc";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 127;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Serie";
            this.gridColumn2.FieldName = "serie";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 101;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Número";
            this.gridColumn3.FieldName = "numero";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 95;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Fecha emisión";
            this.gridColumn4.FieldName = "fechaEmision";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 91;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "RUC/DNI Cliente";
            this.gridColumn5.FieldName = "cliente_dniRuc";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 130;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Cliente";
            this.gridColumn6.FieldName = "cliente_desc";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 281;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Moneda";
            this.gridColumn7.FieldName = "modena_desc";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 123;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Tipo de cambio";
            this.gridColumn8.DisplayFormat.FormatString = "n3";
            this.gridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn8.FieldName = "tipo_cambio_monto";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            this.gridColumn8.Width = 128;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Total gravada";
            this.gridColumn9.DisplayFormat.FormatString = "n2";
            this.gridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn9.FieldName = "total_gravada";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total_gravada", "{0:n2}")});
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            this.gridColumn9.Width = 117;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Total inafecta";
            this.gridColumn10.DisplayFormat.FormatString = "n2";
            this.gridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn10.FieldName = "total_inafecta";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total_inafecta", "{0:n2}")});
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 9;
            this.gridColumn10.Width = 133;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Total exonerada";
            this.gridColumn11.DisplayFormat.FormatString = "n2";
            this.gridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn11.FieldName = "total_exonerada";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total_exonerada", "{0:n2}")});
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 10;
            this.gridColumn11.Width = 118;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Total igv";
            this.gridColumn12.DisplayFormat.FormatString = "n2";
            this.gridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn12.FieldName = "total_igv";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total_igv", "{0:n2}")});
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 11;
            this.gridColumn12.Width = 90;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Total otros cargos";
            this.gridColumn13.DisplayFormat.FormatString = "n2";
            this.gridColumn13.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn13.FieldName = "total_otros_cargos";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.AllowEdit = false;
            this.gridColumn13.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total_otros_cargos", "{0:n2}")});
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 12;
            this.gridColumn13.Width = 117;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Total";
            this.gridColumn14.DisplayFormat.FormatString = "n2";
            this.gridColumn14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn14.FieldName = "total_cab";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.OptionsColumn.AllowEdit = false;
            this.gridColumn14.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total_cab", "{0:n2}")});
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 13;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Aceptado por sunat";
            this.gridColumn15.FieldName = "aceptado_por_sunat";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.OptionsColumn.AllowEdit = false;
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 14;
            this.gridColumn15.Width = 105;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnnuevo,
            this.btnexportar,
            this.btnverdetalles});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1133, 39);
            this.toolStrip1.TabIndex = 3;
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
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
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
            // btnverdetalles
            // 
            this.btnverdetalles.Image = global::interfacedsk.Properties.Resources.verdetalles;
            this.btnverdetalles.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnverdetalles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnverdetalles.Name = "btnverdetalles";
            this.btnverdetalles.Size = new System.Drawing.Size(103, 36);
            this.btnverdetalles.Text = "Ver Detalles";
            this.btnverdetalles.Click += new System.EventHandler(this.btnverdetalles_Click);
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
            this.groupBox1.TabIndex = 0;
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
            // frm_reporte_ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 557);
            this.Controls.Add(this.dgvdatos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frm_reporte_ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de venta";
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnnuevo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnverreporte;
        private System.Windows.Forms.Label label1;
        private dhsoft.MaskedTextBoxNew txtfechahasta;
        private dhsoft.TextBoxNew txtclienterucdnides;
        private dhsoft.TextBoxNew txtclienterucdni;
        private System.Windows.Forms.Label label2;
        private dhsoft.MaskedTextBoxNew txtfechainicio;
        private System.Windows.Forms.Label label23;
        private DevExpress.XtraGrid.GridControl dgvdatos;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private System.Windows.Forms.ToolStripButton btnexportar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private System.Windows.Forms.ToolStripButton btnverdetalles;
    }
}