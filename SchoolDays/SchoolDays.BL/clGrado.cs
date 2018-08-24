using SchoolDays.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SchoolDays.BL
{
    public class clGrado : IGrado<Grados>
    {
        #region Singelton  

        private static clGrado Instancia;

        public static clGrado _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new clGrado();
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


        public List<Grados> ListaGrado()
        {
            List<Grados> listaGrados = new List<Grados>();

            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    listaGrados = DATA.clGrado._Instancia.ListarGrados();
                    scope.Complete();
                }
                return listaGrados;

            }
            catch (Exception ee)
            {

                throw;
            }
        }

    }
}
