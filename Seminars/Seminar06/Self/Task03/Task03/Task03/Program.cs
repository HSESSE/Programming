namespace Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            //Console.WriteLine(cnt);
            for (int i = 2000; i < 3001; i++) 
            {
                int a4 = i % 10;
                //Console.WriteLine(a4);
                int a3 = (i/ 10) % 10;
                //Console.WriteLine(a3);
                int a2 = (i/100) % 10;
                //Console.WriteLine(a2);
                int a1 = (i / 1000) % 10;
                //Console.WriteLine(a1);
                if (a1!=a2 && a2!=a3 && a3!=a4 && a1!=a4 && a2!=a4 && a1!=a3) { cnt++;
                    //Console.WriteLine(cnt);
                }

            }
            Console.WriteLine(cnt);
        }
    }
}