using BE;
using DAL;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class VentaBLL : IBLL<Venta>
    {
        public IDAL<Venta> DAL { get; set; }
        public DetalleVentaBLL DetalleBLL { get; set; }

        public VentaBLL()
        {
            DAL = new VentaDAL();
            DetalleBLL = new DetalleVentaBLL();
        }

        // Alta de venta con sus detalles
        public int Alta(Venta entidad)
        {
            // Alta de la venta
            int IdVenta = DAL.Alta(entidad);

            // Si la venta se creó correctamente, dar de alta los detalles y bajar el stock
            if (IdVenta > 0 && entidad.DetallesVenta != null)
            {
                LibroBLL libroBLL = new LibroBLL();
                foreach (DetalleVenta detalle in entidad.DetallesVenta)
                {
                    DetalleBLL.Alta(IdVenta, detalle);
                    BE.Libro libro = detalle.Libro;
                    libro.Stock -= detalle.Cantidad;
                    libroBLL.Modificacion(libro);
                }
            }

            return IdVenta;
        }

        // Baja
        public int Baja(int id)
        {
            return DAL.Baja(id);
        }

        // Modificación
        public int Modificacion(Venta entidad)
        {
            return DAL.Modificacion(entidad);
        }

        // Listado
        public List<Venta> Listado()
        {
            List<Venta> ventas = DAL.Listado();

            foreach (Venta venta in ventas)
            {
                venta.DetallesVenta = DetalleBLL.ListarPorVenta(venta.IdVenta);
            }

            return ventas;
        }
    }
}
