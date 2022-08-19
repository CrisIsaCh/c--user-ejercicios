using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Validado
{
    class Program
    {

        public struct Agenda
        {
            public string Nombre;
            public int Edad;
            public string Telefono;

            /// <summary>
            /// 
            /// </summary>
            /// <param name="pNombre"></param>
            /// <param name="pEdad"></param>
            /// <param name="ptTelefono"></param>
            //-------------------CONSTRUCTOR-----------//

            //--------se valida en el constrcutor Telefono
            public Agenda(string pNombre, int pEdad, string ptTelefono)
            {
                Nombre = pNombre;
                Edad = pEdad;

                if (ptTelefono.Length>8)
                {
                    Telefono = ptTelefono;
                }
                else
                {
                    Telefono = "Telefono no valido";
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

            Agenda amigo =new Agenda("juan",24,"(555) 123-4567");
            Agenda amigo1 =new Agenda("Pedro",32,"(555)");
            Agenda amigo3 = new Agenda("Pedro", 32, "(555)");
            Console.WriteLine(amigo.ToString());

            Console.WriteLine();
            Console.WriteLine(amigo1.ToString());
            Console.ReadKey();
        }
    }
}
