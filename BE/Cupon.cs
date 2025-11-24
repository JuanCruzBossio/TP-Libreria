using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cupon
    {
        public int IdCupon { get; set; }
        public string Codigo { get; set; }
        public float Valor { get; set; } 
        public bool Activo { get; set; }
    }

}
