using System;

namespace Metodos_Numericos_En_CSharp
{
    class Metodo_De_Diseccion
    {
        public void MetodoDeDiseccion()
        {
            Console.WriteLine("-------------------");
            double x1;
            double x2;
            double x3 = 0;

            int conteo = 0;
            double epsilion = 1.0e-10;

            //Pedimos el valor de x1.
            Console.WriteLine("Dame el valor de x1");
            x1 = Convert.ToDouble(Console.ReadLine());

            //Pedimos el valor de x2.
            Console.WriteLine("Dame el valor de x2");
            x2 = Convert.ToDouble(Console.ReadLine());

            //llevamos a cabo la bisección.
            while (!(Función(x3) == 0.0 && Math.Abs(x1 - x2) < epsilion))
            {
                x3 = (x1 + x2) / 2.0;

                if (Función(x1) * Función(x3) < 0)
                    x2 = x3;
                else x1 = x3;

                conteo++;
                Console.WriteLine("{0} {1}", conteo, x3);

                if (conteo > 100)
                    break;
            }
            Console.WriteLine("La iteraciones fueron {0}", conteo);
            Console.WriteLine("x = {0}", x1);
        }
        private static double Función(double x)
        {
            return (-4 * x * x * x) + (6 * x * x) + 2 * x;
        }
    }
}
