namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = Console.ReadLine().Split().Select(int.Parse).ToList();
            string line = Console.ReadLine();
            while (line != "end")
            {
                string[] tokens = line.Split();
                string command = tokens[0];

                if (command == "Delete")
                {
                    int element = int.Parse(tokens[1]);
                    intList.RemoveAll(el => el == element);

                }
                else if (command == "Insert")
                {
                    int element = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    for (int i = 0; i < intList.Count; i++)
                    {
                        if (i == index)
                        {
                            intList.Insert(index, element);
                        }
                    }
                }
                line = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", intList));
        }
    }
}
