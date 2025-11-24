namespace TP_Libreria
{
    partial class ABMCupon
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
            this.buttonModificacion = new System.Windows.Forms.Button();
            this.buttonBaja = new System.Windows.Forms.Button();
            this.buttonAlta = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.controlNumericoValor = new TP_Libreria.ControlNumerico();
            this.controlTextoCodigo = new TP_Libreria.ControlTexto();
            this.controlNumericoIdCupon = new TP_Libreria.ControlNumerico();
            this.checkBoxActivado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonModificacion
            // 
            this.buttonModificacion.Location = new System.Drawing.Point(256, 492);
            this.buttonModificacion.Name = "buttonModificacion";
            this.buttonModificacion.Size = new System.Drawing.Size(98, 37);
            this.buttonModificacion.TabIndex = 16;
            this.buttonModificacion.Text = "Modificacion";
            this.buttonModificacion.UseVisualStyleBackColor = true;
            this.buttonModificacion.Click += new System.EventHandler(this.buttonModificacion_Click_1);
            // 
            // buttonBaja
            // 
            this.buttonBaja.Location = new System.Drawing.Point(141, 492);
            this.buttonBaja.Name = "buttonBaja";
            this.buttonBaja.Size = new System.Drawing.Size(98, 37);
            this.buttonBaja.TabIndex = 15;
            this.buttonBaja.Text = "Baja";
            this.buttonBaja.UseVisualStyleBackColor = true;
            this.buttonBaja.Click += new System.EventHandler(this.buttonBaja_Click_1);
            // 
            // buttonAlta
            // 
            this.buttonAlta.Location = new System.Drawing.Point(27, 492);
            this.buttonAlta.Name = "buttonAlta";
            this.buttonAlta.Size = new System.Drawing.Size(98, 37);
            this.buttonAlta.TabIndex = 14;
            this.buttonAlta.Text = "Alta";
            this.buttonAlta.UseVisualStyleBackColor = true;
            this.buttonAlta.Click += new System.EventHandler(this.buttonAlta_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(584, 182);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // controlNumericoValor
            // 
            this.controlNumericoValor.Location = new System.Drawing.Point(23, 144);
            this.controlNumericoValor.Name = "controlNumericoValor";
            this.controlNumericoValor.Numero = 0F;
            this.controlNumericoValor.PermitirEditar = true;
            this.controlNumericoValor.Size = new System.Drawing.Size(584, 37);
            this.controlNumericoValor.TabIndex = 12;
            this.controlNumericoValor.Titulo = "Valor";
            // 
            // controlTextoCodigo
            // 
            this.controlTextoCodigo.Location = new System.Drawing.Point(23, 88);
            this.controlTextoCodigo.Name = "controlTextoCodigo";
            this.controlTextoCodigo.PermitirNull = false;
            this.controlTextoCodigo.Size = new System.Drawing.Size(584, 36);
            this.controlTextoCodigo.TabIndex = 10;
            this.controlTextoCodigo.Texto = null;
            this.controlTextoCodigo.Titulo = "Codigo";
            // 
            // controlNumericoIdCupon
            // 
            this.controlNumericoIdCupon.Location = new System.Drawing.Point(23, 23);
            this.controlNumericoIdCupon.Name = "controlNumericoIdCupon";
            this.controlNumericoIdCupon.Numero = 0F;
            this.controlNumericoIdCupon.PermitirEditar = false;
            this.controlNumericoIdCupon.Size = new System.Drawing.Size(584, 37);
            this.controlNumericoIdCupon.TabIndex = 9;
            this.controlNumericoIdCupon.Titulo = "Id Cupon:";
            // 
            // checkBoxActivado
            // 
            this.checkBoxActivado.AutoSize = true;
            this.checkBoxActivado.Checked = true;
            this.checkBoxActivado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxActivado.Location = new System.Drawing.Point(89, 197);
            this.checkBoxActivado.Name = "checkBoxActivado";
            this.checkBoxActivado.Size = new System.Drawing.Size(68, 17);
            this.checkBoxActivado.TabIndex = 18;
            this.checkBoxActivado.Text = "Activado";
            this.checkBoxActivado.UseVisualStyleBackColor = true;
            // 
            // ABMCupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 593);
            this.Controls.Add(this.checkBoxActivado);
            this.Controls.Add(this.buttonModificacion);
            this.Controls.Add(this.buttonBaja);
            this.Controls.Add(this.buttonAlta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.controlNumericoValor);
            this.Controls.Add(this.controlTextoCodigo);
            this.Controls.Add(this.controlNumericoIdCupon);
            this.Name = "ABMCupon";
            this.Text = "ABMCupon";
            this.Load += new System.EventHandler(this.ABMCupon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonModificacion;
        private System.Windows.Forms.Button buttonBaja;
        private System.Windows.Forms.Button buttonAlta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ControlNumerico controlNumericoValor;
        private ControlTexto controlTextoCodigo;
        private ControlNumerico controlNumericoIdCupon;
        private System.Windows.Forms.CheckBox checkBoxActivado;
    }
}