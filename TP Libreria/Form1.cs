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
        public BE.Usuario usuarioLogueado;
        public Form1(BE.Usuario usuario)
        {
            InitializeComponent();
            this.usuarioLogueado = usuario;
            if (usuarioLogueado.Rol == 1)
            {

            }
            else if (usuarioLogueado.Rol == 2)
            {
                generoToolStripMenuItem.Visible = false;
            }
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
            ABMCliente ventanaCliente = new ABMCliente(usuarioLogueado.Rol);
            ventanaCliente.MdiParent = this;
            ventanaCliente.Show();
        }

        private void libroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMLibro ventanaLibro = new ABMLibro(usuarioLogueado.Rol);
            ventanaLibro.MdiParent = this;
            ventanaLibro.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMUsuario ventanaUsuario = new ABMUsuario(usuarioLogueado.Rol);
            ventanaUsuario.MdiParent = this;
            ventanaUsuario.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Venta ventanaVenta= new Venta(usuarioLogueado);
            ventanaVenta.MdiParent = this;
            ventanaVenta.Show();
        }
    }
}
