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
    public partial class ListaAlumnos : Form
    {
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

        #region Metodos

        private void CargarGrid()
        {
            var query = (from a in SchoolDays.BL.clEstudiante._Instancia.ListaEstudiantes().AsReadOnly()
                         select new {a.Cedula, a.Nombre, a.Apellido, a.Nombre_Papa,a.Numero_Papa,a.Nombre_Mama,a.Numero_Mama}
                        ).ToList();
            //dgvData.DataSource = Fidelitas.BS.clFerreteria._Instancia.Get();
            dgvListaAlumnos.DataSource = query;

        }
        #endregion
    }
}
