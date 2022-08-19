using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            int comparacion = 0;
            String nombre = "Juan";


            comparacion = String.Compare("k", nombre);

            if (comparacion==0)
            {
                Console.WriteLine("los nombres son iguales");

            }
            else
            {
                Console.WriteLine("los nombres son diferentes");
            }

            
            Console.ReadKey();

        }
    }
}
