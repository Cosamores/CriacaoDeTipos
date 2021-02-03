using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeVariaveis
{
    class Interface : IItemAula
    {

        public void Executar()
        {
            IEletrodomestico eletrodomestico = new Televisao();

            Console.WriteLine(eletrodomestico.Ligado());

            eletrodomestico = new Radio();
            eletrodomestico = new Luminaria();
        }
    }

    interface IIluminacao
    {
        double potencia { get; set; }
    }

    interface IEletrodomestico
    {
        bool Ligado();
        bool Desligado();
    }

    class Televisao : IEletrodomestico
    {
        public bool Desligado()
        {
            throw new NotImplementedException();
        }

        public bool Ligado()
        {
            return true;
        }
    }
    class Luminaria : IEletrodomestico, IIluminacao
    {
        public double potencia { get; set; }
        public bool Desligado()
        {
            throw new NotImplementedException();
        }

        bool Ligado()
        {
            return true;
        }

        bool IEletrodomestico.Ligado()
        {
            throw new NotImplementedException();
        }
    }

    class Lanterna : IEletrodomestico, IIluminacao
    {
        public double potencia { get; set; }

        public bool Desligado()
        {
            throw new NotImplementedException();
        }

        bool Ligado()
        {
            return true;
        }

        bool IEletrodomestico.Ligado()
        {
            throw new NotImplementedException();
        }
    }
    class Radio : IEletrodomestico
    {
        public bool Desligado()
        {
            throw new NotImplementedException();
        }

        bool Ligado()
        {
            return true;
        }

        bool IEletrodomestico.Ligado()
        {
            throw new NotImplementedException();
        }
    }
}
 