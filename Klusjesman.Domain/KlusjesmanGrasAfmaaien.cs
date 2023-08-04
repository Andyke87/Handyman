using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klusjesman.Domain
{
    public class KlusjesmanGrasAfmaaien : IActie
    {
        private string grasPerceel{ get; set; }

        public KlusjesmanGrasAfmaaien(string grasPerceel)
        {
            this.grasPerceel = grasPerceel;
        }
        public void Uitvoeren()
        {
            Console.WriteLine($"Het gras in de {grasPerceel} wordt gemaaid.");
        }
    }
}
