using System;

namespace classemath
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = Math.PI;
            Console.WriteLine($"O valor de PI é: {pi.ToString("#.0000")}.\n");

            double num = Math.Pow(5,3);
            Console.WriteLine($"A raiz cúbica de 5 é: {num}.\n");

            double raiz = Math.Sqrt(81);
            Console.WriteLine($"A raiz de 81 é: {raiz}.\n");

            int menor = Math.Min(50, 112);
            Console.WriteLine($"Entre 50 e 112, o menor é: {menor}.\n");

            int maior = Math.Max(5, 39);
            Console.WriteLine($"Entre 5 e 39, o maior é: {maior}.");

            Console.ReadKey();
        }
    }
}
