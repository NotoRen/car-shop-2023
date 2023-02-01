using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarShopLibrary;

namespace CarShopConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veicolo v = new Auto("BMW", "Serie 3");
            Console.WriteLine(v.Marca + v.Modello);

           Console.ReadKey();
        }
    }
}
