using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedsk
{
  public   class Log_Servicio
    {

        private Dat_Servicio CapaDato = new Dat_Servicio();


        public bool Insertar(Ent_Servicio Cls_Enti)
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


        public bool Modificar(Ent_Servicio Cls_Enti)
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

        public List<Ent_Servicio> Listar(Ent_Servicio Cls_Enti)
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
