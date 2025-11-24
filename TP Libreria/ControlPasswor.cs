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
    public partial class ControlPasswor : UserControl
    {
        public ControlPasswor()
        {
            InitializeComponent();
        }

        private string password;
        private bool mostrarPassword = false;

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                textBox1.Text = value;
            }
        }

        public bool MostrarPassword
        {
            get { return mostrarPassword; }
            set
            {
                mostrarPassword = value;
                textBox1.UseSystemPasswordChar = !value;
            }
        }
        private bool permitirEditar = true;

        public bool PermitirEditar
        {
            get { return permitirEditar; }
            set { permitirEditar = value; }
        }
        private void ControlPasswor_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = PermitirEditar;
            textBox1.UseSystemPasswordChar = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            password = textBox1.Text;
        }

        private void checkBoxMostrar_CheckedChanged(object sender, EventArgs e)
        {
            MostrarPassword = checkBoxMostrar.Checked;
        }
    }
}
