using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace IEnumerable
{
    class CTiendaTelevisor:System.Collections.IEnumerable
    {
        //guardamos los televisoreas de la tienda

        private CTelevisor[] televisores;

        public CTiendaTelevisor()
        {
            //el arreglo va a contener 3 teelevisores
            televisores = new CTelevisor[3];
            televisores[0]=new CTelevisor("Televisor LCD",1500.0);
            televisores[1] = new CTelevisor("Televisor Plasma", 1800.50);
            televisores[2] = new CTelevisor("Televisor LED", 2500.75);


        }

        //implementamos a Ienumerable
        //el metodo regresa unbojeto qeu implementa a IEnumerator
        //da el comportamientode un iterador


        public IEnumerator GetEnumerator()
        {
            return televisores.GetEnumerator();
        }
    }
}
