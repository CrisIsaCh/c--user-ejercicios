using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciamos la tienda
            CTiendaTelevisor miTienda =new CTiendaTelevisor();

            //la tienda de televisdores no implementa a IEnumerable
            //no es posible recorrer sus contenidos con foreach

            foreach (CTelevisor tv in miTienda)
            {
                //calculamos impuesto
                tv.CalculaImpuesto(0.16);
                //mostramos la informacion
                tv.MuestraInformacion();
                
            }

            Console.ReadKey();

        }
    }
}
