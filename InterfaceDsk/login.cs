using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using interfacedsk;

namespace interfacedsk
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void txtusuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtcontrasenia.Focus();
            }
        }

        private void txtcontrasenia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btningresar.Focus();
            }
        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            txtusuario.BackColor = Color.FromArgb(255, 251, 149);
        }

        private void txtcontrasenia_Enter(object sender, EventArgs e)
        {
            txtcontrasenia.BackColor = Color.FromArgb(255, 251, 149);
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            txtusuario.BackColor = Color.White;
        }

        private void txtcontrasenia_Leave(object sender, EventArgs e)
        {
            txtcontrasenia.BackColor = Color.White;
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtusuario.Text.Trim()))
            {
                MessageBox.Show("Ingrese su nombre");
                txtusuario.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtcontrasenia.Text.Trim()))
            {
                MessageBox.Show("Ingrese su Contraseña");
                txtcontrasenia.Focus();
                return;
            }


            try
            {
                List<Ent_Inicio_Sesion> Ent = new List<Ent_Inicio_Sesion>();
                Log_Inicio_sesion LogUsu = new Log_Inicio_sesion();
                Ent_Inicio_Sesion enti = new Ent_Inicio_Sesion();


                enti.usuario = txtusuario.Text.Trim();
                enti.clave = txtcontrasenia.Text.Trim();


                Ent = LogUsu.Iniciar(enti);

                if (Ent.Count > 0)
                {
                    this.Hide();

                    using (frm_principal f = new frm_principal())
                    {
                        if (f.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nombre de Usuario o Contraseña inconrrectos", "Inicio de sesion incorrecto", MessageBoxButtons.OK);
                    txtusuario.Focus();
                }

            }
            catch (Exception ex)
            {
               Accion.ErrorSistema(ex.Message);
            }

        }

        private void login_Load(object sender, EventArgs e)
        {
            txtusuario.Text = "808050580";
            txtcontrasenia.Text = "1234";
        }
    }
}
