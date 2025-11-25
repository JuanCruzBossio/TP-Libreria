using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace TP_Libreria
{
    public partial class Venta : Form
    {
        public Venta(Usuario usuario)
        {
            InitializeComponent();
            vendedor = usuario;
        }
        ClienteBLL clienteBLL = new ClienteBLL();
        LibroBLL libroBLL = new LibroBLL();
        VentaBLL ventaBLL = new VentaBLL();
        CuponBLL cuponBLL = new CuponBLL();
        BE.Usuario vendedor;
        BE.Cliente cliente = new Cliente(0,"","",0);
        BE.Cupon cupon = null;
        List<BE.DetalleVenta> carrito = new List<BE.DetalleVenta>();

        private void Venta_Load(object sender, EventArgs e)
        {
            dataGridViewLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLibros.MultiSelect = false;
            dataGridViewCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCarrito.MultiSelect = false;
            controlSelectorCliente.CargarLista<BE.Cliente>(clienteBLL.Listado());
            List<BE.Libro> listadoLibro = libroBLL.Listado().Where(libro => libro.Stock > 0).ToList();
            dataGridViewLibros.DataSource = listadoLibro;
            dataGridViewLibros.Columns["IdLibro"].Visible = false;
        }

        private void dataGridViewLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridViewLibros.SelectedRows.Count == 1 )
            {
                BE.Libro libro = (BE.Libro)dataGridViewLibros.SelectedRows[0].DataBoundItem;
                if (carrito?.FirstOrDefault(_detalle => _detalle.Libro.IdLibro == libro.IdLibro) != null)
                {
                    if(carrito?.FirstOrDefault(_detalle => _detalle.Libro.IdLibro == libro.IdLibro).Cantidad < libro.Stock)
                    {
                        carrito.First(_detalle => _detalle.Libro.IdLibro == libro.IdLibro).Cantidad++;
                    }
                    else
                    {
                        MessageBox.Show("Stock insuficiente: ya agregaste la cantidad máxima disponible de este libro.");
                    }
                }
                else
                {
                    DetalleVenta detalle = new DetalleVenta(libro, 1,libro.Precio);
                    carrito.Add(detalle);
                }
                dataGridViewCarrito.DataSource = null;
                dataGridViewCarrito.DataSource = carrito;
                UpdateTotal();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un libro");
            }
        }

        private void buttonQuitarDelCarrito_Click(object sender, EventArgs e)
        {
            if (dataGridViewCarrito.SelectedRows.Count == 1)
            {
                DetalleVenta detalleVenta = (DetalleVenta)dataGridViewCarrito.SelectedRows[0].DataBoundItem;
                if (carrito?.FirstOrDefault(_detalle => _detalle.Libro.IdLibro == detalleVenta.Libro.IdLibro).Cantidad > 1)
                {
                    carrito.FirstOrDefault(_detalle => _detalle.Libro.IdLibro == detalleVenta.Libro.IdLibro).Cantidad--;
                }
                else
                {
                    carrito.Remove(detalleVenta);
                }
                dataGridViewCarrito.DataSource = null;
                dataGridViewCarrito.DataSource = carrito;
                UpdateTotal();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Detalle");
            }
        }
        public void UpdateTotal()
        {
            float total = 0;
            foreach (DetalleVenta _detalle in carrito)
            {
                total += _detalle.total();
            }
            if (cupon != null) { 
               if(cupon.Valor < total)
                {
                    total -= cupon.Valor;
                }
                else
                {
                    total = 0;
                }
            }
            textBoxTotal.Text = total.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            carrito = new List<DetalleVenta>();
            dataGridViewCarrito.DataSource = null;
            dataGridViewCarrito.DataSource = carrito;
            UpdateTotal();
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
                else if (control is ControlSelector cs)
                {
                    ok = cs.Validar() && ok;
                }
            }
            if (!ok)
            {
                MessageBox.Show("Datos incorrectos");
                return false;
            }
            return true;
        }
        private void buttonAltaVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validateControllers()) return;
                if (carrito.Count > 0) {
                    BE.Venta venta = new BE.Venta(
                        0,
                        DateTime.Now,
                        (BE.Cliente)controlSelectorCliente.Seleccionado,
                        vendedor,
                        carrito,
                        cupon);
                    int res = ventaBLL.Alta(venta);

                    if (res <= 0)
                        MessageBox.Show("Error al realizar la Venta");
                    else
                    {
                        MessageBox.Show("Venta registrada correctamente");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Agregue al menos un libro al carrito");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error al realizar la Venta");
                throw;
            }
        }

        private void buttonValidarCupon_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validateControllers()) return;
                cliente = (BE.Cliente)controlSelectorCliente.Seleccionado;
                cupon = cuponBLL.Validar(textBoxCupon.Text, cliente.IdCliente);
                if(cupon != null)
                {
                    MessageBox.Show("El Cupon es valido");
                }
                else
                {
                    MessageBox.Show("El Cupon ingresado no es valido o ya fue utilizado por el cliente");
                }
                textBoxCuponValor.Text = cupon?.Valor.ToString() ?? "0";
                UpdateTotal();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al validar Cupon");
                throw;
            }
        }
    }
}
