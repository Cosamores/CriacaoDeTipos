using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiposDeVariaveis;


namespace TiposDeVariaveis
{
    class Program
    {

        static IList<MenuItem> menuItems;
        static void Main(string[] args)
        {

            IItemAula itemSelecionado;
            menuItems = GetMenuItems();

            while (true)
            {

                ImprimirMenuItems(menuItems);
                var opcao = Console.ReadLine();

                int.TryParse(opcao, out int resultado);

                if (resultado == 0 || resultado > menuItems.Count())
                    break;


                itemSelecionado = Executar(resultado);

                Console.ReadKey();

            }


        }

        private static IList<MenuItem> GetMenuItems()
        {
            return new List<MenuItem>
            {
                new MenuItem("Tipos de Valor", typeof(TipoDeValor)),
                new MenuItem("Tipos Inteiros", typeof(TiposInteiros)),
                new MenuItem("Tipos Flutuantes", typeof(PontoFlutuante)),
                new MenuItem("Decimal", typeof(Decimal)),
                new MenuItem("Estruturas", typeof(Estrutura)),
                new MenuItem("Emumeracoes", typeof(Enumeracoes)),
                new MenuItem("Tipo de Referência", typeof(TiposDeReferência)),
                new MenuItem("Classe", typeof(Classe)),
                new MenuItem("Interface", typeof(Interface))
            };
        }

        private static void ImprimirMenuItems(IList<MenuItem> menuItems)
        {
            int i = 1;
            Console.WriteLine("SELECIONE UMA OPÇÃO");
            Console.WriteLine("===================");
            Console.WriteLine("0 - Sair");

            foreach (var menuItem in menuItems)
            {
                Console.WriteLine((i++).ToString() + " - " + menuItem.Titulo);
            }
        }

        static IItemAula Executar(int valoropcao)
        {
            IItemAula itemSelecionado;
            MenuItem menuItem = menuItems[valoropcao - 1];

            //
            Type tipoClasse = menuItem.TipoClasse;

            itemSelecionado = (IItemAula)Activator.CreateInstance(tipoClasse);

            Console.WriteLine();
            string titulo = $"EXECUTANDO: {menuItem.Titulo}";
            Console.WriteLine(titulo);
            Console.WriteLine(new string('=', titulo.Length));

            itemSelecionado.Executar();

            Console.WriteLine();
            Console.WriteLine("Tecle algo para continuar...");

            return itemSelecionado;
        }
    }

    class MenuItem
    {

        public string Titulo { get; set; }
        public Type TipoClasse { get; set; }

        public MenuItem(string titulo, Type tipoClasse)
        {
            Titulo = titulo;
            TipoClasse = tipoClasse;
        }


    }
}
