using System;

namespace Metodos_Numericos_En_CSharp
{
    class Regla_De_Simpson
    {
        public void ReglaDeSimpson()
        {
            Console.WriteLine("-------------------------------------");
            int particiones;

            double a;
            double b;
            double h;
            double s;
            double s1;
            double s2 = 0;
            double s3 = 0;

            //Pedimos el valor de A.
            Console.WriteLine("Dame el valor de a");
            a = Convert.ToDouble(Console.ReadLine());

            //Pedimos el valor de B.
            Console.WriteLine("Dame el valor de b");
            b = Convert.ToDouble(Console.ReadLine());

            //Pedimos el valor de la particiones
            Console.WriteLine("Dame el valor de la particiones");
            particiones = Convert.ToInt32(Console.ReadLine());

            //Verficamos que sea par.
            if (particiones % 2 != 0)
                particiones++;

            h = (b - a) / (2.0 * particiones);

            s1 = (Funcion(a) + Funcion(b));

            for (int i = 1; i < 2 * particiones; i += 2)
                s2 += Funcion(a + i * h);

            for (int i = 1; i < 2 * particiones; i += 2)
                s3 += Funcion(a + i * h);

            s = (h / 3.0) * (s1 + 4.0 * s2 + 2.0 * s3);

            Console.WriteLine("El resultado es {0}", s);
        }

        public static double Funcion(double x)
        {
            return 4.0 / (1 + x * x);
        }
    }
}


