using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            int indice = 0;
            int cantidad = 0;

            //declaramos arraylist

            System.Collections.ArrayList datos = new System.Collections.ArrayList();

            //adicionamos valores al arraylist
            datos.Add(7);
            datos.Add(5);
            datos.Add(1);

            Console.WriteLine("tenemos inicialmente los datos:");
            Imprime(datos);

            //hacemos crecer el arraylist
            datos.Add(4);
            datos.Add(5);

            //obtenemos l indice 

            indice = datos.Add(10);

            Console.WriteLine("despues de hacerlo crecer:");

            

            Console.WriteLine("el ultimo elemento tiene el indice {0}",indice);

            Console.WriteLine("\n -----------");


            Imprime(datos);

            //imprimimos un elemenot en particular

            Console.WriteLine("El valor en el indice 2 es {0}", datos[2]);

            Console.WriteLine("\n -------------");

            //modificamos un dato

            datos[3] = 55;
            Console.WriteLine("dewspues de la modificacion:");
            Imprime(datos);

            //obtenemos la cantidad

            cantidad = datos.Count;
            Console.WriteLine("la cantidad de elementos es {0}",cantidad);
            Console.WriteLine("\n ----------");

            //insertamos un elemento

            datos.Insert(2,88);
            Console.WriteLine("despues de la insercion");
            Imprime((datos));


            //eliminamos elemento
            datos.RemoveAt(4);
            Console.WriteLine("despues de la eliminacion");
            Imprime(datos);

            //encontramos el indice donde se encuentra el primeer 5

            indice = datos.IndexOf(5);
            Console.WriteLine("el primer 5 se encuentra en {0}",indice);
            Console.WriteLine("\n ----------");

            Hashtable mitabla=new Hashtable();


            Console.ReadKey();
        }

        static void Imprime(System.Collections.ArrayList arreglo)
        {
            foreach (int n in arreglo)
            {
                Console.Write( "  {0},",n);

                
            }
            Console.WriteLine("\n-------------");

            
        }

    }
}
