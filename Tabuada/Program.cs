using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //    int[] tabuada = new int[10];

        //    for (int i = 1; i <= 10; i++)
        //    {
        //        for (int j = 1; j <= 10; j++)
        //        {
        //            Console.WriteLine("{0} + {1} = {2}", i, j, i * j);
        //        }
        //        Console.WriteLine("-------------");
        //    }
        //    Console.ReadLine();


        int[,] tabuada = new int[10,10];

            for (int linha = 0; linha < 10; linha++)
            {
                int linhaValor = linha + 1;
                for (int coluna = 0; coluna < 10; coluna++)
                {
                    int colunaValor = coluna + 1;
                    tabuada[linha, coluna] = linhaValor * colunaValor;
                    Console.WriteLine("{0} * {1} = {2}", linhaValor, colunaValor, tabuada[linha, coluna]);
               }
               Console.WriteLine("-------------");
            }
            Console.ReadLine();
        }
    }  
}
