using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class CTiendaTelevisor
    {
        //datos

        private ArrayList misTelevisores=new ArrayList();

        public CTiendaTelevisor()
        {
            //inicializamos el arreglo interno con datos
            misTelevisores.Add(new CTelevisor("Plama", 1700.00));
            misTelevisores.Add(new CTelevisor("Led", 2300.00));
            misTelevisores.Add(new CTelevisor("Pantalla Plana", 800.33));
        }
        //CReamos el Indexer


    }
}
