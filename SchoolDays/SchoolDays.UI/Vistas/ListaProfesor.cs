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
    public partial class ListaProfesor : Form
    {
        private DATA.Profesor objeto;

        public ListaProfesor()
        {
            InitializeComponent();
            CargaGrid();

        }

        #region botones

        private void btn_MostrarProfesor_Click(object sender, EventArgs e)
        {
            try
            {
                CargaGrid();
            }
            catch
            {
                MessageBox.Show
                    (
                    "El profesor ya existe o no ingreso un dato correcto", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                    );

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var listaProf = (from a in BL.clProfesor._Instancia.ListaProfesor().AsEnumerable()
                             where a.Cedula == Convert.ToInt32(txtCedula.Value)
                             select new
                             {
                                 a.Cedula,
                                 a.Nombre,
                                 a.Apellido,
                                 a.Telefono_Hogar,
                                 a.Celular,
                                 a.DireccionHogar,
                                 a.ID_Materia,
                                 a.ID_Horario,
                                 a.ID_Salario

                             }
                 ).ToList();
            dgvListaProfes.DataSource = listaProf;
        }
        #endregion

        #region Metodos

        private void CargaGrid()
        {

            var query = (from a in BL.clProfesor._Instancia.ListaProfesor().AsEnumerable()
                         select new
                         {

                             a.Cedula,
                             a.Nombre,
                             a.Apellido,
                             a.Telefono_Hogar,
                             a.Celular,
                             a.DireccionHogar,
                             a.ID_Materia,
                             a.ID_Horario,
                             a.ID_Salario

                         }
                         ).ToList();
            dgvListaProfes.DataSource = query;
        }

        #endregion

        #region metodos para ids

        private string BuscarMateria(int idMateria)
        {
            if (idMateria == 1)
            {
                return "Matematicas";
            }
            else if (idMateria == 2)
            {
                return "Sociales";
            }
            else if (idMateria == 3)
            {
                return "Español";
            }
            return "Ciencias";
        }

        #endregion


    }
}
