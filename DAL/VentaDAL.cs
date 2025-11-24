using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class VentaDAL : IDAL<Venta>
    {
        private Acceso acceso = new Acceso();

        // ALTA
        public int Alta(Venta entidad)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Fecha", entidad.Fecha),
                new SqlParameter("@IdCliente", entidad.Cliente.IdCliente),
                new SqlParameter("@IdVendedor", entidad.Vendedor.IdUsuario)
            };

            // Ejecutar y leer el Id generado
            DataTable tabla = acceso.leer("AltaVenta", parametros);
            if (tabla.Rows.Count > 0)
            {
                return int.Parse(tabla.Rows[0]["IdVenta"].ToString());
            }

            return 0;
        }


        // BAJA
        public int Baja(int id)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@IdVenta", id)
            };

            return acceso.escribir("BajaVenta", parametros);
        }

        // MODIFICACIÓN
        public int Modificacion(Venta entidad)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@IdVenta", entidad.IdVenta),
                new SqlParameter("@Fecha", entidad.Fecha),
                new SqlParameter("@IdCliente", entidad.Cliente.IdCliente),
                new SqlParameter("@IdVendedor", entidad.Vendedor.IdUsuario)
            };

            return acceso.escribir("ModificarVenta", parametros);
        }

        // LISTADO
        public List<Venta> Listado()
        {
            DataTable tabla = acceso.leer("ListarVenta", null);
            List<Venta> lista = new List<Venta>();

            foreach (DataRow fila in tabla.Rows)
            {
                // MAPEO DE CLIENTE COMPLETO
                Cliente cliente = new Cliente(
                    idCliente: int.Parse(fila["IdCliente"].ToString()),
                    nombre: fila["ClienteNombre"].ToString(),
                    genero: fila["ClienteGenero"].ToString(),
                    edad: int.Parse(fila["ClienteEdad"].ToString())
                );

                // MAPEO DE USUARIO (VENDEDOR)
                Usuario vendedor = new Usuario(
                    idUsuario: int.Parse(fila["IdUsuario"].ToString()),
                    nombre: fila["VendedorNombre"].ToString(),
                    null,
                    2
                );

                // CREACIÓN DE VENTA
                lista.Add(new Venta(
                    idVenta: int.Parse(fila["IdVenta"].ToString()),
                    fecha: DateTime.Parse(fila["Fecha"].ToString()),
                    _cliente: cliente,
                    usuario: vendedor,
                    detallesVenta: new List<DetalleVenta>()
                ));
            }

            return lista;
        }
    }
}
