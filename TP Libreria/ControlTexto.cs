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
    public partial class ControlTexto : UserControl
    {
        public ControlTexto()
        {
            InitializeComponent();
        }
        private string titulo;
        public string Titulo
        {
            get => titulo;
            set
            {
                titulo = value;
                label1.Text = value;
            }
        }
        private string texto;
        public string Texto
        {
            get => texto;
            set
            {
                texto = value;
                textBox1.Text = value;
            }
        }

        private bool permitirNull = false;

        public bool PermitirNull
        {
            get { return permitirNull ; }
            set { permitirNull = value; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ControlTexto_Load(object sender, EventArgs e)
        {
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
                texto = textBox1.Text;
        }
        public bool validate()
        {
            if (!string.IsNullOrEmpty(texto) || permitirNull == true)
            {
                textBox1.BackColor = Color.White;
                return true;
            }
            else
            {
                textBox1.BackColor = Color.Red;
                return false;
            }
        }
    }
}
