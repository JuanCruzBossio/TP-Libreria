using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
namespace DAL
{
    public class Acceso
    {
        SqlConnection coneccion = new SqlConnection(@"Data Source=.;Initial Catalog=TP Libreria;Integrated Security=True");

        public void abrir()
        {
            coneccion.Open();
        }

        public void cerrar()
        {
            coneccion.Close();
        }

        public DataTable leer(string procedimiento, SqlParameter[] parametros)
        {
            DataTable tabla = new DataTable();
            abrir();
            SqlTransaction transaccion = coneccion.BeginTransaction();
            try
            {
                SqlCommand comando = new SqlCommand(procedimiento, coneccion);
                comando.Transaction = transaccion;
                comando.CommandType = CommandType.StoredProcedure;
                if (parametros != null && parametros.Length > 0)
                {
                    foreach (SqlParameter param in parametros)
                    {
                        comando.Parameters.Add(param);
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(tabla);
                transaccion.Commit();
            }
            catch (Exception)
            {
                transaccion.Rollback();
                throw;
            }
            finally
            {
                cerrar();
            }
            return tabla;
        }
        public int escribir(string procedimiento, SqlParameter[] parametros)
        {
            int filasAfectadas = 0;
            abrir();
            SqlTransaction transaccion = coneccion.BeginTransaction();
            try
            {
                SqlCommand comando = new SqlCommand(procedimiento, coneccion);
                comando.Transaction = transaccion;
                comando.CommandType = CommandType.StoredProcedure;
                if (parametros != null && parametros.Length > 0)
                {
                    foreach (SqlParameter param in parametros)
                    {
                        comando.Parameters.Add(param);
                    }
                }
                filasAfectadas = comando.ExecuteNonQuery();
                transaccion.Commit();
            }
            catch (Exception)
            {
                transaccion.Rollback();
                throw;
            }
            finally
            {
                cerrar();
            }
            return filasAfectadas;
        }
        public void escribirXML<T>(string nombre,List<T> lista,string path)
        {
            DataTable tabla = new DataTable(nombre);
            DataSet dataSet = new DataSet(nombre);
            foreach (PropertyInfo prop in typeof(T).GetProperties())
            {
                Type colType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
                tabla.Columns.Add(prop.Name, colType);
            }
            foreach (T item in lista)
            {
                DataRow row = tabla.NewRow();

                foreach (PropertyInfo prop in typeof(T).GetProperties())
                {
                    object valor = prop.GetValue(item) ?? DBNull.Value;
                    row[prop.Name] = valor;
                }

                tabla.Rows.Add(row);
            }
            dataSet.Tables.Add(tabla);
            dataSet.WriteXml(path);
        }
    }
}
