using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Libreria
{
    public partial class ABMGenero : Form
    {
        public ABMGenero()
        {
            InitializeComponent();
        }
        public BLL.GeneroBLL generoBll = new BLL.GeneroBLL();
        public BE.Genero generoBE = new BE.Genero(0, "");
        private void ABMGenero_Load(object sender, EventArgs e)
        {
            controlNumerico1.Titulo = "Id Genero:";
            controlNumerico1.Numero = generoBE.IdGenero;
            controlTexto1.Titulo = "Descripcion:";
            controlTexto1.Texto = generoBE.Descripcion;
            dataGridView1.DataSource = generoBll.Listado();
        }

        private void controlNumerico1_Load(object sender, EventArgs e)
        {
        }
        private void CargarDatosCampos()
        {
            controlTexto1.Texto = generoBE.Descripcion;
            controlNumerico1.Numero = generoBE.IdGenero;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                generoBE = (BE.Genero)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                CargarDatosCampos();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al seleccionar Genero");
                throw;
            }
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
                MessageBox.Show("Formato de datos Incorrectos");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void buttonAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validateControllers()) { 
                    return;
                }
                
                BE.Genero genero = new BE.Genero(int.Parse(controlNumerico1.Numero.ToString()), controlTexto1.Texto);
                int res = generoBll.Alta(genero);
                if (res != 1) {
                    MessageBox.Show("Error al dar de Alta");
                }
                else
                {
                    MessageBox.Show("Genero dado de Alta Correctamente");
                    dataGridView1.DataSource = generoBll.Listado();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al dar de Alta");
                throw;
            }
        }

        private void buttonBaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validateControllers())
                {
                    return;
                }

                BE.Genero genero = new BE.Genero(int.Parse(controlNumerico1.Numero.ToString()), controlTexto1.Texto);
                int res = generoBll.Baja(genero.IdGenero);
                if (res != 1)
                {
                    MessageBox.Show("Error en la Baja de Genero");
                }
                else
                {
                    MessageBox.Show("Genero dado de Baja Correctamente");
                    dataGridView1.DataSource = generoBll.Listado();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error en  la Baja de Genero");
                throw;
            }
        }

        private void buttonModificacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validateControllers())
                {
                    return;
                }

                BE.Genero genero = new BE.Genero(int.Parse(controlNumerico1.Numero.ToString()), controlTexto1.Texto);
                int res = generoBll.Modificacion(genero);
                if (res != 1)
                {
                    MessageBox.Show("Error en la Modificacion de Genero");
                }
                else
                {
                    MessageBox.Show("Genero Modificado Correctamente");
                    dataGridView1.DataSource = generoBll.Listado();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la Modificacion de Genero");
                throw;
            }
        }
    }
}
