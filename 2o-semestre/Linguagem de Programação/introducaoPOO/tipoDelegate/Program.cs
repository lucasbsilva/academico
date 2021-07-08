using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipoDelegate
{
    class Program
    {
        delegate void operacao(int x, int y);

        static void Main(string[] args)
        {
            matematica obj = new matematica();
            operacao op = null;

            op += obj.soma;
            op += obj.subtracao;
            op += obj.divisao;
            op += obj.multiplicacao;
            op(10, 2);

            Console.ReadKey();
        }
    }
}
