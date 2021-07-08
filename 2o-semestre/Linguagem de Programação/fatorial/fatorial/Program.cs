using System;

namespace fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo do Fatorial\n\nDigite um número inteiro positivo:");
            int num = Convert.ToInt32(Console.ReadLine());

            int fat = 1;

            for (int contador = 1; contador <= num; contador++)
                fat = contador*fat;
            
            Console.WriteLine("\nO fatorial do número digitado é: " + fat + " (" + num + "!=" + fat + ").");
        }
    }
}
