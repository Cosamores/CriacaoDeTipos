using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeVariaveis
{ 
    class TipoDeValor : IItemAula
    {

        public void Executar()
        {
            int idade;
                idade = 32;

            int CopiaIdade;
            CopiaIdade = idade;

            Console.WriteLine($"idade {idade}");

            idade = 53;

            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"CopiaIdade: {CopiaIdade}");
        }
    }
}
