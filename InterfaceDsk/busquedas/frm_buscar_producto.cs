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
    public partial class frm_buscar_producto : Form
    {
        public frm_buscar_producto()
        {
            InitializeComponent();
        }

        private void frm_buscar_producto_Load(object sender, EventArgs e)
        {
            Lista();
        }
        public List<Ent_Producto> Listar = new List<Ent_Producto>();
        void Lista()
        {
            try
            {
                Ent_Producto ent = new Ent_Producto();
                Log_Producto log = new Log_Producto();

   
                Listar = log.ListarPorCodigo(ent);
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
