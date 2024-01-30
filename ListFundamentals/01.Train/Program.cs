
namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> waggons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string comands = Console.ReadLine();    

            while (comands != "end")
            {
                string[] tokens = comands.Split();
                if (tokens.Length == 2)
                {
                    int currentWaggons = int.Parse(tokens[1]);
                    waggons.Add(currentWaggons);

                }
                else
                {
                    int currentCapacity = int.Parse(tokens[0]);
                    FindWaggon(waggons, maxCapacity, currentCapacity);
                }
                comands = Console.ReadLine();    
            }
            Console.WriteLine(string.Join(" ", waggons)); 
        }

        private static void FindWaggon(List<int> waggons, int maxCapacity, int currentCapacity)
        {
            for (int i = 0; i < waggons.Count; i++)
            {
                if (waggons[i] + currentCapacity <= maxCapacity)
                {
                    waggons[i] += currentCapacity;
                    break;
                }
            }
        }
    }
}
