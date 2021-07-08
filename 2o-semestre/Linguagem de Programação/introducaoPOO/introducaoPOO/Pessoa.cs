using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introducaoPOO
{
    class Pessoa
    {
        public string nome;
        public string sobrenome;
        public int idade;

        public void saudacao()
        {
            Console.WriteLine("Olá " + nome + " " + sobrenome + ", conforme seu cadastro, você tem " + idade + " anos.");
        }
    }

    
}
