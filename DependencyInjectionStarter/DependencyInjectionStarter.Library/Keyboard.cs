using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionStarter.Library
{
    public class Keyboard : IInstrument
    {
        public string Play()
        {
            return "If I shall exist eternally, how shall I exist tomorrow?";
        }
    }
}
