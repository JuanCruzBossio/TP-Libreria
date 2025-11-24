using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DetalleVentaDAL
    {
        private Acceso acceso = new Acceso();

        // ALTA
        public int Alta(int idVenta, DetalleVenta detalle)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@IdVenta", idVenta),
                new SqlParameter("@IdLibro", detalle.Libro.IdLibro),
                new SqlParameter("@Cantidad", detalle.Cantidad),
                new SqlParameter("@PrecioUnitario", detalle.PrecioUnitario)
            };

            return acceso.escribir("AltaDetalleVenta", parametros);
        }

        // LISTADO
        public List<DetalleVenta> ListarPorVenta(int idVenta)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@IdVenta", idVenta)
            };

            DataTable tabla = acceso.leer("ListarDetalleVenta", parametros);
            List<DetalleVenta> lista = new List<DetalleVenta>();

            foreach (DataRow fila in tabla.Rows)
            {
                // MAPEAR GENERO
                Genero genero = new Genero(
                    idGenero: int.Parse(fila["IdGenero"].ToString()),
                    descripcion: fila["GeneroDescripcion"].ToString()
                );

                // MAPEAR LIBRO
                Libro libro = new Libro(
                    idLibro: int.Parse(fila["IdLibro"].ToString()),
                    titulo: fila["Titulo"].ToString(),
                    autor: fila["Autor"].ToString(),
                    genero: genero,
                    precio: float.Parse(fila["PrecioLibro"].ToString()),
                    stock: int.Parse(fila["Stock"].ToString())
                );

                // CREAR DETALLE
                lista.Add(new DetalleVenta(
                    libro: libro,
                    cantidad: int.Parse(fila["Cantidad"].ToString()),
                    precioUnitario: float.Parse(fila["PrecioUnitario"].ToString())
                ));
            }

            return lista;
        }
    }
}
