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
    public partial class RegistrarAlumno : Form
    {
        public RegistrarAlumno()
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
            cboCarrera.Items.Add("MANTENIMIENTO");

            cboGrado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGrado.Items.Add("PRIMERO");
            cboGrado.Items.Add("SEGUNDO");
            cboGrado.Items.Add("TERCERO");
            cboGrado.Items.Add("CUARTO");
            cboGrado.Items.Add("QUINTO");
            cboGrado.Items.Add("SEXTO");

            cboModalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboModalidad.Items.Add("BIS");
            cboModalidad.Items.Add("TRADICIONAL");

        }

        private void cboCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboGrado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboModalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidoP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtapellidoM_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
