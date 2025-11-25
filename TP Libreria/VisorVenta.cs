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
    public partial class VisorVenta : Form
    {
        BE.Venta venta;
        public VisorVenta(BE.Venta _venta)
        {
            InitializeComponent();
            venta = _venta;
        }

        private void VisorVenta_Load(object sender, EventArgs e)
        {
            textBoxIdVenta.Text = venta.IdVenta.ToString();
            textBoxFecha.Text = venta.Fecha.ToString();
            textBoxCliente.Text = venta.Cliente.ToString();
            textBoxVendedor.Text = venta.Vendedor.ToString();
            textBoxCupon.Text = venta.Cupon != null ? venta.Cupon.ToString() :"";
            textBoxTotal.Text = venta.MontoTotal.ToString();
            dataGridView1.DataSource = venta.DetallesVenta;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
