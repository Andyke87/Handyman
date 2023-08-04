using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klusjesman.Domain
{
    public class KlusjesmanKraanRepareren : IActie
    {
        private string kraan { get; set; }
        public KlusjesmanKraanRepareren(string kraan)
        {
            this.kraan = kraan;
        }
        public void Uitvoeren()
        {
            Console.WriteLine($"De kraan in de {kraan} wordt gerepareerd.");
        }
    }
}
