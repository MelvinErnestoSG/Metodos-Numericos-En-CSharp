using System;

namespace Metodos_Numericos_En_CSharp
{
    class Errores_De_Precision
    {
        public void ErrorDePrecision()
        {
            Console.WriteLine("------------------");

            float sumatoria = 0;

            for (int n = 0; n < 10000; n++)
                sumatoria += 0.1f;

            //No obtenemos 1000.
            Console.WriteLine("1) Error De Precisión Con Valores Tipo Flotantes");
            Console.WriteLine("El Resultado Es " + sumatoria);
            Console.WriteLine("------------------------");

            double sumatoriaD = 0;

            for (int n = 0; n < 10000; n++)
                sumatoriaD += 0.1;

            //Obtenemos 1000 con un pequeño exceso en el valor.
            Console.WriteLine("2) Error De Precisión Con Valores Tipo Dobles");
            Console.WriteLine("El Resultado Es " + sumatoriaD);
            Console.WriteLine("----------------------------------");

            //Este tipo de error se conoce como error de cancelación.

            //pues elimina cifras significativas.
            float a = 100.45678f;
            float b = 100.45655f;

            float c = a - b;
            //el resultado no es 0.00023.
            Console.WriteLine("3) Error De Precisión Con Valores Tipo Flotantes");
            Console.WriteLine("El Resultado Es " + c);
            Console.WriteLine("-----------------------------");

            //Este tipo de error se conoce como error de cancelación.

            //pues elimina cifras significativas.
            double aD = 100.45678;
            double bD = 100.45655;

            double cD = aD - bD;
            //el resultado es 0.00023 con un pequeño exceso en el valor.
            Console.WriteLine("4) Error De Precisión Con Valores Tipo Doble");
            Console.WriteLine("El Resultado Es " + cD);
            Console.WriteLine("--------------------------------------");

            float a1 = 1;
            float b2 = 200000;
            float c3 = -3;

            float descriminante = (b2 * b2) - (4 * a1 * c3);
            float x1 = (-b2 - (float)Math.Sqrt(descriminante)) / (2 * a1);
            float x2 = (-b2 + (float)Math.Sqrt(descriminante)) / (2 * a1);

            /*El error ocurre al restar b del discriminante por eso tenemos 0
            vemos nuevamente el error  de cancelación.*/
            Console.WriteLine("5) Error De Precisión Con Valores Tipo Flotantes");
            Console.WriteLine("x1={0}, x2={1}, d={2} ", x1, x2, descriminante);
            Console.WriteLine("-------------------------");

            double a1D = 1;
            double b2D = 200000;
            double c3D = -3;

            double descriminanteD = (b2D * b2D) - (4 * a1D * c3D);
            double x1D = (-b2D - (double)Math.Sqrt(descriminanteD)) / (2 * a1D);
            double x2D = (-b2D + (double)Math.Sqrt(descriminanteD)) / (2 * a1D);

            Console.WriteLine("6) Error De Precisión Con Valores Tipo Doble");
            Console.WriteLine("x1={0}, x2={1}, d={2} ", x1D, x2D, descriminanteD);
            Console.WriteLine("-----------------------------------------------------------");

            decimal a1Dc = 1;
            decimal b2Dc = 200000;
            decimal c3Dc = -3;

            decimal descriminanteDc = (b2Dc * b2Dc) - (4 * a1Dc * c3Dc);
            decimal x1Dc = (-b2Dc - (decimal)Math.Sqrt((double)descriminanteDc)) / (2 * a1Dc);
            decimal x2Dc = (-b2Dc + (decimal)Math.Sqrt((double)descriminanteDc)) / (2 * a1Dc);

            Console.WriteLine("7) Error De Precisión Con Valores Tipo Decimal");
            Console.WriteLine("x1={0}, x2={1}, d={2} ", x1Dc, x2Dc, descriminanteDc);
            Console.WriteLine("---------------------------------------------");

            /*Lo mejor es que usamos double o decimal
            Si necesitamos presión infinita lo mejor es usar Maple Mathematica.*/
        }
    }
}
