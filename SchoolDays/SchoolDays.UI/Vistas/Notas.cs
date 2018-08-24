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
    public partial class Notas : Form
    {
        private DATA.Notas objeto;

        public Notas()
        {
            InitializeComponent();
            LlenarCmbNombre();
            LlenarCmbMateria();
            LlenarCmbGrados();
            LlenarCmbNombreProfesor();
        }


        #region Metodos

        private void LlenarCmbNombre()
        {
            var listaNombres = from a
                               in BL.clEstudiante._Instancia.ListaEstudiantes().AsEnumerable()
                               select new
                               {
                                   a.Nombre
                               };
            txtNombreAlumno.DisplayMember = "Nombre";
            txtNombreAlumno.DataSource = listaNombres.ToList();

        }

        private void LlenarCmbMateria()
        {
            var listaNombres = from a
                               in BL.clMateria._Instancia.ListaMateria().AsEnumerable()
                               select new
                               {
                                   a.NombreMateria
                               };
            txtMateria.DisplayMember = "NombreMateria";
            txtMateria.DataSource = listaNombres.ToList();

        }

        private void LlenarCmbGrados()
        {
            var listaNombres = from a
                               in BL.clGrado._Instancia.ListaGrado().AsEnumerable()
                               select new
                               {
                                   a.Grado
                               };
            txtGrado.DisplayMember = "Grado";
            txtGrado.DataSource = listaNombres.ToList();

        }

        private void LlenarCmbNombreProfesor()
        {
            var listaNombres = from a
                               in BL.clProfesor._Instancia.ListaProfesor().AsEnumerable()
                               select new
                               {
                                   a.Nombre
                               };
            txtNombreProfesor.DisplayMember = "Nombre";
            txtNombreProfesor.DataSource = listaNombres.ToList();

        }

        private int ObtenerIDAlumno(string nombre)
        {
         
                var ID = (from a in BL.clEstudiante._Instancia.ListaEstudiantes().AsEnumerable()
                         where a.Nombre == nombre
                         select new
                         {
                             a.Cedula
                         }
                         ).FirstOrDefault();
            int s = ID.Cedula;

            return s;

        }

        private int ObtenerIDMateria(string nombre)
        {

            var ID = (from a in BL.clMateria._Instancia.ListaMateria().AsEnumerable()
                     where a.NombreMateria == nombre
                     select new
                     {
                         a.ID_Materia
                     }).FirstOrDefault();

            int id = ID.ID_Materia;
            return id;
        }

        private int ObtenerIDProfesor(string nombre)
        {

            var ID = (from a in BL.clProfesor._Instancia.ListaProfesor().AsEnumerable()
                     where a.Nombre == nombre
                     select new
                     {
                         a.Cedula
                     }).FirstOrDefault();

            int id = ID.Cedula;
            return id;
        }

        private int ObtenerIDGrado(string nombre)
        {

            var ID = (from a
                    in BL.clGrado._Instancia.ListaGrado().AsEnumerable()
                     where a.Grado == nombre
                     select new
                     {
                         a.ID_Grado
                     }).FirstOrDefault();
            int id = ID.ID_Grado;
            return id;
        }

        private void ObtenerValores()
        {
            objeto = new DATA.Notas();

            objeto.PrimerParcial = Convert.ToInt32(txtPrimerParcial.Value);
            objeto.SegundoParcial = Convert.ToInt32(txtSegundoParcial.Value);
            objeto.TercerParcial = Convert.ToInt32(txttercerParcial.Value);
            objeto.TrabajoCotidiano = Convert.ToInt32(txtTrabajoCotidiano.Value);
            objeto.Tareas = Convert.ToInt32(txtTareas.Value);
            objeto.ID_Estudiante = ObtenerIDAlumno(txtNombreAlumno.Text);
            objeto.ID_Materia = ObtenerIDMateria(txtMateria.Text);
            objeto.ID_Profesor = ObtenerIDProfesor(txtNombreProfesor.Text);
            objeto.ID_Grado = ObtenerIDGrado(txtGrado.Text);
        }

        #endregion

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ObtenerValores();
                BL.clNota._Instancia.Insertar(objeto);
                MessageBox.Show("Nota Agregada", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ee)
            {
                MessageBox.Show("No se pudo agregar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
