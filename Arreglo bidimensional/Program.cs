using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglo_bidimensional
{
    class Program
    {
        static void Main(string[] args)
        {

            int cantidad = 0;
            int salones = 0;
            string valor = "";

            //valores de promedio
            float suma = 0.0f;
            float promedio = 0.0f;

            float minima = 10.0f;
            float maxima = 0.0f;

            Console.WriteLine(" dame la canidad de salones");
            valor = Console.ReadLine();
            salones = Convert.ToInt32(valor);

            Console.WriteLine(" dame la cantidad de alumnos por salon");
            valor = Console.ReadLine();
            cantidad = Convert.ToInt32(valor);

            float[,] calif = new float[salones,cantidad];

            for (int i = 0; i < salones; i++)
            {
                Console.WriteLine("Salon {0}", i);
                for (int j = 0; j < cantidad; j++)
                {
                    Console.WriteLine(" dame la calificacion  ");
                    valor = Console.ReadLine();
                    calif[i, j] = Convert.ToSingle(valor);

                }
            }

            //promedio
            for (int i = 0; i < salones; i++)
            {
                for (int j = 0; j < cantidad; j++)
                {
                    suma += calif[i, j];
                }
            }

            promedio = suma / (cantidad * salones);


            //calificaion minima
            for (int i = 0; i < salones; i++)
            {
                for (int j = 0; j < cantidad; j++)
                {
                    if (calif[i,j]< minima)
                    {
                        minima = calif[i, j];
                    }
                }
            }

            //calificacion maxima 

            for (int i = 0; i < salones; i++)
            {
                for (int j = 0; j < cantidad; j++)
                {
                    if (calif[i,j]>maxima)
                    {

                        maxima = calif[i, j];
                    }
                }
            }

            Console.WriteLine(" el promedio es {0}",promedio);
            Console.WriteLine("la calificacion minima es : {0}",minima);
            Console.WriteLine("la calificacion maxima es : {0}", maxima);

            Console.ReadKey();

        }
    }
}
