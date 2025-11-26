using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LibroBLL : IBLL<BE.Libro>
    {
        public LibroDAL DAL { get; set; }

        public LibroBLL()
        {
            DAL = new LibroDAL();
        }

        public int Alta(Libro entidad)
        {
            return DAL.Alta(entidad);
        }

        public int Baja(int id)
        {
            return DAL.Baja(id);
        }

        public List<Libro> Listado()
        {
            return DAL.Listado();
        }

        public int Modificacion(Libro entidad)
        {
            return DAL.Modificacion(entidad);
        }
        public void GuardarXML(string nombre, List<ReporteLibro> lista, string path)
        {
            DAL.escribirXML(nombre, lista, path);
        }
    }

}
