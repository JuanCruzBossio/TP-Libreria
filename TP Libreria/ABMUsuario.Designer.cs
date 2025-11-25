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
            this.controlTexto1 = new TP_Libreria.ControlTexto();
            this.controlNumerico1 = new TP_Libreria.ControlNumerico();
            this.controlPasswor1 = new TP_Libreria.ControlPasswor();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            // controlPasswor1
            // 
            this.controlPasswor1.Location = new System.Drawing.Point(-14, 98);
            this.controlPasswor1.MostrarPassword = false;
            this.controlPasswor1.Name = "controlPasswor1";
            this.controlPasswor1.Password = null;
            this.controlPasswor1.PermitirEditar = true;
            this.controlPasswor1.Size = new System.Drawing.Size(708, 39);
            this.controlPasswor1.TabIndex = 13;
            this.controlPasswor1.Load += new System.EventHandler(this.controlPasswor1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Rol";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Vendedor"});
            this.comboBox1.Location = new System.Drawing.Point(77, 143);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(509, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ABMUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.controlPasswor1);
            this.Controls.Add(this.buttonModificacion);
            this.Controls.Add(this.buttonBaja);
            this.Controls.Add(this.buttonAlta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.controlTexto1);
            this.Controls.Add(this.controlNumerico1);
            this.Name = "ABMUsuario";
            this.Text = "ABMUsuario";
            this.Load += new System.EventHandler(this.ABMUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlNumerico controlNumerico1;
        private ControlTexto controlTexto1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonModificacion;
        private System.Windows.Forms.Button buttonBaja;
        private System.Windows.Forms.Button buttonAlta;
        private ControlPasswor controlPasswor1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}