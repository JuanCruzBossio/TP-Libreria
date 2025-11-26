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
                new SqlParameter("@Rol", entidad.Rol),
                new SqlParameter("@IntentosRestantes", entidad.IntentosRestantes)
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
                new SqlParameter("@Rol", entidad.Rol),
                new SqlParameter("@IntentosRestantes", entidad.IntentosRestantes)
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
                    rol: int.Parse(fila["Rol"].ToString()),
                    intentosRestantes: int.Parse(fila["IntentosRestantes"].ToString())
                ));
            }

            return lista;
        }
        public Usuario Login(Usuario user)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Nombre", user.Nombre),
                new SqlParameter("@HashedPassword", user.HashedPassword)
            };
            Usuario usuario = new Usuario(0, "", "", 0,0);
            DataTable tabla = acceso.leer("login", parametros);

            foreach (DataRow fila in tabla.Rows)
            {
                usuario = new Usuario(
                                    idUsuario: int.Parse(fila["IdUsuario"].ToString()),
                                    nombre: fila["Nombre"].ToString(),
                                    hashedPassword: fila["HashedPassword"].ToString(),
                                    rol: int.Parse(fila["Rol"].ToString()),
                                    intentosRestantes: int.Parse(fila["IntentosRestantes"].ToString())
                 );
            }
            return usuario;
        }
        public int IntentosRestantes(string nombre)
        {
            int intentosRestantes = 0;
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Nombre", nombre)
            };
            DataTable tabla = acceso.leer("IntentosRestantes", parametros);

            foreach (DataRow fila in tabla.Rows)
            {
                intentosRestantes = int.Parse(fila["IntentosRestantes"].ToString());
            }
            return intentosRestantes;
        }
        public int RestarIntento(string nombre)
        {
            int intentosRestantes = 0;
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Nombre", nombre)
            };
            DataTable tabla = acceso.leer("RestarIntento", parametros);

            foreach (DataRow fila in tabla.Rows)
            {
                intentosRestantes = int.Parse(fila["IntentosRestantes"].ToString());
            }
            return intentosRestantes;
        }
    }
}
