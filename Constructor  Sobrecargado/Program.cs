using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor__Sobrecargado
{
    class Program
    {

        public struct Agenda
        {
            public string Nombre;
            public int Edad;
            public string Telefono;


            public Agenda(string pNombre, int pEdad, string pTelefono)
            {
                Nombre = pNombre;
                Edad = pEdad;
                if (pTelefono.Length>8)
                {
                    Telefono = pTelefono;
                }
                else
                {
                    Telefono = "telefono no valido";

                }
            }

            public Agenda(string pNombre, int pEdad)
            {
                Nombre = pNombre;
                Edad = pEdad;
                Telefono = "Sin telefono";
            }

            public Agenda(string pNombre)
            {
                Nombre = pNombre;
                Console.WriteLine("Dame la edad");
                Edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("dame el telefono");
                Telefono = Console.ReadLine();
                if (Telefono.Length<8)
                {
                    Telefono = "Sin telefono";
                }
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Nombre: {0}, Edad:{1}, Telefono:{2}", Nombre, Edad, Telefono);
                return (sb.ToString());

            }
        }
        static void Main(string[] args)
        {

            Agenda amigo =new Agenda("juan",25,"(555) 123-456");
            Agenda amigo1 = new Agenda("Pedro", 32, "(555) ");
            Agenda amigo2 = new Agenda("Luis", 28);
            Agenda amigo3 = new Agenda("Maria");


            Console.WriteLine(amigo.ToString());
            Console.WriteLine(amigo1.ToString());
            Console.WriteLine(amigo2.ToString());
            Console.WriteLine(amigo3.ToString());
            Console.ReadKey();
        }
    }
}
