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
    public partial class ModificarProfesor : Form
    {
        private DATA.Profesor objeto;

        public ModificarProfesor()
        {
            InitializeComponent();
        }

        #region Botones

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (buscarID(Convert.ToInt32(txtCedula.Value)))
            {
                ActivarTextBox();
                LlenarTxt(Convert.ToInt32(txtCedula.Value));
            }
            else
            {
                MessageBox.Show("No existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                ObtenerValores();
                BL.clProfesor._Instancia.Actualizar(objeto);
                DesactivarTXT();
                MessageBox.Show("Profesor Modificado", "Profesor", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        #region Metodos

        private bool buscarID(int cedula)
        {
            using (SchoolDaysEntities entities = new SchoolDaysEntities())
            {

                if (entities.Profesor.Any(x => x.Cedula == cedula))
                {
                    return true;
                }
                return false;
            }


        }

        private void ActivarTextBox()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtNumeroCelular.Enabled = true;
            txtMateria.Enabled = true;
            txtSalario.Enabled = true;
            txtHorario.Enabled = true;
            txtNumeroHogar.Enabled = true;
            txtCorreo.Enabled = true;
            txtDireccionHogar.Enabled = true;
            btnModificar.Enabled = true;
        }

        private void DesactivarTXT()
        {
            txtCedula.Value = 0;
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtNumeroCelular.Value = 0;
            txtCorreo.Text = "";
            txtDireccionHogar.Text = "";
            txtMateria.Text = "";
            txtSalario.Text = "";
            txtHorario.Text = "";
            txtNumeroHogar.Value = 0;
            txtCorreo.Text = "";
            txtDireccionHogar.Text = "";

            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtNumeroCelular.Enabled = false;
            txtMateria.Enabled = false;
            txtSalario.Enabled = false;
            txtHorario.Enabled = false;
            txtNumeroHogar.Enabled = false;
            txtCorreo.Enabled = false;
            txtDireccionHogar.Enabled = false;
            btnModificar.Enabled = false;


        }

        private void LlenarTxt(int cedula)
        {
            var profesor = (from a in BL.clProfesor._Instancia.ListaProfesor()
                            where a.Cedula == cedula
                            select new
                            {
                                a.Nombre,
                                a.Apellido,
                                a.Telefono_Hogar,
                                a.Celular,
                                a.DireccionHogar,
                                a.ID_Materia,
                                a.ID_Salario,
                                a.ID_Horario,
                                a.Correo
                            }
            ).FirstOrDefault();

            txtNombre.Text = profesor.Nombre;
            txtApellido.Text = profesor.Apellido;
            txtNumeroHogar.Value = profesor.Telefono_Hogar;
            txtNumeroCelular.Value = profesor.Celular;
            txtDireccionHogar.Text = profesor.DireccionHogar;
            txtMateria.Text = IDMateriaLlenar(Convert.ToString(profesor.ID_Materia));
            txtSalario.Text = IdSalarioProfesorLlenar(profesor.ID_Salario);
            txtHorario.Text = IdHorarioLlenar(profesor.ID_Horario);
            txtCorreo.Text = profesor.Correo;

        }

        private void ObtenerValores()
        {
            objeto = new DATA.Profesor();
            objeto.Cedula = Convert.ToInt32(txtCedula.Value);
            objeto.Nombre = txtNombre.Text;
            objeto.Apellido = txtApellido.Text;
            objeto.Telefono_Hogar = Convert.ToInt32(txtNumeroHogar.Value);
            objeto.Celular = Convert.ToInt32(txtNumeroCelular.Value);
            objeto.DireccionHogar = txtDireccionHogar.Text;
            objeto.ID_Materia = IDMateria(txtMateria.Text);
            objeto.ID_Salario = IdSalarioProfesor(txtSalario.Text);
            objeto.ID_Horario = IdHorario(txtHorario.Text);
            objeto.Correo = txtCorreo.Text;
        }

        #endregion

        #region Metodos para obtener IDs

        private string IDMateriaLlenar(string materia)
        {
            if (materia.Equals("1"))
            {
                return "Matematicas";
            }
            else if (materia.Equals("2"))
            {
                return "Sociales";
            }
            else if (materia.Equals("3"))
            {
                return "Español";
            }
            return "Ciencias";
        }

        private string IdSalarioProfesorLlenar(int? salario)
        {
            if (salario.Equals(1))
            {
                return "Profesor nuevo";
            }
            else if (salario.Equals(3))
            {
                return "Profesor con experiencia";
            }
            return "Profesor Experto";
        }

        private string IdHorarioLlenar(int? horario)
        {
            if (horario.Equals(3))
            {
                return "Mañana";
            }
            else if (horario.Equals(4))
            {
                return "Tarde";
            }

            return "Turno Completo";
        }

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
