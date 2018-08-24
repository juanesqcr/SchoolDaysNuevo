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
    public partial class Modificar : Form
    {
        private Estudiante objeto;

        public Modificar()
        {
            InitializeComponent();
        }


      #region Botones

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            ObtenerValores();
            BL.clEstudiante._Instancia.Eliminar(objeto);
            DesactivarTXT();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                ObtenerValores();
                BL.clEstudiante._Instancia.Actualizar(objeto);
                DesactivarTXT();
                MessageBox.Show("Estudiante Modificado", "Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("Error","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

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

        #endregion

        #region Metodos

        private void ActivarTextBox()
        {
            txtGrado.Enabled = true;
            txtNumeroHogar.Enabled = true;
            txtCorreo.Enabled = true;
            txtDireccionHogar.Enabled = true;
            txtNumeroPapa.Enabled = true;
            txtNumeroMama.Enabled = true;
            txtOtroCorreo.Enabled = true;
            txtApellidoAlumno.Enabled = true;
            txtNombreEstudiante.Enabled = true;
            txtNombreMama.Enabled = true;
            txtNombrePapa.Enabled = true;
            btnModificar.Enabled = true;
            btn_eliminar.Enabled = true;
        }

        private void DesactivarTXT()
        {
            txtNombreEstudiante.Text = "";
            txtApellidoAlumno.Text = "";
            txtGrado.Value = 0;
            txtNumeroHogar.Value = 0;
            txtCorreo.Text = "";
            txtDireccionHogar.Text = "";
            txtOtroCorreo.Text = "";
            txtNombrePapa.Text = "";
            txtNumeroPapa.Value = 0;
            txtNombreMama.Text = "";
            txtNumeroMama.Value = 0;


            txtGrado.Enabled = false;
            txtNumeroHogar.Enabled = false;
            txtCorreo.Enabled = false;
            txtDireccionHogar.Enabled = false;
            txtNumeroPapa.Enabled = false;
            txtNumeroMama.Enabled = false;
            txtOtroCorreo.Enabled = false;
            txtApellidoAlumno.Enabled = false;
            txtNombreEstudiante.Enabled = false;
            txtNombreMama.Enabled = false;
            txtNombrePapa.Enabled = false;
            btnModificar.Enabled = false;
            btn_eliminar.Enabled = false;
        }

        private bool buscarID(int cedula)
        {
            using (SchoolDaysEntities entities = new SchoolDaysEntities())
            {

                if (entities.Estudiante.Any(x => x.Cedula == cedula))
                {
                    return true;
                }
                return false;
            }


        }

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

        private void LlenarTxt(int cedula)
        {
            var estudiante = (from a in BL.clEstudiante._Instancia.ListaEstudiantes()
                              where a.Cedula == cedula
                              select new
                              {
                                  a.Nombre,
                                  a.Apellido,
                                  a.Grados,
                                  a.Nombre_Papa,
                                  a.Correo,
                                  a.CorreoOtro,
                                  a.Numero_Papa,
                                  a.Nombre_Mama,
                                  a.Numero_Mama,
                                  a.Otros,
                                  a.ID_Grado,
                                  a.Telefono_Hogar


                              }
            ).FirstOrDefault();


            txtNombreEstudiante.Text = estudiante.Nombre;
            txtApellidoAlumno.Text = estudiante.Apellido;
            txtGrado.Value = Convert.ToInt32(estudiante.ID_Grado);
            txtNumeroHogar.Value = Convert.ToInt32(estudiante.Telefono_Hogar);
            txtCorreo.Text = estudiante.Correo;
            txtDireccionHogar.Text = estudiante.Otros;
            txtOtroCorreo.Text = estudiante.CorreoOtro;
            txtNombrePapa.Text = estudiante.Nombre_Papa;
            txtNumeroPapa.Value = Convert.ToInt32(estudiante.Numero_Papa);
            txtNombreMama.Text = estudiante.Nombre_Mama;
            txtNumeroMama.Value = Convert.ToInt32(estudiante.Numero_Mama);

        }

        #endregion


  


    }
}
