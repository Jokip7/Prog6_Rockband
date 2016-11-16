using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInjectionStarter.Library
{
    public class Drums : IInstrument
    {
        public string Drum()
        {
            return "Boom chack, Boom Boom chack";
        }


        public string Play()
        {
            return Drum();
        }
    }
}
