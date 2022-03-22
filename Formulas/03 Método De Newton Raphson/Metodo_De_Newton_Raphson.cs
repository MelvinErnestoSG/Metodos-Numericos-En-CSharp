using System;

namespace Metodos_Numericos_En_CSharp
{
    class Metodo_De_Newton_Raphson
    {
        public void MetodoDeNewtonRaphson()
        {
            Console.WriteLine("------------------------");
            double x1;
            double x2;
            int n;

            //Pedimos el valor de Inicial.
            Console.WriteLine("Dame el valor de inicial");
            x1 = Convert.ToDouble(Console.ReadLine());

            double epsilion = 1.0e-10;

            //verificamos que la derivada no sea igual a cero.

            if (Derivada(x1) == 0.0)
                Console.WriteLine("La derivada de x1 es cero");

            for (n = 0; n < 100; n++)
            {
                //calculamos x2
                x2 = NewtonRaphson(x1);

                //verificamos si ya estamos los suficientemente cerca.
                if (Math.Abs(x1 - x2) < epsilion)
                    break;

                //Actualizamos x1 para a cercarnos a la raiz.
                x1 = x2;
            }
            Console.WriteLine("La iteraciones fueron {0}", n);
            Console.WriteLine("x = {0}", x1);
        }

        private static double Funcion(double x)
        {
            return x * x - 2;
        }

        private static double Derivada(double x)
        {
            return 2 * x;
        }

        private static double NewtonRaphson(double x)
        {
            return x - Funcion(x) / Derivada(x);
        }
    }
}
