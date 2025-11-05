namespace TP_Libreria
{
    partial class ABMCliente
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonModificacion = new System.Windows.Forms.Button();
            this.buttonBaja = new System.Windows.Forms.Button();
            this.buttonAlta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // controlNumerico1
            // 
            this.controlNumerico1.Location = new System.Drawing.Point(38, 29);
            this.controlNumerico1.Name = "controlNumerico1";
            this.controlNumerico1.Numero = 0F;
            this.controlNumerico1.Size = new System.Drawing.Size(584, 37);
            this.controlNumerico1.TabIndex = 0;
            this.controlNumerico1.Titulo = "Id Cliente:";
            // 
            // controlTexto1
            // 
            this.controlTexto1.Location = new System.Drawing.Point(38, 94);
            this.controlTexto1.Name = "controlTexto1";
            this.controlTexto1.Size = new System.Drawing.Size(584, 36);
            this.controlTexto1.TabIndex = 1;
            this.controlTexto1.Texto = null;
            this.controlTexto1.Titulo = "Nombre:";
            // 
            // controlTexto2
            // 
            this.controlTexto2.Location = new System.Drawing.Point(38, 151);
            this.controlTexto2.Name = "controlTexto2";
            this.controlTexto2.Size = new System.Drawing.Size(584, 36);
            this.controlTexto2.TabIndex = 2;
            this.controlTexto2.Texto = null;
            this.controlTexto2.Titulo = "Género:";
            // 
            // controlNumerico2
            // 
            this.controlNumerico2.Location = new System.Drawing.Point(38, 210);
            this.controlNumerico2.Name = "controlNumerico2";
            this.controlNumerico2.Numero = 0F;
            this.controlNumerico2.Size = new System.Drawing.Size(584, 37);
            this.controlNumerico2.TabIndex = 3;
            this.controlNumerico2.Titulo = "Edad:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(584, 182);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonModificacion
            // 
            this.buttonModificacion.Location = new System.Drawing.Point(271, 498);
            this.buttonModificacion.Name = "buttonModificacion";
            this.buttonModificacion.Size = new System.Drawing.Size(98, 37);
            this.buttonModificacion.TabIndex = 8;
            this.buttonModificacion.Text = "Modificacion";
            this.buttonModificacion.UseVisualStyleBackColor = true;
            this.buttonModificacion.Click += new System.EventHandler(this.buttonModificacion_Click_1);
            // 
            // buttonBaja
            // 
            this.buttonBaja.Location = new System.Drawing.Point(156, 498);
            this.buttonBaja.Name = "buttonBaja";
            this.buttonBaja.Size = new System.Drawing.Size(98, 37);
            this.buttonBaja.TabIndex = 7;
            this.buttonBaja.Text = "Baja";
            this.buttonBaja.UseVisualStyleBackColor = true;
            this.buttonBaja.Click += new System.EventHandler(this.buttonBaja_Click_1);
            // 
            // buttonAlta
            // 
            this.buttonAlta.Location = new System.Drawing.Point(42, 498);
            this.buttonAlta.Name = "buttonAlta";
            this.buttonAlta.Size = new System.Drawing.Size(98, 37);
            this.buttonAlta.TabIndex = 6;
            this.buttonAlta.Text = "Alta";
            this.buttonAlta.UseVisualStyleBackColor = true;
            this.buttonAlta.Click += new System.EventHandler(this.buttonAlta_Click_1);
            // 
            // ABMCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 558);
            this.Controls.Add(this.buttonModificacion);
            this.Controls.Add(this.buttonBaja);
            this.Controls.Add(this.buttonAlta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.controlNumerico2);
            this.Controls.Add(this.controlTexto2);
            this.Controls.Add(this.controlTexto1);
            this.Controls.Add(this.controlNumerico1);
            this.Name = "ABMCliente";
            this.Text = "ABMCliente";
            this.Load += new System.EventHandler(this.ABMCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ControlNumerico controlNumerico1;
        private ControlTexto controlTexto1;
        private ControlTexto controlTexto2;
        private ControlNumerico controlNumerico2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonModificacion;
        private System.Windows.Forms.Button buttonBaja;
        private System.Windows.Forms.Button buttonAlta;
    }
}