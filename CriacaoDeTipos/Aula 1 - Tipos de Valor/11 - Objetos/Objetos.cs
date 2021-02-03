using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeVariaveis
{
    class Objetos
    {
        public void Executar()
        {
            int valor = 10;

             object obj;

            obj = valor;

            object pes1 = new Pessoa();

            Pessoa Pes2;

            Pes2 = (Pessoa)pes1;

            Pes2.idade = 10;
        }
    }

    class Pessoa
    {
        int idade = 18;
        
    }
}
