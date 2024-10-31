using AutomobilisCore.Auto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutomobiliuParkas
{
    public class AutomobiliuParkas
    {
        private List<Automobilis> automobiliai = new List<Automobilis>();

        public void PridetiAutomobili(Automobilis automobilis)
        {
            automobiliai.Add(automobilis);
        }

        public void TrintiAutomobili(string numeris)
        {
            var automobilis = automobiliai.FirstOrDefault(a => a.Numeris == numeris);
            if (automobilis != null)
            {
                automobiliai.Remove(automobilis);
                Console.WriteLine($"Automobilis '{automobilis}' ištrintas.");
            }
            else
            {
                Console.WriteLine("Automobilis nerastas.");
            }
        }

        public void RodytiVisusAutomobilius()
        {
            if (automobiliai.Count == 0)
            {
                Console.WriteLine("Nėra automobilių parke.");
                return;
            }

            foreach (var automobilis in automobiliai)
            {
                Console.WriteLine(automobilis);
            }
        }

        public List<Automobilis> RastiPagalMarke(string marke)
        {
            return automobiliai.Where(a => a.Marke.Equals(marke, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public Automobilis RastiNaujausiaAutomobili()
        {
            return automobiliai.OrderByDescending(a => a.Metai).FirstOrDefault();
        }

        public Automobilis RastiSeniausiaAutomobili()
        {
            return automobiliai.OrderBy(a => a.Metai).FirstOrDefault();
        }

        public List<Automobilis> FiltruotiPagalMetus(int nuo, int iki)
        {
            return automobiliai.Where(a => a.Metai >= nuo && a.Metai <= iki).ToList();
        }

        public int Kiekis()
        {
            return automobiliai.Count;
        }

        public bool ArYraAutomobilis(string numeris)
        {
            return automobiliai.Any(a => a.Numeris == numeris);
        }

        public void AtnaujintiAutomobili(string numeris, string marke, string modelis, int metai)
        {
            var automobilis = automobiliai.FirstOrDefault(a => a.Numeris == numeris);
            if (automobilis != null)
            {
                automobilis.Marke = marke;
                automobilis.Modelis = modelis;
                automobilis.Metai = metai;
                Console.WriteLine($"Automobilio '{numeris}' informacija atnaujinta.");
            }
            else
            {
                Console.WriteLine("Automobilis nerastas.");
            }
        }
    }
}
