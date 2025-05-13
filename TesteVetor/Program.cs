using System;
using System.Collections.Generic;
using System.Globalization;

namespace EntradaDados {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int M, N; // Definindo as variáveis M e N Sendo linha e coluna

            Console.Write("Quantas linhas vaiter a matriz: ");
            M = int.Parse(Console.ReadLine(), CI); // Lendo o número de linhas
            Console.Write("Quantas colunas vaiter a matriz: ");
            N =  int.Parse(Console.ReadLine(), CI); // Lendo o número de colunas

            int[,] mat = new int[M, N]; // Criando a matriz com M linhas e N colunas

            for (int i = 0; i < M; i++){
                for (int j =0; j <N; j++) {
                    Console.Write("Elemento [" + i + "," + j+ "]:");
                    mat[i,j] = int.Parse(Console.ReadLine(), CI); // Lendo os elementos da matriz
                    

                }
            }
            Console.WriteLine();
            Console.WriteLine("MATRIZ DIGITADA:");
            for (int i = 0; i <M; i++) {
                for (int j = 0; j < N; j++) {
                    Console.Write(mat[i, j] + " "); // Imprimindo a matriz
                }
                Console.WriteLine();
            }
        }
    }
}
