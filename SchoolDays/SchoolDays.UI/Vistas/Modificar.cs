using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolDays.UI.Vistas
{
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (true)
            {
                txtGrado.Enabled = true;
                txtNumeroHogar.Enabled = true;
                txtCorreo.Enabled = true;
                txtDireccionHogar.Enabled = true;
                txtNumeroPapa.Enabled = true;
                txtNumeroMama.Enabled = true;
                txtOtroCorreo.Enabled = true;
                txtOtro.Enabled = true;
            }
            else
            {
                MessageBox.Show("No existe","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreEstudiante_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtApellidoAlumno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
