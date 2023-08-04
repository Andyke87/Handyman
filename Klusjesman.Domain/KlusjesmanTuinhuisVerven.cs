using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klusjesman.Domain
{
    public class KlusjesmanTuinhuisVerven : IActie
    {
        private string tuinhuis { get; set; }
        public KlusjesmanTuinhuisVerven(string tuinhuis)
        {
            this.tuinhuis = tuinhuis;
        }
        public void Uitvoeren()
        {
            Console.WriteLine($"Het tuinhuis wordt geverfd in de kleur {tuinhuis}.");
        }
    }
}
