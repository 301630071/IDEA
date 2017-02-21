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
    public partial class Registar : Form
    {
        static int Matricula;
        static string Nombre;
        static string ApellidoP;
        static string ApellidoM;
        static string Carrera;
        static string Grado;
        static string Correo;
        static string Password1;
        static string Password2;
        

        public Registar()
        {
            InitializeComponent();

            cboCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCarrera.Items.Add("TICSI");
            cboCarrera.Items.Add("QUIMICA");
            cboCarrera.Items.Add("LENGUA INGLESA");
            cboCarrera.Items.Add("MECATRONICA");
            cboCarrera.Items.Add("ENERGIAS RENOVABLES");
            cboCarrera.Items.Add("NANOTECNOLOGIA");
            cboCarrera.Items.Add("DESARROLLO DE NEGOCIOS");

            cboGrado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGrado.Items.Add("PRIMERO");
            cboGrado.Items.Add("SEGUNDO");
            cboGrado.Items.Add("TERCERO");
            cboGrado.Items.Add("CUARTO");
            cboGrado.Items.Add("QUINTO");
            cboGrado.Items.Add("SEXTO");
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
            Matricula = int.Parse(txtMatricula.Text);
            txtMatricula.Text = " ";
            Nombre = txtNombre.Text;
            txtNombre.Text = " ";
            ApellidoP = txtApellidoP.Text;
            txtApellidoP.Text = " ";
            ApellidoM = txtApellidoM.Text;
            txtApellidoM.Text = " ";
            Carrera = cboCarrera.SelectedItem.ToString();
            cboCarrera.SelectedIndex = -1;
            Grado = cboGrado.SelectedItem.ToString();
            cboGrado.SelectedIndex = -1;
            Password1 = txtPassword1.Text;
            txtPassword1.Text = "";
            Password2 = txtPassword2.Text;
            txtPassword2.Text = "";
            Correo = txtCorreo.Text;
            txtCorreo.Text = " ";



            MessageBox.Show(Matricula + "\n" + Nombre + "\n" + ApellidoP + "\n" + ApellidoM 
                 + "\n" + Carrera + "\n" + Grado + "\n" + Correo + "\n"+ Password1 + "\n" + Password2 );
            
        }
    }
}
