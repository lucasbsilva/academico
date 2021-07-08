using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace UsingClassLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            NameClass obj = new NameClass();

            int resultado = obj.somar(7, 13);
            Console.WriteLine(resultado);

            Console.ReadKey();
        }
    }
}
