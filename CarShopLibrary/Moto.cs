using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopLibrary
{
    public enum ETipoMoto
    {
        Undefined,
        Cross,
        Enduro,
        Strada,
        Chopper,
        Touring
    }
    public class Moto:Veicolo
    {
        public ETipoMoto Tipo { get; set; }
        public int NumTempi { get; set; }
        public Moto(string marca, string modello) : base(marca, modello) { }
        public Moto(string marca, string modello,ETipoMoto tipo,int numTempi) : base(marca, modello)
        {
            Tipo = tipo;
            NumTempi = numTempi;
        }
        public Moto(string marca, string modello, string vin, string colore, int Km, EAlimentazione alimentazione,
            int MaxSpeed, int potenza, DateTime Data, int prezzo, ETipoMoto tipo, int numTempi) : this(marca, modello, tipo, numTempi)
        {
            VIN = vin;
            Colore = colore;
            km = Km;
            Alimentazione = alimentazione;
            maxSpeed = MaxSpeed;
            Potenza = potenza;
            dataImmatricolazione = Data;
            Prezzo = prezzo;
        }
        public override string ToString()
        {
            return "";
            /*string stOut = base.ToString();
            if (Tipo!=ETipoMoto.Undefined) stOut += " Tipo: "+Tipo;
            if (NumTempi > 0) stOut += " Num.Tempi: " + NumTempi;
            return stOut;*/
        }
        public string ToString(bool isExtended = false)
        {
            if (!isExtended) return ToString();
            else return " ";
        }
    }
}
