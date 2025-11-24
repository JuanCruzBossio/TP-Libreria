using BE;
using DAL;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class CuponBLL
    {
        public CuponDAL DAL { get; set; }

        public CuponBLL()
        {
            DAL = new CuponDAL();
        }

        public int Alta(Cupon entidad)
        {
            return DAL.Alta(entidad);
        }

        public int Baja(int id)
        {
            return DAL.Baja(id);
        }

        public int Modificacion(Cupon entidad)
        {
            return DAL.Modificacion(entidad);
        }

        public List<Cupon> Listado()
        {
            return DAL.Listado();
        }

        public Cupon Validar(string codigo, int idCliente)
        {
            return DAL.Validar(codigo, idCliente);
        }
    }
}
