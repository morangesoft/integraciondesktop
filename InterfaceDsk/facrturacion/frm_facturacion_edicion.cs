using DevExpress.Data.Filtering.Helpers;
using DevExpress.XtraGrid.Views.BandedGrid.Handler;
using Entidad;
using interfacedsk.busquedas;
using interfacedsk.nube_fact;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
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
        public int idVentaCab;
        string DvtD_OperCodigo = "";
        int unidad_medida_id  ;
        string unidad_medida_fe = "";
        decimal DvtD_IGVTasaPorcentaje;
        string tipo_afectacion_de_igv = "";

        string tipo_afectacion_de_igv_codNubefact;

        string comprobante_codSunat;
        string comprobante_codNubefact;
        string modena_fe;
        string moneda_codNubefact;
        string tipDoccodsunatCliente;
        decimal total_gratuita;
 

        private void frm_facturacion_edicion_Load(object sender, EventArgs e)
        {
            IniciarCombo();
            IniciarComboTipoProducto();
            IniciarComboMoneda();
            DvtD_IGVTasaPorcentaje =Convert.ToDecimal(18);
            TxtRsIGVPorc.Text =Convert.ToString(DvtD_IGVTasaPorcentaje);
            txtfechaemision.Text = DateTime.Now.ToShortDateString();
            gbdetalle.Enabled = false;

            BtnDtEditar.Enabled = false;
            BtnDtGrabar.Enabled = false;
            BtnDtEliminar.Enabled = false;


            if (Es_Nuevo == true)
            {

                cbocomprobamte.Focus();
            }
            else
            {
                ListarModificar();
            }

        }


        public List<Ent_Facturacion> Lista_Modificar = new List<Ent_Facturacion>();
        public void ListarModificar()
        {
            Ent_Facturacion Ent = new Ent_Facturacion();
            Log_Facturacion log = new Log_Facturacion();



            Ent.id = idVentaCab;

            try
            {
                Lista_Modificar = log.Listar(Ent);
                if (Lista_Modificar.Count > 0)
                {
                    Ent_Facturacion Enti = new Ent_Facturacion();
                    Enti = Lista_Modificar[0];


                    idVentaCab   = Enti.id ;
                    cbocomprobamte.SelectedValue = Enti.comprobante_id;
         
                    comprobante_codSunat  = Enti.comprobante_codSunat;
                    cbomoneda.SelectedValue = Enti.modena_id;
                    modena_fe = Enti.modena_fe;

                    txttipocambio.Text = Convert.ToString(Enti.tipo_cambio_monto);
                    txtserie.Text = Enti.serie;
                    txtnumero.Text = Enti.numero;
                    txtfechaemision.Text = Convert.ToString(Enti.fechaEmision);

                    txtclienterucdni.Tag= Enti.cliente_id;
                    txtclienterucdni.Text = Enti.cliente_dniRuc;
                    txtclienterucdnides.Text = Enti.cliente_desc;
                    tipDoccodsunatCliente = Enti.cliente_tipo_doc_codSunat;

                    txtglosa.Text   = Enti.glosa;

                    TxtRsBaseImponible.Text     =  Convert.ToString(Enti.total_gravada);
                    TxtRsInAfecta.Text   =  Convert.ToString(Enti.total_inafecta);
                    TxtRsExonerada.Text  =    Convert.ToString(Enti.total_exonerada);
                    TxtRsIGVMonto.Text  =   Convert.ToString(Enti.total_igv);
                    total_gratuita = Enti.total_gratuita;
                    TxtRsOtrosTribCarg.Text   =   Convert.ToString(Enti.total_otros_cargos);
                    TxtRsImporteTotal.Text =    Convert.ToString(Enti.total_cab);



                    //listar detalle
                    //Logica_Movimiento_Cab log_det_con = new Logica_Movimiento_Cab();
                    DgvDetalle.DataSource = null;
                    Detalles = log.Listar_Det(Enti);
                    if (Detalles.Count > 0)
                    {
                        DgvDetalle.DataSource = Detalles;
                    }






                }
            }
            catch (Exception ex)
            {
                Accion.ErrorSistema(ex.Message);
            }
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
                                tipDoccodsunatCliente = Entidad.tipDoccodsunat;


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
                            tipDoccodsunatCliente = T.tipDoccodsunat;
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

                BtnDtNuevo.Enabled = false;
                BtnDtEditar.Enabled = false;
                BtnDtGrabar.Enabled = true;
                BtnDtEliminar.Enabled = false;
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
                limpiarProducto();
                txtproducto.ResetText();
                if (cbotipo.SelectedIndex == 0)
                {
                    lbldescripcionproser.Text = "Producto";
                }
                else
                {
                    lbldescripcionproser.Text = "Servicio";
                }
                txtproducto.Focus();

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
                                        tipo_afectacion_de_igv = Entidad.idAfectacionIgv;

                                        TxtPrecunitario.Text =Convert.ToString(Entidad.precioProducto);
                                        DvtD_OperCodigo = Entidad.afecIgvTabla;
                                        tipo_afectacion_de_igv_codNubefact = Entidad.tipo_afectacion_de_igv_codNubefact;


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
                                        tipo_afectacion_de_igv = Entidad.idAfectacionIgv;

                                        TxtPrecunitario.Text = Convert.ToString(Entidad.precioServicio);
                                        DvtD_OperCodigo = Entidad.afecIgvTabla;
                                        tipo_afectacion_de_igv_codNubefact = Entidad.tipo_afectacion_de_igv_codNubefact;

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
                            tipo_afectacion_de_igv = T.idAfectacionIgv;

                            TxtPrecunitario.Text = Convert.ToString(T.precioProducto);
                            DvtD_OperCodigo = T.afecIgvTabla;
                            tipo_afectacion_de_igv_codNubefact = T.tipo_afectacion_de_igv_codNubefact;

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
                            tipo_afectacion_de_igv = T.idAfectacionIgv;

                            TxtPrecunitario.Text = Convert.ToString(T.precioServicio);
                            DvtD_OperCodigo = T.afecIgvTabla;
                            tipo_afectacion_de_igv_codNubefact = T.tipo_afectacion_de_igv_codNubefact;

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

                if (VerificarDetalle())
                {
                    Ent_Facturacion ItemDetalle = new Ent_Facturacion();
                
                    ItemDetalle.id_det = Convert.ToInt32(TxtItNum.Text);
                    ItemDetalle.id_tipo_bien_servicio = Convert.ToInt32(cbotipo.SelectedValue.ToString());
                    ItemDetalle.tipo_bien_servicio_desc = cbotipo.GetItemText(this.cbotipo.SelectedItem);  //cbotipo.Text ;

                    ItemDetalle.prod_serv_id =Convert.ToInt32(txtproducto.Tag.ToString());
                    ItemDetalle.productocod = txtproducto.Text;
                    ItemDetalle.productodesc = txtproductodesc.Text;
                    ItemDetalle.unidad_medida_id = unidad_medida_id;
                    ItemDetalle.unidad_medida_desc = txtunidadmedida.Text.Trim();
                    ItemDetalle.unidad_medida_fe = unidad_medida_fe;
                    ItemDetalle.tipo_afectacion_de_igv = tipo_afectacion_de_igv;
                    ItemDetalle.tipo_afectacion_de_igv_codNubefact = tipo_afectacion_de_igv_codNubefact;

                    ItemDetalle.DvtD_OperCodigo = DvtD_OperCodigo;

                    ItemDetalle.cantidad = Convert.ToDecimal(TxtItCantidad.Text);

                    if (ItemDetalle.DvtD_OperCodigo == "0565")
                    {
                        ItemDetalle.valor_unitario =Math.Round(Convert.ToDecimal(TxtPrecunitario.Text) / (1 +(DvtD_IGVTasaPorcentaje/100)),2) ;
                    }
                    else
                    {
                        ItemDetalle.valor_unitario = Convert.ToDecimal(TxtPrecunitario.Text);
                    }
                     
                    ItemDetalle.precio_unitario = Convert.ToDecimal(TxtPrecunitario.Text);
           

                    if (ItemDetalle.DvtD_OperCodigo == "0565")
                    {
                        ItemDetalle.DvtD_IGVTasaPorcentaje = DvtD_IGVTasaPorcentaje; ;
                    }
                    else
                    {
                        ItemDetalle.DvtD_IGVTasaPorcentaje = 0;
                    }


                    ItemDetalle.total_det = Convert.ToDecimal(TxtItImporte.Text);

                    if (Es_Nuevo_Det)
                    {
                        Detalles.Add(ItemDetalle);
                        Es_Nuevo_Det = false;
                        gbdetalle.Enabled = false;

                        BtnDtNuevo.Enabled = true;
                        BtnDtEditar.Enabled = false;
                        BtnDtGrabar.Enabled = false;
                        BtnDtEliminar.Enabled = false;

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
                
                //TxtRsValExporta.Text =Convert.ToString(MValorFactExport);
                TxtRsBaseImponible.Text = Convert.ToString(MBaseImponible);
                TxtRsExonerada.Text = Convert.ToString(MExonerada);
                TxtRsInAfecta.Text = Convert.ToString(MInafecta);
                //TxtRsISC.Text = Convert.ToString(MISC);
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
                Accion.ErrorSistema(ex.Message);
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


            try
            {
                if (cbocomprobamte.Items.Count > 0)
                {
                    List<Ent_Moneda> Lista = new List<Ent_Moneda>();

                    Log_Moneda LogEmp = new Log_Moneda();
                    Ent_Moneda Ent = new Ent_Moneda();
                    Ent.id = Convert.ToInt32(cbocomprobamte.SelectedValue.ToString());


                    Lista = LogEmp.Listar(Ent);

                    modena_fe = Lista[0].codsunat;
                    moneda_codNubefact = Lista[0].moneda_codNubefact;


                }

            }
            catch (Exception ex)
            {
                Accion.ErrorSistema(ex.Message);
            }



        }

        private void GridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (Detalles.Count > 0 & GridView1.GetFocusedDataSourceRowIndex() > -1)
                {
                    Ent_Facturacion Entidad = new Ent_Facturacion();
 
                    Entidad = Detalles[GridView1.GetFocusedDataSourceRowIndex()];

                    TxtItNum.Text = Convert.ToString(Entidad.id_det);
                    cbotipo.SelectedValue=Entidad.id_tipo_bien_servicio;

                    txtproducto.Tag = Entidad.prod_serv_id;
                    txtproducto.Text = Entidad.productocod;
                    txtproductodesc.Text = Entidad.productodesc;
                    unidad_medida_id = Entidad.unidad_medida_id;
                    txtunidadmedida.Text = Entidad.unidad_medida_desc;
                    unidad_medida_fe = Entidad.unidad_medida_fe;
                    tipo_afectacion_de_igv  = Entidad.tipo_afectacion_de_igv;
                    tipo_afectacion_de_igv_codNubefact = Entidad.tipo_afectacion_de_igv_codNubefact;

                    DvtD_OperCodigo = Entidad.DvtD_OperCodigo;
                    TxtItCantidad.Text = Convert.ToString(Entidad.cantidad);
                    TxtPrecunitario.Text = Convert.ToString(Entidad.precio_unitario);
                    TxtItImporte.Text = Convert.ToString(Entidad.total_det);
                    cbotipo.SelectedValue = Entidad.id_tipo_bien_servicio;

                    BtnDtNuevo.Enabled = true;
                    BtnDtEditar.Enabled = true;
                    BtnDtGrabar.Enabled = false;
                    BtnDtEliminar.Enabled = true;

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
                gbdetalle.Enabled = true;
                BtnDtEditar.Enabled = false;
                BtnDtGrabar.Enabled = true;

                cbotipo.Focus();


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

        public bool VerificarCabecera()
        {
            if (string.IsNullOrEmpty(txtserie.Text.Trim()))
            {
                Accion.Advertencia("Debe ingresar una serie");
                txtserie.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtnumero.Text.Trim()))
            {
                Accion.Advertencia("Debe ingresar un número");
                txtnumero.Focus();
                return false;
            }

            if (txtfechaemision.Text == "" || txtfechaemision.Text == "  /  /")
            {
                Accion.Advertencia("Debe ingresar una fecha de emisión");
                txtfechaemision.Focus();
                return false;
            }

            if (Detalles.Count == 0)
            {
                Accion.Advertencia("Debe ingresar al menos un detalle");
                BtnDtNuevo.Focus();
                return false;
            }


            return true;
        }

        public bool VerificarDetalle()
        {
            if (string.IsNullOrEmpty(txtproductodesc.Text.Trim()))
            {
                Accion.Advertencia("Debe ingresar un producto");
                txtproducto.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtunidadmedida.Text.Trim()))
            {
                Accion.Advertencia("Debe asignar una unidad de medida a este producto,revise la configuración del producto");
                txtproducto.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(TxtItCantidad.Text.Trim()) || TxtItCantidad.Text =="0.00")
            {
                Accion.Advertencia("Debe ingresar una cantidad");
                TxtItCantidad.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(TxtPrecunitario.Text.Trim()) || TxtPrecunitario.Text =="0.00")
            {
                Accion.Advertencia("Debe ingresar un precio unitario,revise la configuración del producto");
                TxtPrecunitario.Focus();
                return false;
            }
 

            return true;
        }


        private void btngrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificarCabecera())
                {
                    Ent_Facturacion Ent = new Ent_Facturacion();
                    Log_Facturacion Log = new Log_Facturacion();

                    Ent.id = idVentaCab;
                    Ent.comprobante_id = Convert.ToInt32(cbocomprobamte.SelectedValue.ToString());
                    Ent.comprobante_codSunat = comprobante_codSunat;


                    Ent.modena_id = Convert.ToInt32(cbomoneda.SelectedValue.ToString());
                    Ent.modena_fe = modena_fe;


                    Ent.tipo_cambio_monto =Convert.ToDecimal(txttipocambio.Text);
                    Ent.serie = txtserie.Text;
                    Ent.numero = txtnumero.Text;
                    Ent.fechaEmision =Convert.ToDateTime(txtfechaemision.Text);
                    Ent.cliente_id = Convert.ToInt32(txtclienterucdni.Tag.ToString());
                    Ent.cliente_dniRuc = txtclienterucdni.Text.Trim();
                    Ent.cliente_desc = txtclienterucdnides.Text.Trim();


                    Ent.glosa = txtglosa.Text.Trim();

                    Ent.total_gravada = Convert.ToDecimal(TxtRsBaseImponible.Text);
                    Ent.total_inafecta = Convert.ToDecimal(TxtRsInAfecta.Text);
                    Ent.total_exonerada = Convert.ToDecimal(TxtRsExonerada.Text);
                    Ent.total_igv = Convert.ToDecimal(TxtRsIGVMonto.Text);
                    Ent.total_gratuita = 0;
                    Ent.total_otros_cargos = Convert.ToDecimal(TxtRsOtrosTribCarg.Text);
                    Ent.total_cab = Convert.ToDecimal(TxtRsImporteTotal.Text);

                    Ent.DetalleADM = Detalles;
                    
                    if (Es_Nuevo ==true)
                    {
                        if (Log.Insertar(Ent))
                        {
                            //Despues de guardar se envia al servicio
                            Respuesta rpta = new Respuesta();
                            rpta =   Envia_Comprobante_Electronico_A_Servicio(Ent);

                            //Actualizamos el campo aceptada_por_sunat capturado en la respuesta , se actualiza venta_cab por el id
                            Ent_Facturacion EntRpta = new Ent_Facturacion();
                            EntRpta.id = Ent.id;
                            EntRpta.aceptado_por_sunat =Convert.ToBoolean(rpta.aceptada_por_sunat);

                            Log.Actualizar_Campos_Sunat(EntRpta);



                            //
                            Accion.ExitoGuardar();
                            this.Close();
                        }
                    }
                    else
                    {
                        if (Log.Modificar(Ent))
                        {
                            Accion.ExitoModificar();
                            this.Close();
                        }
                    }

                }


            }
            catch(Exception ex)
            {
                Accion.ErrorSistema(ex.Message);
            }
        }

        Respuesta Envia_Comprobante_Electronico_A_Servicio(Ent_Facturacion entidad)
        {
            string ULServicioFacturacion = Actual_Conexion.urlServicio;//"https://localhost:44305/api/facturacion/nubefact"; //"

            Invoice parametros = new Invoice();
            parametros = Convertir_Cliente_Objet(entidad);


            string json = JsonConvert.SerializeObject(parametros, Formatting.Indented);
 
            byte[] bytes = Encoding.Default.GetBytes(json);
            string json_en_utf_8 = Encoding.UTF8.GetString(bytes);

            string json_de_respuesta = SendJson(ULServicioFacturacion, json_en_utf_8,"");

            dynamic r = JsonConvert.DeserializeObject<Respuesta>(json_de_respuesta);
            string r2 = JsonConvert.SerializeObject(r, Formatting.Indented);

            dynamic leer_respuesta = JsonConvert.DeserializeObject<Respuesta>(json_de_respuesta);

            Respuesta rpta = new Respuesta();

            if (leer_respuesta.errors == null)
            {

                rpta.tipo = Convert.ToString(leer_respuesta.tipo);
                rpta.serie = Convert.ToString(leer_respuesta.serie);
                rpta.numero = Convert.ToString(leer_respuesta.numero);
                rpta.url = Convert.ToString(leer_respuesta.url);
                rpta.aceptada_por_sunat = Convert.ToString(leer_respuesta.aceptada_por_sunat);
                rpta.sunat_description = Convert.ToString(leer_respuesta.sunat_description);
                rpta.sunat_note = Convert.ToString(leer_respuesta.sunat_note);
                rpta.sunat_responsecode = Convert.ToString(leer_respuesta.sunat_responsecode);
                rpta.sunat_soap_error = Convert.ToString(leer_respuesta.sunat_soap_error);
                rpta.pdf_zip_base64 = Convert.ToString(leer_respuesta.pdf_zip_base64);
                rpta.xml_zip_base64 = Convert.ToString(leer_respuesta.xml_zip_base64);
                rpta.cdr_zip_base64 = Convert.ToString(leer_respuesta.cdr_zip_base64);
                rpta.cadena_para_codigo_qr = Convert.ToString(leer_respuesta.cadena_para_codigo_qr);
                rpta.codigo_hash = Convert.ToString(leer_respuesta.codigo_hash);
                rpta.codigo_de_barras = Convert.ToString(leer_respuesta.codigo_de_barras);


            }
            else
            {
                rpta.errors = Convert.ToString(leer_respuesta.errors);
            }

            return rpta;

        }








        Invoice Convertir_Cliente_Objet(Ent_Facturacion Documento_Cliente)
        {
            Invoice Doc = new Invoice();

            Doc.URLNubeFact = Actual_Conexion.urlNubeFact;
            Doc.TokenNubeFact = Actual_Conexion.tokenNubeFact;
            Doc.operacion = "generar_comprobante";
            Doc.tipo_de_comprobante = comprobante_codNubefact;
            Doc.serie = Documento_Cliente.serie;
            Doc.numero = Documento_Cliente.numero ;
            Doc.sunat_transaction =  1 ; //1 = VENTA INTERNA 
            Doc.cliente_tipo_de_documento = Convert.ToInt32(tipDoccodsunatCliente);
            Doc.cliente_numero_de_documento = Documento_Cliente.cliente_dniRuc.Trim()  ;
            Doc.cliente_denominacion =   Documento_Cliente.cliente_desc.Trim();
            Doc.cliente_direccion =   "";
            Doc.cliente_email =   "";
            Doc.cliente_email_1 =  "" ;
            Doc.cliente_email_2 =   "";
            Doc.fecha_de_emision = Convert.ToString(Documento_Cliente.fechaEmision);
            Doc.fecha_de_vencimiento =  "" ;
            Doc.moneda =  moneda_codNubefact;
            Doc.tipo_de_cambio = Convert.ToString(Documento_Cliente.tipo_cambio_monto);
            Doc.porcentaje_de_igv = Convert.ToString(Documento_Cliente.DvtD_IGVTasaPorcentaje);
            Doc.descuento_global = "";
            Doc.total_descuento = "";
            Doc.total_anticipo = "";
            Doc.total_gravada = Convert.ToString(Documento_Cliente.total_gravada);
            Doc.total_inafecta = Convert.ToString(Documento_Cliente.total_inafecta);
            Doc.total_exonerada = Convert.ToString(Documento_Cliente.total_exonerada);
            Doc.total_igv = Convert.ToString(Documento_Cliente.total_igv);
            Doc.total_gratuita = Convert.ToString(Documento_Cliente.total_gratuita);
            Doc.total_otros_cargos = Convert.ToString(Documento_Cliente.total_otros_cargos);
            Doc.total = Convert.ToString(Documento_Cliente.total_cab);
            Doc.percepcion_tipo = "";
            Doc.percepcion_base_imponible = "";
            Doc.total_percepcion = "";
            Doc.detraccion = "false";
            Doc.observaciones = "";
            Doc.documento_que_se_modifica_tipo = "";
            Doc.documento_que_se_modifica_serie = "";
            Doc.documento_que_se_modifica_numero = "";
            Doc.tipo_de_nota_de_credito = "";
            Doc.tipo_de_nota_de_debito = "";
            Doc.enviar_automaticamente_a_la_sunat = "true";
            Doc.enviar_automaticamente_al_cliente = "false";
            Doc.codigo_unico = "";
            Doc.condiciones_de_pago = "";
            Doc.medio_de_pago = "";
            Doc.placa_vehiculo = "";
            Doc.orden_compra_servicio = "";
            Doc.tabla_personalizada_codigo = "";
            Doc.formato_de_pdf = "";


            List<Items> feDetalles = new List<Items>();

            foreach (Ent_Facturacion bf in Documento_Cliente.DetalleADM)
            {
                Items det = new Items();

                det.unidad_de_medida =bf.unidad_medida_fe;
                det.codigo = bf.productocod;
                det.descripcion =  bf.productodesc ;
                det.cantidad = Convert.ToString(bf.cantidad);
                det.valor_unitario = Convert.ToString(bf.valor_unitario);
                det.precio_unitario = Convert.ToString(bf.precio_unitario); 
                det.descuento = "";
                det.subtotal = Convert.ToString(bf.subtotal);
                det.tipo_de_igv = bf.tipo_afectacion_de_igv_codNubefact;
                det.igv = Convert.ToString(bf.DvtD_IGVMonto);
                det.total = Convert.ToString(bf.total_det);
                det.anticipo_regularizacion = "false"; 
                det.anticipo_comprobante_serie = "";
                det.anticipo_comprobante_numero = "";
 
                feDetalles.Add(det);
            }

            Doc.items = feDetalles;

            return Doc;


        }

        static string SendJson(string ruta, string json, string token)
        {
            try
            {
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });

                using (var client = new WebClient())
                {
                    /// ESPECIFICAMOS EL TIPO DE DOCUMENTO EN EL ENCABEZADO
                    client.Headers[HttpRequestHeader.ContentType] = "application/json; charset=utf-8";
                    /// ASI COMO EL TOKEN UNICO
                    //client.Headers[HttpRequestHeader.Authorization] = "Token token=" + token;
                    /// OBTENEMOS LA RESPUESTA
                    string respuesta = client.UploadString(ruta, "POST", json);
                    /// Y LA 'RETORNAMOS'
                    return respuesta;
                }
            }
            catch (WebException ex)
            {
                /// EN CASO EXISTA ALGUN ERROR, LO TOMAMOS
                var respuesta = new StreamReader(ex.Response.GetResponseStream()).ReadToEnd();
                /// Y LO 'RETORNAMOS'
                return respuesta;
            }
        }




        private void cbocomprobamte_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbocomprobamte.Items.Count > 0)
                {
                    List<Ent_Comprobante> Lista = new List<Ent_Comprobante>();
 
                    Log_Comprobante LogEmp = new Log_Comprobante();
                    Ent_Comprobante Ent = new Ent_Comprobante();
                    Ent.id = Convert.ToInt32(cbocomprobamte.SelectedValue.ToString());


                    Lista = LogEmp.Listar(Ent);

                    comprobante_codSunat = Lista[0].codsunat;
                    comprobante_codNubefact = Lista[0].comprobante_codNubefact;
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

        private void txtproducto_TextChanged(object sender, EventArgs e)
        {
            if (txtproducto.Focus() == true)
            {
                limpiarProducto();
            }
        }

        void limpiarProducto()
        {
            txtproductodesc.ResetText();
            txtunidadmedida.ResetText();
            TxtItCantidad.Text = "0.00";
            TxtPrecunitario.Text = "0.00";
            TxtItImporte.Text = "0.00";

        }
    }
}
