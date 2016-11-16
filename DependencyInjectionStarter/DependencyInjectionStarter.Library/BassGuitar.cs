using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInjectionStarter.Library
{
    public class BassGuitar : IInstrument
    {
        public string PlayBassLine()
        {
            return "Boooow Boooow Boooooow";
        }

        public string Play()
        {
            return PlayBassLine();
        }
    }
}
