using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia10
{
    class CDijkstra
    {
        private int rango = 0;
        private int[,] L;  //Matriz de adyacencia
        private int[] C;  //Arreglo de nodos
        public int[] D;  //Arreglo de distancias
        private int trango = 0;

        public CDijkstra(int paramRango, int[,] paramArreglo)
        {
            L = new int[paramRango, paramRango];
            C = new int[paramRango];
            D = new int[paramRango];

            rango = paramRango;

            for (int i = 0; i < rango; i++)
            {
                for (int j = 0; j < rango; j++)
                {
                    L[i, j] = paramArreglo[i, j];
                }
            }

            for (int i = 0; i < rango; i++)
            {
                C[i] = i;
            }

            C[0] = -1;

            for (int i = 0; i < rango; i++)
                D[i] = L[0, i];
        }

        public void SolDijkstra()
        {
            int minValor = Int32.MaxValue;
            int minNodo = 0;

            for (int i = 0; i < rango; i++)
            {
                if (C[i] == -1)
                    continue;
                if (D[i]> 0 && D [i]<minValor)
                {
                    minValor = D[i];
                    minNodo = i;
                }

            }

            C[minNodo] = -1;

            for (int i = 0; i < rango; i++)
            {
                if (L[minNodo, i] < 0)
                    continue;

                if (D[i] < 0)
                {
                    D[i] = minValor + L[minNodo, i];
                    continue;
                }

                if ((D[minNodo] + L[minNodo, i] < D[i]))
                    D[i] = minValor + L[minNodo, i];
            }
        }

        public void CorrerDijkstra()
        {
            for (trango = 1; trango < rango; trango++)
            {
                SolDijkstra();
                //Console.WriteLine("Iteracion No. " + trango);
                //Console.WriteLine("Matriz de distancias");

                //for (int i = 0; i < rango; i++)
                //    Console.Write(i + " ");

                //Console.WriteLine("\n");

                //for (int i = 0; i < rango; i++)
                //{
                //    for (int j = 0; j < rango; j++)
                //        Console.Write(D[i] + " ");

                //    Console.WriteLine();
                //}
                //Console.WriteLine(" ");
                //Console.WriteLine(" ");
                //Console.Write("   ");
            }
        }
    }
}
