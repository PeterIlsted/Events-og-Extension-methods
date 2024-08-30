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
            List<string> list = new List<string>() { "Nord", "Syd", "Øst", "Vest" };
            Console.WriteLine(random.NextString(list));
            
        }
    }
}
