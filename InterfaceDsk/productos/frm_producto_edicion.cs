using interfacedsk.Proveedor;
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
    public partial class frm_producto_edicion : Form
    {
        public frm_producto_edicion()
        {
            InitializeComponent();
        }
        public bool Es_Nuevo = false;
        public int IdProducto;
        private void frm_producto_edicion_Load(object sender, EventArgs e)
        {
            IniciarComboUnidadMedida();
            IniciarComboTipoAfectacion();
            if (Es_Nuevo == true)
            {

                txtrucproveedor.Focus();
            }
            else
            {
                ListarModificar();
            }
        }

        private List<Ent_Unidad_Medida> ListUnm = new List<Ent_Unidad_Medida>();
        public void IniciarComboUnidadMedida()
        {
            try
            {
                Log_Unidad_Medida LogEmp = new Log_Unidad_Medida();
                Ent_Unidad_Medida Ent = new Ent_Unidad_Medida();
                cbounidadmedida.ValueMember = "id";
                cbounidadmedida.DisplayMember = "descripcion";


                ListUnm = LogEmp.Listar(Ent);

                cbounidadmedida.DataSource = ListUnm;
            }
            catch (Exception ex)
            {
                Accion.ErrorSistema(ex.Message);
            }
        }



        private List<Ent_tipo_afectacion_igv> ListtipAfec= new List<Ent_tipo_afectacion_igv>();
        public void IniciarComboTipoAfectacion()
        {
            try
            {
                Log_tipo_afectacion_igv LogEmp = new Log_tipo_afectacion_igv();
                Ent_tipo_afectacion_igv Ent = new Ent_tipo_afectacion_igv();
                cbooperacionigv.ValueMember = "afecIgvCodigo";
                cbooperacionigv.DisplayMember = "afecIgvDescripcion";


                ListtipAfec = LogEmp.Listar(Ent);

                cbooperacionigv.DataSource = ListtipAfec;
            }
            catch (Exception ex)
            {
                Accion.ErrorSistema(ex.Message);
            }
        }



        public List<Ent_Producto> Lista_Modificar = new List<Ent_Producto>();
        public void ListarModificar()
        {
            Ent_Producto Ent = new Ent_Producto();
            Log_Producto log = new Log_Producto();

 

            Ent.idProducto = IdProducto;
 
            try
            {
                Lista_Modificar = log.Listar(Ent);
                if (Lista_Modificar.Count > 0)
                {
                    Ent_Producto Enti = new Ent_Producto();
                    Enti = Lista_Modificar[0];

                    IdProducto = Enti.idProducto;
                    txtrucproveedor.Tag = Enti.idProveedor;
                    txtrucproveedor.Text = Enti.numeroDocumentoProveedor;
                    txtrucproveedordesc.Text = Enti.nombreProveedor;
                    txtnombre.Text = Enti.nombreProducto ;
                    txtdescripcion.Text = Enti.descripcionProducto ;
                    txtespecificaciones.Text  = Enti.especificacionesProducto;
                    txtprecio.Text    = Convert.ToString(Enti.precioProducto);
                    txtfechaingreso.Text    =    Convert.ToString(Enti.fechaIngresoProducto);
                    txtfechaexpiracion.Text   =    Convert.ToString(Enti.fechaExpiracionProducto);
                    txtcantidadstock.Text    = Convert.ToString(Enti.cantidadStockProducto);
                    txtcolor.Text    = Enti.colorProducto ;
                    txttamanio.Text   = Enti.tamProducto;
                    txtaltura.Text= Enti.alturaProducto ;
                    txtancho.Text = Enti.anchoProducto ;
                    txtvolumen.Text  = Enti.volumenProducto;
                    txtpeso.Text = Enti.pesoProducto ;
                    txtmarca.Text  = Enti.marcaProducto;
                    txtmodelo.Text = Enti.modeloProducto ;
                    txtcodproducto.Text  = Enti.codigoProducto ;
                    txttiempogarantia.Text  = Enti.tiempoGarantiaProducto;
                    txtfotoprincipal.Text = Enti.fotoPrincipalProducto ;


                    cbounidadmedida.SelectedValue = Enti.idUnidadMedida;
                    cbooperacionigv.SelectedValue = Enti.idAfectacionIgv;




                }
            }
            catch (Exception ex)
            {
                Accion.ErrorSistema(ex.Message);
            }
        }




        private void txtrucproveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (String.IsNullOrEmpty(txtrucproveedor.Text) == false)
            {
                try
                {
                    if (e.KeyCode == Keys.Enter & txtrucproveedor.Text.Substring(txtrucproveedor.Text.Length - 1, 1) == "*")
                    {
                        using (frm_proveedor f = new frm_proveedor())
                        {
 

                            if (f.ShowDialog(this) == DialogResult.OK)
                            {
                                Ent_Proveedor Entidad = new Ent_Proveedor();

                                Entidad = f.Listar[f.gridView1.GetFocusedDataSourceRowIndex()];
                                
                                txtrucproveedor.Tag = Entidad.idProveedor;
                                txtrucproveedor.Text = Entidad.numeroDocumentoProveedor;
                                txtrucproveedordesc.Text = Entidad.nombreProveedor;
                            }
                        }
                    }
                    else
                        if (e.KeyCode == Keys.Enter & !string.IsNullOrEmpty(txtrucproveedor.Text) & string.IsNullOrEmpty(txtrucproveedordesc.Text))
                    {
                        Buscarproveedor();
                    }
                }
                catch (Exception ex)
                {
                    Accion.ErrorSistema(ex.Message);
                }
            }
        }

        public void Buscarproveedor()
        {
            try
            {
              
                Log_Proveedor log = new Log_Proveedor();

                List<Ent_Proveedor> Generales = new List<Ent_Proveedor>();
                Generales = log.Listar(new Ent_Proveedor
                {
                    idProveedor = 2
                });

                if (Generales.Count > 0)
                {

                    foreach (Ent_Proveedor T in Generales)
                    {
                        if ((T.numeroDocumentoProveedor).ToString().Trim().ToUpper() == txtrucproveedor.Text.Trim().ToUpper())
                        {
                            txtrucproveedor.Tag = T.idProveedor;
                            txtrucproveedor.Text = T.numeroDocumentoProveedor;
                            txtrucproveedordesc.Text = T.nombreProveedor;

                        }
                    }

                }
                else
                {
                    Accion.Advertencia("No se encontro el proveedor");
                }
            }
            catch (Exception ex)
            {
                Accion.ErrorSistema(ex.Message);
            }
        }

        private void txtrucproveedor_TextChanged(object sender, EventArgs e)
        {
            if(txtrucproveedor.Focus() == true)
            {
                txtrucproveedordesc.ResetText();
            }
        }

        public bool VerificarCabecera()
        {
            if (string.IsNullOrEmpty(txtrucproveedordesc.Text.Trim()))
            {
                Accion.Advertencia("Debe ingresar un proveedor");
                txtrucproveedor.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtnombre.Text.Trim()))
            {
                Accion.Advertencia("Debe ingresar un nombre del producto");
                txtnombre.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtcodproducto.Text.Trim()))
            {
                Accion.Advertencia("Debe ingresar un código del producto");
                txtcodproducto.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtdescripcion.Text.Trim()))
            {
                Accion.Advertencia("Debe ingresar una descripción");
                txtdescripcion.Focus();
                return false;
            }

            if (txtfechaingreso.Text == "" || txtfechaingreso.Text == "  /  /")
            {
                Accion.Advertencia("Debe ingresar una fecha de ingreso");
                txtdescripcion.Focus();
                return false;
            }

            if (txtfechaexpiracion.Text == "" || txtfechaexpiracion.Text == "  /  /")
            {
                Accion.Advertencia("Debe ingresar una fecha de expiracion");
                txtdescripcion.Focus();
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
                    Ent_Producto Ent = new Ent_Producto();
                    Log_Producto Log = new Log_Producto();

 
                        Ent.idProducto = IdProducto;
                        Ent.idProveedor = Convert.ToInt32(IIf(txtrucproveedor.Tag.ToString() == "",0, Convert.ToInt32(txtrucproveedor.Tag.ToString())));

 
  
                        Ent.nombreProducto  = txtnombre.Text;
                        Ent.descripcionProducto = txtdescripcion.Text;
                        Ent.especificacionesProducto = txtespecificaciones.Text;
                        Ent.precioProducto  = Convert.ToDecimal(txtprecio.Text);
                
                        if (txtfechaingreso.Text == "" || txtfechaingreso.Text == "01/01/1900")
                        {
                            Ent.fechaIngresoProducto = Convert.ToDateTime("01/01/1900");
                        }
                        else
                        {
                            Ent.fechaIngresoProducto = Convert.ToDateTime(txtfechaingreso.Text);
                        }
 
                        if (txtfechaexpiracion.Text == "" || txtfechaexpiracion.Text == "01/01/1900")
                        {
                            Ent.fechaExpiracionProducto = Convert.ToDateTime("01/01/1900");
                        }
                        else
                        {
                            Ent.fechaExpiracionProducto = Convert.ToDateTime(txtfechaexpiracion.Text);
                        }

                       Ent.cantidadStockProducto = Convert.ToDecimal(txtcantidadstock.Text);
                        Ent.colorProducto  = txtcolor.Text;
                        Ent.tamProducto = txttamanio.Text;
                        Ent.alturaProducto  = txtaltura.Text;
                        Ent.anchoProducto  = txtancho.Text;
                        Ent.volumenProducto  = txtvolumen.Text;
                        Ent.pesoProducto  = txtpeso.Text;
                        Ent.marcaProducto  = txtmarca.Text;
                        Ent.modeloProducto  = txtmodelo.Text;
                        Ent.codigoProducto  = txtcodproducto.Text;
                        Ent.tiempoGarantiaProducto  = txttiempogarantia.Text;
                        Ent.fotoPrincipalProducto  = txtfotoprincipal.Text;
                        Ent.idUnidadMedida = Convert.ToInt32(cbounidadmedida.SelectedValue.ToString());
                        Ent.idAfectacionIgv = cbooperacionigv.SelectedValue.ToString();

                    if (Es_Nuevo == true)
                    {
                        if (Log.Insertar(Ent))
                        {
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
            catch (Exception ex)
            {
                Accion.ErrorSistema(ex.Message);
            }

        }


        Object IIf(bool expression, object truePart, object falsePart)
        { return expression ? truePart : falsePart; }

        private void cbounidadmedida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbooperacionigv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
