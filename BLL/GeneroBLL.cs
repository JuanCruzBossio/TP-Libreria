using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GeneroBLL : IBLL<BE.Genero>
    {
        public  GeneroDAL DAL { get; set; }

        public GeneroBLL()
        {
            DAL = new GeneroDAL();
        }

        public int Alta(Genero entidad)
        {
            return DAL.Alta(entidad);
        }

        public int Baja(int id)
        {
            return DAL.Baja(id);
        }

        public List<Genero> Listado()
        {
            return DAL.Listado();
        }

        public int Modificacion(Genero entidad)
        {
            return DAL.Modificacion(entidad);
        }
        public void GuardarXML(string nombre, List<ReporteGenero> lista, string path)
        {
            DAL.escribirXML(nombre, lista, path);
        }
    }
}
