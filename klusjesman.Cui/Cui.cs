using Klusjesman.Domain;

namespace klusjesman.Cui
{
    public class Cui 
    { 
        private KlusjesmanController klusjesmanController;

        public Cui(KlusjesmanController klusjesmanController)
        {
            this.klusjesmanController = klusjesmanController;
        }

        // Voeg een actie toe op basis van gebruikersinvoer
        public void VoegActieToeVanGebruikersinvoer()
        {
            Console.WriteLine("Voeg een actie toe:");
            Console.WriteLine("1. Gras afmaaien");
            Console.WriteLine("2. Kraan repareren");
            Console.WriteLine("3. Tuinhuis verven");
            Console.WriteLine("4. Stoppen met klusjes geven en de taken laten uitvoeren");

            bool stoppen = false;
            while (!stoppen)
            {
                Console.Write("Maak u keuze: ");
                string keuze = Console.ReadLine();

                switch (keuze)
                {
                    case "1":
                        Console.Write("Geef het adres: ");
                        string perceelnummer = Console.ReadLine();
                        klusjesmanController.VoegActieToe(KlusjesmanActieType.GrasAfmaaien, perceelnummer);
                        break;
                    case "2":
                        Console.Write("Geef de locatie van de kraan: ");
                        string kraan = Console.ReadLine();
                        klusjesmanController.VoegActieToe(KlusjesmanActieType.KraanRepareren, kraan);
                        break;
                    case "3":
                        Console.Write("Geef de kleur voor het tuinhuis: ");
                        string tuinhuis = Console.ReadLine();
                        klusjesmanController.VoegActieToe(KlusjesmanActieType.TuinhuisVerven, tuinhuis);
                        break;
                    case "4":
                        Console.WriteLine("De klussen zullen nu uitgevoerd worden.\n");
                        stoppen = true;
                    break;
                    default:
                        Console.WriteLine("Deze keuze is momenteel niet mogelijk.");
                        break;
                }
            }
        }
        public void RoepEventHandlerAan()
        {
            klusjesmanController.RoepEventHandlerAan();
        }

    }
}