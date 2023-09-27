namespace Demo02
{
    internal class Program
    {
        public static void Sum1(int a, int b)
        {
            int c;
            c = a + b;
            Console.WriteLine(c);
        }

        public static int Sum2(int a, int b)
        {
            int c;
            c = a + b;
            return c;
        }

        static void Main(string[] args)
        {
            int p1 = 10, p2 = 30;
            Sum1(p1, p2);
            int r;
            r = Sum2(5, 10);
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }
}