using SchoolDays.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SchoolDays.BL
{
    public class clNota : INota<Notas>
    {
        #region Singelton  

        private static clNota Instancia;

        public static clNota _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new clNota();
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

        public void Actualizar(Notas nota)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DATA.clNota._Instancia.Actualizar(nota);
                    scope.Complete();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Eliminar(Notas nota)
        {
            throw new NotImplementedException();
        }

        public void Insertar(Notas nota)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DATA.clNota._Instancia.Insertar(nota);
                    scope.Complete();
                }
            }
            catch (Exception)
            {

            }
        }

        public List<Notas> ListaNota()
        {
            List<Notas> listaEstudiante = new List<Notas>();

            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    listaEstudiante = DATA.clNota._Instancia.ListaNota();
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
