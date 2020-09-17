using Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfacedsk.busquedas
{
    public partial class frm_buscar_cliente : Form
    {
        public frm_buscar_cliente()
        {
            InitializeComponent();
        }

      public  List<Ent_Usuario> Listar = new List<Ent_Usuario>();
        private void frm_buscar_cliente_Load(object sender, EventArgs e)
        {
            Lista();
        }

        void Lista()
        {
            try
            {
                Ent_Usuario ent = new Ent_Usuario();
                Log_usuario log = new Log_usuario();
                ent.usuario_id = 0;
                ent.perfil_id = 3;
                Listar = log.Listar_Por_Perfil(ent);
                if (Listar.Count > 0)
                {
                    dgvdatos.DataSource = null;
                    dgvdatos.DataSource = Listar;
                }
            }
            catch (Exception ex)
            {
                Accion.ErrorSistema(ex.Message);
            }
        }

        private void dgvdatos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnseleccion.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void btnseleccion_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void dgvdatos_DoubleClick(object sender, EventArgs e)
        {
            btnseleccion.PerformClick();
        }
    }
}
