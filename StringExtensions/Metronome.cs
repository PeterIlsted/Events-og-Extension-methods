using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensions
{
    public static class Metronome
    {
        public static string OnTick(bool tock)
        {
            System.Threading.Thread.Sleep(3000);
            string tick = string.Empty;
            if (tock == false)
                tick = "Tick";
            else
                tick = "Tock";
            return tick;
        }
    }
}
