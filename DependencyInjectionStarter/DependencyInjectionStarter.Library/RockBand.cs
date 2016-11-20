using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionStarter.Library
{
    public class RockBand
    {
        private List<IInstrument> instruments;
        private Guitar guitar = new Guitar();
        private BassGuitar bassGuitar = new BassGuitar();
        private Drums drums = new Drums();
        private Vocal vocal = new Vocal();

        public RockBand()
        {
            instruments.Add(new Guitar());
            instruments.Add(new BassGuitar());
            instruments.Add(new Drums());
            instruments.Add(new Vocal());
        }

        public RockBand(List<IInstrument> instrumentsList)
        {
            instruments = instrumentsList;
        }

        public void DoSoundCheck()
        {
            Console.WriteLine("=~=~=~ Sound Check ~=~=~=");
            Console.WriteLine("");
            foreach (var instrument in instruments)
            {
                Console.WriteLine(instrument.Play());
            }
            Console.WriteLine("");
            Console.WriteLine("=~=~=~=~=~= * =~=~=~=~=~=");
            Console.WriteLine("");
        }
    }
}
