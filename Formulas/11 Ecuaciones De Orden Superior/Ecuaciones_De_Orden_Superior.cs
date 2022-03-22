using System;

namespace Metodos_Numericos_En_CSharp
{
    class Ecuaciones_De_Orden_Superior
    {
        public void EcuacionesDeOrdenSuperior()
        {
            double h = 0.01;
            double y1 = 0.0;
            double y2 = 1.0;
            double x = 0;

            Console.WriteLine("x\ty2\tcos(x)");
            for (int i = 0; i <= 10; i++)
            {
                //Mostramos valores
                Console.WriteLine("{0:0.######}\t{1:0.######}\t{2:0}.######", x, y2, Math.Cos(x));

                //Calculamos el valor
                y1 += h * F1(x, y1, y2);
                y2 += h * F2(x, y1, y2);
                x += h;
            }
        }

        // Estos Metodós reprensentan a las funciones
        static double F2(double x, double y1, double y2)
        {
            return y2;
        }

        static double F1(double x, double y1, double y2)
        {
            return -y1;
        }
    }
}
