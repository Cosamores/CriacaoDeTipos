using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeVariaveis
{
    public class Estrutura : IItemAula
    {
        public void Executar()
        {

            Posicao gps = new Posicao(10.23, 90.30);

            Console.WriteLine(gps.ToString());

            if (gps.EhHmesfeirioSul())
                Console.WriteLine("voce esta localizado no hemisferio sul");

        }


        struct Posicao : IHemisferio
        {
            public double Latitude;
            public double Longitude;

            public Posicao(double latitude, double longitude)
            {
                Latitude = latitude;
                Longitude = longitude;
            }

            public bool EhHmesfeirioSul()
            {
                return (Latitude > 0) ? true : false;

            }

            public override string ToString()
            {
                return $"Latitude: {Latitude} Longitude: {Longitude}";
            }


        }

        public interface IHemisferio
        {
            bool EhHmesfeirioSul();
        }



    }

}