using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolDays.DATA
{
    public class ClEstudiante : IEstudiante<Estudiante>
    {

        #region Singelton  

        private static ClEstudiante Instancia;

        public static ClEstudiante _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new ClEstudiante();
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

        

        #region Metodos CRUD

        public void Actualizar(Estudiante estudiante)
        {
            try
            {
                using (SchoolDaysEntities entities = new SchoolDaysEntities())
                {
                    entities.Entry(estudiante).State = System.Data.Entity.EntityState.Modified;
                    entities.SaveChanges();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }


        public void Eliminar(Estudiante estudiante)
        {
            SchoolDaysEntities entities = new SchoolDaysEntities();
            var resultado = entities.Estudiante.Find(estudiante.Cedula);
            entities.Estudiante.Remove(resultado);
            entities.SaveChanges();
        }

        public void Insertar(Estudiante estudiante)
        {
            try
            {
                SchoolDaysEntities entities = new SchoolDaysEntities();
                entities.Estudiante.Add(estudiante);
                entities.SaveChanges();
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<Estudiante> ListaEstudiantes()
        {
            List<Estudiante> listaEstudiante = new List<Estudiante>();
            try
            {
                SchoolDaysEntities entities = new SchoolDaysEntities();
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
