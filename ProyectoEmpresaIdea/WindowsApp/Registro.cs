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
    }
}
