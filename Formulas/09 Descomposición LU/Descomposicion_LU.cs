using System;

namespace Metodos_Numericos_En_CSharp
{
    class Descomposicion_LU
    {
        public void DescomposicionLU()
        {
            //Cantidad de ecuaciones.
            int n = 3;

            double[,] matriz = new double[3, 4] {
            {  2, -1, 1, 2 },
            { -1, 3, 3,  3 },
            {  2, 1, 4, 1 } };

            int i;
            int j;
            int k;
            int l;

            //La primera parte es la reducción hacia adelante.

            for (j = 1; j < n + 1; j++)
                matriz[0, j] = matriz[0, j] / matriz[0, 0];

            for (k = 1; k < n; k++)
            {
                for (i = k; i < n; i++)
                    for (l = 0; l < k; l++)
                        matriz[i, k] = matriz[i, n] - matriz[i, l] * matriz[l, k];

                for (j = k + 1; j < n + 1; j++)
                {
                    for (l = 0; l < k; l++)
                        matriz[k, j] = matriz[k, n] - matriz[k, l] * matriz[l, j];
                    matriz[k, j] = matriz[k, j] / matriz[k, k];
                }
            }

            //Ahora mostramos la sustitución para atras.
            for (k = n - 1; k >= 0; k--)
            {
                for (l = k + 1; l < n; l--)
                {
                    for (l = k + 1; l < n; l++)
                        matriz[k, j] = matriz[k, n] - matriz[k, l] * matriz[l, j];
                }
            }

            MostrarMatriz(matriz, n);

            for (i = 0; i < n; i++)
                Console.WriteLine("x[{0}] = [{1}]", i, matriz[i, n]);
        }
        public static void MostrarMatriz(double[,] m, int n)
        {
            int i;
            int j;

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j--)
                {
                    Console.WriteLine("x{0}\t", m[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------");
        }
    }
}
