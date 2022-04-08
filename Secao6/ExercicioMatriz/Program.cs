using System;
using System.Collections.Generic;

/*
 Fazer um programa para ler dois números inteiros M e N, e depois ler
uma matriz de M linhas por N colunas contendo números inteiros,
podendo haver repetições. Em seguida, ler um número inteiro X que
pertence à matriz. Para cada ocorrência de X, mostrar os valores à
esquerda, acima, à direita e abaixo de X, quando houver, conforme
exemplo.
 */
namespace ExercicioMatriz
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.Write("Linha: ");
            int linha = int.Parse(Console.ReadLine());
            Console.Write("Coluna: ");
            int coluna = int.Parse(Console.ReadLine());

            int[,] matriz = new int[linha, coluna];

            Console.WriteLine("Entrar com os valores da matriz");
            
            //laço for para popular a matriz
            for (int i =0;i < linha; i++)
            {
                //string[] vetor = Console.ReadLine().Split(' ');

                for(int j=0;j < coluna; j++)
                {
                    //matriz[i, j] = int.Parse(vetor[j]);

                    Console.Write($"{i}x{j}: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
                
            }

            Console.Write("\nDigite um número existente na matriz: ");
            int numero = int.Parse(Console.ReadLine());

            
            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    if(matriz[i,j] == numero)
                    {
                        Console.WriteLine($"Posição => ({i}x{j})");
                        if(j > 0)
                        {
                            Console.WriteLine($"Esquerda: {matriz[i,j-1]}");
                        }
                        if (i > 0)
                        {
                            Console.WriteLine($"Acima: {matriz[i-1,j]}");
                        }
                        if(i < linha - 1)
                        {
                            Console.WriteLine($"Abaixo: {matriz[i+1,j]}");
                        }
                        if(j < coluna - 1)
                        {
                            Console.WriteLine($"Direita: {matriz[i,j+1]}");
                        }
                    }
                }
            }
            //for para mostrar os valores da matriz
            for (int i = 0; i < linha; i++)
            {
                Console.WriteLine();
                for(int j = 0; j < coluna; j++)
                {
                    Console.Write(matriz[i,j]+" ");
                }
            }
        }
    }

}