using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klusjesman.Domain
{
    public class Klusjesman
    {
        private List<IActie> acties = new List<IActie>();
        public void VoegActieToe(IActie actie)
        {
            acties.Add(actie);
        }
        public void VoerActiesUit()
        {
            foreach (var actie in acties)
            {
                actie.Uitvoeren();
            }
        }
        public void EventHandler(object sender, EventArgs e)
        {
            VoerActiesUit();
        }
    }
}
