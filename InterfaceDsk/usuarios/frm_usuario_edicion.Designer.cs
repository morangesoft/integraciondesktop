namespace interfacedsk.usuarios
{
    partial class frm_usuario_edicion
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
            this.cbotipodoc = new System.Windows.Forms.ComboBox();
            this.cboperfil = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtapellidos = new dhsoft.TextBoxNew(this.components);
            this.txtcelular = new dhsoft.TextBoxNew(this.components);
            this.txtdni = new dhsoft.TextBoxNew(this.components);
            this.txtclave = new dhsoft.TextBoxNew(this.components);
            this.txtdireccion = new dhsoft.TextBoxNew(this.components);
            this.txtemail = new dhsoft.TextBoxNew(this.components);
            this.txtnombres = new dhsoft.TextBoxNew(this.components);
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
            this.toolStrip1.Size = new System.Drawing.Size(650, 39);
            this.toolStrip1.TabIndex = 0;
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
            this.groupBox1.Controls.Add(this.cbotipodoc);
            this.groupBox1.Controls.Add(this.cboperfil);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtapellidos);
            this.groupBox1.Controls.Add(this.txtcelular);
            this.groupBox1.Controls.Add(this.txtdni);
            this.groupBox1.Controls.Add(this.txtclave);
            this.groupBox1.Controls.Add(this.txtdireccion);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.txtnombres);
            this.groupBox1.Location = new System.Drawing.Point(3, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "datos";
            // 
            // cbotipodoc
            // 
            this.cbotipodoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipodoc.FormattingEnabled = true;
            this.cbotipodoc.Location = new System.Drawing.Point(63, 27);
            this.cbotipodoc.Name = "cbotipodoc";
            this.cbotipodoc.Size = new System.Drawing.Size(252, 21);
            this.cbotipodoc.TabIndex = 1;
            this.cbotipodoc.SelectedIndexChanged += new System.EventHandler(this.cbotipodoc_SelectedIndexChanged);
            // 
            // cboperfil
            // 
            this.cboperfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboperfil.FormattingEnabled = true;
            this.cboperfil.Location = new System.Drawing.Point(376, 130);
            this.cboperfil.Name = "cboperfil";
            this.cboperfil.Size = new System.Drawing.Size(252, 21);
            this.cboperfil.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tipo Doc.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Apellidos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(321, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Perfil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Celular";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "DNI/RUC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Clave";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombres";
            // 
            // txtapellidos
            // 
            this.txtapellidos.Contenido = dhsoft.Enums.TipoTexto.NormalText;
            this.txtapellidos.DecimalPrecision = 0;
            this.txtapellidos.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txtapellidos.DisabledForeColor = System.Drawing.Color.Black;
            this.txtapellidos.Enganche = null;
            this.txtapellidos.EnterEmuleTab = true;
            this.txtapellidos.IsDecimalNegative = false;
            this.txtapellidos.LinkKeyDown = null;
            this.txtapellidos.Location = new System.Drawing.Point(375, 54);
            this.txtapellidos.MaskFormat = null;
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Requiere = false;
            this.txtapellidos.Size = new System.Drawing.Size(253, 20);
            this.txtapellidos.TabIndex = 7;
            // 
            // txtcelular
            // 
            this.txtcelular.Contenido = dhsoft.Enums.TipoTexto.NormalText;
            this.txtcelular.DecimalPrecision = 0;
            this.txtcelular.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txtcelular.DisabledForeColor = System.Drawing.Color.Black;
            this.txtcelular.Enganche = null;
            this.txtcelular.EnterEmuleTab = true;
            this.txtcelular.IsDecimalNegative = false;
            this.txtcelular.LinkKeyDown = null;
            this.txtcelular.Location = new System.Drawing.Point(63, 127);
            this.txtcelular.MaskFormat = null;
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Requiere = false;
            this.txtcelular.Size = new System.Drawing.Size(251, 20);
            this.txtcelular.TabIndex = 15;
            // 
            // txtdni
            // 
            this.txtdni.Contenido = dhsoft.Enums.TipoTexto.NormalText;
            this.txtdni.DecimalPrecision = 0;
            this.txtdni.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txtdni.DisabledForeColor = System.Drawing.Color.Black;
            this.txtdni.Enganche = null;
            this.txtdni.EnterEmuleTab = true;
            this.txtdni.IsDecimalNegative = false;
            this.txtdni.LinkKeyDown = null;
            this.txtdni.Location = new System.Drawing.Point(376, 28);
            this.txtdni.MaskFormat = null;
            this.txtdni.Name = "txtdni";
            this.txtdni.Requiere = false;
            this.txtdni.Size = new System.Drawing.Size(252, 20);
            this.txtdni.TabIndex = 3;
            // 
            // txtclave
            // 
            this.txtclave.Contenido = dhsoft.Enums.TipoTexto.NormalText;
            this.txtclave.DecimalPrecision = 0;
            this.txtclave.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txtclave.DisabledForeColor = System.Drawing.Color.Black;
            this.txtclave.Enganche = null;
            this.txtclave.EnterEmuleTab = true;
            this.txtclave.IsDecimalNegative = false;
            this.txtclave.LinkKeyDown = null;
            this.txtclave.Location = new System.Drawing.Point(374, 104);
            this.txtclave.MaskFormat = null;
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '*';
            this.txtclave.Requiere = false;
            this.txtclave.Size = new System.Drawing.Size(254, 20);
            this.txtclave.TabIndex = 13;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Contenido = dhsoft.Enums.TipoTexto.NormalText;
            this.txtdireccion.DecimalPrecision = 0;
            this.txtdireccion.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txtdireccion.DisabledForeColor = System.Drawing.Color.Black;
            this.txtdireccion.Enganche = null;
            this.txtdireccion.EnterEmuleTab = true;
            this.txtdireccion.IsDecimalNegative = false;
            this.txtdireccion.LinkKeyDown = null;
            this.txtdireccion.Location = new System.Drawing.Point(63, 78);
            this.txtdireccion.MaskFormat = null;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Requiere = false;
            this.txtdireccion.Size = new System.Drawing.Size(565, 20);
            this.txtdireccion.TabIndex = 9;
            // 
            // txtemail
            // 
            this.txtemail.Contenido = dhsoft.Enums.TipoTexto.NormalText;
            this.txtemail.DecimalPrecision = 0;
            this.txtemail.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txtemail.DisabledForeColor = System.Drawing.Color.Black;
            this.txtemail.Enganche = null;
            this.txtemail.EnterEmuleTab = true;
            this.txtemail.IsDecimalNegative = false;
            this.txtemail.LinkKeyDown = null;
            this.txtemail.Location = new System.Drawing.Point(62, 101);
            this.txtemail.MaskFormat = null;
            this.txtemail.Name = "txtemail";
            this.txtemail.Requiere = false;
            this.txtemail.Size = new System.Drawing.Size(252, 20);
            this.txtemail.TabIndex = 11;
            // 
            // txtnombres
            // 
            this.txtnombres.Contenido = dhsoft.Enums.TipoTexto.NormalText;
            this.txtnombres.DecimalPrecision = 0;
            this.txtnombres.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            this.txtnombres.DisabledForeColor = System.Drawing.Color.Black;
            this.txtnombres.Enganche = null;
            this.txtnombres.EnterEmuleTab = true;
            this.txtnombres.IsDecimalNegative = false;
            this.txtnombres.LinkKeyDown = null;
            this.txtnombres.Location = new System.Drawing.Point(62, 54);
            this.txtnombres.MaskFormat = null;
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Requiere = false;
            this.txtnombres.Size = new System.Drawing.Size(252, 20);
            this.txtnombres.TabIndex = 5;
            // 
            // frm_usuario_edicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 205);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_usuario_edicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.frm_usuario_edicion_Load);
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
        private System.Windows.Forms.ComboBox cboperfil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private dhsoft.TextBoxNew txtapellidos;
        private dhsoft.TextBoxNew txtcelular;
        private dhsoft.TextBoxNew txtdni;
        private dhsoft.TextBoxNew txtclave;
        private dhsoft.TextBoxNew txtemail;
        private dhsoft.TextBoxNew txtnombres;
        private System.Windows.Forms.ComboBox cbotipodoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private dhsoft.TextBoxNew txtdireccion;
    }
}