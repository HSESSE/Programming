namespace Task05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double S = 0.0, P = 1.0;
            double cur;

            int N = int.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());
            double a = A;


            for (int i = 1; i <= N; i++)
            {

                cur = 1 / a;
                S += cur;
                a *= A;

            }

            for (int i = 1; i <= N; i++)
            {
                cur = A - i;
                P *= cur;

            }

            Console.WriteLine($"S = {S}, P = {P}"); 


        }
    }
}