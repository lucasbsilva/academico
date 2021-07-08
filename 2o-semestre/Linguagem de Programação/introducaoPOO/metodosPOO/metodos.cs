using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodosPOO
{
    class metodos
    {
        // método simples
        public void simples()
        {
            Console.WriteLine("Olá!");
        }

        // método com parâmetros
        public void somar(int x, int y)
        {
            int soma = x + y;
            Console.WriteLine(soma);
        }

        public void apresentar(string nome, int idade)
        {
            Console.WriteLine($"Meu nome é {nome}. Tenho {idade} anos.");
        }

        public void aumentarvlr(int xpto)
        {
            xpto += 10;
            Console.WriteLine(xpto);
        }

        public void aumentarvlref(ref int xpto)
        {
            xpto += 25;
            Console.WriteLine(xpto);
        }

        // métodos com retorno de valores
        public string montanome(string nome, string sobrenome)
        {
            string nomecompleto = nome + " " + sobrenome;
            return nomecompleto;
        }

        public int codigochar(char caract)
        {
            int res = caract;
            return res;
        }

        public double valorpi()
        {
            return 3.1415;
        }

        // sobrecarga de métodos

        public void simples(string nome)
        {
            Console.WriteLine("Olá, " + nome + ".");
        }

        public void simples(string nome, int hora)
        {
            string mensagem = hora < 12 ? "Bom dia, " + nome + "." : "Boa tarde, " + nome + ".";
            Console.WriteLine(mensagem);
        }

        // métodos comparativos
        public bool comparar(int x, int y)
        {
            return x == y;
        }

        public bool comparar(string a, string b)
        {
            return a == b;
        }
    }
}
