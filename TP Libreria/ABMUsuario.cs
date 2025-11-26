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
    public partial class ABMUsuario : Form
    {
        public int rolLogueado;
        public ABMUsuario(int rol)
        {
            InitializeComponent();
            rolLogueado = rol;
        }
        public BLL.UsuarioBLL usuarioBll = new BLL.UsuarioBLL();
        public BE.Usuario usuarioBE = new BE.Usuario(0, "", "", 0,0);
        int rolID = 0;
        private void ABMUsuario_Load(object sender, EventArgs e)
        {
            if (rolLogueado == 1)
            {
                //Es admin tiene todos los permisos
            }
            else
            {
                //Es vendedor, no puede Utilizar ABM, solo mirar
                buttonAlta.Enabled = false;
                buttonBaja.Enabled = false;
                buttonModificacion.Enabled = false;
                comboBox1.Enabled = true;
            }
            dataGridView1.DataSource = usuarioBll.Listado();
            dataGridView1.Columns["HashedPassword"].Visible = false;
        }
        private void CargarDatosCampos()
        {
            controlNumerico1.Numero = usuarioBE.IdUsuario;
            controlTexto1.Texto = usuarioBE.Nombre;
            controlPasswor1.Password = usuarioBE.HashedPassword = null;
            if(usuarioBE.Rol == 1)
            {
                comboBox1.Text = "Admin";
            }
            else
            {
                comboBox1.Text = "Vendedor";
            }
            controlNumerico2.Numero = usuarioBE.IntentosRestantes;
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
            }

            return ok;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                usuarioBE = (BE.Usuario)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                CargarDatosCampos();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al seleccionar Usuario");
                throw;
            }
        }

        private void buttonAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validateControllers()) return;


                BE.Usuario usuario = new BE.Usuario(
                    int.Parse(controlNumerico1.Numero.ToString()),
                    controlTexto1.Texto,
                    controlPasswor1.Password,
                    rol(),
                    int.Parse(controlNumerico2.Numero.ToString())
                );

                int res = usuarioBll.Alta(usuario);
                if (res != 1)
                    MessageBox.Show("Error al dar de alta el usuario");
                else
                {
                    MessageBox.Show("Usuario dado de alta correctamente");
                    dataGridView1.DataSource = usuarioBll.Listado();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al dar de alta el usuario: " + ex.Message);
            }
        }

        private void buttonBaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validateControllers()) return;

                int idUsuario = int.Parse(controlNumerico1.Numero.ToString());
                int res = usuarioBll.Baja(idUsuario);

                if (res != 1)
                    MessageBox.Show("Error al dar de baja el usuario");
                else
                {
                    MessageBox.Show("Usuario dado de baja correctamente");
                    dataGridView1.DataSource = usuarioBll.Listado();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al dar de baja el usuario: " + ex.Message);
            }
        }

        private void buttonModificacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validateControllers()) return;

                BE.Usuario usuario = new BE.Usuario(
                    int.Parse(controlNumerico1.Numero.ToString()),
                    controlTexto1.Texto,
                    controlPasswor1.Password,
                    rol(),
                    int.Parse(controlNumerico2.Numero.ToString())
                );

                int res = usuarioBll.Modificacion(usuario);
                if (res != 1)
                    MessageBox.Show("Error al modificar el usuario");
                else
                {
                    MessageBox.Show("Usuario modificado correctamente");
                    dataGridView1.DataSource = usuarioBll.Listado();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el usuario: " + ex.Message);
            }
        }

        private void controlTexto2_Load(object sender, EventArgs e)
        {

        }

        private void controlPasswor1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public int rol()
        {
            if(comboBox1.Text == "Admin")
            {
                return 1;
            }else if(comboBox1.Text == "Vendedor")
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }

    }
}
