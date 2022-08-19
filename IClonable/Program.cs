using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClonable
{
    class Program
    {
        static void Main(string[] args)
        {

            //ejemplo con objetos que no se an clonado
            CTelevisor miTV =new CTelevisor();
            CTelevisor tuTV = miTV;

            //Aqui pensamos q hiciemos el clonado
            //vemos los dos objetos
            Console.WriteLine("objetos sin ningn cambio \n");
            miTV.MuestraInformacion();
            tuTV.MuestraInformacion();

            //modificamos un objeto
            tuTV.ColocarCosto(1300.80);
            //vemos los dos objtos
            Console.WriteLine("\nObjetos despues del cambio \n");
            miTV.MuestraInformacion();
            tuTV.MuestraInformacion();


            //lo mismo pero con calses que implementam a ICloneable
            CRadio miRadio =new CRadio();

            //Cloanmos el objeto
            CRadio tuRadio = (CRadio)miRadio.Clone();

            //vemos los dos objeotos 
            Console.WriteLine("\n ---Radios----");

            Console.WriteLine("\nObjetos sin ningun cambio \n");
            miRadio.MuestraInformacion();
            tuRadio.MuestraInformacion();
            //modificamos el objeto

            tuRadio.ColocarCosto(800.50);
            //vemos los dos objetos

            Console.WriteLine("\nObjetos despues del cambio \n");

            miRadio.MuestraInformacion();
            tuRadio.MuestraInformacion();


            Console.ReadKey();

        }
    }
}
