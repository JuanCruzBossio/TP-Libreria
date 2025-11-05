using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class UsuarioDAL : IDAL<Usuario>
    {
        private Acceso acceso = new Acceso();

        // Alta
        public int Alta(Usuario entidad)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Nombre", entidad.Nombre),
                new SqlParameter("@HashedPassword", entidad.HashedPassword),
                new SqlParameter("@Rol", entidad.Rol)
            };

            return acceso.escribir("AltaUsuario", parametros);
        }

        // Baja
        public int Baja(int id)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@IdUsuario", id)
            };

            return acceso.escribir("BajaUsuario", parametros);
        }

        // Modificacion
        public int Modificacion(Usuario entidad)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@IdUsuario", entidad.IdUsuario),
                new SqlParameter("@Nombre", entidad.Nombre),
                new SqlParameter("@HashedPassword", entidad.HashedPassword),
                new SqlParameter("@Rol", entidad.Rol)
            };

            return acceso.escribir("ModificacionUsuario", parametros);
        }

        // Listado
        public List<Usuario> Listado()
        {
            DataTable tabla = acceso.leer("ListarUsuario", null);
            List<Usuario> lista = new List<Usuario>();

            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(new Usuario(
                    idUsuario: int.Parse(fila["IdUsuario"].ToString()),
                    nombre: fila["Nombre"].ToString(),
                    hashedPassword: fila["HashedPassword"].ToString(),
                    rol: int.Parse(fila["Rol"].ToString())
                ));
            }

            return lista;
        }
    }
}
