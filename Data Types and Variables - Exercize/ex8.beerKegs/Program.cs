namespace ex8.beerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double biggestKeg = double.MinValue;
            string biggestKegModelName = ""; 

            for (int i = 0; i < n; i++)
            { 
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int hight = int.Parse(Console.ReadLine());
                double volumeOfCurrentKeg = Math.PI * Math.Pow(radius, 2) * hight;
                if (volumeOfCurrentKeg > biggestKeg)
                {
                    biggestKeg = volumeOfCurrentKeg;

                }
            }
            Console.WriteLine(biggestKegModelName);
        }
    }
}
