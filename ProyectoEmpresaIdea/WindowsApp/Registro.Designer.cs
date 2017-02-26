namespace WindowsApp
{
    partial class Registrar
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidoP = new System.Windows.Forms.Label();
            this.lblApellidoM = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblGrado = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.txtApellidoM = new System.Windows.Forms.TextBox();
            this.cboCarrera = new System.Windows.Forms.ComboBox();
            this.cboGrado = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblReContraseña = new System.Windows.Forms.Label();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(145, 360);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(87, 37);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(249, 360);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 37);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.BackColor = System.Drawing.Color.Transparent;
            this.lblMatricula.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.ForeColor = System.Drawing.Color.White;
            this.lblMatricula.Location = new System.Drawing.Point(12, 121);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(61, 15);
            this.lblMatricula.TabIndex = 2;
            this.lblMatricula.Text = "Matricula:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(12, 146);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 15);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre(s):";
            // 
            // lblApellidoP
            // 
            this.lblApellidoP.AutoSize = true;
            this.lblApellidoP.BackColor = System.Drawing.Color.Transparent;
            this.lblApellidoP.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoP.ForeColor = System.Drawing.Color.White;
            this.lblApellidoP.Location = new System.Drawing.Point(12, 171);
            this.lblApellidoP.Name = "lblApellidoP";
            this.lblApellidoP.Size = new System.Drawing.Size(100, 15);
            this.lblApellidoP.TabIndex = 4;
            this.lblApellidoP.Text = "Apellido Paterno:";
            // 
            // lblApellidoM
            // 
            this.lblApellidoM.AutoSize = true;
            this.lblApellidoM.BackColor = System.Drawing.Color.Transparent;
            this.lblApellidoM.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoM.ForeColor = System.Drawing.Color.White;
            this.lblApellidoM.Location = new System.Drawing.Point(12, 196);
            this.lblApellidoM.Name = "lblApellidoM";
            this.lblApellidoM.Size = new System.Drawing.Size(103, 15);
            this.lblApellidoM.TabIndex = 5;
            this.lblApellidoM.Text = "Apellido Materno:";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.BackColor = System.Drawing.Color.Transparent;
            this.lblCarrera.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.ForeColor = System.Drawing.Color.White;
            this.lblCarrera.Location = new System.Drawing.Point(12, 222);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(51, 15);
            this.lblCarrera.TabIndex = 6;
            this.lblCarrera.Text = "Carrera:";
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.BackColor = System.Drawing.Color.Transparent;
            this.lblGrado.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrado.ForeColor = System.Drawing.Color.White;
            this.lblGrado.Location = new System.Drawing.Point(12, 250);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(44, 15);
            this.lblGrado.TabIndex = 7;
            this.lblGrado.Text = "Grado:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.Location = new System.Drawing.Point(145, 116);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(191, 21);
            this.txtMatricula.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(145, 141);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(191, 21);
            this.txtNombre.TabIndex = 9;
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoP.Location = new System.Drawing.Point(145, 166);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(191, 21);
            this.txtApellidoP.TabIndex = 10;
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoM.Location = new System.Drawing.Point(145, 191);
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(191, 21);
            this.txtApellidoM.TabIndex = 11;
            // 
            // cboCarrera
            // 
            this.cboCarrera.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCarrera.FormattingEnabled = true;
            this.cboCarrera.Location = new System.Drawing.Point(145, 216);
            this.cboCarrera.Name = "cboCarrera";
            this.cboCarrera.Size = new System.Drawing.Size(191, 24);
            this.cboCarrera.TabIndex = 12;
            this.cboCarrera.SelectedIndexChanged += new System.EventHandler(this.cboCarrera_SelectedIndexChanged);
            // 
            // cboGrado
            // 
            this.cboGrado.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGrado.FormattingEnabled = true;
            this.cboGrado.Location = new System.Drawing.Point(145, 244);
            this.cboGrado.Name = "cboGrado";
            this.cboGrado.Size = new System.Drawing.Size(191, 24);
            this.cboGrado.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsApp.Properties.Resources.LogoFinal2;
            this.pictureBox1.Location = new System.Drawing.Point(142, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 94);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseña.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.White;
            this.lblContraseña.Location = new System.Drawing.Point(12, 278);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(72, 15);
            this.lblContraseña.TabIndex = 15;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblReContraseña
            // 
            this.lblReContraseña.AutoSize = true;
            this.lblReContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblReContraseña.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReContraseña.ForeColor = System.Drawing.Color.White;
            this.lblReContraseña.Location = new System.Drawing.Point(12, 302);
            this.lblReContraseña.Name = "lblReContraseña";
            this.lblReContraseña.Size = new System.Drawing.Size(129, 15);
            this.lblReContraseña.TabIndex = 17;
            this.lblReContraseña.Text = "Reingrese Contraseña:";
            // 
            // txtPassword1
            // 
            this.txtPassword1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword1.Location = new System.Drawing.Point(145, 272);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.Size = new System.Drawing.Size(191, 21);
            this.txtPassword1.TabIndex = 18;
            this.txtPassword1.UseSystemPasswordChar = true;
            // 
            // txtPassword2
            // 
            this.txtPassword2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword2.Location = new System.Drawing.Point(145, 297);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(191, 21);
            this.txtPassword2.TabIndex = 19;
            this.txtPassword2.UseSystemPasswordChar = true;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(145, 322);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(191, 21);
            this.txtCorreo.TabIndex = 21;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.White;
            this.lblCorreo.Location = new System.Drawing.Point(12, 327);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(111, 15);
            this.lblCorreo.TabIndex = 20;
            this.lblCorreo.Text = "Correo Electronico:";
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsApp.Properties.Resources.Registro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(703, 416);
            this.ControlBox = false;
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.txtPassword1);
            this.Controls.Add(this.lblReContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cboGrado);
            this.Controls.Add(this.cboCarrera);
            this.Controls.Add(this.txtApellidoM);
            this.Controls.Add(this.txtApellidoP);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblGrado);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblApellidoM);
            this.Controls.Add(this.lblApellidoP);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidoP;
        private System.Windows.Forms.Label lblApellidoM;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidoP;
        private System.Windows.Forms.TextBox txtApellidoM;
        private System.Windows.Forms.ComboBox cboCarrera;
        private System.Windows.Forms.ComboBox cboGrado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblReContraseña;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
    }
}