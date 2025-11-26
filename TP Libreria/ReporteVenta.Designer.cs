namespace TP_Libreria
{
    partial class ReporteVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.controlSelectorCliente = new TP_Libreria.ControlSelector();
            this.controlSelectorVendedor = new TP_Libreria.ControlSelector();
            this.controlSelectorGenero = new TP_Libreria.ControlSelector();
            this.controlSelectorLibro = new TP_Libreria.ControlSelector();
            this.controlSelectorCupon = new TP_Libreria.ControlSelector();
            this.buttonGenerar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 278);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 552);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // controlSelectorCliente
            // 
            this.controlSelectorCliente.Location = new System.Drawing.Point(38, 10);
            this.controlSelectorCliente.Name = "controlSelectorCliente";
            this.controlSelectorCliente.Seleccionado = null;
            this.controlSelectorCliente.Size = new System.Drawing.Size(588, 36);
            this.controlSelectorCliente.TabIndex = 3;
            this.controlSelectorCliente.Titulo = "Cliente:";
            // 
            // controlSelectorVendedor
            // 
            this.controlSelectorVendedor.Location = new System.Drawing.Point(38, 52);
            this.controlSelectorVendedor.Name = "controlSelectorVendedor";
            this.controlSelectorVendedor.Seleccionado = null;
            this.controlSelectorVendedor.Size = new System.Drawing.Size(588, 36);
            this.controlSelectorVendedor.TabIndex = 4;
            this.controlSelectorVendedor.Titulo = "Vendedor:";
            // 
            // controlSelectorGenero
            // 
            this.controlSelectorGenero.Location = new System.Drawing.Point(38, 94);
            this.controlSelectorGenero.Name = "controlSelectorGenero";
            this.controlSelectorGenero.Seleccionado = null;
            this.controlSelectorGenero.Size = new System.Drawing.Size(588, 36);
            this.controlSelectorGenero.TabIndex = 5;
            this.controlSelectorGenero.Titulo = "Genero:";
            // 
            // controlSelectorLibro
            // 
            this.controlSelectorLibro.Location = new System.Drawing.Point(38, 136);
            this.controlSelectorLibro.Name = "controlSelectorLibro";
            this.controlSelectorLibro.Seleccionado = null;
            this.controlSelectorLibro.Size = new System.Drawing.Size(588, 36);
            this.controlSelectorLibro.TabIndex = 6;
            this.controlSelectorLibro.Titulo = "Libro:";
            // 
            // controlSelectorCupon
            // 
            this.controlSelectorCupon.Location = new System.Drawing.Point(38, 178);
            this.controlSelectorCupon.Name = "controlSelectorCupon";
            this.controlSelectorCupon.Seleccionado = null;
            this.controlSelectorCupon.Size = new System.Drawing.Size(588, 36);
            this.controlSelectorCupon.TabIndex = 7;
            this.controlSelectorCupon.Titulo = "Cupon:";
            // 
            // buttonGenerar
            // 
            this.buttonGenerar.Location = new System.Drawing.Point(93, 249);
            this.buttonGenerar.Name = "buttonGenerar";
            this.buttonGenerar.Size = new System.Drawing.Size(115, 23);
            this.buttonGenerar.TabIndex = 11;
            this.buttonGenerar.Text = "Generar Reporte";
            this.buttonGenerar.UseVisualStyleBackColor = true;
            this.buttonGenerar.Click += new System.EventHandler(this.buttonGenerar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(265, 249);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(115, 23);
            this.buttonGuardar.TabIndex = 12;
            this.buttonGuardar.Text = "Guardar Reporte";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(657, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Limpiar Filtros";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 842);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonGenerar);
            this.Controls.Add(this.controlSelectorCupon);
            this.Controls.Add(this.controlSelectorLibro);
            this.Controls.Add(this.controlSelectorGenero);
            this.Controls.Add(this.controlSelectorVendedor);
            this.Controls.Add(this.controlSelectorCliente);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Reporte";
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private ControlSelector controlSelectorCliente;
        private ControlSelector controlSelectorVendedor;
        private ControlSelector controlSelectorGenero;
        private ControlSelector controlSelectorLibro;
        private ControlSelector controlSelectorCupon;
        private System.Windows.Forms.Button buttonGenerar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button button2;
    }
}