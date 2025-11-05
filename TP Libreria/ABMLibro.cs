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

namespace TP_Libreria
{
    public partial class ABMLibro : Form
    {
        public ABMLibro()
        {
            InitializeComponent();
        }
        public BLL.LibroBLL libroBll = new BLL.LibroBLL();
        public BE.Libro libroBE = new BE.Libro(0, "", "", new BE.Genero(0, ""), 0, 0);
        public BLL.GeneroBLL generoBll = new BLL.GeneroBLL();
        private void ABMLibro_Load(object sender, EventArgs e)
        {
            controlSelector1.CargarLista<BE.Genero>(generoBll.Listado());
            controlSelector1.ConfigurarDisplayMember("descripcion");
            dataGridView1.DataSource = libroBll.Listado();
        }
        private void CargarDatosCampos()
        {
            controlNumerico1.Numero = libroBE.IdLibro;
            controlTexto1.Texto = libroBE.Titulo;
            controlTexto2.Texto = libroBE.Autor;
            controlNumerico2.Numero = (float)libroBE.Precio;
            controlNumerico3.Numero = libroBE.Stock;
            controlSelector1.CargarSeleccionado(libroBE.Genero, "IdGenero");
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
                }else if (control is ControlSelector cs)
                {
                    ok = cs.Validar() && ok;
                }
            }
            if (!ok)
            {
                MessageBox.Show("Formato de datos incorrectos");
                return false;
            }
            return true;
        }

        private void buttonAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validateControllers()) return;

                BE.Libro libro = new BE.Libro(
                int.Parse(controlNumerico1.Numero.ToString()),
                controlTexto1.Texto,
                controlTexto2.Texto,
                (BE.Genero)controlSelector1.Seleccionado,
                float.Parse(controlNumerico2.Numero.ToString()),
                int.Parse(controlNumerico3.Numero.ToString())
                );

                int res = libroBll.Alta(libro);

                if (res != 1)
                    MessageBox.Show("Error al dar de alta el libro");
                else
                {
                    MessageBox.Show("Libro dado de alta correctamente");
                    dataGridView1.DataSource = libroBll.Listado();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al dar de alta el libro: " + ex.Message);
            }
        }

        private void buttonBaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validateControllers()) return;

                int idLibro = int.Parse(controlNumerico1.Numero.ToString());
                int res = libroBll.Baja(idLibro);

                if (res != 1)
                    MessageBox.Show("Error al dar de baja el libro");
                else
                {
                    MessageBox.Show("Libro dado de baja correctamente");
                    dataGridView1.DataSource = libroBll.Listado();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al dar de baja el libro: " + ex.Message);
            }
        }

        private void buttonModificacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validateControllers()) return;

                BE.Libro libro = new BE.Libro(
                    int.Parse(controlNumerico1.Numero.ToString()),
                    controlTexto1.Texto,
                    controlTexto2.Texto,
                    (BE.Genero)controlSelector1.Seleccionado,
                    float.Parse(controlNumerico2.Numero.ToString()),
                    int.Parse(controlNumerico3.Numero.ToString())
                );

                int res = libroBll.Modificacion(libro);

                if (res != 1)
                    MessageBox.Show("Error al modificar el libro");
                else
                {
                    MessageBox.Show("Libro modificado correctamente");
                    dataGridView1.DataSource = libroBll.Listado();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el libro: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                libroBE = (BE.Libro)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                CargarDatosCampos();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al seleccionar Libro");
            }
        }

        private void controlSelector1_Load(object sender, EventArgs e)
        {

        }
    }
}
