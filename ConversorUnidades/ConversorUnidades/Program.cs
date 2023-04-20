using System;

namespace CalculadoraBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo à Calculadora Básica!");

            while (true)
            {
                Console.WriteLine("\nPor favor, selecione o tipo de operação que você deseja fazer:");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Sair");

                Console.Write("\nOpção: ");
                string opcao = Console.ReadLine();

                if (opcao == "5")
                {
                    Console.WriteLine("Obrigado por usar a Calculadora Básica! Até logo.");
                    break;
                }

                Console.Write("\nDigite o primeiro número: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double num2 = double.Parse(Console.ReadLine());

                double resultado = 0;

                switch (opcao)
                {
                    case "1":
                        resultado = num1 + num2;
                        break;
                    case "2":
                        resultado = num1 - num2;
                        break;
                    case "3":
                        resultado = num1 * num2;
                        break;
                    case "4":
                        if (num2 == 0)
                        {
                            Console.WriteLine("\nNão é possível dividir por zero. Por favor, tente novamente.");
                            continue;
                        }
                        resultado = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida. Por favor, selecione uma opção válida.");
                        continue;
                }

                Console.WriteLine("\nO resultado é: " + resultado);
            }
        }
    }
}
