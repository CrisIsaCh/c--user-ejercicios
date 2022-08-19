using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClonable
{
    class CRadio:IProducto,ICloneable
    {
        private double costo;
        private double impuesto;
        private string descripcion;
        //metodos propios
        //Constructor
        public CRadio()
        {
            //inicializamos los datos
            costo=150.85;
            descripcion = "Radio onda corta";
        }

        public void ColocarCosto(double nCosto)
        {
            //asignamos el nuevo costo
            costo = nCosto;


        }

        //metodos a implementar debido a la interfaz IProducto
        public void  CalculaImpuesto(double imp)
        {

            //Calculamos el impuesto
            impuesto = costo * imp;

        }

        public void MuestraInformacion()
        {
            //mostrAMOS la informacion necesaria
            Console.WriteLine("---Producto radio");
            Console.WriteLine(descripcion);
            Console.WriteLine("Costo{0},Impuesto{1}",costo,impuesto);
        }
        //metodo a implementar debido al metodo de lainterfaz ICloneable
        public object Clone()
        {
            CRadio temp=new CRadio();
            temp.costo = costo;
            temp.descripcion = descripcion;
            temp.impuesto = impuesto;
            return temp;
        }
    }

    
}
