using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace BE
{
    public class Venta
    {
        public Venta(int idVenta, DateTime fecha, Cliente _cliente, Usuario usuario, List<DetalleVenta> detallesVenta, Cupon cupon = null)
        {
            IdVenta = idVenta;
            Fecha = fecha;
            Cliente = _cliente;
            Vendedor = usuario;
            DetallesVenta = detallesVenta ?? new List<DetalleVenta>();
        }
        private int idVenta;

        public int IdVenta
        {
            get { return idVenta; }
            set { idVenta = value; }
        }

        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private Cliente cliente;

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        private Usuario vendedor;

        public Usuario Vendedor
        {
            get { return vendedor; }
            set { vendedor = value; }
        }
        private List<DetalleVenta> detallesVenta;

        public List<DetalleVenta> DetallesVenta
        {
            get { return detallesVenta; }
            set { detallesVenta = value; }
        }

        private Cupon cupon;

        public Cupon Cupon
        {
            get { return cupon; }
            set { cupon = value; }
        }



        public float MontoTotal()
        {
            float total = 0;
            foreach (DetalleVenta detalle in DetallesVenta)
            {
                total += detalle.total();
            }
            if (Cupon != null)
            {
                if(Cupon.Valor < total)
                {
                    total -= Cupon.Valor;
                }
                else
                {
                    total = 0;
                }
            }
            return total;
        }
    }
    public class DetalleVenta
    {
        public DetalleVenta(Libro libro, int cantidad, float precioUnitario) { 
            Libro = libro;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
        }
        private Libro libro;

        public Libro Libro
        {
            get { return libro; }
            set { libro = value; }
        }
        private int cantidad = 0;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        private float precioUnitario = 0;

        public float PrecioUnitario
        {
            get { return precioUnitario; }
            set { precioUnitario = value; }
        }
        public float total()
        {
            return PrecioUnitario * Cantidad;
        }
    }
}
