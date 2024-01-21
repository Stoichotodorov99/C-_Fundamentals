namespace _03.zigZagArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] evenArray = new int[n];
            int[] oddArray = new int[n];


            for (int i = 0; i < n; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray(); 

                if (i % 2 == 0)
                {
                    evenArray[i] = numbers[0];
                    oddArray[i] = numbers[1];
                }
                else
                {
                    evenArray[i] = numbers[1];
                    oddArray[i] = numbers[0];
                }
            }
            Console.WriteLine(String.Join(" ", evenArray));
            Console.WriteLine(String.Join(" ", oddArray));
        }
    }
}
