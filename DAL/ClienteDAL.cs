using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ClienteDAL : IDAL<Cliente>
    {
        private Acceso acceso = new Acceso();

        // Alta
        public int Alta(Cliente entidad)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Nombre", entidad.Nombre),
                new SqlParameter("@Genero", entidad.Genero),
                new SqlParameter("@Edad", entidad.Edad)
            };

            return acceso.escribir("AltaCliente", parametros);
        }

        // Baja
        public int Baja(int id)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@IdCliente", id)
            };

            return acceso.escribir("BajaCliente", parametros);
        }

        // Modificacion
        public int Modificacion(Cliente entidad)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@IdCliente", entidad.IdCliente),
                new SqlParameter("@Nombre", entidad.Nombre),
                new SqlParameter("@Genero", entidad.Genero),
                new SqlParameter("@Edad", entidad.Edad)
            };

            return acceso.escribir("ModificacionCliente", parametros);
        }

        // Listado
        public List<Cliente> Listado()
        {
            DataTable tabla = acceso.leer("ListarCliente", null);
            List<Cliente> lista = new List<Cliente>();

            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(new Cliente(
                    idCliente: int.Parse(fila["IdCliente"].ToString()),
                    nombre: fila["Nombre"].ToString(),
                    genero: fila["Genero"].ToString(),
                    edad: int.Parse(fila["Edad"].ToString())
                ));
            }

            return lista;
        }
    }
}
