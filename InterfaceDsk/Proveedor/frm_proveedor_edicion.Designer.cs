namespace interfacedsk.Proveedor
{
    partial class frm_proveedor_edicion
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
            this.label21 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttipodoc = new dhsoft.TextBoxNew(this.components);
            this.txtnombre = new dhsoft.TextBoxNew(this.components);
            this.txtnumdoc = new dhsoft.TextBoxNew(this.components);
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
            this.toolStrip1.TabIndex = 3;
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
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txttipodoc);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.txtnumdoc);
            this.groupBox1.Location = new System.Drawing.Point(0, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "datos";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(35, 43);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(54, 13);
            this.label21.TabIndex = 4;
            this.label21.Text = "Tipo Doc.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nro. Documento";
            // 
            // txttipodoc
            // 
            this.txttipodoc.Contenido = dhsoft.Enums.TipoTexto.NormalText;
            this.txttipodoc.DecimalPrecision = 0;
            this.txttipodoc.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txttipodoc.DisabledForeColor = System.Drawing.Color.Black;
            this.txttipodoc.Enganche = null;
            this.txttipodoc.EnterEmuleTab = true;
            this.txttipodoc.IsDecimalNegative = false;
            this.txttipodoc.LinkKeyDown = null;
            this.txttipodoc.Location = new System.Drawing.Point(95, 40);
            this.txttipodoc.MaskFormat = null;
            this.txttipodoc.Name = "txttipodoc";
            this.txttipodoc.Requiere = false;
            this.txttipodoc.Size = new System.Drawing.Size(380, 20);
            this.txttipodoc.TabIndex = 5;
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
            this.txtnombre.Location = new System.Drawing.Point(270, 17);
            this.txtnombre.MaskFormat = null;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Requiere = false;
            this.txtnombre.Size = new System.Drawing.Size(523, 20);
            this.txtnombre.TabIndex = 3;
            // 
            // txtnumdoc
            // 
            this.txtnumdoc.Contenido = dhsoft.Enums.TipoTexto.NormalText;
            this.txtnumdoc.DecimalPrecision = 0;
            this.txtnumdoc.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txtnumdoc.DisabledForeColor = System.Drawing.Color.Black;
            this.txtnumdoc.Enganche = null;
            this.txtnumdoc.EnterEmuleTab = true;
            this.txtnumdoc.IsDecimalNegative = false;
            this.txtnumdoc.LinkKeyDown = null;
            this.txtnumdoc.Location = new System.Drawing.Point(95, 17);
            this.txtnumdoc.MaskFormat = null;
            this.txtnumdoc.Name = "txtnumdoc";
            this.txtnumdoc.Requiere = false;
            this.txtnumdoc.Size = new System.Drawing.Size(124, 20);
            this.txtnumdoc.TabIndex = 1;
            // 
            // frm_proveedor_edicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 168);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_proveedor_edicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedor";
            this.Load += new System.EventHandler(this.frm_proveedor_edicion_Load);
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
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private dhsoft.TextBoxNew txttipodoc;
        private dhsoft.TextBoxNew txtnombre;
        private dhsoft.TextBoxNew txtnumdoc;
    }
}