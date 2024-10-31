using AutomobilisCore.Auto;
using System;

namespace AutomobiliuParkas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AutomobiliuParkas automobiliuParkas = new AutomobiliuParkas();
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("\nPasirinkite veiksmą:");
                Console.WriteLine("1. Pridėti automobilį");
                Console.WriteLine("2. Rodyti visus automobilius");
                Console.WriteLine("3. Ištrinti automobilį");
                Console.WriteLine("4. Rasti automobilį pagal markę");
                Console.WriteLine("5. Rasti naujausią automobilį");
                Console.WriteLine("6. Rasti seniausią automobilį");
                Console.WriteLine("7. Filtruoti automobilius pagal metus");
                Console.WriteLine("8. Patikrinti, ar automobilis egzistuoja");
                Console.WriteLine("9. Atnaujinti automobilio informaciją");
                Console.WriteLine("10. Baigti");

                string pasirinkimas = Console.ReadLine();

                switch (pasirinkimas)
                {
                    case "1":
                        Console.Write("Įveskite automobilio markę: ");
                        string marke = Console.ReadLine();
                        Console.Write("Įveskite automobilio modelį: ");
                        string modelis = Console.ReadLine();
                        Console.Write("Įveskite automobilio gamybos metus: ");
                        int metai = int.Parse(Console.ReadLine());
                        Console.Write("Įveskite automobilio registracijos numerį: ");
                        string numeris = Console.ReadLine();

                        automobiliuParkas.PridetiAutomobili(new Automobilis(marke, modelis, metai, numeris));
                        Console.WriteLine("Automobilis pridėtas.");
                        break;

                    case "2":
                        automobiliuParkas.RodytiVisusAutomobilius();
                        break;

                    case "3":
                        Console.Write("Įveskite automobilio registracijos numerį, kurį norite ištrinti: ");
                        string numerisTrinti = Console.ReadLine();
                        automobiliuParkas.TrintiAutomobili(numerisTrinti);
                        break;

                    case "4":
                        Console.Write("Įveskite automobilio markę: ");
                        string markeIeškoti = Console.ReadLine();
                        var rastiAutomobiliai = automobiliuParkas.RastiPagalMarke(markeIeškoti);
                        Console.WriteLine("Rasti automobiliai:");
                        foreach (var automobilis in rastiAutomobiliai)
                        {
                            Console.WriteLine(automobilis);
                        }
                        break;

                    case "5":
                        var naujausias = automobiliuParkas.RastiNaujausiaAutomobili();
                        Console.WriteLine("Naujausias automobilis: " + (naujausias != null ? naujausias.ToString() : "Nėra automobilių."));
                        break;

                    case "6":
                        var seniausias = automobiliuParkas.RastiSeniausiaAutomobili();
                        Console.WriteLine("Seniausias automobilis: " + (seniausias != null ? seniausias.ToString() : "Nėra automobilių."));
                        break;

                    case "7":
                        Console.Write("Įveskite nuo metų: ");
                        int nuo = int.Parse(Console.ReadLine());
                        Console.Write("Įveskite iki metų: ");
                        int iki = int.Parse(Console.ReadLine());

                        var filtruotiAutomobiliai = automobiliuParkas.FiltruotiPagalMetus(nuo, iki);
                        Console.WriteLine("Filtruoti automobiliai:");
                        foreach (var automobilis in filtruotiAutomobiliai)
                        {
                            Console.WriteLine(automobilis);
                        }
                        break;

                    case "8":
                        Console.Write("Įveskite automobilio registracijos numerį: ");
                        string numerisPatikrinti = Console.ReadLine();
                        bool arYra = automobiliuParkas.ArYraAutomobilis(numerisPatikrinti);
                        Console.WriteLine(arYra ? "Automobilis randamas." : "Automobilis nerandamas.");
                        break;

                    case "9":
                        Console.Write("Įveskite automobilio registracijos numerį, kurio informaciją norite atnaujinti: ");
                        string numerisAtnaujinti = Console.ReadLine();
                        Console.Write("Įveskite naują markę: ");
                        string naujaMarke = Console.ReadLine();
                        Console.Write("Įveskite naują modelį: ");
                        string naujasModelis = Console.ReadLine();
                        Console.Write("Įveskite naujus gamybos metus: ");
                        int naujiMetai = int.Parse(Console.ReadLine());

                        automobiliuParkas.AtnaujintiAutomobili(numerisAtnaujinti, naujaMarke, naujasModelis, naujiMetai);
                        break;

                    case "10":
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
}
