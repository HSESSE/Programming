namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string chislo = Console.ReadLine();

            int ch,
                c1, c2, c3;
            ch = int.Parse(chislo);

            c1 = Math.Abs(ch) % 10;
            ch /= 10;
            c2 = Math.Abs(ch) % 10;
            ch /= 10;
            c3 = Math.Abs(ch) % 10;
            Console.WriteLine(c3);
            Console.WriteLine(c2);
            Console.WriteLine(c1);
        }
    }
}