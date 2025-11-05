using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class GeneroDAL : IDAL<Genero>
    {
        private Acceso acceso = new Acceso();

        // Alta
        public int Alta(Genero entidad)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Descripcion", entidad.Descripcion)
            };

            return acceso.escribir("AltaGenero", parametros);
        }

        // Baja
        public int Baja(int id)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@IdGenero", id)
            };

            return acceso.escribir("BajaGenero", parametros);
        }

        // Modificacion
        public int Modificacion(Genero entidad)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@IdGenero", entidad.IdGenero),
                new SqlParameter("@Descripcion", entidad.Descripcion)
            };

            return acceso.escribir("ModificacionGenero", parametros);
        }

        // Listado
        public List<Genero> Listado()
        {
            DataTable tabla = acceso.leer("ListarGenero", null);
            List<Genero> lista = new List<Genero>();

            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(new Genero(
                    idGenero : int.Parse(fila["IdGenero"].ToString()),
                    descripcion : fila["Descripcion"].ToString()
                ));
            }

            return lista;
        }
    }
}
