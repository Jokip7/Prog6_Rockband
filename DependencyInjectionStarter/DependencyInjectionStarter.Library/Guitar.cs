using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInjectionStarter.Library
{
    public class Guitar : IInstrument
    {
        public string PlayRiff()
        {
            return "wwhoaaaaaaaa wee wee";
        }

        public string Play()
        {
            return PlayRiff();
        }
    }
}
