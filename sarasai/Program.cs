using System;
using knygaCore.Knygos;
using KnygaCoreBibliotekaCore;

public class Program
{
    public static void Main(string[] args)
    {
        Biblioteka biblioteka = new Biblioteka();
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("\nPasirinkite veiksmą:");
            Console.WriteLine("1. Pridėti knygą");
            Console.WriteLine("2. Rodyti knygas");
            Console.WriteLine("3. Ištrinti knygą");
            Console.WriteLine("4. Rasti naujausią knygą");
            Console.WriteLine("5. Rasti seniausią knygą");
            Console.WriteLine("6. Filtruoti knygas pagal metus");
            Console.WriteLine("7. Patikrinti, ar yra knyga su konkrečiu kodu");
            Console.WriteLine("8. Baigti");

            string pasirinkimas = Console.ReadLine();

            switch (pasirinkimas)
            {
                case "1":
                    Console.Write("Įveskite knygos ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Įveskite knygos pavadinimą: ");
                    string pavadinimas = Console.ReadLine();
                    Console.Write("Įveskite autoriaus vardą: ");
                    string autorius = Console.ReadLine();
                    Console.Write("Įveskite išleidimo metus: ");
                    int isleidimoMetai = int.Parse(Console.ReadLine());
                    Console.Write("Įveskite knygos kodą: ");
                    int kodas = int.Parse(Console.ReadLine());

                    biblioteka.PridetiKnyga(new Knyga(id, pavadinimas, autorius, isleidimoMetai, kodas));
                    Console.WriteLine("Knyga pridėta.");
                    break;

                case "2":
                    biblioteka.RodytiKnygas();
                    break;

                case "3":
                    Console.Write("Įveskite knygos kodą, kurią norite ištrinti: ");
                    int kodasTrinti = int.Parse(Console.ReadLine());
                    biblioteka.TrintiKnyga(kodasTrinti);
                    break;

                case "4":
                    var naujausia = biblioteka.RastiNaujausiaKnyga();
                    Console.WriteLine("Naujausia knyga: " + (naujausia != null ? naujausia.ToString() : "Nėra knygų."));
                    break;

                case "5":
                    var seniausia = biblioteka.RastiSeniausiaKnyga();
                    Console.WriteLine("Seniausia knyga: " + (seniausia != null ? seniausia.ToString() : "Nėra knygų."));
                    break;

                case "6":
                    Console.Write("Įveskite nuo metų: ");
                    int nuo = int.Parse(Console.ReadLine());
                    Console.Write("Įveskite iki metų: ");
                    int iki = int.Parse(Console.ReadLine());

                    var filtruotos = biblioteka.FiltruotiKnygasPagalMetus(nuo, iki);
                    Console.WriteLine("Filtruotos knygos:");
                    foreach (var knyga in filtruotos)
                    {
                        Console.WriteLine(knyga);
                    }
                    break;

                case "7":
                    Console.Write("Įveskite knygos kodą: ");
                    int kodasPatikrinti = int.Parse(Console.ReadLine());
                    bool arYra = biblioteka.ArYraKnygaSuKodu(kodasPatikrinti);
                    Console.WriteLine(arYra ? "Knyga randama." : "Knyga nerandama.");
                    break;

                case "8":
                    isRunning = false;
                    Console.WriteLine("Programa baigta.");
                    break;

                default:
                    Console.WriteLine("Neteisingas pasirinkimas, bandykite dar kartą.");
                    break;
            }
        }
    }
}
