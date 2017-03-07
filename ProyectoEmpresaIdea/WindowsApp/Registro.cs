using Entities;
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
    public partial class Registrar : Form
    {
        static string Matricula;
        static string Nombre;
        static string ApellidoP;
        static string ApellidoM;
        static string Carrera;
        static string Grado;
        static string Correo;
        static string Password1;
        static string Password2;


        public Registrar()
        {
            InitializeComponent();

            //cboCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            //cboCarrera.Items.Add("TICSI");
            //cboCarrera.Items.Add("QUIMICA");
            //cboCarrera.Items.Add("LENGUA INGLESA");
            //cboCarrera.Items.Add("MECATRONICA");
            //cboCarrera.Items.Add("ENERGIAS RENOVABLES");
            //cboCarrera.Items.Add("NANOTECNOLOGIA");
            //cboCarrera.Items.Add("DESARROLLO DE NEGOCIOS");

            //cboGrado.DropDownStyle = ComboBoxStyle.DropDownList;
            //cboGrado.Items.Add("PRIMERO");
            //cboGrado.Items.Add("SEGUNDO");
            //cboGrado.Items.Add("TERCERO");
            //cboGrado.Items.Add("CUARTO");
            //cboGrado.Items.Add("QUINTO");
            //cboGrado.Items.Add("SEXTO");
        }

        private void Registar_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Matricula = txtMatricula.Text;
            Nombre = txtNombre.Text;
            ApellidoP = txtApellidoP.Text;
            ApellidoM = txtApellidoM.Text;
            Carrera = cboCarrera.SelectedItem.ToString();
            Grado = cboGrado.SelectedItem.ToString();
            Password1 = txtPassword1.Text;
            Password2 = txtPassword2.Text;
            Correo = txtCorreo.Text;

            Usuario u = new Usuario();
            u.Matricula = Matricula;
            u.Nombre = Nombre;
            u.Apellido1 = ApellidoP;
            u.Apellido2 = ApellidoM;
            u.Grado = Grado;
            u.Password1 = Password1;
            u.Password2 = Password2;
            u.Correo = Correo;
            string mensaje = BussinessLogicLayer.UsuarioBLL.Registrar(u);

            if (string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show("Registro Exitoso");
            }
            else
            {
                MessageBox.Show(mensaje);
            }

        }

        private void cboCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
