using SchoolDays.DATA;
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
    public partial class Alumnos : Form
    {
        private Estudiante objeto;

        public Alumnos()
        {
            InitializeComponent();
        }

        private void Alumnos_Load(object sender, EventArgs e)
        {

        }

        private void txtOtroCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ObtenerValores();
                BL.clEstudiante._Instancia.Insertar(objeto);
                MessageBox.Show("Estudiante Agregado", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ee)
            {
                MessageBox.Show("No se pudo agregar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Metodos

        private void ObtenerValores()
        {
            objeto = new Estudiante();
           
            objeto.Nombre = txtNombreEstudiante.Text;
            objeto.Apellido = txtApellidoAlumno.Text;
            objeto.Cedula = Convert.ToInt32(txtCedula.Value);
            if (txtGrado.Text == "1" || txtGrado.Text == "2" || txtGrado.Text == "3" || txtGrado.Text == "4" || txtGrado.Text == "5")
            {
                objeto.ID_Grado = Convert.ToInt32(txtGrado.Text) + 1;
            }
            else
            {
                objeto.ID_Grado = Convert.ToInt32(txtGrado.Text) + 2;
            }
            objeto.Telefono_Hogar = Convert.ToInt32(txtNumeroHogar.Value);
            objeto.Otros = txtDireccionHogar.Text;
            objeto.Nombre_Papa = txtNombrePapa.Text;
            objeto.Nombre_Mama = txtNombreMama.Text;
            objeto.Numero_Mama = Convert.ToInt32(txtNumeroMama.Value);
            objeto.Numero_Papa = Convert.ToInt32(txtNumeroPapa.Value);
            objeto.Correo = txtCorreo.Text;
            objeto.CorreoOtro = txtOtroCorreo.Text;

        }
        #endregion
    }
}
