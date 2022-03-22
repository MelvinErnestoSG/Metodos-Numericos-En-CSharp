using System;

namespace Metodos_Numericos_En_CSharp
{
    class Eliminacion_Gauss_Jordan
    {
        public void EliminacionGaussJordan()
        {
            //Cantidad de ecuaciones.
            int n = 3;

            //Aqui definimos la matriz donde quedan codificadas las ecuaciones.
            double[,] matriz = new double[3, 4] 
            {
                { 1, 2,  1,  0},
                {-3, 2, -5,  2},
                { 2, 6, -1, -2},
            };

            int k;
            int j;
            int i;

            double pivote;
            double d;

            for(k = 0; k < n; k++)
            {
                //obtenemos el pivote.
                pivote = matriz[k, k];

                for (j = k; j < n + 1; j++)
                    matriz[k, j] = matriz[k, j] / pivote;

                for (i = 0; i < n; i++)
                {
                    if (i != k)
                    {
                        d = matriz[i, k];

                        for (j = k; j < n + 1; j++)
                            matriz[i, j] = matriz[i, j] - d * matriz[k, j];
                    }
                    MostrarMatriz(matriz, n);

                }//end for i

            }//end for k

            for (i = 0; i < n; i++)
                Console.WriteLine("x[{0}]={1}", i, matriz[i, n]);
        }

        public static void MostrarMatriz(double [,]m, int n)
        {
            int i;
            int j;

            for(i = 0; i < n; i++)
            {
                for(j = 0; j < n + 1; j++)
                {
                    Console.Write("{0}\t", m[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------");
        }
    }
}
