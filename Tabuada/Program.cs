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
            int[] tabuada = new int[10];

            for (int i = 1; i <= tabuada.Length; i++)
            {
                for (int j = 1; j <= tabuada.Length; j++)
                {
                    Console.WriteLine("{0} X {1} = {2}", i, j, i * j);                    
                }
                Console.WriteLine("-------------");
            }
            Console.ReadLine();
        }
    }
}
