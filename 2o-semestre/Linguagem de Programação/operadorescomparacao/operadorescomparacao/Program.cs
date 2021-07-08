using System;

namespace operadorescomparacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite um segundo número:");
            int num2 = Int32.Parse(Console.ReadLine());

            if (num1 == num2)
                Console.WriteLine("Os números digitados são iguais.");

            if (num1 != num2)
                Console.WriteLine("Os números digitados são diferentes.");

            if (num1 > num2)
                Console.WriteLine($"{num1} é maior que {num2}.");

            if (num1 < num2)
                Console.WriteLine($"{num1} é menor que {num2}.");

            if (num1 >= num2)
                Console.WriteLine($"{num1} é maior ou igual a {num2}.");

            if (num1 <= num2)
                Console.WriteLine($"{num1} é menor ou igual a {num2}.");
        }
    }
}
