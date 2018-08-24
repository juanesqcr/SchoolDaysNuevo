using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDays.DATA
{
    public interface IEstudiante<Estudiante>
    {
        void Insertar(Estudiante estudiante);

        List<Estudiante> ListaEstudiantes();

        void Eliminar(Estudiante estudiante);
        
        void Actualizar(Estudiante estudiante);
    }
}
