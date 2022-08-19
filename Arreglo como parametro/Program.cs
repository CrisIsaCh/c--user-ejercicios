using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglo_como_parametro
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros=new int[5];
            int n = 0;
            string valor = "";

            //pedimos los numeros
            for (int i = 0; i < 5; i++)
            {
                Console.Write("dame un numero :");
                valor = Console.ReadLine();
                numeros[i] = Convert.ToInt32(valor);

            }

            //invocAMOS A LA FUNCION
            Imprime(numeros);

            Console.ReadKey();



        }

        static void Imprime(int[] arreglo)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("el numero es {0}",arreglo[i]);
            }
        }

    }
}
