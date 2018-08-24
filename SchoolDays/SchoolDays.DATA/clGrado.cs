using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDays.DATA
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

        public List<Grados> ListarGrados()
        {
            List<Grados> listaGrados = new List<Grados>();
            try
            {
                SchoolDaysEntities entities = new SchoolDaysEntities();
                listaGrados = entities.Grados.ToList();
                entities.SaveChanges();
                return listaGrados;
            }
            catch (Exception ee)
            {


                throw;
            }
        }
    }
}
