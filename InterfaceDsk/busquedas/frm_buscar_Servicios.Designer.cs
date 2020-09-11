namespace interfacedsk.busquedas
{
    partial class frm_buscar_Servicios
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnseleccion = new System.Windows.Forms.ToolStripButton();
            this.dgvdatos = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnseleccion});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(886, 39);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnseleccion
            // 
            this.btnseleccion.Image = global::interfacedsk.Properties.Resources.seleccionar;
            this.btnseleccion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnseleccion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnseleccion.Name = "btnseleccion";
            this.btnseleccion.Size = new System.Drawing.Size(103, 36);
            this.btnseleccion.Text = "Seleccionar";
            this.btnseleccion.Click += new System.EventHandler(this.btnseleccion_Click);
            // 
            // dgvdatos
            // 
            this.dgvdatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvdatos.Location = new System.Drawing.Point(0, 39);
            this.dgvdatos.MainView = this.gridView1;
            this.dgvdatos.Name = "dgvdatos";
            this.dgvdatos.Size = new System.Drawing.Size(886, 343);
            this.dgvdatos.TabIndex = 6;
            this.dgvdatos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.dgvdatos.DoubleClick += new System.EventHandler(this.dgvdatos_DoubleClick);
            this.dgvdatos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvdatos_KeyDown);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gridView1.GridControl = this.dgvdatos;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Servicio";
            this.gridColumn2.FieldName = "nombreServicio";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 251;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Descripción";
            this.gridColumn3.FieldName = "descripcionServicio";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 372;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Precio";
            this.gridColumn4.FieldName = "precioServicio";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 116;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Fecha expiración";
            this.gridColumn5.FieldName = "fechaExpiracionServicio";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 139;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "stock";
            this.gridColumn6.FieldName = "cantidadStockServicio";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 104;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Código";
            this.gridColumn7.FieldName = "codigoServicio";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            this.gridColumn7.Width = 153;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Tiempo garantía";
            this.gridColumn8.FieldName = "tiempoGarantiaServicio";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 6;
            this.gridColumn8.Width = 196;
            // 
            // frm_buscar_Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 382);
            this.Controls.Add(this.dgvdatos);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_buscar_Servicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de servicios";
            this.Load += new System.EventHandler(this.frm_buscar_Servicios_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnseleccion;
        private DevExpress.XtraGrid.GridControl dgvdatos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}