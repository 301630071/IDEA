namespace WindowsApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblcontraseña = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btniniciar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnregistro = new System.Windows.Forms.Button();
            this.lbltexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblusuario
            // 
            resources.ApplyResources(this.lblusuario, "lblusuario");
            this.lblusuario.BackColor = System.Drawing.Color.Transparent;
            this.lblusuario.ForeColor = System.Drawing.Color.White;
            this.lblusuario.Name = "lblusuario";
            // 
            // lblcontraseña
            // 
            resources.ApplyResources(this.lblcontraseña, "lblcontraseña");
            this.lblcontraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblcontraseña.ForeColor = System.Drawing.Color.White;
            this.lblcontraseña.Name = "lblcontraseña";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // btniniciar
            // 
            resources.ApplyResources(this.btniniciar, "btniniciar");
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            resources.ApplyResources(this.btncancelar, "btncancelar");
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnregistro
            // 
            resources.ApplyResources(this.btnregistro, "btnregistro");
            this.btnregistro.Name = "btnregistro";
            this.btnregistro.UseVisualStyleBackColor = true;
            // 
            // lbltexto
            // 
            resources.ApplyResources(this.lbltexto, "lbltexto");
            this.lbltexto.BackColor = System.Drawing.Color.Transparent;
            this.lbltexto.ForeColor = System.Drawing.Color.White;
            this.lbltexto.Name = "lbltexto";
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.lbltexto);
            this.Controls.Add(this.btnregistro);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btniniciar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblcontraseña);
            this.Controls.Add(this.lblusuario);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblcontraseña;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btniniciar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnregistro;
        private System.Windows.Forms.Label lbltexto;
    }
}