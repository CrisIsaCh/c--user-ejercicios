using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras
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
                StringBuilder sb= new StringBuilder();
                sb.AppendFormat("Nombre: {0}, Edad: {1},Telefono: {2}", Nombre, Edad, Telefono);
                return (sb.ToString());
            }
        }

        static void Main(string[] args)
        {

            Agenda amigo=new Agenda();

            Agenda amigo1, amigo2, amigo3;

            Agenda[] amigos = new Agenda[15];
            Agenda[] clientes = new Agenda[5];

            amigo.Nombre = "Cristian";
            clientes[1].Nombre = "Ignacio";

            amigo.Edad = 25;

           if (amigo.Edad>18)
            {
                string diasVividos = "";

                diasVividos =Convert.ToString(amigo.Edad * 365);
                Console.WriteLine("el nombre es:{0} y tiene vivido :{1} dias vividos",amigo.Nombre,diasVividos);

                
            }
          Console.WriteLine(amigo.ToString());
            Console.ReadKey();

        }


       

    }




}

        
    
