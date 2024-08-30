using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensions
{
    public static class RandomDouble
    {
        public static double NextDouble(this Random random, double x)
        {
            return random.NextDouble() * x;
        }
        public static bool CoinFlip(this Random random, double chance)
        {
            if (chance < 0.0 || chance > 1.0)
                throw new ArgumentException("Chancen skal være mellem 0.0 og 1.0", nameof(chance));

            return random.NextDouble() < chance;
        }
        public static string NextString(this Random random, List<string> strings)
        {
            random.Next(0, strings.Count);
            return strings[random.Next(strings.Count)];
        }
    }
}
