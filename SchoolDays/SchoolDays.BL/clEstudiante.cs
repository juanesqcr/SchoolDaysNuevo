using SchoolDays.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;


namespace SchoolDays.BL
{
    public class clEstudiante : IEstudiante<Estudiante>
    {
        #region Singelton  

        private static clEstudiante Instancia;

        public static clEstudiante _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new clEstudiante();
                }
                return Instancia;
            }
        }

        #endregion

        public void Actualizar(Estudiante estudiante)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(Estudiante estudiante)
        {
            throw new NotImplementedException();
        }

        public void Insertar(Estudiante estudiante)
        {
            throw new NotImplementedException();
        }

        public List<Estudiante> ListaEstudiantes()
        {
            List<Estudiante> listaEstudiante = new List<Estudiante>();

            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    listaEstudiante = SchoolDays.DATA.clEstudiante._Instancia.ListaEstudiantes();
                    scope.Complete();
                }
                return listaEstudiante;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
