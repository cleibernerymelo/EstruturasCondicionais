using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E07_SomarDoisNumerosDiferentesZero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int resultadoSoma = 0;
            Console.WriteLine("Escreva o primeiro número: ");
            var numero1 = Console.ReadLine();
            Console.WriteLine("Escreva o segundo número: ");
            var numero2 = Console.ReadLine();
            if ((Convert.ToInt32(numero1) != 0) && ((Convert.ToInt32(numero2) != 0)))
            {
                int resultadoSoma = Somar(Convert.ToInt32(numero1), Convert.ToInt32(numero2));
                Console.WriteLine(resultadoSoma);
            }
            else
            {
                Console.WriteLine("Os números informados, não são diferentes de zero");
            }
            Console.ReadKey();
        }

        public static int Somar(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            return resultado;
        }
    }
}
