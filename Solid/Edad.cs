using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public static class Edad
    { 
        public static int Calcular(DateTime fechaNacimiento)
        {
            return DateTime.Now.Year - fechaNacimiento.Year;
        }
    }
}
