﻿using Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfacedsk.usuarios
{
    public partial class frm_usuario_edicion : Form
    {
        public frm_usuario_edicion()
        {
            InitializeComponent();
        }

        public bool Es_Nuevo = false;
        public int id =0;
        private void frm_usuario_edicion_Load(object sender, EventArgs e)
        {
            IniciarCombo();

            if (Es_Nuevo == true)
            {
              
                txtnombres.Focus();
            }
            else
            {
                ListarModificar();
            }
        }

        private List<Ent_Perfil> ListEmp = new List<Ent_Perfil>();
        public void IniciarCombo()
        {
            try
            {
                Log_Perfil LogEmp = new Log_Perfil();
                Ent_Perfil Ent = new Ent_Perfil();
                cboperfil.ValueMember = "perfil_id";
                cboperfil.DisplayMember = "perfil_nombre";
 

                ListEmp = LogEmp.Listar(Ent);

                cboperfil.DataSource = ListEmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Inicio de sesion incorrecto", MessageBoxButtons.OK);
            }
        }


        public bool VerificarCabecera()
        {
            if (string.IsNullOrEmpty(txtnombres.Text.Trim()))
            {
                Accion.Advertencia("Debe ingresar un nombre");
                txtnombres.Focus();
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
                        Ent_Usuario Ent = new Ent_Usuario();
                        Log_usuario Log = new Log_usuario();

                        Ent.usuario_id = id;
                        Ent.usuario_nombre = txtnombres.Text.Trim();
                        Ent.usuario_apellido = txtapellidos.Text.Trim();
                        Ent.usuario_email = txtemail.Text.Trim();
                        Ent.usuario_clave = txtclave.Text.Trim();
                        Ent.usuario_dni = txtdni.Text.Trim();
                        Ent.usuario_celular =txtcelular.Text.Trim();
                        Ent.perfil_id =Convert.ToInt32(cboperfil.SelectedValue.ToString());



                    if (Es_Nuevo == true)
                        {
                            if (Log.Insertar(Ent))
                            {
                                Accion.ExitoGuardar();
                    
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

        public List<Ent_Usuario> Lista_Modificar = new List<Ent_Usuario>();
        public void ListarModificar()
        {
            Ent_Usuario Ent = new Ent_Usuario();
            Log_usuario log = new Log_usuario();

            //Estado = Estados.Ninguno;

            Ent.usuario_id = id;

            //Ent.Id_Periodo = Id_Periodo;
            //Ent.Id_Libro = Id_Libro;
            //Ent.Id_Voucher = Voucher;
            try
            {
                Lista_Modificar = log.Listar(Ent);
                if (Lista_Modificar.Count > 0)
                {
                    Ent_Usuario Enti = new Ent_Usuario();
                    Enti = Lista_Modificar[0];


                    id = Enti.usuario_id;

                txtnombres.Text  = Enti.usuario_nombre ;
                txtapellidos.Text    = Enti.usuario_apellido;
                txtemail.Text     = Enti.usuario_email ;
                txtclave.Text     = Enti.usuario_clave;
                txtdni.Text   = Enti.usuario_dni;
                txtcelular.Text  = Enti.usuario_celular ;
                cboperfil.SelectedValue = Enti.perfil_id;

                }
            }catch(Exception ex)
            {
                Accion.ErrorSistema(ex.Message);
            }
        }





    }
}