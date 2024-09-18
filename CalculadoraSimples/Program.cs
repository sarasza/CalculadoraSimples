using System;
using System.Globalization;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            double numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número");
            double numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Adição: 1");
            Console.WriteLine("Subtração: 2");
            Console.WriteLine("Multiplicação: 3");
            Console.WriteLine("Divisão: 4");
            Console.WriteLine("Selecione uma opção: ");

            int operacao = int.Parse(Console.ReadLine());

            double resultado = 0;

            Console.WriteLine();

            switch (operacao)
            {
                case 1:
                    resultado = numero1 + numero2;
                    break;
                case 2:
                    resultado = numero1 - numero2;
                    break;
                case 3:
                    resultado = numero1 * numero2;
                    break;
                case 4:
                    resultado = numero1 / numero2;
                    break;
                default:
                    Console.WriteLine("Essa operação é inválida!");
                    break;
            }
            Console.WriteLine("Resultado: " + resultado);
        }
    }
}