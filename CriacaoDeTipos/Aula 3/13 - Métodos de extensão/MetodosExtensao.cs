using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeVariaveis
{
    class MetodosExtensao
    {
        public void Executar()
        {

            Impressora imp = new Impressora("texto qualquer...");
            imp.ImprimirDocumento();

            imp.imprimirDocumentoHTML();
        }

         void imprimirDocumentoHTML(string doc)
        {
            Console.WriteLine(doc);
        }
    }

    class Impressora
    {
        public Impressora(string documento)
        {
            Documento = documento;

        }

        public string Documento { get; set; }

        public void ImprimirDocumento()
        {
            Console.WriteLine(Documento);
            Console.ReadKey();
        }
    }


    static class ImpressaoExtensions
    {
        public static void imprimirDocumentoHTML(this Impressora imp)
        {
            Console.WriteLine($"<html><body> {imp.Documento} </body></html>");
        }

    }
}
