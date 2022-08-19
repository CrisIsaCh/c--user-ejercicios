using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz_unidimensional
{
    class Program
    {
        static void Main(string[] args)
        {

            int cantidad = 0;
            
            string valor = "";

            float suma = 0.0f;
            float promedio = 00.0f;


            float minimo =10.0f;
            float maxima = 0.0f;


            Console.WriteLine("dame la cantidad de alumno");
            valor = Console.ReadLine();
            cantidad = Convert.ToInt32(valor);

            float[] calif= new float[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write(" Dame la calificacion ");
                valor = Console.ReadLine();
                calif[i] = Convert.ToSingle(valor);

            }

            //promedio
            for (int n = 0; n < cantidad; n++)
            {
                suma += calif[n];

            }

            promedio = suma / cantidad;

            //calificacion minima
            for (int i = 0; i < cantidad; i++)
            {
                if (calif[i] < minimo)
                {
                    minimo = calif[i];
                }
                
            }
            //calif maxima

            for (int i = 0; i < cantidad; i++)
            {
                if (calif[i]>maxima)
                {
                    maxima = calif[i];
                }
            }

            Console.WriteLine("el promedio es {0}",promedio);
            Console.WriteLine(" la calificaion minima es {0}", minimo);
            Console.WriteLine("la calificacion maxima es:{0} ",maxima);

            Console.ReadKey();

        }
    }
}
