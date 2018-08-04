using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDays.DATA
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
                SchoolDaysEntities1 entities = new SchoolDaysEntities1();
                listaEstudiante = entities.Estudiante.ToList();
                entities.SaveChanges();
                return listaEstudiante;
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        #endregion

    }
}
