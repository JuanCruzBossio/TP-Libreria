using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Libro
    {
		public Libro() { }
        public Libro( int idLibro, string titulo, string autor, Genero genero, float precio, int stock) {
			IdLibro = idLibro;
			Titulo = titulo;
			Autor = autor;
			Genero = genero;
			Precio = precio;
			Stock = stock;
		}

		private int idLibro;

		public int IdLibro
		{
			get { return idLibro; }
			set { idLibro = value; }
		}
		private string titulo;

		public string Titulo
		{
			get { return titulo; }
			set { titulo = value; }
		}

		private string autor;

		public string Autor
		{
			get { return autor; }
			set { autor = value; }
		}

		private Genero genero;

		public Genero Genero
		{
			get { return genero; }
			set { genero = value; }
		}

		private float precio;

		public float Precio
        {
			get { return precio; }
			set { precio = value; }
		}

		private int stock;

		public int Stock
        {
			get { return stock; }
			set { stock = value; }
		}
        public override string ToString()
        {
            return Titulo;
        }

    }
    public class ReporteLibro
    {
        public float Cantidad { get; set; }
        public Libro libro { get; set; }
    }
}
