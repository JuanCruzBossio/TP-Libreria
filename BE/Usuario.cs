using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace BE
{
    public class Usuario
    {
        public Usuario(int idUsuario, string nombre, string hashedPassword, int rol)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            HashedPassword = hashedPassword;
            Rol = rol;
        }

        private int idUsuario;

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string hashedPassword;

        public string HashedPassword
        {
            get { return hashedPassword; }
            set { if (value != null) { hashedPassword = ComputeSha256Hash(value); } else { hashedPassword = null; } }
        }

        private int rol;

        public int Rol
        {
            get { return rol; }
            set { rol = value; }
        }
        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
