using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{

    public enum Meses
    {
        Enero,
        Febrero=2,
        Marzo,
        Abril,
        Mayo,
        Junio,
        Julio,
        Agosto,
        Setiembre,
        Octubre,
        Noviembre,
        Diciembre
    };

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Es actual "+ Meses.Febrero);
           
            Console.ReadKey();
        }
    }
}
