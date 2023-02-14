using CarShopLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CarShopConsole
{
    internal class Program
    {
        static List<Veicolo> ParcoMezzi = new List<Veicolo>();
        static void Main(string[] args)
        {
            creaDatiProva();
            Console.WriteLine("*** GESTIONE RIVENDITA VEICOLI USATI ***");
            char scelta = ' ';
            while (scelta.ToString().ToLower() != "q")
            {
                scelta = scriviMenu();
                switch (scelta)
                {
                    case '1':
                        ElencoVeicoli();
                        break;
                    case '2':
                        ElencoAuto();
                        break;
                    case '3':
                        ElencoMoto();
                        break;
                    default:
                        break;
                }
            }
            Console.ReadKey();
        }
        #region Scrivi menu, stampa elenchi
        private static char scriviMenu()
        {
            Console.WriteLine("1 - Visualizza TUTTI i veicoli");
            Console.WriteLine("2 - Visualizza le auto");
            Console.WriteLine("3 - Visualizza le moto");
            Console.WriteLine("\nQ - Uscita");
            return Console.ReadKey(true).KeyChar; //true non vedo la risposta
        }
        private static void ElencoVeicoli()
        {
            Console.Clear();
            Console.WriteLine("*** ELENCO GENERALE VEICOLI ***");
            int cont = 0;
            foreach (var item in ParcoMezzi)
            {
                cont++;
                Console.WriteLine(cont.ToString() + " - " + item.ToString());
            }
            Console.WriteLine("\n");
        }
        private static void ElencoAuto()
        {
            Console.Clear();
            Console.WriteLine("*** ELENCO GENERALE VEICOLI ***");
            int cont = 0;
            foreach (var item in ParcoMezzi)
            {
                if (item is Auto)
                {
                    cont++;
                    Auto a = item as Auto;
                    Console.WriteLine(cont.ToString() + " - " + a.ToString());
                }
            }
            Console.WriteLine("\n");
        }

        private static void ElencoMoto()
        {
            Console.Clear();
            Console.WriteLine("*** ELENCO GENERALE VEICOLI ***");
            int cont = 0;
            foreach (var item in ParcoMezzi)
            {
                if (item is Moto)
                {
                    cont++;
                    Console.WriteLine(cont.ToString() + " - " + item.ToString());
                }
            }
            Console.WriteLine("\n");
        }
        static void creaDatiProva()
        {
            Veicolo v = new Auto("BMW", "Serie 3");
            ParcoMezzi.Add(v);
            v = new Auto("Mercedes", "CLA", true, 5, 18);
            ParcoMezzi.Add(v);
            v = new Moto("Yamaha", "KZ5");
            ParcoMezzi.Add(v);
            v = new Moto("Ducati", "RossoFuoco", ETipoMoto.Strada, 4);
            ParcoMezzi.Add(v);
        }
        #endregion
    }
}
