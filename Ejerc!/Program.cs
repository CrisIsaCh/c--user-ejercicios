 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc_
{
    class Program
    {
        static void Main(string[] args)
        {

            var cliente = new Cliente
            {
                Apellido = "Daud",
                Nombre = " Cristian",
                Direccion = new Direccion
                {
                    Calle = "Rivadavia",
                    Numero = 1050
                },
                Dni = "26554558"
            };
            var cliente2 = new Cliente
            {
                Apellido = "Cuello",
                Nombre = " Agostina",
                Direccion = new Direccion
                {
                    Calle = "Rivadavia",
                    Numero = 1050,
                    Piso = "7",
                    Deparatamento = "H"
                },
                Dni = "453431322"
            };
            var cuentaCliente = new Cuenta
            {
                Cliente = cliente

            };

            var cuentaCliente2 = new Cuenta
            {
                Cliente = cliente2

            };
            cuentaCliente.Depositar(150);
            cuentaCliente.Extraer(50);
            Console.WriteLine(cuentaCliente.ToString() );
            cuentaCliente2.Depositar(500);
            cuentaCliente2.Extraer(50);
            Console.WriteLine(cuentaCliente2.ToString());

            var listaDeCuentas = new List<Cuenta>();

            listaDeCuentas.Add(cuentaCliente);
           
            listaDeCuentas.Add(cuentaCliente2);
            


            decimal saldoCuentas = 0m;
            Console.WriteLine($"TOTAL en Cuentas: {listaDeCuentas.Sum(x => x.Saldo)}");
            foreach (var listaDeCuenta in listaDeCuentas)
            {
                saldoCuentas += listaDeCuenta.Saldo;


            }
            Console.WriteLine($"TotAL en Cuentas: {saldoCuentas}");
            

            Console.ReadKey();

        }

    }
    
}
