using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeVariaveis
{
    class Classe : IItemAula
    {
        public void Executar()
        {
            PosicaoGPS gps1 = new PosicaoGPS(100.3, 34.5);
           
            Console.WriteLine(gps1);
            PosicaoGPSComData gps2 = new PosicaoGPSComData(94.2, 100.3, DateTime.Now);
            Console.WriteLine(gps2);
        }
    }

        public class PosicaoGPS : IHemisferio
    {
        public double Latitude;
        public double Longitude;

        public PosicaoGPS(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        
        
        }

        public bool HemisferioSul()
        {
            return Latitude > 0 ? true : false;
        }
        public override string ToString()
        {
            return $"Latitude: {Latitude} Longitude: {Longitude}";
        }
    }

  public class PosicaoGPSComData: PosicaoGPS
    {
        private readonly DateTime Dataleitura;

        public PosicaoGPSComData(double latitude, double longitude, DateTime dataleitura) : base(latitude, longitude)
        {
            Dataleitura = dataleitura;
        }

        public override string ToString()
        {
            return $"Latitude: {Latitude} Longitude: {Longitude} Dataleitura {Dataleitura}";
        }
    }


    interface IHemisferio
    {
        bool HemisferioSul();
    }
}
