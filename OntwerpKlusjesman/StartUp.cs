using klusjesman.Cui;
using Klusjesman.Domain;

namespace OntwerpKlusjesman
{
    public class StartUp
    {
        public class Startup
        {
            static void Main(string[] args)
            {
                KlusjesmanController klusjesmanController = new();
                Cui cui = new(klusjesmanController);

                cui.VoegActieToeVanGebruikersinvoer();
                cui.RoepEventHandlerAan();
            }
        }
    }
}