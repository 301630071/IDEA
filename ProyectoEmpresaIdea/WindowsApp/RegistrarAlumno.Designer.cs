namespace WindowsApp
{
    partial class RegistrarAlumno
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
            this.groupBoxNuevoAlumno = new System.Windows.Forms.GroupBox();
            this.cboGrado = new System.Windows.Forms.ComboBox();
            this.cboCarrera = new System.Windows.Forms.ComboBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtapellidoM = new System.Windows.Forms.TextBox();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblGrado = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblApellidoM = new System.Windows.Forms.Label();
            this.lblApellidoP = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.groupBoxNuevoAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxNuevoAlumno
            // 
            this.groupBoxNuevoAlumno.Controls.Add(this.cboGrado);
            this.groupBoxNuevoAlumno.Controls.Add(this.cboCarrera);
            this.groupBoxNuevoAlumno.Controls.Add(this.txtCorreo);
            this.groupBoxNuevoAlumno.Controls.Add(this.txtapellidoM);
            this.groupBoxNuevoAlumno.Controls.Add(this.txtApellidoP);
            this.groupBoxNuevoAlumno.Controls.Add(this.txtNombre);
            this.groupBoxNuevoAlumno.Controls.Add(this.txtMatricula);
            this.groupBoxNuevoAlumno.Controls.Add(this.lblCorreo);
            this.groupBoxNuevoAlumno.Controls.Add(this.lblGrado);
            this.groupBoxNuevoAlumno.Controls.Add(this.lblCarrera);
            this.groupBoxNuevoAlumno.Controls.Add(this.lblApellidoM);
            this.groupBoxNuevoAlumno.Controls.Add(this.lblApellidoP);
            this.groupBoxNuevoAlumno.Controls.Add(this.lblNombre);
            this.groupBoxNuevoAlumno.Controls.Add(this.lblMatricula);
            this.groupBoxNuevoAlumno.Location = new System.Drawing.Point(12, 12);
            this.groupBoxNuevoAlumno.Name = "groupBoxNuevoAlumno";
            this.groupBoxNuevoAlumno.Size = new System.Drawing.Size(572, 451);
            this.groupBoxNuevoAlumno.TabIndex = 0;
            this.groupBoxNuevoAlumno.TabStop = false;
            this.groupBoxNuevoAlumno.Text = "Nuevo Alumno";
            // 
            // cboGrado
            // 
            this.cboGrado.FormattingEnabled = true;
            this.cboGrado.Location = new System.Drawing.Point(280, 264);
            this.cboGrado.Name = "cboGrado";
            this.cboGrado.Size = new System.Drawing.Size(121, 21);
            this.cboGrado.TabIndex = 14;
            this.cboGrado.SelectedIndexChanged += new System.EventHandler(this.cboGrado_SelectedIndexChanged);
            // 
            // cboCarrera
            // 
            this.cboCarrera.FormattingEnabled = true;
            this.cboCarrera.Location = new System.Drawing.Point(280, 214);
            this.cboCarrera.Name = "cboCarrera";
            this.cboCarrera.Size = new System.Drawing.Size(121, 21);
            this.cboCarrera.TabIndex = 13;
            this.cboCarrera.SelectedIndexChanged += new System.EventHandler(this.cboCarrera_SelectedIndexChanged);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(282, 312);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(237, 20);
            this.txtCorreo.TabIndex = 12;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // txtapellidoM
            // 
            this.txtapellidoM.Location = new System.Drawing.Point(280, 165);
            this.txtapellidoM.Name = "txtapellidoM";
            this.txtapellidoM.Size = new System.Drawing.Size(160, 20);
            this.txtapellidoM.TabIndex = 11;
            this.txtapellidoM.TextChanged += new System.EventHandler(this.txtapellidoM_TextChanged);
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Location = new System.Drawing.Point(280, 115);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(160, 20);
            this.txtApellidoP.TabIndex = 10;
            this.txtApellidoP.TextChanged += new System.EventHandler(this.txtApellidoP_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(280, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(160, 20);
            this.txtNombre.TabIndex = 9;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(280, 29);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 8;
            this.txtMatricula.TextChanged += new System.EventHandler(this.txtMatricula_TextChanged);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(53, 319);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(97, 13);
            this.lblCorreo.TabIndex = 7;
            this.lblCorreo.Text = "Correo Electronico:";
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.Location = new System.Drawing.Point(53, 272);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(39, 13);
            this.lblGrado.TabIndex = 5;
            this.lblGrado.Text = "Grado:";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(53, 222);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(44, 13);
            this.lblCarrera.TabIndex = 4;
            this.lblCarrera.Text = "Carrera:";
            // 
            // lblApellidoM
            // 
            this.lblApellidoM.AutoSize = true;
            this.lblApellidoM.Location = new System.Drawing.Point(53, 172);
            this.lblApellidoM.Name = "lblApellidoM";
            this.lblApellidoM.Size = new System.Drawing.Size(89, 13);
            this.lblApellidoM.TabIndex = 3;
            this.lblApellidoM.Text = "Apellido Materno:";
            // 
            // lblApellidoP
            // 
            this.lblApellidoP.AutoSize = true;
            this.lblApellidoP.Location = new System.Drawing.Point(51, 122);
            this.lblApellidoP.Name = "lblApellidoP";
            this.lblApellidoP.Size = new System.Drawing.Size(87, 13);
            this.lblApellidoP.TabIndex = 2;
            this.lblApellidoP.Text = "Apellido Paterno:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(51, 78);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombres(s):";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(51, 36);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(53, 13);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matricula:";
            // 
            // RegistrarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 477);
            this.Controls.Add(this.groupBoxNuevoAlumno);
            this.IsMdiContainer = true;
            this.Name = "RegistrarAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Alumno";
            this.groupBoxNuevoAlumno.ResumeLayout(false);
            this.groupBoxNuevoAlumno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxNuevoAlumno;
        private System.Windows.Forms.Label lblApellidoM;
        private System.Windows.Forms.Label lblApellidoP;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.ComboBox cboGrado;
        private System.Windows.Forms.ComboBox cboCarrera;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtapellidoM;
        private System.Windows.Forms.TextBox txtApellidoP;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.Label lblCarrera;
    }
}