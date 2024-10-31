public class Program
{
    public static void Main(string[] args)
    {
        Biblioteka biblioteka = new Biblioteka();


        biblioteka.PridetiKnyga(new Knyga(001, "Knyga 1", "Autorius 1", 2020, 1));
        biblioteka.PridetiKnyga(new Knyga(002, "Knyga 2", "Autorius 2", 2021, 2));


        biblioteka.RodytiKnygas();


        biblioteka.TrintiKnyga(1);


        var naujausia = biblioteka.RastiNaujausiaKnyga();
        Console.WriteLine("Naujausia knyga: " + naujausia);


        var seniausia = biblioteka.RastiSeniausiaKnyga();
        Console.WriteLine("Seniausia knyga: " + seniausia);


        var filtruotos = biblioteka.FiltruotiKnygasPagalMetus(2019, 2021);
        Console.WriteLine("Filtruotos knygos (2019-2021):");
        foreach (var knyga in filtruotos)
        {
            Console.WriteLine(knyga);
        }


        bool arYra = biblioteka.ArYraKnygaSuKodu(2);
        Console.WriteLine(arYra ? "Knyga randama." : "Knyga nerandama.");
    }
