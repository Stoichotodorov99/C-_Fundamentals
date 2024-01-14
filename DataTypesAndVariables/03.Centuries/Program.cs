namespace _03.Centuries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte Centuries = byte.Parse(Console.ReadLine());
            short years = (short)(Centuries * 100);
            int days = (int)(years * 365.2422);
            long hours = days * 24; 
            long minutes = days * 60;
            Console.WriteLine($"{Centuries} Centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");

        }
    }
}
