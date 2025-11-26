using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BE;
using BLL;

namespace TP_Libreria
{
    public partial class ABMCupon : Form
    {
        public int rolLogueado;

        public ABMCupon(int rol)
        {
            InitializeComponent();
            this.rolLogueado = rol;
        }

        CuponBLL cuponBLL = new CuponBLL();
        Cupon cuponBE = new Cupon();

        private void ABMCupon_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cuponBLL.Listado();
            dataGridView1.Columns["Activo"].ReadOnly = true;
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
            }
        }

        private void CargarDatosCampos()
        {
            controlNumericoIdCupon.Numero = cuponBE.IdCupon;
            controlTextoCodigo.Texto = cuponBE.Codigo;
            controlNumericoValor.Numero = cuponBE.Valor;
            checkBoxActivado.Checked = cuponBE.Activo;
        }

        private bool validateControllers()
        {
            bool ok = true;
            foreach (Control control in this.Controls)
            {
                if (control is ControlNumerico cn)
                    ok = cn.validate() && ok;
                else if (control is ControlTexto ct)
                    ok = ct.validate() && ok;
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

                Cupon nuevoCupon = new Cupon
                {
                    IdCupon = 0,
                    Codigo = controlTextoCodigo.Texto,
                    Valor = controlNumericoValor.Numero,
                    Activo = checkBoxActivado.Checked
                };

                int res = cuponBLL.Alta(nuevoCupon);

                if (res <= 0)
                    MessageBox.Show("Error al dar de alta el cupón");
                else
                {
                    MessageBox.Show("Cupón dado de alta correctamente");
                    dataGridView1.DataSource = cuponBLL.Listado();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al dar de alta el cupón: " + ex.Message);
            }
        }

        private void buttonBaja_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!validateControllers()) return;

                int idCupon = (int)controlNumericoIdCupon.Numero;
                int res = cuponBLL.Baja(idCupon);

                if (res != 1)
                    MessageBox.Show("Error al dar de baja el cupón");
                else
                {
                    MessageBox.Show("Cupón dado de baja correctamente");
                    dataGridView1.DataSource = cuponBLL.Listado();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al dar de baja el cupón: " + ex.Message);
            }
        }

        private void buttonModificacion_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!validateControllers()) return;

                Cupon modCupon = new Cupon
                {
                    IdCupon = (int)controlNumericoIdCupon.Numero,
                    Codigo = controlTextoCodigo.Texto,
                    Valor = controlNumericoValor.Numero,
                    Activo = checkBoxActivado.Checked
                };

                int res = cuponBLL.Modificacion(modCupon);

                if (res != 1)
                    MessageBox.Show("Error al modificar el cupón");
                else
                {
                    MessageBox.Show("Cupón modificado correctamente");
                    dataGridView1.DataSource = cuponBLL.Listado();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el cupón: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cuponBE = (BE.Cupon)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                CargarDatosCampos();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al seleccionar el cupón");
            }
        }

    }
}
