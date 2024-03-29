﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operação deseja realizar?");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão \n");

            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            int resultado = 0;

            switch(operacao)
            {
                case 1:
                    {
                        resultado = Adicao(numero1, numero2);
                        break;
                    };
                case 2:
                    {
                        resultado = Subtracao(numero1, numero2);
                        break;
                    };
                case 3:
                    {
                        resultado = Multiplicacao(numero1, numero2);
                        break;
                    };
                case 4:
                    {
                        resultado = Divisao(numero1, numero2);
                        break;
                    };
                default:
                    Console.WriteLine("Número invalido, escreva outro número");
                        break;
            }
            Console.WriteLine("O resultado da operação com os números {0} e {1} = {2}", numero1, numero2, resultado);
            Console.ReadKey();
        }

        public static int Adicao (int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            return resultado;
        }

        public static int Subtracao(int numero1, int numero2)
        {
            int resultado = numero1 - numero2;
            return resultado;
        }

        public static int Multiplicacao(int numero1, int numero2)
        {
            int resultado = numero1 * numero2;
            return resultado;
        }

        public static int Divisao(int numero1, int numero2)
        {
            int resultado = numero1 / numero2;
            return resultado;
        }
    }
}
