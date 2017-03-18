using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void btniniciar_Click(object sender, EventArgs e)
        {
            string matricula = txtMatricula.Text;
            string contraseña = txtPassword.Text.ToString();
            string mensaje = BussinessLogicLayer.UsuarioBLL.iniciarSesion(matricula, contraseña);

            if (string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show("Bienvenido al Sistema de IDEA");
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            Registrar abrir = new Registrar();
            abrir.Show();
        }
    }
}
