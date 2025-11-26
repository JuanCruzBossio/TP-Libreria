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
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }
        VentaBLL ventaBLL = new VentaBLL();
        List<BE.Venta> listadoVentas = new List<BE.Venta>();
        LibroBLL libroBLL = new LibroBLL();
        ClienteBLL clienteBLL = new ClienteBLL();
        GeneroBLL generoBLL = new GeneroBLL();
        private void ReporteLibro_Load(object sender, EventArgs e)
        {
            listadoVentas = ventaBLL.Listado();
            comboBoxTipo.Items.AddRange(new string[]
            {
                "Libros más comprados",
                "Libros que más recaudaron",
                "Libros con poco stock",
                "Géneros más vendidos",
                "Géneros que más recaudaron",
                "Porcentaje de ventas por género",
                "Cliente que más libros compró",
                "Cliente que más gastó",
                "Cliente que más cupones usó"
            });

        }
        public List<ReporteLibro> ordenarPorVentas()
        {
            return listadoVentas
                .SelectMany(v => v.DetallesVenta)
                .GroupBy(d => d.Libro.IdLibro)
                .Select(g => new ReporteLibro
                {
                    libro = g.First().Libro,        
                    Cantidad = g.Sum(d => d.Cantidad)
                })
                .OrderByDescending(r => r.Cantidad) 
                .ToList();
        }
        public List<ReporteLibro> ordenarPorRecaudacion()
        {
            return listadoVentas
                .SelectMany(v => v.DetallesVenta) 
                .GroupBy(d => d.Libro.IdLibro) 
                .Select(g => new ReporteLibro
                {
                    libro = g.First().Libro,  
                    Cantidad = g.Sum(d => d.Cantidad * d.PrecioUnitario) 
                })
                .OrderByDescending(r => r.Cantidad) 
                .ToList();
        }
        public List<ReporteLibro> ordenarPorPocoStock()
        {
            return listadoVentas
                .SelectMany(v => v.DetallesVenta)
                .GroupBy(d => d.Libro.IdLibro)
                .Where(g => g.First().Libro.Stock < 5) 
                .Select(g => new ReporteLibro
                {
                    libro = g.First().Libro,
                    Cantidad = g.Sum(d => d.Cantidad)  
                })
                .OrderBy(r => r.libro.Stock)  
                .ToList();
        }
        public List<ReporteGenero> ordenarPorGeneroVentas()
        {
            return listadoVentas
                .SelectMany(v => v.DetallesVenta)
                .GroupBy(d => d.Libro.Genero.IdGenero)  
                .Select(g => new ReporteGenero
                {
                    genero = g.First().Libro.Genero,  
                    Cantidad = g.Sum(d => d.Cantidad) 
                })
                .OrderByDescending(r => r.Cantidad) 
                .ToList();
        }
        public List<ReporteGenero> ordenarPorGeneroRecaudacion()
        {
            return listadoVentas
                .SelectMany(v => v.DetallesVenta)
                .GroupBy(d => d.Libro.Genero.IdGenero)
                .Select(g => new ReporteGenero
                {
                    genero = g.First().Libro.Genero,
                    Cantidad = g.Sum(d => d.Cantidad * d.PrecioUnitario)
                })
                .OrderByDescending(r => r.Cantidad)
                .ToList();
        }
        public List<ReporteGenero> ordenarPorPorcentajeDeVentas()
        {
            float totalVentas = listadoVentas
                .SelectMany(v => v.DetallesVenta)
                .Sum(d => d.Cantidad);

            return listadoVentas
                .SelectMany(v => v.DetallesVenta)
                .GroupBy(d => d.Libro.Genero.IdGenero)
                .Select(g => new ReporteGenero
                {
                    genero = g.First().Libro.Genero,
                    Cantidad = (g.Sum(d => d.Cantidad) / totalVentas) * 100
                })
                .OrderByDescending(r => r.Cantidad)
                .ToList();
        }
        public List<ReporteCliente> ordenarPorClienteMasLibros()
        {
            return listadoVentas
                .GroupBy(v => v.Cliente.IdCliente)  
                .Select(g => new ReporteCliente
                {
                    cliente = g.First().Cliente,  
                    Cantidad = g.Sum(v => v.DetallesVenta.Sum(d => d.Cantidad)) 
                })
                .OrderByDescending(r => r.Cantidad) 
                .ToList();
        }

        public List<ReporteCliente> ordenarPorClienteMasGasto()
        {
            return listadoVentas
                .GroupBy(v => v.Cliente.IdCliente)
                .Select(g => new ReporteCliente
                {
                    cliente = g.First().Cliente,  
                    Cantidad = g.Sum(v => v.MontoTotal)  
                })
                .OrderByDescending(r => r.Cantidad) 
                .ToList();
        }

        public List<ReporteCliente> ordenarPorClienteMasCupones()
        {
            return listadoVentas
                .Where(v => v.Cupon != null)  
                .GroupBy(v => v.Cliente.IdCliente)
                .Select(g => new ReporteCliente
                {
                    cliente = g.First().Cliente,
                    Cantidad = g.Count() 
                })
                .OrderByDescending(r => r.Cantidad) 
                .ToList();
        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxTipo.Text)
            {
                case "Libros más comprados":
                    dataGridView1.DataSource = ordenarPorVentas();
                    break;
                case "Libros que más recaudaron":
                    dataGridView1.DataSource = ordenarPorRecaudacion();
                    break;
                case "Libros con poco stock":
                    dataGridView1.DataSource = ordenarPorPocoStock();
                    break;
                case "Géneros más vendidos":
                    dataGridView1.DataSource = ordenarPorGeneroVentas();
                    break;
                case "Géneros que más recaudaron":
                    dataGridView1.DataSource = ordenarPorGeneroRecaudacion();
                    break;
                case "Porcentaje de ventas por género":
                    dataGridView1.DataSource = ordenarPorPorcentajeDeVentas();
                    break;
                case "Cliente que más libros compró":
                    dataGridView1.DataSource = ordenarPorClienteMasLibros();
                    break;
                case "Cliente que más gastó":
                    dataGridView1.DataSource = ordenarPorClienteMasGasto();
                    break;
                case "Cliente que más cupones usó":
                    dataGridView1.DataSource = ordenarPorClienteMasCupones();
                    break;
                default:
                    break;
            }

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (comboBoxTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de reporte.");
                return;
            }

            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Archivo XML (*.xml)|*.xml";
            dlg.Title = "Guardar XML";
            dlg.FileName = "Reporte.xml";

            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            string ruta = dlg.FileName;

            switch (comboBoxTipo.Text)
            {
                case "Libros más comprados":
                    var listaLibrosVendidos = ordenarPorVentas();
                    libroBLL.GuardarXML("Libros mas comprados", listaLibrosVendidos, ruta);
                    break;

                case "Libros que más recaudaron":
                    var listaLibrosRecaudados = ordenarPorRecaudacion();
                    libroBLL.GuardarXML("Libros que mas recaudaron", listaLibrosRecaudados, ruta);
                    break;

                case "Libros con poco stock":
                    var listaPocoStock = ordenarPorPocoStock();
                    libroBLL.GuardarXML("Libros con poco stock", listaPocoStock, ruta);
                    break;

                case "Géneros más vendidos":
                    var listaGeneroVentas = ordenarPorGeneroVentas();
                    generoBLL.GuardarXML("Generos mas vendidos", listaGeneroVentas, ruta);
                    break;

                case "Géneros que más recaudaron":
                    var listaGeneroRecauda = ordenarPorGeneroRecaudacion();
                    generoBLL.GuardarXML("Generos que mas recaudaron", listaGeneroRecauda, ruta);
                    break;

                case "Porcentaje de ventas por género":
                    var listaPorcentaje = ordenarPorPorcentajeDeVentas();
                    generoBLL.GuardarXML("Porcentaje de ventas por genero", listaPorcentaje, ruta);
                    break;

                case "Cliente que más libros compró":
                    var listaClienteLibros = ordenarPorClienteMasLibros();
                    clienteBLL.GuardarXML("Cliente que mas libros compro", listaClienteLibros, ruta);
                    break;

                case "Cliente que más gastó":
                    var listaClienteGasto = ordenarPorClienteMasGasto();
                    clienteBLL.GuardarXML("Cliente que mas gasto", listaClienteGasto, ruta);
                    break;

                case "Cliente que más cupones usó":
                    var listaClienteCupon = ordenarPorClienteMasCupones();
                    clienteBLL.GuardarXML("Cliente que mas cupones uso", listaClienteCupon, ruta);
                    break;
            }

            MessageBox.Show("XML guardado correctamente.");
        }

    }
}
