using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class CTelevisor:IProducto
        //Indicamos q CTelevisor impelmenta a IProducto

    {
        double costo;
         double impuesto;

         private string descripcion;

         //Metodos propios
         //Constructor
         public CTelevisor()
         {
             costo = 400.0;
             descripcion = "Televisor pantalla plana";
         }

         public void ColocarCosto(double nCosto)
         {
             costo = nCosto;
         }
         //metodos a implementar debido al interfaz
         public void CalculaImpuesto(double imp)
         {
             //caculamos impuesto
             impuesto = costo * imp;
         }

         public void MuestraInformacion()
         {
             //mostramos la informacion necesaria

             Console.WriteLine("---Producto televisor");
             Console.WriteLine(descripcion);
             Console.WriteLine("Costo{0},Impuesto{1}",costo,impuesto);
         }

    }
}
