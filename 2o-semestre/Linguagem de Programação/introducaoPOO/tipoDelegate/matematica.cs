using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipoDelegate
{
    class matematica
    {
        public void soma(int x, int y)
        {
            Console.WriteLine("O soma é: " + (x + y));
        }

        public void subtracao(int x, int y)
        {
            Console.WriteLine("A subtração é: " + (x - y));
        }

        public void divisao(int x, int y)
        {
            Console.WriteLine("A divisão é: " + (x / y));
        }

        public void multiplicacao(int x, int y)
        {
            Console.WriteLine("A multiplicação é: " + (x * y));
        }

    }
}
