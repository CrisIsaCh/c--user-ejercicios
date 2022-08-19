using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class CTelevisor
    {
        private double costo;
        private double impuesto;
        private string descripcion;

        //motodos propios

        //cpnstructor

        public CTelevisor(string desc,double pcosto)
        {
            //inicializamos los datos

            costo = pcosto;
            descripcion = desc;

        }

        public void ColocarCosto(double nCosto)
        {
            //assignamos el nuevo costo
            costo = nCosto;
        }

        public void CalcularImpuesto(double imp)
        {
            //Calculamos el impuesto
            impuesto = costo * imp;
        }

        public void MuestraInformacion()
        {
            //M,ostreamos la info necesaria

            Console.WriteLine("--- Producto televisor");
            Console.WriteLine(descripcion);
            Console.WriteLine("Costo {0},Impuesto {1}",costo,impuesto);
        }
    
        
    }
    
}
