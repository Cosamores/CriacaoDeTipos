using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeVariaveis
{
    class Delegate : IItemAula
    {

        delegate double metodoMultiplicacao;
        public void Executar()
        {
            Calculadora calc = new Calculadora();

            Console.WriteLine($"Duplicar(7.5): {calc.Duplicar(7.5)}");
            Console.WriteLine($"Triplicar(7.5): {calc.Triplicar(7.5)}");

            MetodoMultiplicacao metodoMulticlicacao = calc.Duplicar;

            Console.WriteLine(metodoMultiplicacao(7.5));
        }

        public class Calculadora
        {
            public double Duplicar(double input);
            {
            return input* 2;
             }

        public double Triplicar(double input);
        {
        return input * 3;

        }
    }
}
}
