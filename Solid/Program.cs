using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaDeEmpleados = new List<Empleado>();
            listaDeEmpleados.Add(new Empleado{Apellido = "Daud", Nombre = "Crsitian", FechadeNAcimiento = new DateTime(1977,06,13), Categoria = Categoria.Vendedor});
            listaDeEmpleados.Add(new Empleado
            {
                Apellido = "Cahilke",
                Nombre = "sergio",
                FechadeNAcimiento = new DateTime(2000, 11, 13),
                Categoria = Categoria.Gerente
            });
            listaDeEmpleados.Add(new Empleado
            {
                Apellido = "Rodriguez",
                Nombre = "Juan",
                FechadeNAcimiento = new DateTime(1984, 09, 21),
                Categoria = Categoria.Cajero
            }); 
            listaDeEmpleados.Add(new Empleado
            {
                Apellido = "Cuello",
                Nombre = "agostina",
                FechadeNAcimiento = new DateTime(1990 , 09, 21),
                Categoria = Categoria.Cadete
            });

            foreach (var empleado in listaDeEmpleados)
            {       
                Console.WriteLine($"{empleado.Apellido} {empleado.Nombre} - Sueldo: {empleado.Sueldo} - Edad:{empleado.Edad}" );
                
            }

            Console.ReadKey();

        }
    }
}
