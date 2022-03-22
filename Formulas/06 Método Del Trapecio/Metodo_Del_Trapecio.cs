using System;

namespace Metodos_Numericos_En_CSharp
{
    class Metodo_Del_Trapecio
    {
        public void MetodoDelTrapecio()
        {
            Console.WriteLine("----------------------------------------");
            int particiones;

            double a;
            double b;

            double h;
            double s = 0;

            //Pedimos el valor de A.
            Console.WriteLine("Dame el valor de a");
            a = Convert.ToDouble(Console.ReadLine());

            //Pedimos el valor de B.
            Console.WriteLine("Dame el valor de b");
            b = Convert.ToDouble(Console.ReadLine());

            //Pedimos el valor de la particiones.
            Console.WriteLine("Dame el valor de la particiones");
            particiones = Convert.ToInt32(Console.ReadLine());

            //Calculamos el valor de h, la base del Trapecio.
            h = (b - a) / particiones;

            //Llevamos a cabo la sumatoria de la alturas.
            for (int n = 0; n < particiones; n++)
            {
                s += Funcion(a + n * h);
            }

            //Ahora obtenemos el area total.
            s = (h / 2) * (Funcion(a) + Funcion(b)) + (h * 2);

            Console.WriteLine("El resultado es {0}", s);
        }

        public static double Funcion(double x)
        {
            return 4.0 / (1 + x * x);
        }
    }
}


