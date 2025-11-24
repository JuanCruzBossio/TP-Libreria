using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Genero
    {
        public Genero(int idGenero, string descripcion) {
			IdGenero = idGenero;
			Descripcion = descripcion;
		}

		private int idGenero;

		public int IdGenero
		{
			get { return idGenero; }
			set { idGenero = value; }
		}
		private string descripcion;

		public string Descripcion
        {
			get { return descripcion; }
			set { descripcion = value; }
		}
		public override string  ToString()
		{
			return Descripcion;
		}
	}
}
