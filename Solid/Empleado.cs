using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public class Empleado
    {
        private SalarioServicio _salario;

        public Empleado()
        {
            _salario=new SalarioServicio();
        }
        public string Apellido { get; set; }
        public string Nombre  { get; set; }

        public DateTime FechadeNAcimiento { get; set; }
        public Categoria Categoria { get; set; }
        public int Edad => Solid.Edad.Calcular(FechadeNAcimiento);
        public decimal Sueldo => _salario.Calcular(this);

      
        
    }
}
