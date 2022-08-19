using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        public struct Agenda
        {
            public string Nombre;
            public int Edad;
            public string Telefono;


            //-------------------CONSTRUCTOR-----------//
            public Agenda(string pNombre, int pEdad, string ptTelefono)
            {
                Nombre = pNombre;
                Edad = pEdad;
                Telefono = ptTelefono;

            }

            public override string ToString()
            {
                StringBuilder sb=new StringBuilder();
                sb.AppendFormat("Nombre: {0}, Edad:{1}, Telefono:{2}", Nombre, Edad, Telefono);
                return (sb.ToString());

            }
        }



        static void Main(string[] args)
        {

            Agenda amigo =new Agenda("Juan",25,"(555) 123-456");
            Console.WriteLine(amigo.ToString());






            Console.ReadKey();
        }
    }
}
