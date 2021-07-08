using System;

namespace pgtoporcomissao
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdefunc = 0;
            // a) $200 a $299 [0]
            // b) $300 a $399 [1]
            // c) $400 a $499 [2]
            // d) $500 a $599 [3]
            // e) $600 a $699 [4]
            // f) $700 a $799 [5]
            // g) $800 a $899 [6]
            // h) $900 a $999 [7]
            // i) >= $1000 [8]
            int[] intervalos = new int[9];
            double valorvenda = 0;

            Console.Write("Informe quantos funcionários deseja cadastrar: ");
            qtdefunc = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= qtdefunc; i++)
            {
                Console.Write($"\nInforme o valor da venda do {i}º funcionário: R$ ");
                valorvenda = Convert.ToDouble(Console.ReadLine());
                valorvenda = 200 + ((valorvenda * 9) / 100);

                if (valorvenda >= 200 && valorvenda <= 299)
                { intervalos[0] += 1; }

                else if (valorvenda >= 300 && valorvenda <= 399)
                { intervalos[1] += 1; }

                else if (valorvenda >= 400 && valorvenda <= 499)
                { intervalos[2] += 1; }

                else if (valorvenda >= 500 && valorvenda <= 599)
                { intervalos[3] += 1; }

                else if (valorvenda >= 600 && valorvenda <= 699)
                { intervalos[4] += 1; }

                else if (valorvenda >= 700 && valorvenda <= 799)
                { intervalos[5] += 1; }

                else if (valorvenda >= 800 && valorvenda <= 899)
                { intervalos[6] += 1; }

                else if (valorvenda >= 900 && valorvenda <= 999)
                { intervalos[7] += 1; }

                else intervalos[8] += 1;
                
                valorvenda = 0;

            }

            Console.WriteLine("\nTabela - Quantidade de vendedores por intervalos:");
            Console.WriteLine($"Salário entre $200 a $299:\t {intervalos[0]}");
            Console.WriteLine($"Salário entre $300 a $399:\t {intervalos[1]}");
            Console.WriteLine($"Salário entre $400 a $499:\t {intervalos[2]}");
            Console.WriteLine($"Salário entre $500 a $599:\t {intervalos[3]}");
            Console.WriteLine($"Salário entre $600 a $699:\t {intervalos[4]}");
            Console.WriteLine($"Salário entre $700 a $799:\t {intervalos[5]}");
            Console.WriteLine($"Salário entre $800 a $899:\t {intervalos[6]}");
            Console.WriteLine($"Salário entre $900 a $999:\t {intervalos[7]}");
            Console.WriteLine($"Salário entre $1000 ou mais:\t {intervalos[8]}");

        }
    }
}
