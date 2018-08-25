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
    public partial class ListaNotas : Form
    {
        public ListaNotas()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var listaProf = (from a in BL.clNota._Instancia.ListaNota().AsEnumerable()
                             join a2 in BL.clEstudiante._Instancia.ListaEstudiantes().AsEnumerable()
                             on a.ID_Estudiante equals a2.Cedula
                             join a3 in BL.clGrado._Instancia.ListaGrado().AsEnumerable()
                             on a2.ID_Grado equals a3.ID_Grado
                             join a4 in BL.clMateria._Instancia.ListaMateria().AsEnumerable()
                             on a.ID_Materia equals a4.ID_Materia
                             where a.ID_Estudiante == Convert.ToInt32(txtCedula.Value)
                             select new
                             {
                                 a2.Nombre,
                                 a2.Apellido,
                                 a3.Grado,
                                 a4.NombreMateria,
                                 a.PrimerParcial,
                                 a.SegundoParcial,
                                 a.TercerParcial,
                                 a.TrabajoCotidiano,
                                 a.Tareas
                             }
                 ).ToList();
            dgvListaNota.DataSource = listaProf;
        }

        private void btn_MostrarProfesor_Click(object sender, EventArgs e)
        {

        }


    }
}
