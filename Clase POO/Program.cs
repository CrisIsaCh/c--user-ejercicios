using System;
using System.Runtime.InteropServices;

namespace Clases_POO
{
    class Program
    {

        class cubo
        {
            public int lado;
            public int area;
            public int volumen;

            //metodo para calcular area
            public void CalcularArea()
            {
                area = (lado * lado) * 6;
            }

            //metodo para calcular el volumen

            public void CalcularVolumen()
            {
                volumen=lado*lado* lado;
            }
        
    }

        class prisma
        {
            private int ancho;
            private int alto;
            private int espesor;
            private int area;
            private int volumen;


            //definimos las propiedades
            public int Ancho
            {
                get
                {
                    return ancho;
                }
                set
                {
                    if (value<=0)
                    {
                        ancho = value;
                    }
                }
            }
            public int Alto
            {
                get
                {
                    return alto;
                }
                set
                {
                    if (value <= 0)
                    {
                        alto = value;
                    }
                }
            }
            public int Espesor
            {
                get
                {
                    return espesor;
                }
                set
                {
                    if (value <= 0)
                    {
                        espesor = value;
                    }
                }
            }
            public int Area
            {
                get
                {
                    return area;
                }
                
            }
            public int Volumen
            {
                get
                {
                    return volumen;
                }

            }

            //definimos los Constructores

            public prisma()
            {
                //Datos necesarion
                string valor = "";

                //pedimos los datos

                Console.WriteLine("Dame el ancho");
                valor = Console.ReadLine();
                ancho = Convert.ToInt32(valor);

                Console.WriteLine("Dame el alto");
                valor = Console.ReadLine();
                alto = Convert.ToInt32(valor);

                Console.WriteLine("dame el espesor");
                valor = Console.ReadLine();
                espesor = Convert.ToInt32(valor);


            }
            //version sobrecargada
            public prisma(int pancho, int palto, int pespesor)
            {
                //assignamos los valores
                ancho = pancho;
                alto = palto;
                espesor = pespesor;

            }
            //definimos metodos
            public void CalcularVolumen()
            {
                volumen = ancho * alto * espesor;
            }

            public void CalcularArea()
            {
                int a1 = 0;
                int a2 = 0;
                int a3 = 0;
                a1 = 2 * CalcularRectangulo(ancho, alto);
                a2 = 2 * CalcularRectangulo(ancho, espesor);
                a3 = 2 * CalcularRectangulo(ancho, espesor);

                area = a1 + a2 + a3;
            }

            private int CalcularRectangulo(int a, int b)
            {
                return (a * b);
            }
            public override string ToString()
            {
                string mensaje = "";
                mensaje += "Ancho " + ancho.ToString() + " Alto " + alto.ToString() + " Espesor " + espesor.ToString() +
                           " Volumen " + volumen.ToString();
                return mensaje;
            }

            public void ImprimeResultado()
            {
                Console.WriteLine("El area es {0},el volumen es {1}",area,volumen);
            }

        }

       

        static void Main(string[] args)
        {
            //istancioamos la clase cubo
            cubo miCubo = new cubo();
            cubo tuCubo = new cubo();

            //istanciamos clase prisma

            prisma miPrisma = new prisma();

            //instanciamos con la version sobrecargada
            prisma miPrisma2=new prisma(3,5,7);

            //asignamos el valor del lado
            miCubo.lado = 5;
            tuCubo.lado = 8;
            //invocamos los metodos
            miCubo.CalcularArea();
            tuCubo.CalcularArea();
            miCubo.CalcularVolumen();
            tuCubo.CalcularVolumen();
            

            //asignamos los valores al prisma 
            miPrisma.Ancho = 10;
            miPrisma.Alto = 3;
            miPrisma.Espesor = 5;

            //invocamos los metodos delprisma
             miPrisma.CalcularArea();
             miPrisma.CalcularVolumen();

             miPrisma2.CalcularArea();
             miPrisma2.CalcularVolumen();

            //desplegamos lsodatos
            Console.WriteLine("Area={0}, Volumen{1}", miCubo.area,miCubo.volumen);
            Console.WriteLine("Area={0}, Volumen{1}", tuCubo.area, tuCubo.volumen);

            

            
            Console.WriteLine("EEl volumen es {0}",miPrisma.Volumen);
            Console.WriteLine(miPrisma.ToString());
            miPrisma.ImprimeResultado();

            Console.WriteLine(miPrisma2.ToString());



            Console.ReadKey();




        }
    }
}
