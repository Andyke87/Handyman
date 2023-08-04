using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klusjesman.Domain;

namespace Klusjesman.Domain
{
    public class ActieFactory
    {
        public IActie MaakActie(KlusjesmanActieType actieType, string argument)
        {
            switch(actieType)
            {
                case KlusjesmanActieType.TuinhuisVerven:
                    return new KlusjesmanTuinhuisVerven(argument);
                case KlusjesmanActieType.KraanRepareren:
                    return new KlusjesmanKraanRepareren(argument);
                case KlusjesmanActieType.GrasAfmaaien:
                    return new KlusjesmanGrasAfmaaien(argument);
                default:
                    throw new NotImplementedException("Ongeldig actie");
            }
        }
    }
}
