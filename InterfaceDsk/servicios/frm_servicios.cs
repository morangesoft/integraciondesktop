using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfacedsk.servicios
{
    public partial class frm_servicios : Form
    {
        public frm_servicios()
        {
            InitializeComponent();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            using (frm_servicios_edicion f = new frm_servicios_edicion())
            {
                f.Es_Nuevo = true;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    Lista();
                }
            }
        }

        private void frm_servicios_Load(object sender, EventArgs e)
        {
            Lista();
        }

        List<Ent_Servicio> Listar = new List<Ent_Servicio>();
        void Lista()
        {
            try
            {
                Ent_Servicio ent = new Ent_Servicio();
                Log_Servicio log = new Log_Servicio();


                Listar = log.Listar(ent);
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

        Ent_Servicio Entidad = new Ent_Servicio();
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

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                using (frm_servicios_edicion f = new frm_servicios_edicion())
                {
                    f.IdServicio = Entidad.idServicio;
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
            }
            catch (Exception ex)
            {
                Accion.ErrorSistema(ex.Message);
            }
        }
    }
}
