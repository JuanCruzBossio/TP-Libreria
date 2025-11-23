namespace TP_Libreria
{
    partial class ABMUsuario
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
            this.buttonModificacion = new System.Windows.Forms.Button();
            this.buttonBaja = new System.Windows.Forms.Button();
            this.buttonAlta = new System.Windows.Forms.Button();
            this.controlNumerico2 = new TP_Libreria.ControlNumerico();
            this.controlTexto2 = new TP_Libreria.ControlTexto();
            this.controlTexto1 = new TP_Libreria.ControlTexto();
            this.controlNumerico1 = new TP_Libreria.ControlNumerico();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(583, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonModificacion
            // 
            this.buttonModificacion.Location = new System.Drawing.Point(243, 356);
            this.buttonModificacion.Name = "buttonModificacion";
            this.buttonModificacion.Size = new System.Drawing.Size(98, 37);
            this.buttonModificacion.TabIndex = 12;
            this.buttonModificacion.Text = "Modificacion";
            this.buttonModificacion.UseVisualStyleBackColor = true;
            this.buttonModificacion.Click += new System.EventHandler(this.buttonModificacion_Click);
            // 
            // buttonBaja
            // 
            this.buttonBaja.Location = new System.Drawing.Point(128, 356);
            this.buttonBaja.Name = "buttonBaja";
            this.buttonBaja.Size = new System.Drawing.Size(98, 37);
            this.buttonBaja.TabIndex = 11;
            this.buttonBaja.Text = "Baja";
            this.buttonBaja.UseVisualStyleBackColor = true;
            this.buttonBaja.Click += new System.EventHandler(this.buttonBaja_Click);
            // 
            // buttonAlta
            // 
            this.buttonAlta.Location = new System.Drawing.Point(14, 356);
            this.buttonAlta.Name = "buttonAlta";
            this.buttonAlta.Size = new System.Drawing.Size(98, 37);
            this.buttonAlta.TabIndex = 10;
            this.buttonAlta.Text = "Alta";
            this.buttonAlta.UseVisualStyleBackColor = true;
            this.buttonAlta.Click += new System.EventHandler(this.buttonAlta_Click);
            // 
            // controlNumerico2
            // 
            this.controlNumerico2.Location = new System.Drawing.Point(13, 141);
            this.controlNumerico2.Name = "controlNumerico2";
            this.controlNumerico2.Numero = 0F;
            this.controlNumerico2.PermitirEditar = true;
            this.controlNumerico2.Size = new System.Drawing.Size(584, 37);
            this.controlNumerico2.TabIndex = 3;
            this.controlNumerico2.Titulo = "Rol:";
            // 
            // controlTexto2
            // 
            this.controlTexto2.Location = new System.Drawing.Point(12, 98);
            this.controlTexto2.Name = "controlTexto2";
            this.controlTexto2.PermitirNull = true;
            this.controlTexto2.Size = new System.Drawing.Size(584, 36);
            this.controlTexto2.TabIndex = 2;
            this.controlTexto2.Texto = null;
            this.controlTexto2.Titulo = "Contraseña:";
            // 
            // controlTexto1
            // 
            this.controlTexto1.Location = new System.Drawing.Point(12, 56);
            this.controlTexto1.Name = "controlTexto1";
            this.controlTexto1.PermitirNull = false;
            this.controlTexto1.Size = new System.Drawing.Size(584, 36);
            this.controlTexto1.TabIndex = 1;
            this.controlTexto1.Texto = null;
            this.controlTexto1.Titulo = "Nombre:";
            // 
            // controlNumerico1
            // 
            this.controlNumerico1.Location = new System.Drawing.Point(13, 13);
            this.controlNumerico1.Name = "controlNumerico1";
            this.controlNumerico1.Numero = 0F;
            this.controlNumerico1.PermitirEditar = false;
            this.controlNumerico1.Size = new System.Drawing.Size(584, 37);
            this.controlNumerico1.TabIndex = 0;
            this.controlNumerico1.Titulo = "Id Usuario:";
            // 
            // ABMUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 450);
            this.Controls.Add(this.buttonModificacion);
            this.Controls.Add(this.buttonBaja);
            this.Controls.Add(this.buttonAlta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.controlNumerico2);
            this.Controls.Add(this.controlTexto2);
            this.Controls.Add(this.controlTexto1);
            this.Controls.Add(this.controlNumerico1);
            this.Name = "ABMUsuario";
            this.Text = "ABMUsuario";
            this.Load += new System.EventHandler(this.ABMUsuario_Load);
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