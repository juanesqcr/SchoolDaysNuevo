using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolDays.DATA;


namespace SchoolDays.UI.Vistas
{
    public partial class Profesor : Form
    {
        private DATA.Profesor objeto;

        public Profesor()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            ObtenerValores();
            BL.clProfesor._Instancia.Insertar(objeto);
            MessageBox.Show("Profesor Agregado", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        #region Metodos 

        private void ObtenerValores()
        {
            objeto = new DATA.Profesor();
            objeto.Nombre = txtNombre.Text;
            objeto.Apellido = txtApellido.Text;
            objeto.Cedula = Convert.ToInt32(txtCedula.Value);
            objeto.Telefono_Hogar = Convert.ToInt32(txtNumeroHogar.Value);
            objeto.Celular = Convert.ToInt32(txtNumeroCelular.Value);
            objeto.ID_Materia = IDMateria(txtMateria.Text);
            objeto.ID_Salario = IdSalarioProfesor(txtSalario.Text);
            objeto.ID_Horario = IdHorario(txtHorario.Text);
            objeto.Correo = txtCorreo.Text;
            objeto.DireccionHogar = txtDireccionHogar.Text;
        }

        #endregion

        #region Metodos para obtener IDs

        private int IDMateria(string materia)
        {
            if (materia.Equals("Matematicas"))
            {
                return 1;
            }
            else if (materia.Equals("Sociales"))
            {
                return 2;
            }
            else if (materia.Equals("Español"))
            {
                return 3;
            }
            return 4;
        }

        private int IdSalarioProfesor(string salario)
        {
            if (salario.Equals("Profesor nuevo"))
            {
                return 1;
            }
            else if (salario.Equals("Profesor con experiencia"))
            {
                return 3;
            }

            return 4;
        }

        private int IdHorario(string horario)
        {
            if (horario.Equals("Mañana"))
            {
                return 3;
            }
            else if (horario.Equals("Tarde"))
            {
                return 4;
            }

            return 5;
        }

        #endregion

    }
}