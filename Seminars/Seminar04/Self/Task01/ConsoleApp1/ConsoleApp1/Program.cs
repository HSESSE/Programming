namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()

        {
            char a = char.Parse(Console.ReadLine());
            switch (a)
            {
                case >= '1' and <= '9':
                    Console.WriteLine("100"); break;

                case >= 'A' and <= 'Z':
                    Console.WriteLine("200"); break;

                case >= 'a' and <= 'z':
                    Console.WriteLine("300"); break;

                default: Console.WriteLine("400"); break;



            }
        }
    }
}