using System;
using System.Text;

namespace Estructuras_Enlazadas
{
    class Program
    {
        public struct Direccion
        {
            public string Calle;
            public int Numero;

            public Direccion(string pCalle, int pNumero)
            {
                Calle = pCalle;
                Numero = pNumero;

            }

            public override string ToString()
            {
                StringBuilder sb=new StringBuilder();
                sb.AppendFormat(" Direccion:{0} #:{1}", Calle, Numero);
                return (sb.ToString());
            }
        }
        public struct Agenda
        {
            public string Nombre;
            public int Edad;
            public string Telefono;
            public Direccion Domicilio;

            public Agenda(string pNombre, int pEdad, string pTelefono, string pCalle, int pNumero)
            {

                Nombre = pNombre;
                Edad = pEdad;

                if (pTelefono.Length>8)
                {
                    Telefono = pTelefono;
                }
                else
                {
                    Telefono = " Telefono no valido";
                }
                Domicilio=new Direccion(pCalle,pNumero);
            }

            public Agenda(string pNombre, int pEdad)
            {
                Nombre = pNombre;
                Edad = pEdad;
                Telefono = " Sin Telefono";
                Domicilio = new Direccion(" Sin Direccion",0);
            }

            public Agenda(string pNombre)
            {
                Nombre = pNombre;
                Console.WriteLine("Dame la edad");
                Edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("dame el telefono");
                Telefono = Console.ReadLine();
                if (Telefono.Length < 8)
                {
                    Telefono = " Sin telefono";
                }
                Domicilio=new Direccion(" sin direccion",0);
            }
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Nombre: {0}, Edad:{1}, Telefono:{2}", Nombre, Edad, Telefono);

                sb.Append(Domicilio.ToString());
                return (sb.ToString());

            }
        }

        static void Main(string[] args)
        {

            Agenda amigo =new Agenda("Juan",25,"(388)-12345678","av.aguero",149);
            Agenda amigo1=new Agenda("Pedro",32,"(381)","calle diaz Velez",250);
            Agenda amigo2=new Agenda("Luis",28);
            Agenda amigo3=new Agenda("Maria");
            Console.WriteLine(amigo.ToString());
            Console.WriteLine(amigo1.ToString());
            Console.WriteLine(amigo2.ToString());
            Console.WriteLine(amigo3.ToString());

            Console.ReadKey();
        }
    }
}
