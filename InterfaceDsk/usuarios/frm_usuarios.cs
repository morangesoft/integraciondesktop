
using Entidad;
using interfacedsk.usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfacedsk
{
    public partial class frm_usuarios : Form
    {
        public frm_usuarios()
        {
            InitializeComponent();
        }
        List<Ent_Usuario> Listar = new List<Ent_Usuario>();
        private void frm_usuarios_Load(object sender, EventArgs e)
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
                    Listar = log.Listar(ent);
                    if (Listar.Count > 0)
                    {

                        dgvdatos.DataSource = null;
                        dgvdatos.DataSource = Listar;
                    }
            }catch(Exception ex)
            {
                Accion.ErrorSistema(ex.Message);
            }
 
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            using (frm_usuario_edicion f = new frm_usuario_edicion())
            {
                f.Es_Nuevo = true;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    Lista();
                }
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                using (frm_usuario_edicion f = new frm_usuario_edicion())
                {
                    f.id = Entidad.usuario_id;
                    f.Es_Nuevo = false;

                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        Lista();
                    }
                    else
                    {
                        Lista();
                    }
                }
            }catch(Exception ex)
            {
                Accion.ErrorSistema(ex.Message);
            }

        }

        Ent_Usuario Entidad = new Ent_Usuario();
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (Listar.Count > 0 & gridView1.GetFocusedDataSourceRowIndex() > -1)
                {
 

                    Entidad = Listar[gridView1.GetFocusedDataSourceRowIndex()];
 
                }
            }
            catch (Exception ex)
            {
                Accion.ErrorSistema(ex.Message);
            }
        }

        private void dgvdatos_DoubleClick(object sender, EventArgs e)
        {
            btnmodificar.PerformClick();
        }
    }
}
