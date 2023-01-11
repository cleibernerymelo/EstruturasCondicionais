using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subrotinas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void EscreverNumeros()
            {
                Console.WriteLine("Escreva o primeiro número: ");
                int numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Escreva o segundo número: ");
                int numero2 = int.Parse(Console.ReadLine());
                int resultado = Somar(numero1, numero2);
                Console.WriteLine("A soma de {0} + {1} = {2}", numero1, numero2, resultado);
                Console.ReadLine();
            }

            EscreverNumeros();

        }
        public static int Somar(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            return resultado;
        }
    }
}
