namespace Task06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 1000 ; i++)
            {
                if (i > 99)
                {
                    int a3 = i % 10;
                    int a2 = i / 10 % 10;
                    int a1 = i / 100;
                    if (a3 == a2 && a2 == a1 && a3 == a1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}