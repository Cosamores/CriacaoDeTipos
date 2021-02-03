using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeVariaveis
{
    class PontoFlutuante : IItemAula
    {
        public void Executar()
        {

            //int  massaterra = 6_0000_0000_0000_0000;

            //long massa = 6e24;

            Console.WriteLine($"long.MinValue: {long.MinValue}");
            Console.WriteLine($"long.MaxValue: {long.MaxValue}");

            //massa da Terra ==> 5.9722 × 10^24

            float massaDaTerra = 5.9736e24f; //System.Single
            Console.WriteLine($"massaDaTerra: {massaDaTerra}");

            float numeroPI = 3.1415989888f; // System.Single
            Console.WriteLine($"numeroPI: {numeroPI}");

            // float numeroMuitoGrande = 6e100f;

            double nromuitogrande = 6e100;

            Console.WriteLine();
            Console.WriteLine("Operação com int, float e short");

            int x = 3;
            float y = 5.123956f;

            var resultado1 = x + y;

            Console.WriteLine("x + y = {0:F3}", resultado1);

            Console.WriteLine($"O resultado é do tipo:  {resultado1.GetType()}");
        }
    }
}