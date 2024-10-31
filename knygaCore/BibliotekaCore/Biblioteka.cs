using knygaCore.Knygos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KnygaCoreBibliotekaCore
{
    public class Biblioteka
    {
        private List<Knyga> knygos = new List<Knyga>();

        public void PridetiKnyga(Knyga knyga)
        {
            knygos.Add(knyga);
        }

        public void TrintiKnyga(int kodas)
        {
            var knyga = knygos.FirstOrDefault(k => k.Kodas == kodas);
            if (knyga != null)
            {
                knygos.Remove(knyga);
                Console.WriteLine($"Knyga '{knyga.Pavadinimas}' ištrinta.");
            }
            else
            {
                Console.WriteLine("Knyga nerasta.");
            }
        }

        public void RodytiKnygas()
        {
            if (knygos.Count == 0)
            {
                Console.WriteLine("Nėra knygų bibliotekoje.");
                return;
            }

            foreach (var knyga in knygos)
            {
                Console.WriteLine(knyga);
            }
        }

        public Knyga RastiNaujausiaKnyga()
        {
            return knygos.OrderByDescending(k => k.IsleidimoMetai).FirstOrDefault();
        }

        public Knyga RastiSeniausiaKnyga()
        {
            return knygos.OrderBy(k => k.IsleidimoMetai).FirstOrDefault();
        }

        public List<Knyga> FiltruotiKnygasPagalMetus(int nuo, int iki)
        {
            return knygos.Where(k => k.IsleidimoMetai >= nuo && k.IsleidimoMetai <= iki).ToList();
        }

        public bool ArYraKnygaSuKodu(int kodas)
        {
            return knygos.Any(k => k.Kodas == kodas);
        }
    }
}
