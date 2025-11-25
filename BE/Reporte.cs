using System;
using System.Collections.Generic;

namespace BE
{
    public class ReporteVentasGenerales
    {
        public string NombreReporte { get; set; }     
        public DateTime FechaGeneracion { get; set; }  
        public List<Venta> Ventas { get; set; }       

        public ReporteVentasGenerales()
        {
            Ventas = new List<Venta>();
            FechaGeneracion = DateTime.Now;
            NombreReporte = "Reporte de Ventas Generales";
        }


        public float MontoTotal
        {
            get
            {
                float total = 0;
                foreach (var venta in Ventas)
                    total += venta.MontoTotal; 
                return total;
            }
        }

        public int CantidadVentas => Ventas.Count;
    }
}
