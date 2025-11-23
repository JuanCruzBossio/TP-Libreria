using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsuarioBLL : IBLL<BE.Usuario>
    {
        public UsuarioDAL DAL = new UsuarioDAL();

        public UsuarioBLL()
        {
            DAL = new UsuarioDAL();
        }

        public int Alta(Usuario entidad)
        {
            return DAL.Alta(entidad);
        }

        public int Baja(int id)
        {
            return DAL.Baja(id);
        }

        public List<Usuario> Listado()
        {
            return DAL.Listado();
        }

        public int Modificacion(Usuario entidad)
        {
            return DAL.Modificacion(entidad);
        }
        public Usuario Login(Usuario user)
        {
            return DAL.Login(user);
        }
    }

}
