using System;

namespace Metodos_Numericos_En_CSharp
{
    class Diferenciacion_Numerica
    {
        public void DiferenciacionNumerica()
        {
            Console.WriteLine("-----------------------");

            int cantidad = 11;//Cantidad de elementos que vamos a tener.

            double h = 0.1;// la distancia o tamaño que tenemos por cada elemento.

            //Aquí Guardamos nuestra tabla
            double[] y = new double[cantidad];

            //Aquí Guardamos la derivada
            double[] derivada = new double[cantidad];

            double paso = 0.1; //Que tanto avanzamos en cada paso al crear la tabla.

            double x = 0; //Que tanto avanzamos cada paso al crear la tabla.

            Console.WriteLine("\r\nx\tf(x)");//Encabezado

            //Creamos la tabla.
            for (int n = 0; n < cantidad; n++)//recorrido de 1 en 1.
            {
                y[n] = Funcion(x);
                Console.WriteLine("{0:N1}\t{1:N4}", x, y[n]);
                x += paso;
            }

            //Calculamos la derivada.
            for (int n = 1; n < cantidad - 1; n++)
            {
                derivada[n] = (y[n + 1] - y[n - 1]) / (2 * h);
            }

            //Funciona bien pero no podemos calcular la derivada de 0 y 1.
            Console.WriteLine("\r\nx\tDerivada");
            for (int n = 1; n < cantidad - 1; n++)
            {
                Console.WriteLine("{0:N1}\t{1:N4}", n * h, derivada[n]);
            }

            derivada[10] = (3 * y[10] - 4 * y[9] + y[8]) / (2 * h);

            Console.WriteLine("\r\nx\tDerivada");
            for (int n = 1; n < cantidad; n++)
            {
                Console.WriteLine("{0:N1}\t{1:N4}", n * h, derivada[n]);
            }

            static double Funcion(double x)
            {
                return Math.Sin(x);
            }
        }
    }
}
