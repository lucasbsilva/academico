using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            metodos m = new metodos();

            // m.simples();

            // m.somar(10, 50);

            // m.apresentar("Lucas", 23);

            //int x = 1;
            //int y = 2;

            //m.aumentarvlr(x);
            //Console.WriteLine($"A variável 'x' valia 1 e agora vale: {x}");

            //m.aumentarvlref(ref y);
            //Console.WriteLine($"A variável 'y' valia 2 e agora vale: {y}");

            //string nomecompleto = m.montanome("Lucas", "Bezerra");
            //int codigochar = m.codigochar('j');
            //double pi = m.valorpi();

            //Console.WriteLine(nomecompleto);
            //Console.WriteLine(codigochar);
            //Console.WriteLine(pi);

            //m.simples();
            //m.simples("Lucas");
            //m.simples("Lucas", 20);

            bool resultado = m.comparar(100, 20+80);
            bool resposta = m.comparar("Lucas", "lucas");

            Console.WriteLine(resultado);
            Console.WriteLine(resposta);

            Console.ReadKey();
        }
    }
}
