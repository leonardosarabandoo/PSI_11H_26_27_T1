
using System;
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Número 1 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Operação ( + * - / ) :");
            string op = Console.ReadLine().Trim();
            Console.WriteLine("Número 2 : ");
            int num2 = int.Parse(Console.ReadLine());

            switch (op)
            {
                case "+":
                    Console.WriteLine($"A soma de {num1} + {num2} é igual a {num1 + num2}");
                    break;

                case "-":
                    Console.WriteLine($"A soma de {num1} - {num2} é igual a {num1 - num2}");
                    break;

                case "*":
                    Console.WriteLine($"A soma de {num1} * {num2} é igual a {num1 * num2}");
                    break;

                case "/":
                    Console.WriteLine($"A soma de {num1} / {num2} é igual a {num1 / num2}");
                    break;

                default:
                    Console.WriteLine("Operação Inválida");
                    break;

            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}

