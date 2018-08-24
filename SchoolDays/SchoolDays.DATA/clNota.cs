using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDays.DATA
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
                using (SchoolDaysEntities entities
                    = new SchoolDaysEntities())
                {
                    entities.Entry(nota).State
                        = System.Data.Entity.EntityState.Modified;
                    entities.SaveChanges();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Eliminar(Notas nota)
        {
            SchoolDaysEntities entities = new SchoolDaysEntities();
            var resultado = entities.Notas.Find(nota.ID_Nota);
            entities.Notas.Remove(resultado);
            entities.SaveChanges();
        }

        public void Insertar(Notas nota)
        {
            try
            {
                SchoolDaysEntities entities = new SchoolDaysEntities();
                entities.Notas.Add(nota);
                entities.SaveChanges();
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<Notas> ListaNota()
        {
            List<Notas> ListaNotas = new List<Notas>();
            try
            {
                SchoolDaysEntities entities = new SchoolDaysEntities();
                ListaNotas = entities.Notas.ToList();
                entities.SaveChanges();
                return ListaNotas;
            }
            catch (Exception ee)
            {


                throw;
            }
        }
    }
}
