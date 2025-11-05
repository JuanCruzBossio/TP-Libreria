namespace TP_Libreria
{
    partial class ABMLibro
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
            this.controlNumerico1 = new TP_Libreria.ControlNumerico();
            this.controlTexto1 = new TP_Libreria.ControlTexto();
            this.controlTexto2 = new TP_Libreria.ControlTexto();
            this.controlNumerico2 = new TP_Libreria.ControlNumerico();
            this.controlNumerico3 = new TP_Libreria.ControlNumerico();
            this.controlSelector1 = new TP_Libreria.ControlSelector();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonModificacion = new System.Windows.Forms.Button();
            this.buttonBaja = new System.Windows.Forms.Button();
            this.buttonAlta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // controlNumerico1
            // 
            this.controlNumerico1.Location = new System.Drawing.Point(13, 13);
            this.controlNumerico1.Name = "controlNumerico1";
            this.controlNumerico1.Numero = 0F;
            this.controlNumerico1.Size = new System.Drawing.Size(584, 37);
            this.controlNumerico1.TabIndex = 0;
            this.controlNumerico1.Titulo = "Id Libro:";
            // 
            // controlTexto1
            // 
            this.controlTexto1.Location = new System.Drawing.Point(13, 57);
            this.controlTexto1.Name = "controlTexto1";
            this.controlTexto1.Size = new System.Drawing.Size(584, 36);
            this.controlTexto1.TabIndex = 1;
            this.controlTexto1.Texto = null;
            this.controlTexto1.Titulo = "Título:";
            // 
            // controlTexto2
            // 
            this.controlTexto2.Location = new System.Drawing.Point(13, 100);
            this.controlTexto2.Name = "controlTexto2";
            this.controlTexto2.Size = new System.Drawing.Size(584, 36);
            this.controlTexto2.TabIndex = 2;
            this.controlTexto2.Texto = null;
            this.controlTexto2.Titulo = "Autor:";
            // 
            // controlNumerico2
            // 
            this.controlNumerico2.Location = new System.Drawing.Point(13, 143);
            this.controlNumerico2.Name = "controlNumerico2";
            this.controlNumerico2.Numero = 0F;
            this.controlNumerico2.Size = new System.Drawing.Size(584, 37);
            this.controlNumerico2.TabIndex = 3;
            this.controlNumerico2.Titulo = "Precio:";
            // 
            // controlNumerico3
            // 
            this.controlNumerico3.Location = new System.Drawing.Point(13, 187);
            this.controlNumerico3.Name = "controlNumerico3";
            this.controlNumerico3.Numero = 0F;
            this.controlNumerico3.Size = new System.Drawing.Size(584, 37);
            this.controlNumerico3.TabIndex = 4;
            this.controlNumerico3.Titulo = "Stock:";
            // 
            // controlSelector1
            // 
            this.controlSelector1.Location = new System.Drawing.Point(13, 231);
            this.controlSelector1.Name = "controlSelector1";
            this.controlSelector1.Seleccionado = null;
            this.controlSelector1.Size = new System.Drawing.Size(588, 47);
            this.controlSelector1.TabIndex = 5;
            this.controlSelector1.Titulo = "Género:";
            this.controlSelector1.Load += new System.EventHandler(this.controlSelector1_Load);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(584, 150);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonModificacion
            // 
            this.buttonModificacion.Location = new System.Drawing.Point(246, 464);
            this.buttonModificacion.Name = "buttonModificacion";
            this.buttonModificacion.Size = new System.Drawing.Size(98, 37);
            this.buttonModificacion.TabIndex = 9;
            this.buttonModificacion.Text = "Modificacion";
            this.buttonModificacion.UseVisualStyleBackColor = true;
            this.buttonModificacion.Click += new System.EventHandler(this.buttonModificacion_Click);
            // 
            // buttonBaja
            // 
            this.buttonBaja.Location = new System.Drawing.Point(131, 464);
            this.buttonBaja.Name = "buttonBaja";
            this.buttonBaja.Size = new System.Drawing.Size(98, 37);
            this.buttonBaja.TabIndex = 8;
            this.buttonBaja.Text = "Baja";
            this.buttonBaja.UseVisualStyleBackColor = true;
            this.buttonBaja.Click += new System.EventHandler(this.buttonBaja_Click);
            // 
            // buttonAlta
            // 
            this.buttonAlta.Location = new System.Drawing.Point(17, 464);
            this.buttonAlta.Name = "buttonAlta";
            this.buttonAlta.Size = new System.Drawing.Size(98, 37);
            this.buttonAlta.TabIndex = 7;
            this.buttonAlta.Text = "Alta";
            this.buttonAlta.UseVisualStyleBackColor = true;
            this.buttonAlta.Click += new System.EventHandler(this.buttonAlta_Click);
            // 
            // ABMLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 549);
            this.Controls.Add(this.buttonModificacion);
            this.Controls.Add(this.buttonBaja);
            this.Controls.Add(this.buttonAlta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.controlSelector1);
            this.Controls.Add(this.controlNumerico3);
            this.Controls.Add(this.controlNumerico2);
            this.Controls.Add(this.controlTexto2);
            this.Controls.Add(this.controlTexto1);
            this.Controls.Add(this.controlNumerico1);
            this.Name = "ABMLibro";
            this.Text = "ABMLibro";
            this.Load += new System.EventHandler(this.ABMLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ControlNumerico controlNumerico1;
        private ControlTexto controlTexto1;
        private ControlTexto controlTexto2;
        private ControlNumerico controlNumerico2;
        private ControlNumerico controlNumerico3;
        private ControlSelector controlSelector1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonModificacion;
        private System.Windows.Forms.Button buttonBaja;
        private System.Windows.Forms.Button buttonAlta;
    }
}