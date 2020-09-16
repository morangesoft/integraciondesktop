using CrystalDecisions.CrystalReports.Engine;
using DevExpress.XtraPrinting;
using Entidad;
using interfacedsk.busquedas;
using interfacedsk.reportes.DS;
using MySql.Data.MySqlClient;
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
    public partial class frm_reporte_ventas : Form
    {
        public frm_reporte_ventas()
        {
            InitializeComponent();
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string Ruta;
                Ruta = path + ("\\ReporteVenta" + ".Xlsx");



                XlsxExportOptionsEx ExXlsxExportOptions = new XlsxExportOptionsEx();
                ExXlsxExportOptions.ExportType = DevExpress.Export.ExportType.WYSIWYG;

                dgvdatos.ExportToXlsx(Ruta, ExXlsxExportOptions);

           
            }
            catch (Exception ex)
            {
                Accion.ErrorSistema(ex.Message);
            }
        }

        List<Ent_Reportes> Listar = new List<Ent_Reportes>();

        private void btnverreporte_Click(object sender, EventArgs e)
        {
            try
            {
             
                Ent_Reportes ent = new Ent_Reportes();
                Log_Reporte log = new Log_Reporte();

                ent.desde =Convert.ToDateTime(txtfechainicio.Text);
                ent.hasta = Convert.ToDateTime(txtfechahasta.Text);

                if (txtclienterucdni.Tag == null)
                {
                     ent.cliente_id = 0;
                }
                else
                {
                    ent.cliente_id = Convert.ToInt32(txtclienterucdni.Tag.ToString());
                }


             

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

        private void btnverdetalles_Click(object sender, EventArgs e)
        {
            try
            {
                if (Listar.Count() > 0)
                {
                    Log_Reporte log = new Log_Reporte();

    

                    for (int i = 0; (i <= (Listar.Count - 1)); i++)
                    {
 

                        List<Ent_Reportes> ListaDet = new List<Ent_Reportes>();
                        Ent_Reportes Enti = new Ent_Reportes();
                        Enti.id = Listar[i].id;

 

                        ListaDet = log.Listar_Det(Enti);

                        Listar[i].Detalle_Ventas = ListaDet;
 

                    }

 

                    dgvdatos.DataSource = null;
                    dgvdatos.DataSource = Listar;

                }

            }
            catch (Exception ex)
            {
                Accion.ErrorSistema(ex.Message);
            }



        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            Rpte_Ventas_Cab objRpt = new Rpte_Ventas_Cab();


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


   

            Venta_Cab Ds = new Venta_Cab(); // ESTE ES EL NOMBRE DE NUESTRO DATASET
            MySqlDataAdapter Adapter;
            MySqlCommand Cmd;
            using (var Cn = new MySqlConnection(Dat_Conexion.ObtenerConnection()))
            {
                try
                {
                    using (Cmd = new MySqlCommand("sp_VentaReporte", Cn)
                    { CommandType = CommandType.StoredProcedure, CommandTimeout = 0 })
                    {

                        Cmd.Parameters.Add("?_desde", MySqlDbType.DateTime).Value = ent.desde;
                        Cmd.Parameters.Add("?_hasta", MySqlDbType.DateTime).Value = ent.hasta;
                        Cmd.Parameters.Add("?_cliente", MySqlDbType.Int32).Value = ent.cliente_id;
                        using (Adapter = new MySqlDataAdapter(Cmd))
                        {

                            Adapter.Fill(Ds, "DS_Venta_Cab"); // ESTE Reportes ES EL NOMBRE DE NUESTRA TABLA DE DATOS QUE ESTA DENTRO DE NUESTRO DATASET

                        }
                    }

                    TextObject text = (TextObject)objRpt.ReportDefinition.Sections["Section2"].ReportObjects["txtdesde"];
                    text.Text = txtfechainicio.Text;

                    TextObject text2 = (TextObject)objRpt.ReportDefinition.Sections["Section2"].ReportObjects["txthasta"];
                    text2.Text = txtfechahasta.Text;

                    objRpt.SetDataSource(Ds); 
                    frm_rpte_viwer rpt = new frm_rpte_viwer(); // ES EL FORM DONDE ESTA NUESTRO CRYSTAL REPORT VIEWER
                    //rpt.MdiParent = frm_principal;
                    rpt.crystalReportViewer1.ReportSource = objRpt; // ESTE ES NUESTRO REPORT VIEWER
                    rpt.ShowDialog(); // AQUI LO MUESTRA


                }
                catch (Exception ex)
                {
                    Accion.ErrorSistema(ex.Message);
                }
            }



        }
    }
}
