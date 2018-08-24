using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDays.BL
{
    public interface IProfesor<Profesor>
    {
        void Insertar(Profesor profesor);

        List<Profesor> ListaProfesor();

        void Eliminar(Profesor profesor);

        void Actualizar(Profesor profesor);
    }
}
