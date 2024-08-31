using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piggybank
{
    internal class Piggybank
    {
        public double Money {  get; set; }
        public void AddMoney(double amount) { Money += amount; }
        public void AnnounceMoney() { Console.WriteLine($"Saldoen er: {Money}"); }
    }
}
