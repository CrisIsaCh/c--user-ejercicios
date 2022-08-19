using System;

namespace Arreglo_Jagged
{
    class Program
    {
        static void Main(string[] args)
        {

            int cantidad = 0;
            int salones = 0;
            int n = 0;
            int m = 0;
            string valor = "";

            //variables promedio
            float suma = 0.0f;
            float promedio = 0.0f;
            float minima = 10.0f;
            float maxima = 0.0f;

            //pedimos los salones

            Console.WriteLine(" Dame la cantidad de salones");

            valor = Console.ReadLine();
            salones = Convert.ToInt32(valor);

            //creamos el arreglo
            float [][] calif =new float[salones][];

            //pedimos los alumnos por salon

            for (int i = 0; i < salones; i++)
            {
                Console.WriteLine("Dame la cantidad de alumnos pra el salon {0}",i);
                valor = Console.ReadLine();
                cantidad = Convert.ToInt32(valor);

                //instanciamos el arreglo 
                calif[i]=new float[cantidad];

            }

            //cápturamos la informacion
            for (int i = 0; i < salones; i++)
            {
                Console.WriteLine("SAlon {0}",i);
                for (int j = 0; j < calif[i].GetLength(0); j++)
                {
                    Console.Write("Dame la calificaion");
                    valor = Console.ReadLine();
                    calif[i][j] = Convert.ToSingle(valor);

                }
            }


            //desplegamos la informacion
            Console.WriteLine("----Informacion----");
            for (int i = 0; i < salones; i++)
            {
                Console.WriteLine("SAlon {0}",i);
                for (int j = 0; j < calif[i].GetLength(0); j++)
                {
                    Console.WriteLine("el alumno {0} tiene {1}", j,calif[i][j]);
                }
            
                
            }

            Console.ReadKey();




        }
    }
}
