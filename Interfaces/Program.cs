using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            //la interfaz no puede imp´lementarse directamente
          //  IProducto miProducto = new IProducto();
            //instanciamos una clase que implementa la interfaz
            CTelevisor miTV=new CTelevisor();
            //invocamos a los comportamientos de la intrfaz
            miTV.CalculaImpuesto(0.16);
            miTV.MuestraInformacion();
            //invocamos un metodo propio de la clase

            miTV.ColocarCosto(567.82);
            miTV.CalculaImpuesto(0.16);
            miTV.MuestraInformacion();

            Console.ReadKey();


        }
    }
}
