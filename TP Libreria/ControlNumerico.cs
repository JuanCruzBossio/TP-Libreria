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
    public partial class ControlNumerico : UserControl
    {
        public ControlNumerico()
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
        private float numero;
        public float Numero
        {
            get => numero;
            set
            {
                numero = value;
                textBox1.Text = value.ToString();
            }
        }
        private void ControlNumerico_Load(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        public bool validate()
        {
            try {
                numero = float.Parse(textBox1.Text);
                if (numero >= 0)
                {
                    textBox1.BackColor = Color.White;
                    return true;
                }
                else
                {
                    textBox1.BackColor = Color.Red;
                    return false;
                }
            }catch {
                textBox1.BackColor = Color.Red;
                return false;
            }
        }
    }
}
