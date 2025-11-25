using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

                if (value != null && listado.Contains(value))
                    comboBox1.SelectedItem = value;
                else
                    comboBox1.SelectedIndex = -1;
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
            comboBox1.DisplayMember = null;
            comboBox1.ValueMember = null;

            comboBox1.DataSource = listado;

            comboBox1.SelectedIndex = -1;

            seleccionado = null;
        }

        public void ConfigurarDisplayMember(string propiedad)
        {
            comboBox1.DisplayMember = propiedad;
        }

        public void ConfigurarValueMember(string propiedad)
        {
            comboBox1.ValueMember = propiedad;
        }

        public void CargarSeleccionado(object valorID, string propiedadID)
        {
            foreach (var item in listado)
            {
                PropertyInfo prop = item.GetType().GetProperty(propiedadID);

                if (prop == null)
                    throw new Exception($"La propiedad {propiedadID} no existe en el objeto.");

                var itemValue = prop.GetValue(item);

                if (object.Equals(itemValue, valorID))
                {
                    seleccionado = item;
                    comboBox1.SelectedItem = item;
                    return;
                }
            }

            comboBox1.SelectedIndex = -1;
            seleccionado = null;
        }
        public bool Validar()
        {
            bool ok = Seleccionado != null;

            comboBox1.BackColor = ok ? Color.White : Color.Red;

            return ok;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccionado = comboBox1.SelectedItem;
        }

        private void ControlSelector_Load(object sender, EventArgs e)
        {
        }
    }
}
