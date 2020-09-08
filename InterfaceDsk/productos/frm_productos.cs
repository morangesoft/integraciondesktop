using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfacedsk.productos
{
    public partial class frm_productos : Form
    {
        public frm_productos()
        {
            InitializeComponent();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            using (frm_producto_edicion f = new frm_producto_edicion())
            {
                f.Es_Nuevo = true;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    Lista();
                }
            }
        }

        private void frm_productos_Load(object sender, EventArgs e)
        {
            Lista();
        }

        List<Ent_Producto> Listar = new List<Ent_Producto>();
        void Lista()
        {
            try
            {
                Ent_Producto ent = new Ent_Producto();
                Log_Producto log = new Log_Producto();

 
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


        Ent_Producto Entidad = new Ent_Producto();
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

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                using (frm_producto_edicion f = new frm_producto_edicion())
                {
                    f.IdProducto = Entidad.idProducto;
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

        private void dgvdatos_DockChanged(object sender, EventArgs e)
        {

        }

        private void dgvdatos_DoubleClick(object sender, EventArgs e)
        {
            btnmodificar.PerformClick();
        }
    }
}
