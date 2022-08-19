using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_array
{
    class Program
    {

        public struct Agenda
        {

            public string Nombre;
            public int Edad;
            public string Telefono;

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Nombre: {0}, Edad: {1},Telefono: {2}", Nombre, Edad, Telefono);
                return (sb.ToString());
            }
        }
        static void Main(string[] args)
        {
            Agenda[] amigos=new Agenda[5];
            amigos[1].Edad = 25;
            amigos[1].Nombre = "Juan";
            amigos[1].Telefono = "(555) 123-456";

            Console.WriteLine(amigos[1].ToString());

            Console.ReadKey();


        }
    }
}
