using System.Globalization;

namespace _05.CondanceArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ArrOfNum = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while(ArrOfNum.Length > 1)

            {
                int[] Condanced = new int[ArrOfNum.Length - 1];

                for (int i = 0; i < Condanced.Length; i++)
                {
                    Condanced[i] = ArrOfNum[i] + ArrOfNum[i + 1];
                }
                ArrOfNum = Condanced;
                    
            }
            Console.WriteLine(string.Join(" ", ArrOfNum));
        }
    }
}
