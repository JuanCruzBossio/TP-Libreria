using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TP_Libreria
{
    public partial class ABMCliente : Form
    {
        public int rolLogueado;

        public ABMCliente(int rol)
        {
            InitializeComponent();
            rolLogueado = rol;
        }
        public BLL.ClienteBLL clienteBll = new BLL.ClienteBLL();
        public BE.Cliente clienteBE = new BE.Cliente(0, "", "", 0);
        private void ABMCliente_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clienteBll.Listado();
            if (rolLogueado == 1)
            {
                //Es admin tiene todos los permisos
            }
            else
            {
                //Es vendedor, no puede Utilizar BAJA
                buttonBaja.Enabled = false;
            }
        }
        private void CargarDatosCampos()
        {
            controlNumerico1.Numero = clienteBE.IdCliente;
            controlTexto1.Texto = clienteBE.Nombre;
            controlTexto2.Texto = clienteBE.Genero;
            controlNumerico2.Numero = clienteBE.Edad;
        }
        public bool validateControllers()
        {
            bool ok = true;
            foreach (Control control in this.Controls)
            {
                if (control is ControlNumerico cn)
                {
                    ok = cn.validate() && ok;
                }
                else if (control is ControlTexto ct)
                {
                    ok = ct.validate() && ok;
                }
            }
            if (!ok)
            {
                MessageBox.Show("Formato de datos incorrectos");
                return false;
            }
            return true;
        }

        private void buttonAlta_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!validateControllers()) return;

                BE.Cliente cliente = new BE.Cliente(
                    int.Parse(controlNumerico1.Numero.ToString()),
                    controlTexto1.Texto,
                    controlTexto2.Texto,
                    int.Parse(controlNumerico2.Numero.ToString())
                );

                int res = clienteBll.Alta(cliente);

                if (res != 1)
                    MessageBox.Show("Error al dar de alta el cliente");
                else
                {
                    MessageBox.Show("Cliente dado de alta correctamente");
                    dataGridView1.DataSource = clienteBll.Listado();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al dar de alta el cliente: " + ex.Message);
            }
        }

        private void buttonBaja_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!validateControllers()) return;

                int id = int.Parse(controlNumerico1.Numero.ToString());
                int res = clienteBll.Baja(id);

                if (res != 1)
                    MessageBox.Show("Error al dar de baja el cliente");
                else
                {
                    MessageBox.Show("Cliente dado de baja correctamente");
                    dataGridView1.DataSource = clienteBll.Listado();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al dar de baja el cliente: " + ex.Message);
            }
        }

        private void buttonModificacion_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!validateControllers()) return;

                BE.Cliente cliente = new BE.Cliente(
                    int.Parse(controlNumerico1.Numero.ToString()),
                    controlTexto1.Texto,
                    controlTexto2.Texto,
                    int.Parse(controlNumerico2.Numero.ToString())
                );

                int res = clienteBll.Modificacion(cliente);

                if (res != 1)
                    MessageBox.Show("Error al modificar el cliente");
                else
                {
                    MessageBox.Show("Cliente modificado correctamente");
                    dataGridView1.DataSource = clienteBll.Listado();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el cliente: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                clienteBE = (BE.Cliente)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                CargarDatosCampos();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al seleccionar Cliente");
                throw;
            }
        }
    }
}
