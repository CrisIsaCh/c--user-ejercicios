using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Enumeraciones
{
    class Program
    {

        enum semana
        {
            Lunes,
            Martes,
            Miercoles,
            Jueves,
            Viernes,
            Sabado,
            Domingo
        };

        enum colores
        {
            Rojo = 1,
            Verde,
            Azul,
            Amarillo
        };
        static void Main(string[] args)
        {

            int numerico = 0;
            //Creamos una variables de tipo semana

            semana miDia;
            //asignamos un valor
            miDia = semana.Lunes;

            //pasamos de enumercion a entero
            numerico = (int) miDia;

            //mostramos la informacion
            Console.WriteLine("El dia es {0} con valor {1}", miDia,numerico);

            //creamos una variable de coplor

            colores miColor = colores.Amarillo;

            //pasamos a numero entero
            numerico = (int) miColor;

            //mostramos la informacion
            Console.WriteLine("el color es {0} con valor {1}", miColor,numerico);

            Console.ReadKey();
        }
    }
}
