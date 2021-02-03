using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeVariaveis
{
    class Dinamico : IItemAula
    {
        public void Executar()
        {
            object obj = 1;

            //obj += 1;

            dynamic numero = 1;

            numero += 1;

            numero.teste();
        }
    }
}
