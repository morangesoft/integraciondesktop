using interfacedsk.alertas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedsk
{
public    class Accion
    {
        public static string Formato(string Id, Int32 Tamanio)
        {
            if (Id.Length < Tamanio)
            {
                for (int i = Id.Length; i <= Tamanio - 1; i++)
                {
                    Id = "0" + Id;
                }
            }
            return Id;
        }

        public static void ExitoGuardar()
        {
            using (frm_exito_guardar f = new frm_exito_guardar())
            {
                //fLblMensaje.Text = "Grabado correctamente en la Base de Datos";*/
                f.ShowDialog();
            }
        }

        public static void ExitoModificar()
        {
            using (frm_exito_modificar f = new frm_exito_modificar())
            {
                //fLblMensaje.Text = "Grabado correctamente en la Base de Datos";*/
                f.ShowDialog();
            }
        }
        public static void ErrorSistema(String text)
        {
            using (frm_error_sistema f = new frm_error_sistema())
            {
                f.lblmensaje.Text = text;
                f.ShowDialog();
            }
        }
        public static void Advertencia(String text)
        {
            using (frm_advertencia f = new frm_advertencia())
            {
                f.lblmensaje.Text = text;
                f.ShowDialog();
            }
        }


    }
}
