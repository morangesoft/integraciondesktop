using DevExpress.XtraPrinting;
using Entidad;
using interfacedsk.busquedas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfacedsk.reportes
{
    public partial class frm_reporte_ventas_detallado : Form
    {
        public frm_reporte_ventas_detallado()
        {
            InitializeComponent();
        }

        List<Ent_Reportes> Listar = new List<Ent_Reportes>();

        private void btnverreporte_Click(object sender, EventArgs e)
        {
            try
            {

                Ent_Reportes ent = new Ent_Reportes();
                Log_Reporte log = new Log_Reporte();

                ent.desde = Convert.ToDateTime(txtfechainicio.Text);
                ent.hasta = Convert.ToDateTime(txtfechahasta.Text);

                if (txtclienterucdni.Tag == null)
                {
                    ent.cliente_id = 0;
                }
                else
                {
                    ent.cliente_id = Convert.ToInt32(txtclienterucdni.Tag.ToString());
                }




                Listar = log.ReportePivotDetallado(ent);
                if (Listar.Count > 0)
                {

                    pivotGridControl1.DataSource = null;
                    pivotGridControl1.DataSource = Listar;
                }

            }
            catch (Exception ex)
            {
                Accion.ErrorSistema(ex.Message);
            }
        }

        private void txtclienterucdni_TextChanged(object sender, EventArgs e)
        {
            if (txtclienterucdni.Focus() == true)
            {
                txtclienterucdnides.ResetText();
            }
        }

        private void txtclienterucdni_KeyDown(object sender, KeyEventArgs e)
        {
            if (String.IsNullOrEmpty(txtclienterucdni.Text) == false)
            {
                try
                {
                    if (e.KeyCode == Keys.Enter & txtclienterucdni.Text.Substring(txtclienterucdni.Text.Length - 1, 1) == "*")
                    {
                        using (frm_buscar_cliente f = new frm_buscar_cliente())
                        {


                            if (f.ShowDialog(this) == DialogResult.OK)
                            {
                                Ent_Usuario Entidad = new Ent_Usuario();

                                Entidad = f.Listar[f.gridView1.GetFocusedDataSourceRowIndex()];

                                txtclienterucdni.Tag = Entidad.usuario_id;
                                txtclienterucdni.Text = Entidad.usuario_dni;
                                txtclienterucdnides.Text = Entidad.usuario_apellido + " " + Entidad.usuario_nombre;



                            }
                        }
                    }
                    else
                        if (e.KeyCode == Keys.Enter & !string.IsNullOrEmpty(txtclienterucdni.Text) & string.IsNullOrEmpty(txtclienterucdnides.Text))
                    {
                        Buscarcliente();
                    }
                }
                catch (Exception ex)
                {
                    Accion.ErrorSistema(ex.Message);
                }
            }
        }

        public void Buscarcliente()
        {
            try
            {

                Log_usuario log = new Log_usuario();

                List<Ent_Usuario> Generales = new List<Ent_Usuario>();
                Generales = log.Listar(new Ent_Usuario
                {
                    usuario_dni = txtclienterucdni.Text.Trim()
                }); ;

                if (Generales.Count > 0)
                {

                    foreach (Ent_Usuario T in Generales)
                    {
                        if ((T.usuario_dni).ToString().Trim().ToUpper() == txtclienterucdni.Text.Trim().ToUpper())
                        {

                            txtclienterucdni.Tag = T.usuario_id;
                            txtclienterucdni.Text = T.usuario_dni;
                            txtclienterucdnides.Text = T.usuario_apellido + " " + T.usuario_nombre;

                        }
                    }

                }
                else
                {
                    Accion.Advertencia("No se encontro el cliente");
                }
            }
            catch (Exception ex)
            {
                Accion.ErrorSistema(ex.Message);
            }
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string Ruta;
                Ruta = path + ("\\ReporteVentaDetallado" + ".Xlsx");



                XlsxExportOptionsEx ExXlsxExportOptions = new XlsxExportOptionsEx();
                ExXlsxExportOptions.ExportType = DevExpress.Export.ExportType.WYSIWYG;

                pivotGridControl1.ExportToXlsx(Ruta, ExXlsxExportOptions);


            }
            catch (Exception ex)
            {
                Accion.ErrorSistema(ex.Message);
            }
        }
    }
}
