using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedsk
{
   public class Log_Proveedor
    {

        private Dat_Proveedor CapaDato = new Dat_Proveedor();


        public bool Insertar(Ent_Proveedor Cls_Enti)
        {
            try
            {

                CapaDato.Insertar(Cls_Enti);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public bool Modificar(Ent_Proveedor Cls_Enti)
        {
            try
            {

                CapaDato.Modificar(Cls_Enti);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Ent_Proveedor> Listar(Ent_Proveedor Cls_Enti)
        {
            try
            {
                return CapaDato.Listar(Cls_Enti);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
