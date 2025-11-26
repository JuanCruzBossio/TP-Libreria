using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class LibroDAL : IDAL<Libro>
    {
        private Acceso acceso = new Acceso();

        // Alta
        public int Alta(Libro entidad)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Titulo", entidad.Titulo),
                new SqlParameter("@Autor", entidad.Autor),
                new SqlParameter("@IdGenero", entidad.Genero.IdGenero),
                new SqlParameter("@Precio", entidad.Precio),
                new SqlParameter("@Stock", entidad.Stock)
            };

            return acceso.escribir("AltaLibro", parametros);
        }

        // Baja
        public int Baja(int id)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@IdLibro", id)
            };

            return acceso.escribir("BajaLibro", parametros);
        }

        // Modificacion
        public int Modificacion(Libro entidad)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@IdLibro", entidad.IdLibro),
                new SqlParameter("@Titulo", entidad.Titulo),
                new SqlParameter("@Autor", entidad.Autor),
                new SqlParameter("@IdGenero", entidad.Genero.IdGenero),
                new SqlParameter("@Precio", entidad.Precio),
                new SqlParameter("@Stock", entidad.Stock)
            };

            return acceso.escribir("ModificacionLibro", parametros);
        }

        // Listado
        public List<Libro> Listado()
        {
            DataTable tabla = acceso.leer("ListarLibro", null);
            List<Libro> lista = new List<Libro>();

            foreach (DataRow fila in tabla.Rows)
            {
                Genero genero = new Genero(
                    idGenero: int.Parse(fila["IdGenero"].ToString()),
                    descripcion: fila["GeneroDescripcion"].ToString()
                );

                lista.Add(new Libro(
                    idLibro: int.Parse(fila["IdLibro"].ToString()),
                    titulo: fila["Titulo"].ToString(),
                    autor: fila["Autor"].ToString(),
                    genero: genero,
                    precio: float.Parse(fila["Precio"].ToString()),
                    stock: int.Parse(fila["Stock"].ToString())
                ));
            }

            return lista;
        }
        public void escribirXML(string nombre, List<ReporteLibro> lista, string path)
        {
            acceso.escribirXML(nombre, lista, path);
        }

    }
}
