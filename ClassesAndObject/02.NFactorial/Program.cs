using System.Numerics;
namespace _02.NFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            FactorialCalculator calculator = new FactorialCalculator(n);
            Console.WriteLine(calculator.Calculate());

        }
    }
}
