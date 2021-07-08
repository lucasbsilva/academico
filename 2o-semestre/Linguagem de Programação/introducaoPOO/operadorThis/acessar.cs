using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadorThis
{
    class acessar
    {

        string senha = "abc";

        public bool login(string senha)
        {
            return this.senha == senha;
        }
    }
}
