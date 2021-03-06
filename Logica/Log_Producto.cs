﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedsk
{
   public class Log_Producto
    {
        private Dat_Producto CapaDato = new Dat_Producto();


        public bool Insertar(Ent_Producto Cls_Enti)
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


        public bool Modificar(Ent_Producto Cls_Enti)
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

        public List<Ent_Producto> Listar(Ent_Producto Cls_Enti)
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

        public List<Ent_Producto> ListarPorCodigo(Ent_Producto Cls_Enti)
        {
            try
            {
                return CapaDato.ListarPorCodigo(Cls_Enti);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
