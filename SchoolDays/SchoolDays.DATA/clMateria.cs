using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDays.DATA
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
            List<Materia> ListaMateria = new List<Materia>();
            try
            {
                SchoolDaysEntities entities = new SchoolDaysEntities();
                ListaMateria = entities.Materia.ToList();
                entities.SaveChanges();
                return ListaMateria;
            }
            catch (Exception ee)
            {


                throw;
            }
        }

    }
}
