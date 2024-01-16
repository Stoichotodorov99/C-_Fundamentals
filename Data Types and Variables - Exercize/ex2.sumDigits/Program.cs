namespace ex2.sumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int finalSum = 0;
            char[] charArr = input.ToCharArray();

            for (int i = 0; i < charArr.Length; i++)
            {
                finalSum += int.Parse(charArr[i].ToString());

            }
            Console.WriteLine(finalSum);

            //        int numToSum = int.Parse(Console.ReadLine());
            //        int finalSum = 0;

            //        while (numToSum != 0)
            //        {
            //            int lastDigit = numToSum % 10;
            //            finalSum += lastDigit;
            //            numToSum /= 10;

            //        }
            //        Console.WriteLine(finalSum);
            //    }


        }
    }
}