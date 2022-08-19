using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc_
{
    public class Cliente : Persona
    {

        public string ApyNom => $"{Apellido} {Nombre}";

    }
}
