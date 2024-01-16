namespace ex1.integerOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int divideNumber = int.Parse(Console.ReadLine());
            int multyplyNumber = int.Parse(Console.ReadLine());

            int sumNums = firstNumber + secondNumber;
            int division = sumNums / divideNumber;
            int result = division * multyplyNumber;

            Console.WriteLine(result);



        }
    }
}
