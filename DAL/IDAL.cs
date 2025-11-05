using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public interface IDAL<T>
    {
        int Alta(T entidad);
        int Baja(int id);
        int Modificacion(T entidad);
        List<T> Listado();
    }
}
