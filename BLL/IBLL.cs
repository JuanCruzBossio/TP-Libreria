using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IBLL<T>
    {
        int Alta(T entidad);
        int Baja(int id);
        int Modificacion(T entidad);
        List<T> Listado();
    }
}
