using DevExpress.Data.Filtering.Helpers;
using DevExpress.XtraGrid.Views.BandedGrid.Handler;
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

namespace interfacedsk.facrturacion
{
    public partial class frm_facturacion_edicion : Form
    {
        public frm_facturacion_edicion()
        {
            InitializeComponent();
        }

        public bool Es_Nuevo = false;
        string DvtD_OperCodigo = "";
        int unidad_medida_id  ;
        string unidad_medida_fe = "";
        decimal DvtD_IGVTasaPorcentaje;

        private void frm_facturacion_edicion_Load(object sender, EventArgs e)
        {
            IniciarCombo();
            IniciarComboTipoProducto();
            IniciarComboMoneda();
            DvtD_IGVTasaPorcentaje =Convert.ToDecimal(18);
            TxtRsIGVPorc.Text =Convert.ToString(DvtD_IGVTasaPorcentaje);
            txtfechaemision.Text = DateTime.Now.ToShortDateString();
            gbdetalle.Enabled = false;
        }

        private List<Ent_Comprobante> ListEmp = new List<Ent_Comprobante>();
        public void IniciarCombo()
        {
            try
            {
                Log_Comprobante LogEmp = new Log_Comprobante();
                Ent_Comprobante Ent = new Ent_Comprobante();
                cbocomprobamte.ValueMember = "id";
                cbocomprobamte.DisplayMember = "descripcion";


                ListEmp = LogEmp.Listar(Ent);

                cbocomprobamte.DataSource = ListEmp;
            }
            catch (Exception ex)
            {
                Accion.ErrorSistema(ex.Message);
            }
        }


        private List<Ent_Moneda> ListMoneda = new List<Ent_Moneda>();
        public void IniciarComboMoneda()
        {
            try
            {
                Log_Moneda LogEmp = new Log_Moneda();
                Ent_Moneda Ent = new Ent_Moneda();
                cbomoneda.ValueMember = "id";
                cbomoneda.DisplayMember = "descripcion";


                ListMoneda = LogEmp.Listar(Ent);

                cbomoneda.DataSource = ListMoneda;
            }
            catch (Exception ex)
            {
                Accion.ErrorSistema(ex.Message);
            }
        }


        private void txtserie_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txtnumero_KeyDown(object sender, KeyEventArgs e)
        {
            
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
                                txtclienterucdnides.Text = Entidad.usuario_apellido + " "+ Entidad.usuario_nombre;
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

        bool Es_Nuevo_Det;
        bool Es_Modificar_Det;
        private void BtnDtNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Es_Nuevo_Det = true;
                TxtItNum.Text =Convert.ToString(Detalles.Count + 1);
                gbdetalle.Enabled = true;
                cbotipo.SelectedIndex = 0;
                LimpiarDetalle();
                txtproducto.Focus();

            }
            catch (Exception ex)
            {
                Accion.ErrorSistema(ex.Message);
            }
        }

        private List<Ent_Tipo_Producto> ListTipoProducto = new List<Ent_Tipo_Producto>();
        public void IniciarComboTipoProducto()
        {
            try
            {
                Log_Tipo_Producto LogEmp = new Log_Tipo_Producto();
                Ent_Tipo_Producto Ent = new Ent_Tipo_Producto();
                cbotipo.ValueMember = "id";
                cbotipo.DisplayMember = "descripcion";
                ListTipoProducto = LogEmp.Listar(Ent);

                cbotipo.DataSource = ListTipoProducto;
            }
            catch (Exception ex)
            {
                Accion.ErrorSistema(ex.Message);
            }
        }

