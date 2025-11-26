namespace TP_Libreria
{
    partial class Login
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.controlPasswor1 = new TP_Libreria.ControlPasswor();
            this.controlTexto1 = new TP_Libreria.ControlTexto();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(297, 120);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(133, 57);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // controlPasswor1
            // 
            this.controlPasswor1.Location = new System.Drawing.Point(23, 45);
            this.controlPasswor1.MostrarPassword = false;
            this.controlPasswor1.Name = "controlPasswor1";
            this.controlPasswor1.Password = "";
            this.controlPasswor1.PermitirEditar = true;
            this.controlPasswor1.Size = new System.Drawing.Size(728, 44);
            this.controlPasswor1.TabIndex = 1;
            // 
            // controlTexto1
            // 
            this.controlTexto1.Location = new System.Drawing.Point(47, 12);
            this.controlTexto1.Name = "controlTexto1";
            this.controlTexto1.PermitirNull = false;
            this.controlTexto1.Size = new System.Drawing.Size(584, 36);
            this.controlTexto1.TabIndex = 0;
            this.controlTexto1.Texto = "";
            this.controlTexto1.Titulo = "Usuario";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 193);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.controlPasswor1);
            this.Controls.Add(this.controlTexto1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlPasswor controlPasswor1;
        private ControlTexto controlTexto1;
        private System.Windows.Forms.Button buttonLogin;
    }
}