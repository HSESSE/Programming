namespace Task07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chislo = int.Parse(Console.ReadLine());

            while (chislo > 0)
            {
                if (chislo %10 != 0)
                {
                    Console.WriteLine(chislo % 10);
                }
                chislo /= 10;
            }
        }
    }
}