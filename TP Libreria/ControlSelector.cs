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
    public partial class ControlSelector : UserControl
    {
        public ControlSelector()
        {
            InitializeComponent();
        }
        private List<object> listado = new List<object>();
        private object seleccionado;
        public object Seleccionado
        {
            get => seleccionado;
            set
            {
                seleccionado = value;
                comboBox1.SelectedItem = value;
            }
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
        public void CargarLista<T>(List<T> lista)
        {
            listado = lista.Cast<object>().ToList();
            comboBox1.DataSource = null;
            comboBox1.DataSource = listado;
        }

        public void CargarSeleccionado(object valor, string parametroID)
        {
            Seleccionado = listado.FirstOrDefault(item =>
            {
                var prop = item.GetType().GetProperty(parametroID);
                return object.Equals(prop.GetValue(item), prop.GetValue(valor));
            });
        }
        public void ConfigurarDisplayMember(string propiedad)
        {
            comboBox1.DisplayMember = propiedad;
        }
        public bool Validar()
        {
            if (Seleccionado != null)
            {
                comboBox1.BackColor = Color.White;
                return true;
            }
            else
            {
                comboBox1.BackColor = Color.Red;
                return false;
            }
        }
        private void ControlSelector_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                seleccionado = comboBox1.SelectedItem;
            }
        }
    }
}