        private void cbotipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbotipo.SelectedIndex == 0)
                {
                    lbldescripcionproser.Text = "Producto";
                }
                else
                {
                    lbldescripcionproser.Text = "Servicio";
                }

            }     
            catch (Exception ex)
            {
                Accion.ErrorSistema(ex.Message);
            }
        }

        private void txtproducto_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
               if (cbotipo.SelectedIndex == 0)
                {
                    if (String.IsNullOrEmpty(txtproducto.Text) == false)
                    {
                        try
                        {
                            if (e.KeyCode == Keys.Enter & txtproducto.Text.Substring(txtproducto.Text.Length - 1, 1) == "*")
                            {
                                using (frm_buscar_producto f = new frm_buscar_producto())
                                {


                                    if (f.ShowDialog(this) == DialogResult.OK)
                                    {
                                        Ent_Producto Entidad = new Ent_Producto();

                                        Entidad = f.Listar[f.gridView1.GetFocusedDataSourceRowIndex()];

                                        txtproducto.Tag = Entidad.idProducto;
                                        txtproducto.Text = Entidad.codigoProducto;
                                        txtproductodesc.Text = Entidad.nombreProducto;
                                        unidad_medida_id = Entidad.idUnidadMedida;
                                        txtunidadmedida.Text = Entidad.descripcionUnm;
                                        unidad_medida_fe = Entidad.unm_fe;
                                        TxtPrecunitario.Text =Convert.ToString(Entidad.precioProducto);
                                        DvtD_OperCodigo = Entidad.afecIgvTabla;
     
    }
                                }
                            }
                            else
                                if (e.KeyCode == Keys.Enter & !string.IsNullOrEmpty(txtproducto.Text) & string.IsNullOrEmpty(txtproductodesc.Text))
                            {
                                Buscarproducto();
                            }
                        }
                        catch (Exception ex)
                        {
                            Accion.ErrorSistema(ex.Message);
                        }
                    }
                }else if (cbotipo.SelectedIndex == 1)
                {
                    if (String.IsNullOrEmpty(txtproducto.Text) == false)
                    {
                        try
                        {
                            if (e.KeyCode == Keys.Enter & txtproducto.Text.Substring(txtproducto.Text.Length - 1, 1) == "*")
                            {
                                using (frm_buscar_Servicios f = new frm_buscar_Servicios())
                                {


                                    if (f.ShowDialog(this) == DialogResult.OK)
                                    {
                                        Ent_Servicio Entidad = new Ent_Servicio();

                                        Entidad = f.Listar[f.gridView1.GetFocusedDataSourceRowIndex()];

                                        txtproducto.Tag = Entidad.idServicio;
                                        txtproducto.Text = Entidad.codigoServicio;
                                        txtproductodesc.Text = Entidad.nombreServicio;
                                        unidad_medida_id = Entidad.idUnidadMedida;
                                        txtunidadmedida.Text = Entidad.descripcionUnm;
                                        unidad_medida_fe = Entidad.unm_fe;
                                        TxtPrecunitario.Text = Convert.ToString(Entidad.precioServicio);
                                        DvtD_OperCodigo = Entidad.afecIgvTabla;
                                    }
                                }
                            }
                            else
                                if (e.KeyCode == Keys.Enter & !string.IsNullOrEmpty(txtproducto.Text) & string.IsNullOrEmpty(txtproductodesc.Text))
                            {
                                Buscarproducto();
                            }
                        }
                        catch (Exception ex)
                        {
                            Accion.ErrorSistema(ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Accion.ErrorSistema(ex.Message);
            }
 
        }


        public void Buscarproducto()
        {
            try
            {

                Log_Producto log = new Log_Producto();

                List<Ent_Producto> Generales = new List<Ent_Producto>();
                Generales = log.ListarPorCodigo(new Ent_Producto
                {
                    codigoProducto = txtproducto.Text.Trim()
                }); ;

                if (Generales.Count > 0)
                {

                    foreach (Ent_Producto T in Generales)
                    {
                        if ((T.codigoProducto).ToString().Trim().ToUpper() == txtproducto.Text.Trim().ToUpper())
                        {

                            txtproducto.Tag = T.idProducto;
                            txtproducto.Text = T.codigoProducto;
                            txtproductodesc.Text = T.nombreProducto;
                            unidad_medida_id = T.idUnidadMedida;
                            txtunidadmedida.Text = T.descripcionUnm;
                            unidad_medida_fe = T.unm_fe;
                            TxtPrecunitario.Text = Convert.ToString(T.precioProducto);
                            DvtD_OperCodigo = T.afecIgvTabla;
                        }
                    }

                }
                else
                {
                    Accion.Advertencia("No se encontro el producto");
                }
            }
            catch (Exception ex)
            {
                Accion.ErrorSistema(ex.Message);
            }
        }

        public void Buscarservicio()
        {
            try
            {

                Log_Servicio log = new Log_Servicio();

                List<Ent_Servicio> Generales = new List<Ent_Servicio>();
                Generales = log.ListarPorCodigo(new Ent_Servicio
                {
                    codigoServicio = txtproducto.Text.Trim()
                }); ;

                if (Generales.Count > 0)
                {

                    foreach (Ent_Servicio T in Generales)
                    {
                        if ((T.codigoServicio).ToString().Trim().ToUpper() == txtproducto.Text.Trim().ToUpper())
                        {

                            txtproducto.Tag = T.idServicio;
                            txtproducto.Text = T.codigoServicio;
                            txtproductodesc.Text = T.nombreServicio;
                            unidad_medida_id = T.idUnidadMedida;
                            txtunidadmedida.Text = T.descripcionUnm;
                            unidad_medida_fe = T.unm_fe;
                            TxtPrecunitario.Text = Convert.ToString(T.precioServicio);
                            DvtD_OperCodigo = T.afecIgvTabla;
                        }
                    }

                }
                else
                {
                    Accion.Advertencia("No se encontro el producto");
                }
            }
            catch (Exception ex)
            {
                Accion.ErrorSistema(ex.Message);
            }
        }

  


        private void txtserie_Leave(object sender, EventArgs e)
        {
            try
            {
                txtserie.Text = Accion.Formato(txtserie.Text, 4);
            }
            catch (Exception ex)
            {
                Accion.ErrorSistema(ex.Message);
            }

        }

        private void txtnumero_Leave(object sender, EventArgs e)
        {
            try
            {
                txtnumero.Text = Accion.Formato(txtnumero.Text, 8);
            }
            catch (Exception ex)
            {
                Accion.ErrorSistema(ex.Message);
            }
        }

        private void TxtItCantidad_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void TxtItCantidad_KeyDown(object sender, KeyEventArgs e)
        {
         
        }

        List<Ent_Facturacion> Detalles = new List<Ent_Facturacion>();
        private void BtnDtGrabar_Click(object sender, EventArgs e)
        {
            try
            {

                Ent_Facturacion ItemDetalle = new Ent_Facturacion();
                
                ItemDetalle.id_det = Convert.ToInt32(TxtItNum.Text);
                ItemDetalle.id_tipo_bien_servicio = Convert.ToInt32(cbotipo.SelectedValue.ToString());
                ItemDetalle.tipo_bien_servicio_desc = cbotipo.SelectedText.ToString() ;

                ItemDetalle.prod_serv_id =Convert.ToInt32(txtproducto.Tag.ToString());
                ItemDetalle.productocod = txtproducto.Text;
                ItemDetalle.productodesc = txtproductodesc.Text;
                ItemDetalle.unidad_medida_id = unidad_medida_id;
                ItemDetalle.unidad_medida_desc = txtunidadmedida.Text.Trim();
                ItemDetalle.unidad_medida_fe = unidad_medida_fe;
                ItemDetalle.DvtD_OperCodigo = DvtD_OperCodigo;
                ItemDetalle.cantidad = Convert.ToDecimal(TxtItCantidad.Text);
                ItemDetalle.valor_unitario =Convert.ToDecimal(TxtPrecunitario.Text) / 1 + DvtD_IGVTasaPorcentaje;
                ItemDetalle.precio_unitario = Convert.ToDecimal(TxtPrecunitario.Text);
                ItemDetalle.DvtD_IGVTasaPorcentaje = DvtD_IGVTasaPorcentaje;
                ItemDetalle.total_det = Convert.ToDecimal(TxtItImporte.Text);

                if (Es_Nuevo_Det)
                {
                    Detalles.Add(ItemDetalle);
                    Es_Nuevo_Det = false;
                    gbdetalle.Enabled = false;
                    BtnDtNuevo.Focus();
                }
                else if (Es_Modificar_Det)
                {
                    Detalles[Convert.ToInt32(TxtItNum.Text) - 1] = ItemDetalle;
                    Es_Modificar_Det = false;
                }
  
                UpdateGrilla();
                MostrarResumen();
       


            }    
            catch (Exception ex)
                {
                    Accion.ErrorSistema(ex.Message);
                }
        }

        void LimpiarDetalle()
        {
            txtproducto.ResetText();
            txtproductodesc.ResetText();
            txtunidadmedida.ResetText();
            TxtItCantidad.Text = "0.00";
            TxtPrecunitario.Text = "0.00";
            TxtItImporte.Text = "0.00";
            unidad_medida_id = 0;
            unidad_medida_fe = "";
            DvtD_OperCodigo = "";
 

        }

        void MostrarResumen()
        {
 
                decimal MValorFactExport=0;
                decimal MBaseImponible = 0;
                decimal MExonerada = 0;
                decimal MInafecta = 0;
                decimal MISC = 0;
                decimal MIGV = 0;
                decimal MOtrosTrib = 0;
                decimal MImportTot = 0;
 
                foreach (Ent_Facturacion item in Detalles)
                {
                    MValorFactExport = (MValorFactExport + item.DvtD_ValorFactExportacion);
                    MBaseImponible = (MBaseImponible + item.DvtD_BaseImpobleOperacionGravada);
                    MExonerada = (MExonerada + item.DvtD_Exonerada);
                    MInafecta = (MInafecta + item.DvtD_Inafecta);
                    MISC = (MISC + item.DvtD_ISC);
                    MIGV = (MIGV + item.DvtD_IGV_IPM);
                }

                if (TxtRsOtrosTribCarg.Text!="0.00")
                {
                    MOtrosTrib =Convert.ToDecimal(TxtRsOtrosTribCarg.Text);
                }
                else
                {
                    MOtrosTrib = 0;
                }

                MImportTot = MValorFactExport  + MBaseImponible + MExonerada + MInafecta + MISC  + MIGV + MOtrosTrib;
                
                TxtRsValExporta.Text =Convert.ToString(MValorFactExport);
                TxtRsBaseImponible.Text = Convert.ToString(MBaseImponible);
                TxtRsExonerada.Text = Convert.ToString(MExonerada);
                TxtRsInAfecta.Text = Convert.ToString(MInafecta);
                TxtRsISC.Text = Convert.ToString(MISC);
                TxtRsIGVMonto.Text = Convert.ToString(MIGV);
                TxtRsImporteTotal.Text = Convert.ToString(MImportTot);
                //CalcularIGV();
   

        }

        void UpdateGrilla()
        {
           DgvDetalle.DataSource = null;
                if (Detalles.Count > 0) {
                DgvDetalle.DataSource = Detalles;
            }
                   
          
        }

        private void ChkOtrosTribCarg_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                    if (ChkOtrosTribCarg.Checked)
                    {
                        TxtRsOtrosTribCarg.Enabled = true;
                    }
                    else
                    {
                        TxtRsOtrosTribCarg.Enabled = false;
                        TxtRsOtrosTribCarg.Text = "0.00";
                    }
                    MostrarResumen();
            }
            catch(Exception ex)
            {

            }

        }

        private void cbomoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbomoneda.SelectedIndex == 0)
            {
                txttipocambio.Text = "1.000";
                txttipocambio.Enabled = false;
            }
            else
            {
                txttipocambio.Text = "0.000";
                txttipocambio.Enabled = true;
                txttipocambio.Focus();
            }
        }

        private void GridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (Detalles.Count > 0)
                {
                    Ent_Facturacion Entidad = new Ent_Facturacion();
 
                    Entidad = Detalles[GridView1.GetFocusedDataSourceRowIndex()];

                    TxtItNum.Text = Convert.ToString(Entidad.id_det);
                    txtproducto.Tag = Entidad.prod_serv_id;
                    txtproducto.Text = Entidad.productocod;
                    txtproductodesc.Text = Entidad.productodesc;
                    unidad_medida_id = Entidad.unidad_medida_id;
                    txtunidadmedida.Text = Entidad.unidad_medida_desc;
                    unidad_medida_fe = Entidad.unidad_medida_fe;
                    DvtD_OperCodigo = Entidad.DvtD_OperCodigo;
                    TxtItCantidad.Text = Convert.ToString(Entidad.cantidad);
                    TxtPrecunitario.Text = Convert.ToString(Entidad.precio_unitario);
                    TxtItImporte.Text = Convert.ToString(Entidad.total_det);
                    cbotipo.SelectedValue = Entidad.id_tipo_bien_servicio;

                    gbdetalle.Enabled = false;


                     

                }
            }
            catch (Exception ex)
            {
                Accion.ErrorSistema(ex.Message);
            }
        }

        private void BtnDtEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Es_Modificar_Det = true;

            }
            catch (Exception ex)
            {
                Accion.ErrorSistema(ex.Message);
            }
        }

        private void BtnDtEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                  if (Detalles.Count > 0)
                    {
                        Detalles.RemoveAt(GridView1.GetFocusedDataSourceRowIndex());

                        DgvDetalle.DataSource = null;
                        if (Detalles.Count > 0)
                        {
                            DgvDetalle.DataSource = Detalles;
                            RefreshNumeral();
                            LimpiarDetalle();
                        }

                        MostrarResumen();
                    }
            }
            catch (Exception ex)
            {
                Accion.ErrorSistema(ex.Message);
            }

  
        }

        public void RefreshNumeral()
        {
            try
            {
                int NumOrden = 1;
                foreach (Ent_Facturacion Det in Detalles)
                {
                    Det.id_det = NumOrden;
                    NumOrden += 1;
                }
            }
            catch (Exception ex)
            {
                Accion.ErrorSistema(ex.Message);
            }

        }

        private void TxtItCantidad_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtPrecunitario.Text.Trim()))
            {
                try
                {
                    //if (e.KeyCode == Keys.Enter)
                    //{
                        if (TxtItCantidad.Text != "")
                        {
                            TxtItImporte.Text = Convert.ToString(Convert.ToDecimal(TxtItCantidad.Text) * Convert.ToDecimal(TxtPrecunitario.Text));
                             BtnDtGrabar.Select();
                        }
                        else
                        {
                            TxtItImporte.Text = "0.00";
                        }

                    //}

                }
                catch (Exception ex)
                {
                    Accion.ErrorSistema(ex.Message);
                }

            }
        }
    }
}
