using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDays.DATA
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

        #region CRUD

        public void Actualizar(Profesor profesor)
        {
            try
            {
                using (SchoolDaysEntities entities = new SchoolDaysEntities())
                {
                    entities.Entry(profesor).State = System.Data.Entity.EntityState.Modified;
                    entities.SaveChanges();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Eliminar(Profesor profesor)
        {
            SchoolDaysEntities entities = new SchoolDaysEntities();
            var resultado = entities.Profesor.Find(profesor.Cedula);
            entities.Profesor.Remove(resultado);
            entities.SaveChanges();
        }

        public void Insertar(Profesor profesor)
        {
            try
            {
                SchoolDaysEntities entities = new SchoolDaysEntities();
                entities.Profesor.Add(profesor);
                entities.SaveChanges();
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<Profesor> ListaProfesor()
        {
            List<Profesor> ListaProfesor = new List<Profesor>();
            try
            {
                SchoolDaysEntities entities = new SchoolDaysEntities();
                ListaProfesor = entities.Profesor.ToList();
                entities.SaveChanges();
                return ListaProfesor;
            }
            catch (Exception ee)
            {


                throw;
            }
        }

        #endregion

    }
}
