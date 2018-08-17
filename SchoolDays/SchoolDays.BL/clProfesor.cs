using SchoolDays.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SchoolDays.BL
{

    public class clProfesor : IProfesor<Profesor>
    {
        #region Singelton  

        private static clProfesor Instancia;

        public static clProfesor _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new clProfesor();
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

        public void Actualizar(Profesor profesor)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DATA.clProfesor._Instancia.Actualizar(profesor);
                    scope.Complete();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Eliminar(Profesor profesor)
        {
            throw new NotImplementedException();
        }

        public void Insertar(Profesor profesor)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DATA.clProfesor._Instancia.Insertar(profesor);
                    scope.Complete();
                }
            }
            catch (Exception)
            {

            }
        }

        public List<Profesor> ListaProfesor()
        {
            List<Profesor> listaEstudiante = new List<Profesor>();

            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    listaEstudiante = DATA.clProfesor._Instancia.ListaProfesor();
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
