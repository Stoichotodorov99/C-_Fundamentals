namespace _02.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrOne = Console.ReadLine().Split(" ");
            string[] arrTwo = Console.ReadLine().Split(" ");

            foreach (string elementsTwo in arrTwo )
            {
                for (int i = 0; i < arrOne.Length; i++)
                { 
                if (elementsTwo == arrOne[i])
                    {
                        Console.Write(elementsTwo + " ");
                        break;
                    }
                }
            }
        }
    }
}
