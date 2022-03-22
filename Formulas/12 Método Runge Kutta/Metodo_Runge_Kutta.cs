using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Numericos_En_CSharp
{
    class Metodo_Runge_Kutta
    {
        public void MetodoRungeKutta()
        {
            double h = 0.1;
            double t = 0;
            double y = 1;

            for (int i = 0; i <= 10; i++)
            {
                //Mostramos valores
                Console.WriteLine("t={0:0.######}\trk{1:0.######}\texacto{2:0}.######", t, y, Math.Exp(t));

                //Calculamos el valor
                double k1 = h * F(t, y);
                double k2 = h * F(t + h / 2, y + k1 / 2.0);
                double k3 = h * F(t + h / 2, y + k2 / 2.0);
                double k4 = h * F(t + h, y + k3);

                y += (k1 + 2.0 * k2 + 2.0 * k3 + k4) / 6.0;

                t += h;
            }
        }

        // Estos Metodós reprensentan a las funciones
        static double F(double t, double y)
        {
            return y;
        }
    }
}
