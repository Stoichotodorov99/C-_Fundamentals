namespace _04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            for(int rotation = 0; rotation < rotations; rotation++)
            {
                int temp = Arr[0];
                for(int operations = 0; operations < Arr.Length - 1; operations++)
                {
                    Arr[operations] = Arr[operations + 1];
                }

                Arr[Arr.Length - 1] = temp;

            }
            Console.WriteLine(string.Join(" ", Arr));
            
        }
    }
}
