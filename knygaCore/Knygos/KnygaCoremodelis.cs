using System;
using System.Diagnostics.Metrics;


namespace knygaCore.Knygos
{
    public class Knyga
    {
        public int KnygosID { get; set; }
        public string Pavadinimas { get; set; }
        public string Autorius { get; set; }
        public int Kodas { get; set; }

        public int IsleidimoMetai { get; set; }



        public Knyga() { }

        public Knyga(int id, string pavadinimas, string autorius, int isleidimoMetai, int kodas)
        {
            KnygosID = id;
            Pavadinimas = pavadinimas;
            Autorius = autorius;
            Kodas = kodas;
            IsleidimoMetai = isleidimoMetai;
        }

        public override string ToString()
        {
            return $"{Pavadinimas} ({Autorius}, {IsleidimoMetai}) [Kodas: {Kodas}]";

        }
    }
}

