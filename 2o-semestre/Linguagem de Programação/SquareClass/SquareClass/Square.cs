using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareClass
{
    class Square
    {
        public double perimetro(double valor)
        {
            return valor * 4;
        }

        public double area(double valor)
        {
            return valor * valor;
        }

        public void saudacao()
        {
            Console.WriteLine("Implementando um quadrado.");
        }
    }
}
