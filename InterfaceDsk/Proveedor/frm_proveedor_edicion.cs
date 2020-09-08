using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfacedsk.Proveedor
{
    public partial class frm_proveedor_edicion : Form
    {
        public frm_proveedor_edicion()
        {
            InitializeComponent();
        }

        public bool Es_Nuevo = false;
        public int id = 0;

        private void frm_proveedor_edicion_Load(object sender, EventArgs e)
        {
            if (Es_Nuevo == true)
            {

                txtnumdoc.Focus();
            }
            else
            {
                ListarModificar();
            }
        }


        public List<Ent_Proveedor> Lista_Modificar = new List<Ent_Proveedor>();
        public void ListarModificar()
        {
            Ent_Proveedor Ent = new Ent_Proveedor();
            Log_Proveedor log = new Log_Proveedor();

            //Estado = Estados.Ninguno;

            Ent.idProveedor = id;


            try
            {
                Lista_Modificar = log.Listar(Ent);
                if (Lista_Modificar.Count > 0)
                {
                    Ent_Proveedor Enti = new Ent_Proveedor();
                    Enti = Lista_Modificar[0];


                    id = Enti.idProveedor;

                    txtnumdoc.Text = Enti.numeroDocumentoProveedor;
                    txtnombre.Text = Enti.nombreProveedor;
                    txttipodoc.Text = Enti.tipoDocumentoProveedor;
 

                }
            }
            catch (Exception ex)
            {
                Accion.ErrorSistema(ex.Message);
            }
        }

        public bool VerificarCabecera()
        {
            if (string.IsNullOrEmpty(txtnumdoc.Text.Trim()))
            {
                Accion.Advertencia("Debe ingresar un número de documento");
                txtnumdoc.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtnombre.Text.Trim()))
            {
                Accion.Advertencia("Debe ingresar un nombre");
                txtnumdoc.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txttipodoc.Text.Trim()))
            {
                Accion.Advertencia("Debe ingresar el tipo de documento");
                txtnumdoc.Focus();
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
                    Ent_Proveedor Ent = new Ent_Proveedor();
                    Log_Proveedor Log = new Log_Proveedor();

                    Ent.idProveedor = id;
                    Ent.numeroDocumentoProveedor = txtnumdoc.Text.Trim();
                    Ent.nombreProveedor = txtnombre.Text.Trim();
                    Ent.tipoDocumentoProveedor = txttipodoc.Text.Trim();
 

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
    }
}
