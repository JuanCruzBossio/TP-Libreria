using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClienteBLL : IBLL<BE.Cliente>
    {
        public IDAL<Cliente> DAL { get; set; }

        public ClienteBLL()
        {
            DAL = new ClienteDAL();
        }

        public int Alta(Cliente entidad)
        {
            return DAL.Alta(entidad);
        }

        public int Baja(int id)
        {
            return DAL.Baja(id);
        }

        public List<Cliente> Listado()
        {
            return DAL.Listado();
        }

        public int Modificacion(Cliente entidad)
        {
            return DAL.Modificacion(entidad);
        }
    }

}
