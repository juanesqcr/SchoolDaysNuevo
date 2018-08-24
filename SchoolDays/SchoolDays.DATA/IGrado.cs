using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDays.DATA
{
    public interface IGrado<Grado>
    {
        List<Grado> ListarGrados();
    }
}
