using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class CuponDAL
    {
        private Acceso acceso = new Acceso();

        // Alta
        public int Alta(Cupon entidad)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Codigo", entidad.Codigo),
                new SqlParameter("@Valor", entidad.Valor),
                new SqlParameter("@Activo", entidad.Activo)
            };
            return  acceso.escribir("AltaCupon", parametros);
        }

        // Baja
        public int Baja(int id)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@IdCupon", id)
            };

            return acceso.escribir("BajaCupon", parametros);
        }

        // Modificación
        public int Modificacion(Cupon entidad)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@IdCupon", entidad.IdCupon),
                new SqlParameter("@Codigo", entidad.Codigo),
                new SqlParameter("@Valor", entidad.Valor),
                new SqlParameter("@Activo", entidad.Activo)
            };

            return acceso.escribir("ModificacionCupon", parametros);
        }

        // Listado
        public List<Cupon> Listado()
        {
            DataTable tabla = acceso.leer("ListarCupon", null);
            List<Cupon> lista = new List<Cupon>();

            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(new Cupon
                {
                    IdCupon = int.Parse(fila["IdCupon"].ToString()),
                    Codigo = fila["Codigo"].ToString(),
                    Valor = float.Parse(fila["Valor"].ToString()),
                    Activo = (bool)fila["Activo"]
                });
            }

            return lista;
        }

        // Validar cupón por Código
        public Cupon Validar(string codigo)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Codigo", codigo)
            };

            DataTable tabla = acceso.leer("ValidarCupon", parametros);

            if (tabla != null && tabla.Rows.Count > 0)
            {
                DataRow fila = tabla.Rows[0];
                return new Cupon
                {
                    IdCupon = int.Parse(fila["IdCupon"].ToString()),
                    Codigo = fila["Codigo"].ToString(),
                    Valor = float.Parse(fila["Valor"].ToString()),
                    Activo = (bool)fila["Activo"]
                };
            }

            return null; // No existe o no activo
        }

    }
}
