using System.Security.Cryptography.X509Certificates;

namespace Task04
{
    internal class Program
    {
        public static double Deistvie(int d, double x, double y)
        {
            if (d == 1)
            {
                return x + y;
            }
            else if (d == 2)
            {
                return x - y;
            }
            else if (d == 3)
            {
                return x * y;
            }
            else
            {
                return x / y;
            }
        }
            public static string Podstavitb(int d)
        {
            if (d == 1)
            {
                return "+";
            }
            else if (d == 2)
            {
                return "-";
            }
            else if (d == 3)
            {
                return "*";
            }
            else
            {
                return "/";
            }
        }

        static void Main()
        {
            for (int i1 = 1; i1 <= 4; i1++)
            {
                for (int i2 = 1; i2 <= 4; i2++)
                {
                    for (int i3 = 1; i3 <= 4; i3++)
                    {
                        for (int i4 = 1; i4 <= 4; i4++)
                        {
                            for (int i5 = 1; i5 <= 4; i5++)
                            {
                                if (Deistvie(i5, Deistvie(i4, Deistvie(i3, Deistvie(i2, Deistvie(i1, 1, 2), 3), 4), 5), 6) == 35)
                                {
                                    Console.WriteLine($"((((1{Podstavitb(i1)}2){Podstavitb(i2)}3){Podstavitb(i3)}4){Podstavitb(i4)}5){Podstavitb(i5)}6 = 35");
                                }
                            }
                        }
                    }
                }
            }
        }
        
    }
}