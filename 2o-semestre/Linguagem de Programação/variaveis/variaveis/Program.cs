using System;

namespace variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variáveis para números inteiros
            sbyte num1 = 1;
            Console.WriteLine(num1);
            byte num2 = 2;
            Console.WriteLine(num2);
            short num3 = 3;
            Console.WriteLine(num3);
            ushort num4 = 4;
            Console.WriteLine(num4);
            int num5 = 5;
            Console.WriteLine(num5);
            uint num6 = 6;
            Console.WriteLine(num6);
            long num7 = 7L;
            Console.WriteLine(num7);
            ulong num8 = 8L;
            Console.WriteLine(num8);

            // Variáveis para números reais
            float num9 = 2.5F;
            Console.WriteLine(num9);
            double num10 = 5.5;
            Console.WriteLine(num10);
            decimal num11 = 10.3M;
            Console.WriteLine(num11);

            // Variáveis para caracteres
            char text = 'L';
            Console.WriteLine(text);
            string msg = "Teste C#!";
            Console.WriteLine(msg);
            Console.WriteLine($"{num1}º {msg}");
        }
    }
}
