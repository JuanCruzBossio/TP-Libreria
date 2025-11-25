using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace TP_Libreria
{
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }
        GeneroBLL generoBLL = new GeneroBLL();
        ClienteBLL clienteBLL = new ClienteBLL();
        LibroBLL libroBLL = new LibroBLL();
        VentaBLL ventaBLL = new VentaBLL();
        CuponBLL cuponBLL = new CuponBLL();
        UsuarioBLL usuarioBLL = new UsuarioBLL();
        List<BE.Venta> listaVentas = new List<BE.Venta>();
        List<BE.Venta> listaVentasFiltradas = new List<BE.Venta>();
        private void Reporte_Load(object sender, EventArgs e)
        {
            listaVentas = ventaBLL.Listado();
            controlSelectorCliente.CargarLista<BE.Cliente>(clienteBLL.Listado());
            controlSelectorVendedor.CargarLista<BE.Usuario>(usuarioBLL.Listado().Where(usuario => usuario.Rol == 2).ToList());
            controlSelectorGenero.CargarLista<BE.Genero>(generoBLL.Listado());
            controlSelectorLibro.CargarLista<BE.Libro>(libroBLL.Listado());
            controlSelectorCupon.CargarLista<BE.Cupon>(cuponBLL.Listado());
        }

        private void buttonGenerar_Click(object sender, EventArgs e)
        {
            var query = listaVentas.AsEnumerable();

            if (controlSelectorCliente.Seleccionado != null)
            {
                var cliente = (BE.Cliente)controlSelectorCliente.Seleccionado;
                query = query.Where(v => v.Cliente.IdCliente == cliente.IdCliente);
            }

            if (controlSelectorVendedor.Seleccionado != null)
            {
                var vendedor = (BE.Usuario)controlSelectorVendedor.Seleccionado;
                query = query.Where(v => v.Vendedor.IdUsuario == vendedor.IdUsuario);
            }

            if (controlSelectorGenero.Seleccionado != null)
            {
                var genero = (BE.Genero)controlSelectorGenero.Seleccionado;
                query = query.Where(v => v.DetallesVenta.Any(d => d.Libro.Genero.IdGenero == genero.IdGenero));
            }

            if (controlSelectorLibro.Seleccionado != null)
            {
                var libro = (BE.Libro)controlSelectorLibro.Seleccionado;
                query = query.Where(v => v.DetallesVenta.Any(d => d.Libro.IdLibro == libro.IdLibro));
            }

            if (controlSelectorCupon.Seleccionado != null)
            {
                var cupon = (BE.Cupon)controlSelectorCupon.Seleccionado;
                query = query.Where(v => v.Cupon != null && v.Cupon.IdCupon == cupon.IdCupon);
            }

            listaVentasFiltradas = query.ToList();
            dataGridView1.DataSource = listaVentasFiltradas;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controlSelectorCliente.CargarSeleccionado( -1, "IdCliente");
            controlSelectorVendedor.CargarSeleccionado( -1, "IdUsuario");
            controlSelectorGenero.CargarSeleccionado( -1, "IdGenero");
            controlSelectorLibro.CargarSeleccionado( -1, "IdLibro");
            controlSelectorCupon.CargarSeleccionado( -1, "IdCupon");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listaVentasFiltradas.Count > 0)
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "Archivo XML (*.xml)|*.xml";
                dlg.Title = "Guardar XML";
                dlg.FileName = "MiArchivo.xml";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    ventaBLL.GuardarXML("Reporte de Ventas", listaVentasFiltradas,dlg.FileName);
                    MessageBox.Show("XML guardado correctamente.");
                }
            }
        }
    }
}
