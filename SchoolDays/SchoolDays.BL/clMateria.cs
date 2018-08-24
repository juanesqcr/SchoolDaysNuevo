using SchoolDays.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SchoolDays.BL
{
    public class clMateria : IMateria<Materia>
    {
        #region Singelton  

        private static clMateria Instancia;

        public static clMateria _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new clMateria();
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

        public List<Materia> ListaMateria()
        {
            List<Materia> listaMateria = new List<Materia>();

            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    listaMateria = DATA.clMateria._Instancia.ListaMateria();
                    scope.Complete();
                }
                return listaMateria;

            }
            catch (Exception ee)
            {

                throw;
            }
        }
    }
}
