using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public class Salario

    {

        public decimal Calcular(Empleado empleado)
        {
            switch (empleado.Categoria)
            {
                case Categoria.Cajero:
                    return new SalarioCajero().Calcular();
                case Categoria.Vendedor:
                    return new SalarioVendedor().Calcular();
                case Categoria.Gerente:
                    return new SalarioGerente().Calcular();
                case Categoria.Cadete:
                    return new SalarioCadete().Calcular();
                default: return 0;

            }
        }

         

    }
}
