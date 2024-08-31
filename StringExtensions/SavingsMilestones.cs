using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensions
{
    internal class SavingsMilestones
    {
        public event EventHandler<String> SavingsMilestonesAchieved;
        
        int seasonPass = 0, SeasonPassPrice = 399;
        int PremiumSeasonPass = 0, PremiumPassPrice = 799;
        
        public void CheckForThresshold(double money)
        {
            if((int)(money / SeasonPassPrice) > seasonPass)
            {
                seasonPass = (int)(money / SeasonPassPrice);
                OnProcessCompleted($"Tillykke - Du har nu penge nok til at købe {seasonPass} sæsonkort til OB's kampe.");
            }
            if((int)(money / PremiumPassPrice) > PremiumSeasonPass) 
            { 
                PremiumSeasonPass = (int)(money / PremiumPassPrice);
                OnProcessCompleted($"Tillykke - Du har nu penge nok til at købe {PremiumSeasonPass} premium sæsonkort til OB's kampe.");
            }
        }
        protected virtual void OnProcessCompleted(string message) { SavingsMilestonesAchieved?.Invoke(this, message); }
    }
}
