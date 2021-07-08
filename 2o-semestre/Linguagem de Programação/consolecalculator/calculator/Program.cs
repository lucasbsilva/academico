using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mêtodo "Console.ReadLine()" armazena apenas strings.
            // Mêtodo "Int32.Parse()" converte o contéudo em um número inteiro.
            Console.WriteLine("Digite um número:");
            int num1 = Int32.Parse(Console.ReadLine()); 
            Console.WriteLine("Digite um segundo número:");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Os valores digitados foram: {num1} e {num2}.");
            Console.WriteLine($"A soma dos números digitados é: {num1+num2}.");
            Console.WriteLine($"A subtração dos números digitados é: {num1-num2}.");
            Console.WriteLine($"A multiplicação dos números digitados é: {num1*num2}.");
            Console.WriteLine($"A divisão entre os números digitados é: {num1/num2}.");
        }
    }
}
