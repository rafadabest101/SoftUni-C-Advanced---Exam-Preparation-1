namespace SoftUni_CSharpAdvancedExamPrep1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> fuelInts = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> indexes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> amounts = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int currentAltitude = 1;
            List<int> reachedAltitudes = new List<int>();
            while(fuelInts.Count > 0)
            {
                if(fuelInts[fuelInts.Count - 1] - indexes[0] >= amounts[0])
                {
                    Console.WriteLine($"John has reached: Altitude {currentAltitude}");
                    reachedAltitudes.Add(currentAltitude);
                    currentAltitude++;
                    fuelInts.RemoveAt(fuelInts.Count - 1);
                    indexes.RemoveAt(0);
                    amounts.RemoveAt(0);
                }
                else
                {
                    Console.WriteLine($"John did not reach: Altitude {currentAltitude}");
                    Console.WriteLine($"John failed to reach the top.");
                    if(reachedAltitudes.Count > 0)
                    {
                        Console.WriteLine($"Reached altitudes: Altitude {string.Join(", Altitude ", reachedAltitudes)}");
                    }
                    else Console.WriteLine("John didn't reach any altitude.");
                    return;
                }
            }

            Console.WriteLine($"John has reached all the altitudes and managed to reach the top!");
        }
    }
}