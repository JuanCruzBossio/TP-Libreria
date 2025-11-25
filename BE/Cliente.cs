using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
		public class Cliente
		{
        public Cliente()
        {
        }
        public Cliente(int idCliente, string nombre, string genero, int edad) {
				IdCliente = idCliente;
				Nombre = nombre;
				Genero = genero;
				Edad = edad;
			}

			private int idCliente;

			public int IdCliente
			{
				get { return idCliente; }
				set { idCliente = value; }
			}

			private string nombre;

			public string Nombre
			{
				get { return nombre; }
				set { nombre = value; }
			}
			private string genero;

			public string Genero
			{
				get { return genero; }
				set { genero = value; }
			}
			private int edad;

			public int Edad
			{
				get { return edad; }
				set { edad = value; }
			}
			public override string ToString()
			{
				return Nombre;
			}
    }
}
