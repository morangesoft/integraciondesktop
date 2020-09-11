using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfacedsk.facrturacion
{
    public partial class frm_facturacion : Form
    {
        public frm_facturacion()
        {
            InitializeComponent();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            using (frm_facturacion_edicion f = new frm_facturacion_edicion())
            {
                f.Es_Nuevo = true;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    //Lista();
                }
            }
        }

        private void frm_facturacion_Load(object sender, EventArgs e)
        {
            Lista();
        }

        List<Ent_Facturacion> Listar = new List<Ent_Facturacion>();
        void Lista()
        {
            try
            {
                Ent_Facturacion ent = new Ent_Facturacion();
                Log_Facturacion log = new Log_Facturacion();


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

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                using (frm_facturacion_edicion f = new frm_facturacion_edicion())
                {
                    f.idVentaCab = Entidad.id;
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

        Ent_Facturacion Entidad = new Ent_Facturacion();
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



    }
}
