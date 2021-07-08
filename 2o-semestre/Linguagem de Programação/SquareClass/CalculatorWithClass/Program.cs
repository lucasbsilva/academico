using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWithClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nInforme outro número:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Matematica objeto = new Matematica();
            objeto.soma(num1, num2);
            objeto.subtracao(num1, num2);
            objeto.multiplicacao(num1, num2);
            objeto.divisao(num1, num2);

            Console.ReadKey();
        }
    }
}
