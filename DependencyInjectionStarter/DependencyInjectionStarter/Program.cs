using DependencyInjectionStarter.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionStarter
{
    class Program
    {
        static void Main(string[] args)
        {
            var metallicaInstruments = new List<IInstrument>();

            metallicaInstruments.Add(new Guitar());
            metallicaInstruments.Add(new Guitar());
            metallicaInstruments.Add(new BassGuitar());
            metallicaInstruments.Add(new Drums());
            metallicaInstruments.Add(new Vocal());

            var metallica = new RockBand(metallicaInstruments);
            metallica.DoSoundCheck();

            var coldplayInstruments = new List<IInstrument>();

            coldplayInstruments.Add(new Guitar());
            coldplayInstruments.Add(new BassGuitar());
            coldplayInstruments.Add(new Drums());
            coldplayInstruments.Add(new Vocal());
            coldplayInstruments.Add(new Keyboard());

            var coldplay = new RockBand(coldplayInstruments);
            coldplay.DoSoundCheck();

            Console.ReadKey();
        }
    }
}
