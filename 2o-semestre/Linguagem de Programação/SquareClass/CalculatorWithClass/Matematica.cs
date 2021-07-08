using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWithClass
{
    class Matematica
    {
        public void soma(double x, double y)
        {
            Console.WriteLine("O resultado da soma entre esses números é: " + (x + y));
        }

        public void subtracao(double x, double y)
        {
            Console.WriteLine("O resultado da subtração entre esses números é: " + (x - y));
        }

        public void divisao(double x, double y)
        {
            Console.WriteLine("O resultado da divisão entre esses números é: " + (x / y));
        }

        public void multiplicacao(double x, double y)
        {
            Console.WriteLine("O resultado da multiplicação entre esses números é: " + (x * y));
        }
    }
}