using interfacedsk.Proveedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfacedsk.servicios
{
    public partial class frm_servicios_edicion : Form
    {
        public frm_servicios_edicion()
        {
            InitializeComponent();
        }

 
        public bool Es_Nuevo = false;
        public int IdServicio;
        string pathOrigen = "";
        string nombreImg = "";
        private void frm_servicios_edicion_Load(object sender, EventArgs e)
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

            }
        }



        private List<Ent_tipo_afectacion_igv> ListtipAfec = new List<Ent_tipo_afectacion_igv>();
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

            }
        }


        public List<Ent_Servicio> Lista_Modificar = new List<Ent_Servicio>();
        public void ListarModificar()
        {
            Ent_Servicio Ent = new Ent_Servicio();
            Log_Servicio log = new Log_Servicio();

            Ent.idServicio = IdServicio;

            try
            {
                Lista_Modificar = log.Listar(Ent);

                if (Lista_Modificar.Count > 0)
                {
                    Ent_Servicio Enti = new Ent_Servicio();
                    Enti = Lista_Modificar[0];

                    IdServicio = Enti.idServicio;
                    txtrucproveedor.Tag = Enti.idProveedor;
                    txtrucproveedor.Text = Enti.numeroDocumentoProveedor;
                    txtrucproveedordesc.Text = Enti.nombreProveedor;

                    //txtcalificacioncod.Text = Convert.ToString(Enti.idCalificacion);
                    txtidhorario.Text = Convert.ToString(Enti.idHorario);
                    txtnombre.Text   = Enti.nombreServicio;
                    txtdescripcion.Text  = Enti.descripcionServicio;
                    txtprecio.Text   = Convert.ToString(Enti.precioServicio);
                    txtfechaexpiracion.Text = Convert.ToString(Enti.fechaExpiracionServicio);
                    txtcantidadstock.Text  = Convert.ToString(Enti.cantidadStockServicio );
                    txtcodigo.Text = Enti.codigoServicio;
                    txttiempogarantia.Text  = Enti.tiempoGarantiaServicio ;
                    txtfotoprincipal.Text   = Enti.fotosGaleriaServicio;

           
                    string ruta = @"c:\MP_Upload";

                    string[] fotos = Directory.GetFiles(ruta,Enti.fotosGaleriaServicio.Trim());
                    if (fotos.Length > 0)
                    {
                        pictureBox1.Image = new Bitmap(fotos[0]);
                    }

                    cbounidadmedida.SelectedValue = Enti.idUnidadMedida;
                    cbooperacionigv.SelectedValue = Enti.idAfectacionIgv;


                }
            }
            catch (Exception ex)
            {
                Accion.ErrorSistema(ex.Message);
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
            if (string.IsNullOrEmpty(txtdescripcion.Text.Trim()))
            {
                Accion.Advertencia("Debe ingresar una descripción");
                txtdescripcion.Focus();
                return false;
            }

 
            if (txtfechaexpiracion.Text == "" || txtfechaexpiracion.Text == "  /  /")
            {
                Accion.Advertencia("Debe ingresar una fecha de expiración");
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
                    Ent_Servicio Ent = new Ent_Servicio();
                    Log_Servicio Log = new Log_Servicio();


                    Ent.idServicio = IdServicio;
                    Ent.idProveedor = Convert.ToInt32(IIf(txtrucproveedor.Tag.ToString() == "", 0, Convert.ToInt32(txtrucproveedor.Tag.ToString())));

                    //if (txtcalificacioncod.Text == "")
                    //{
                    //    txtcalificacioncod.Text = Convert.ToString(0);
                    //    if (Convert.ToInt32(txtcalificacioncod.Text) != 0)
                    //    {
                    //        Ent.idCalificacion = Convert.ToInt32(txtcalificacioncod.Text);
                    //    }
                    //}

                    if (txtidhorario.Text == "")
                    {
                        txtidhorario.Text = Convert.ToString(0);
                        if (Convert.ToInt32(txtidhorario.Text) != 0)
                        {
                            Ent.idHorario = Convert.ToInt32(txtidhorario.Text);
                        }
                    }


                    Ent.nombreServicio = txtnombre.Text;
                    Ent.descripcionServicio = txtdescripcion.Text;
                    Ent.precioServicio = Convert.ToDecimal(txtprecio.Text);

                    if (txtfechaexpiracion.Text == "" || txtfechaexpiracion.Text == "01/01/1900")
                    {
                        Ent.fechaExpiracionServicio = Convert.ToDateTime("01/01/1900");
                    }
                    else
                    {
                        Ent.fechaExpiracionServicio = Convert.ToDateTime(txtfechaexpiracion.Text);
                    }

                    Ent.cantidadStockServicio = Convert.ToDecimal(txtcantidadstock.Text);
                    Ent.codigoServicio = txtcodigo.Text;
                    Ent.tiempoGarantiaServicio = txttiempogarantia.Text;
                    Ent.fotosGaleriaServicio = txtfotoprincipal.Text;

                    Ent.idUnidadMedida = Convert.ToInt32(cbounidadmedida.SelectedValue.ToString());
                    Ent.idAfectacionIgv = cbooperacionigv.SelectedValue.ToString();


                    if (Es_Nuevo == true)
                    {
                        try
                        {
                            string pathDestino = @"c:\MP_Upload";
                            if (!Directory.Exists(pathDestino))
                            {
                                Directory.CreateDirectory(pathDestino);
                            }
                            else
                            {
                                string ruta = @"c:\MP_Upload\" + nombreImg;

                                if (File.Exists(ruta))
                                {
                                    Accion.Advertencia("Existe el archivo: " + nombreImg);
                                    return;
                                }
                                else
                                {
                                    File.Move(pathOrigen, Path.Combine(pathDestino, nombreImg));
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Accion.ErrorSistema(ex.Message);
                        }



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
            if (txtrucproveedor.Focus() == true)
            {
                txtrucproveedordesc.ResetText();
            }
        }

        private void btnbuscarimg_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog BuscarImagen = new OpenFileDialog();
                BuscarImagen.Filter = "Archivos de Imagen (*.png;*.jpg)|*.png;*.jpg";
                BuscarImagen.FileName = "";
                BuscarImagen.Title = "Titulo del Dialogo";
 
                if (BuscarImagen.ShowDialog() == DialogResult.OK)
                {
                    //this.txtfotoprincipal.Text = BuscarImagen.FileName;
                    pathOrigen = BuscarImagen.FileName;
                    string filename = Path.GetFileName(BuscarImagen.FileName);
                    nombreImg = filename;

                    this.txtfotoprincipal.Text = filename;
                    String Direccion = BuscarImagen.FileName;
                    this.pictureBox1.ImageLocation = Direccion;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

           


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }
    }
}
