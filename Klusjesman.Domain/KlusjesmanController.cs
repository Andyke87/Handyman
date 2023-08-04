namespace Klusjesman.Domain
{
   
    public class KlusjesmanController
    {
        private ActieFactory factory;
        private Klusjesman klusjesman;

        public KlusjesmanController()
        {
            klusjesman = new Klusjesman();
            factory = new ActieFactory();
        }

        // Voeg een actie toe aan de klusjesman
        public void VoegActieToe(KlusjesmanActieType actieType, string argument)
        {
            IActie actie = factory.MaakActie(actieType, argument);
            klusjesman.VoegActieToe(actie);
        }

        // Roep de EventHandler aan van de klusjesman
        public void RoepEventHandlerAan()
        {
            klusjesman.EventHandler(null, EventArgs.Empty);
        }
    }
}