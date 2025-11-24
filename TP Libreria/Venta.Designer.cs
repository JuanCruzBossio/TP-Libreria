namespace TP_Libreria
{
    partial class Venta
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewLibros = new System.Windows.Forms.DataGridView();
            this.dataGridViewCarrito = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAgregarAlCarrito = new System.Windows.Forms.Button();
            this.buttonQuitarDelCarrito = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonAltaVenta = new System.Windows.Forms.Button();
            this.textBoxCupon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonValidarCupon = new System.Windows.Forms.Button();
            this.textBoxCuponValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.controlSelectorCliente = new TP_Libreria.ControlSelector();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Libros";
            // 
            // dataGridViewLibros
            // 
            this.dataGridViewLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLibros.Location = new System.Drawing.Point(74, 72);
            this.dataGridViewLibros.Name = "dataGridViewLibros";
            this.dataGridViewLibros.Size = new System.Drawing.Size(514, 165);
            this.dataGridViewLibros.TabIndex = 2;
            this.dataGridViewLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLibros_CellContentClick);
            // 
            // dataGridViewCarrito
            // 
            this.dataGridViewCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarrito.Location = new System.Drawing.Point(654, 72);
            this.dataGridViewCarrito.Name = "dataGridViewCarrito";
            this.dataGridViewCarrito.Size = new System.Drawing.Size(514, 165);
            this.dataGridViewCarrito.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(651, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Carrito";
            // 
            // buttonAgregarAlCarrito
            // 
            this.buttonAgregarAlCarrito.Location = new System.Drawing.Point(74, 254);
            this.buttonAgregarAlCarrito.Name = "buttonAgregarAlCarrito";
            this.buttonAgregarAlCarrito.Size = new System.Drawing.Size(115, 23);
            this.buttonAgregarAlCarrito.TabIndex = 5;
            this.buttonAgregarAlCarrito.Text = "Agregar al Carrito";
            this.buttonAgregarAlCarrito.UseVisualStyleBackColor = true;
            this.buttonAgregarAlCarrito.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonQuitarDelCarrito
            // 
            this.buttonQuitarDelCarrito.Location = new System.Drawing.Point(654, 254);
            this.buttonQuitarDelCarrito.Name = "buttonQuitarDelCarrito";
            this.buttonQuitarDelCarrito.Size = new System.Drawing.Size(115, 23);
            this.buttonQuitarDelCarrito.TabIndex = 6;
            this.buttonQuitarDelCarrito.Text = "Quitar del Carrito";
            this.buttonQuitarDelCarrito.UseVisualStyleBackColor = true;
            this.buttonQuitarDelCarrito.Click += new System.EventHandler(this.buttonQuitarDelCarrito_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total:";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Enabled = false;
            this.textBoxTotal.Location = new System.Drawing.Point(82, 374);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(164, 20);
            this.textBoxTotal.TabIndex = 8;
            this.textBoxTotal.Text = "0";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(1053, 254);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(115, 23);
            this.buttonLimpiar.TabIndex = 9;
            this.buttonLimpiar.Text = "Limpiar el Carrito";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonAltaVenta
            // 
            this.buttonAltaVenta.Location = new System.Drawing.Point(534, 401);
            this.buttonAltaVenta.Name = "buttonAltaVenta";
            this.buttonAltaVenta.Size = new System.Drawing.Size(115, 23);
            this.buttonAltaVenta.TabIndex = 10;
            this.buttonAltaVenta.Text = "Realizar Venta";
            this.buttonAltaVenta.UseVisualStyleBackColor = true;
            this.buttonAltaVenta.Click += new System.EventHandler(this.buttonAltaVenta_Click);
            // 
            // textBoxCupon
            // 
            this.textBoxCupon.Location = new System.Drawing.Point(82, 316);
            this.textBoxCupon.Name = "textBoxCupon";
            this.textBoxCupon.Size = new System.Drawing.Size(164, 20);
            this.textBoxCupon.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cupon";
            // 
            // buttonValidarCupon
            // 
            this.buttonValidarCupon.Location = new System.Drawing.Point(269, 316);
            this.buttonValidarCupon.Name = "buttonValidarCupon";
            this.buttonValidarCupon.Size = new System.Drawing.Size(115, 23);
            this.buttonValidarCupon.TabIndex = 13;
            this.buttonValidarCupon.Text = "Validar";
            this.buttonValidarCupon.UseVisualStyleBackColor = true;
            this.buttonValidarCupon.Click += new System.EventHandler(this.buttonValidarCupon_Click);
            // 
            // textBoxCuponValor
            // 
            this.textBoxCuponValor.Enabled = false;
            this.textBoxCuponValor.Location = new System.Drawing.Point(82, 342);
            this.textBoxCuponValor.Name = "textBoxCuponValor";
            this.textBoxCuponValor.Size = new System.Drawing.Size(164, 20);
            this.textBoxCuponValor.TabIndex = 15;
            this.textBoxCuponValor.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Descuento:";
            // 
            // controlSelectorCliente
            // 
            this.controlSelectorCliente.Location = new System.Drawing.Point(14, 12);
            this.controlSelectorCliente.Name = "controlSelectorCliente";
            this.controlSelectorCliente.Seleccionado = null;
            this.controlSelectorCliente.Size = new System.Drawing.Size(588, 36);
            this.controlSelectorCliente.TabIndex = 0;
            this.controlSelectorCliente.Titulo = "Cliente:";
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 490);
            this.Controls.Add(this.textBoxCuponValor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonValidarCupon);
            this.Controls.Add(this.textBoxCupon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAltaVenta);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonQuitarDelCarrito);
            this.Controls.Add(this.buttonAgregarAlCarrito);
            this.Controls.Add(this.dataGridViewCarrito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewLibros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.controlSelectorCliente);
            this.Name = "Venta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ControlSelector controlSelectorCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewLibros;
        private System.Windows.Forms.DataGridView dataGridViewCarrito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAgregarAlCarrito;
        private System.Windows.Forms.Button buttonQuitarDelCarrito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonAltaVenta;
        private System.Windows.Forms.TextBox textBoxCupon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonValidarCupon;
        private System.Windows.Forms.TextBox textBoxCuponValor;
        private System.Windows.Forms.Label label5;
    }
}