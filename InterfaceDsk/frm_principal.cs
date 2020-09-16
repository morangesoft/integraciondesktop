using interfacedsk.facrturacion;
using interfacedsk.productos;
using interfacedsk.Proveedor;
using interfacedsk.reportes;
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

 
        List<Ent_Datos_Generales> Datos = new List<Ent_Datos_Generales>();
        private void frm_principal_Load(object sender, EventArgs e)
        {
            try
            {
                    Log_Datos_Generales log = new Log_Datos_Generales();
                    Ent_Datos_Generales ent = new Ent_Datos_Generales();
                    Datos = log.Listar(ent);

                    if (Datos.Count > 0)
                    {
                        Actual_Conexion.rucEmpresa = Datos[0].rucEmpresa;
                        Actual_Conexion.razonSocialEmpresa = Datos[0].razonSocialEmpresa;
                        Actual_Conexion.direccionEmpresa = Datos[0].direccionEmpresa;
                        Actual_Conexion.urlServicio = Datos[0].urlServicio;
                        Actual_Conexion.urlNubeFact = Datos[0].urlNubeFact;
                        Actual_Conexion.tokenNubeFact = Datos[0].tokenNubeFact;
                    }
            }
            catch(Exception ex)
            {
                Accion.ErrorSistema(ex.Message);
            }


 
    }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiNoDuplicate("frm_reporte_ventas") == false)
            {
                Form f = new frm_reporte_ventas();
                f.MdiParent = this;
                f.Show();
                f.Activate();
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiNoDuplicate("frm_reporte_ventas_detallado") == false)
            {
                Form f = new frm_reporte_ventas_detallado();
                f.MdiParent = this;
                f.Show();
                f.Activate();
            }
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
