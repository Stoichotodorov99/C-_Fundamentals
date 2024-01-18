namespace _02.NumbersInReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            int[] ReverseArray = new int[n];

            for(int i = 0; i < arr.Length;i++)
            {
                ReverseArray[i] = arr[arr.Length - i - 1];
            }

            for (int i = 0; i < ReverseArray.Length; i++)
            {
                Console.Write(ReverseArray[i] + " ");

            }
        }
    }
}
