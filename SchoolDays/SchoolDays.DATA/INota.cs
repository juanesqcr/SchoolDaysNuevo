using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDays.DATA
{
    interface INota<Nota>
    {
        void Insertar(Nota nota);

        List<Nota> ListaNota();

        void Eliminar(Nota nota);

        void Actualizar(Nota nota);

    }
}