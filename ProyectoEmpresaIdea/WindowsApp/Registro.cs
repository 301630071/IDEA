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
        static int Grado;
        static string password1;
        static string password2;

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
            Matricula = Convert.ToInt32(txtMatricula.Text);
            txtMatricula.Text = " ";
            Nombre = txtNombre.Text;
            txtNombre.Text = " ";
            ApellidoP = txtApellidoP.Text;
            txtApellidoP.Text = " ";
            ApellidoM = txtApellidoM.Text;
            txtApellidoM.Text = " ";
            Carrera = cboCarrera.SelectedItem.ToString();
            cboCarrera.SelectedIndex = -1;
       
            MessageBox.Show(Matricula + "\n" + Nombre + "\n" + ApellidoP + "\n" + ApellidoM 
                 + "\n" + Carrera);
            
        }
    }
}
