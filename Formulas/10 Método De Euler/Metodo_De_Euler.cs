using System;

namespace Metodos_Numericos_En_CSharp
{
    class Metodo_De_Euler
    {
        public void MetodoDeEuler()
        {
            double h = 0.1;
            double y = 1.0;
            double t = 0;

            Console.WriteLine("t\t Euler\t Exacto");
            for(int i = 0; i<=10; i++)
            {
                //Mostramos los valores.
                Console.WriteLine("{0:0.###}\t{1:0.###}\t{2:0}.###", t, y , Math.Exp(t));

                //Calculamos el valor de la función.
                y += h * Funcion(t, y);
                t += h;
            }
        }

        public static double Funcion(double t, double y)
        {
            return y;
        }
    }
}
