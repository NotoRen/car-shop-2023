using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopLibrary
{
    public enum EAlimentazione
    {
        Benzina,
        Diesel,
        Elettrica,
        GPL,
        Metano,
        FullHybrid,
        PluginHibrid
    }
    public abstract class Veicolo
    {
        public string Marca { get; set; }
        public string Modello { get; set; }
        public string VIN { get; set; }
        public string Colore { get; set; }
        public int km { get; set; }
        public EAlimentazione Alimentazione { get; set; }
        public int maxSpeed { get; set; }
        public int Potenza { get; set; }
        public DateTime dataImmatricolazione { get; set; } 
        public int Prezzo { get; set; }


        public Veicolo(string marca, string modello)
        {
            Marca = marca;
            Modello = modello;
        }

        public Veicolo(string marca, string modello, string vin, string colore, int Km, EAlimentazione alimentazione, int MaxSpeed, int potenza, DateTime Data, int prezzo) : this(marca, modello)
        {
            VIN = vin;
            km = Km;
            maxSpeed = MaxSpeed;
            Potenza = potenza;
            dataImmatricolazione = Data;
            Prezzo = prezzo;
        }

        public override string ToString()
        {
            return Marca+" "+Modello;
        }
    }
}
