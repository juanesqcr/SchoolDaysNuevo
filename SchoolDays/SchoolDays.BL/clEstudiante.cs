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
            set
            {
                if (Instancia == null)
                {
                    Instancia = value;
                }
            }
        }

        #endregion

        public void Actualizar(Estudiante estudiante)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    SchoolDays.DATA.ClEstudiante._Instancia.Actualizar(estudiante);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {
                
            }
        }

        public void Eliminar(Estudiante estudiante)
        {
            try
            {
                using(TransactionScope scope = new TransactionScope())
                {
                    DATA.ClEstudiante._Instancia.Eliminar(estudiante);
                    scope.Complete();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Insertar(Estudiante estudiante)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DATA.ClEstudiante._Instancia.Insertar(estudiante);
                    scope.Complete();
                }
            }
            catch (Exception)
            {

                throw;
            }


        }

        public List<Estudiante> ListaEstudiantes()
        {
            List<Estudiante> listaEstudiante = new List<Estudiante>();

            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    listaEstudiante = SchoolDays.DATA.ClEstudiante._Instancia.ListaEstudiantes();
                    scope.Complete();
                }
                return listaEstudiante;

            }
            catch (Exception ee)
            {

                throw;
            }
        }
    }
}
