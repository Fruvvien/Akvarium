using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akvarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EdesViziEloleny edesViziEloleny = new EdesViziEloleny("Ponty");
            SosViziEloleny sosViziEloleny = new SosViziEloleny("Bálna");

            Aquarium<SosViziEloleny> aquarium = new Aquarium<SosViziEloleny>();

            aquarium.AddCreature(sosViziEloleny);

            Aquarium<EdesViziEloleny> aquarium1 = new Aquarium<EdesViziEloleny>();
            aquarium1.AddCreature(edesViziEloleny);
        }
    }
}
