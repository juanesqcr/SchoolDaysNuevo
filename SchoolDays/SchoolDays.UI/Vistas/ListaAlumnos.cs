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
    public partial class ListaAlumnos : Form
    {

        private DATA.Estudiante objeto;

        public ListaAlumnos()
        {
            InitializeComponent();
        }

        private void dgvListaAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarGrid();
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ObtenerValores(true);

        }

        #region Metodos

        private void CargarGrid()
        {
            var query = (from a in SchoolDays.BL.clEstudiante._Instancia.ListaEstudiantes().AsEnumerable()
                         select new
                         {
                             a.Cedula,
                             a.Nombre,
                             a.Apellido,
                             a.Nombre_Papa,
                             a.Numero_Papa,
                             a.Nombre_Mama,
                             a.Numero_Mama,
                             a.Otros
                         }
                        ).ToList();
            dgvListaAlumnos.DataSource = query;

        }

        private void ObtenerValores(bool update)
        {
            objeto = new Estudiante();
            if (update)
            {
                objeto.Cedula = Convert.ToInt32(txtCedula.Value);
            }
        }

        #endregion

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var listaEstu = (from a in BL.clEstudiante._Instancia.ListaEstudiantes().AsEnumerable()
                             where a.Cedula == Convert.ToInt32(txtCedula.Value)
                             select new
                             {
                                 a.Cedula,
                                 a.Nombre,
                                 a.Apellido,
                                 a.Nombre_Papa,
                                 a.Numero_Papa,
                                 a.Nombre_Mama,
                                 a.Numero_Mama

                             }
                   ).ToList();

            dgvListaAlumnos.DataSource = listaEstu;
        }


    }
}
