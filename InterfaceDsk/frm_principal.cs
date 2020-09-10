using interfacedsk.facrturacion;
using interfacedsk.productos;
using interfacedsk.Proveedor;
using interfacedsk.servicios;
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
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void btnusuarios_Click(object sender, EventArgs e)
        {
            if (MdiNoDuplicate("frm_usuarios") == false)
            {
                Form f = new frm_usuarios();
                f.MdiParent = this;
                f.Show();
                f.Activate();
            }
        }


        private bool MdiNoDuplicate(string vcNombre)
        {
            if (this.MdiChildren.Count() > 0)
            {
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm.Name == vcNombre)
                    {
                        frm.Activate();
                        return true;
                    }
                }
            }
            return false;
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            if (MdiNoDuplicate("frm_productos") == false)
            {
                Form f = new frm_productos();
                f.MdiParent = this;
                f.Show();
                f.Activate();
            }
        }

        private void btnproveedor_Click(object sender, EventArgs e)
        {
            if (MdiNoDuplicate("frm_proveedor") == false)
            {
                Form f = new frm_proveedor();
                f.MdiParent = this;
                f.Show();
                f.Activate();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (MdiNoDuplicate("frm_servicios") == false)
            {
                Form f = new frm_servicios();
                f.MdiParent = this;
                f.Show();
                f.Activate();
            }
        }

        private void btnfacturacion_Click(object sender, EventArgs e)
        {
            if (MdiNoDuplicate("frm_facturacion") == false)
            {
                Form f = new frm_facturacion();
                f.MdiParent = this;
                f.Show();
                f.Activate();
            }
        }
    }
}
