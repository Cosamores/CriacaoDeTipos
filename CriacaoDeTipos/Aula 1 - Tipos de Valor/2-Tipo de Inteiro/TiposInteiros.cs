using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeVariaveis
{
    class TiposInteiros : IItemAula
    {

        public void Executar()

        {
            int populacao = 1500;


            uint pop = 1000;

            char n = 's'; //system.char

            byte nivelDeazul = 0xff; //255 em decimal 0 a 255
                                     //    nivelDeazul = -3;

            sbyte nivelDeBrilho = -4;

            short lotacao = 230; // System.Int16
            lotacao = -230;
            ushort latitude = 200;

            long populacaodobrasil = 207_660_000; //
            populacao = -99;
            ulong npopmundial = 7_000_000_000; //-99

            Console.WriteLine($"char: {n}");

            Console.WriteLine($"byte: {nivelDeazul}");
            Console.WriteLine($"sbyte com sinal: {nivelDeBrilho}");

            Console.WriteLine($"short: {lotacao}");
            Console.WriteLine($"ushort: {latitude}");

            Console.WriteLine($"int: {populacao}");
            Console.WriteLine($"long: {populacaodobrasil}");
            Console.WriteLine($"uint nao aceita negativo: {pop}");
            Console.WriteLine($"ulong nao aceita negativo: {npopmundial}");

        }
    }
}
