using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Libreria
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public BLL.UsuarioBLL usuarioBll = new BLL.UsuarioBLL();
        public BE.Usuario usuarioBE = new BE.Usuario(0, "", "", 0);
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioBE = new BE.Usuario(0, controlTexto1.Texto, controlPasswor1.Password, 0);
                usuarioBE = usuarioBll.Login(usuarioBE);
                switch (usuarioBE.Rol)
                {
                    case 0:
                        MessageBox.Show("Error en login Usuario, Credenciales Incorrectas");
                        break;
                    default:
                        controlTexto1.Texto = "";
                        controlPasswor1.Password = "";
                        Form1 form1 = new Form1(usuarioBE);
                        form1.Show();
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error en login Usuario");
                throw;
            }

        }
    }
    
}
