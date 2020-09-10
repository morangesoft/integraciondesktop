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
    public partial class frm_buscar_Servicios : Form
    {
        public frm_buscar_Servicios()
        {
            InitializeComponent();
        }

        private void frm_buscar_Servicios_Load(object sender, EventArgs e)
        {
            Lista();
        }
        public List<Ent_Servicio> Listar = new List<Ent_Servicio>();
        void Lista()
        {
            try
            {
                Ent_Servicio ent = new Ent_Servicio();
                Log_Servicio log = new Log_Servicio();


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
