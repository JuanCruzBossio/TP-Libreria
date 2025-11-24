using BE;
using DAL;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class DetalleVentaBLL
    {
        public DetalleVentaDAL DAL { get; set; }

        public DetalleVentaBLL()
        {
            DAL = new DetalleVentaDAL();
        }

        
        public int Alta(int idVenta, DetalleVenta detalle)
        {
            return DAL.Alta(idVenta, detalle);
        }

        public List<DetalleVenta> ListarPorVenta(int idVenta)
        {
            return DAL.ListarPorVenta(idVenta);
        }
    }
}
