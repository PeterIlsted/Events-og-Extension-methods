namespace StringExtensions
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("a".Capitalize());
            Random random = new Random();
            double Probability = 0.5;
            double chance = random.NextDouble(Probability);
            Console.WriteLine(chance);
            Console.WriteLine("NextDouble: " + random.NextDouble(Probability));
            for (int i = 0;i < 10; i++)
            {
                bool flip = random.CoinFlip(0.5);
                if(flip == false) { Console.WriteLine("Heads"); }
                else { Console.WriteLine("Tails"); }
            }
            for(int i = 0;i < 10; i++)
            {
                List<string> list = new List<string>() { "Nord", "Syd", "Øst", "Vest" };
                Console.WriteLine(random.NextString(list));
            }

            Console.WriteLine("\n\nEvents starter her:");
            Piggybank piggybank = new Piggybank();
            SavingsMilestones milestones = new SavingsMilestones();
            milestones.SavingsMilestonesAchieved += Milestones_SavingsMilestonesAchieved;
            double Ammount = 0;
            
            do
            {
                Console.Write("Hvor mange penge vil du sætte ind? ");
                
                if(double.TryParse(Console.ReadLine(), out Ammount))
                {
                    piggybank.AddMoney(Math.Round(Ammount,2));
                    piggybank.AnnounceMoney();
                    milestones.CheckForThresshold(piggybank.Money);
                }
                
            }
            while(Ammount != 0);

            milestones.SavingsMilestonesAchieved -= Milestones_SavingsMilestonesAchieved;

            Console.WriteLine("Events Metronome øvelse:");
            bool tock = false;
            TickListener listener = new TickListener();
            listener.Listener += Listener_OnTick;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Metronome.OnTick(tock));
                listener.ListenForTicks();
                if(tock == false)
                    tock = true;
                else tock = false;


            }
            listener.Listener -= Listener_OnTick;
        }

        private static void Milestones_SavingsMilestonesAchieved(object sender, string message)
        {
            Console.WriteLine(message);
        }
        private static void Listener_OnTick(object sender, string message)
        {
            Console.WriteLine(message);
        }
    }
}
