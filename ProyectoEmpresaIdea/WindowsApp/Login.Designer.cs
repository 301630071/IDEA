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
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBoxbtniniciar = new System.Windows.Forms.PictureBox();
            this.pictureBoxbtnregitrar = new System.Windows.Forms.PictureBox();
            this.pictureBoxbtncancelar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxbtniniciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxbtnregitrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxbtncancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcorreo
            // 
            this.txtcorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo.Location = new System.Drawing.Point(78, 214);
            this.txtcorreo.Multiline = true;
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(277, 31);
            this.txtcorreo.TabIndex = 0;
            this.txtcorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(78, 285);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBoxbtniniciar
            // 
            this.pictureBoxbtniniciar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxbtniniciar.Location = new System.Drawing.Point(24, 382);
            this.pictureBoxbtniniciar.Name = "pictureBoxbtniniciar";
            this.pictureBoxbtniniciar.Size = new System.Drawing.Size(79, 37);
            this.pictureBoxbtniniciar.TabIndex = 1;
            this.pictureBoxbtniniciar.TabStop = false;
            // 
            // pictureBoxbtnregitrar
            // 
            this.pictureBoxbtnregitrar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxbtnregitrar.Location = new System.Drawing.Point(129, 382);
            this.pictureBoxbtnregitrar.Name = "pictureBoxbtnregitrar";
            this.pictureBoxbtnregitrar.Size = new System.Drawing.Size(84, 37);
            this.pictureBoxbtnregitrar.TabIndex = 1;
            this.pictureBoxbtnregitrar.TabStop = false;
            // 
            // pictureBoxbtncancelar
            // 
            this.pictureBoxbtncancelar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxbtncancelar.Location = new System.Drawing.Point(235, 382);
            this.pictureBoxbtncancelar.Name = "pictureBoxbtncancelar";
            this.pictureBoxbtncancelar.Size = new System.Drawing.Size(92, 37);
            this.pictureBoxbtncancelar.TabIndex = 1;
            this.pictureBoxbtncancelar.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(375, 503);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxbtncancelar);
            this.Controls.Add(this.pictureBoxbtnregitrar);
            this.Controls.Add(this.pictureBoxbtniniciar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtcorreo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GYM UTE";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxbtniniciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxbtnregitrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxbtncancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBoxbtniniciar;
        private System.Windows.Forms.PictureBox pictureBoxbtnregitrar;
        private System.Windows.Forms.PictureBox pictureBoxbtncancelar;
    }
}