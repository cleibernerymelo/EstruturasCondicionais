using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E07._1_VerificarNumerosParesESomar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o primeiro número: ");
            string numero1 = Console.ReadLine();
            Console.WriteLine("Escreva o segundo número: ");
            string numero2 = Console.ReadLine();
            while ((Convert.ToInt32(numero1) % 2 == 0) && (Convert.ToInt32(numero2) % 2 == 0))
            {
                int resultadoSoma = Convert.ToInt32(numero1) + Convert.ToInt32(numero2);
                Console.WriteLine(resultadoSoma);
                Console.WriteLine("Escreva o primeiro número: ");
                numero1 = Console.ReadLine();
                Console.WriteLine("Escreva o segundo número: ");
                numero2 = Console.ReadLine();
            };
            Console.ReadKey();
        }
    }
}
