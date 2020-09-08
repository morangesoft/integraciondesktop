using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfacedsk.Proveedor
{
    public partial class frm_proveedor : Form
    {
        public frm_proveedor()
        {
            InitializeComponent();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            using (frm_proveedor_edicion f = new frm_proveedor_edicion())
            {
                f.Es_Nuevo = true;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    Lista();
                }
            }
        }

      public  List<Ent_Proveedor> Listar = new List<Ent_Proveedor>();
        void Lista()
        {
            try
            {
                Ent_Proveedor ent = new Ent_Proveedor();
                Log_Proveedor log = new Log_Proveedor();

                ent.idProveedor = 0;
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

        private void frm_proveedor_Load(object sender, EventArgs e)
        {
            Lista();
        }


        Ent_Proveedor Entidad = new Ent_Proveedor();
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
                using (frm_proveedor_edicion f = new frm_proveedor_edicion())
                {
                    f.id = Entidad.idProveedor;
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

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void dgvdatos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnseleccionar.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
