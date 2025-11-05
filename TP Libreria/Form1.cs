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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void generoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMGenero ventanaGenero = new ABMGenero();
            ventanaGenero.MdiParent = this;
            ventanaGenero.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMCliente ventanaCliente = new ABMCliente();
            ventanaCliente.MdiParent = this;
            ventanaCliente.Show();
        }

        private void libroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMLibro ventanaLibro = new ABMLibro();
            ventanaLibro.MdiParent = this;
            ventanaLibro.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMUsuario ventanaUsuario = new ABMUsuario();
            ventanaUsuario.MdiParent = this;
            ventanaUsuario.Show();
        }
    }
}
