﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.ID;

namespace CarShopLibrary
{
    public class JsonTools
    {
        public static void SalvaDati(List<Veicolo> dati)
        {
            string jsonString=JsonSerializer.Serialize(dati);
            Console.WriteLine(jsonString);
        }
        public static void CaricaDati(List<Veicolo> dati)
        {
            
        }
    }
}
