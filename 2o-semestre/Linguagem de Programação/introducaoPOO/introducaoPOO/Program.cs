using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introducaoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p01 = new Pessoa();
            p01.nome = "Lucas";
            p01.sobrenome = "Bezerra";
            p01.idade = 23;

            Pessoa p02 = new Pessoa()
            {
                nome = "Ana", sobrenome = "Carolina", idade = 23
            };

            p01.saudacao();
            p02.saudacao();

            Console.ReadKey();
        }
    }
}
