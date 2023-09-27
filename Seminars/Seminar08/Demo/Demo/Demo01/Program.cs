namespace Demo01
{
    internal class Program
    {
        static void p_ref(int a1, int b1, ref int s)
        {
            s = a1 + b1;
            Console.WriteLine("\n p_ref ");
            Console.WriteLine(" a1 {0} b1 {1}", a1, b1);
            Console.WriteLine(" Сумма {0} ", s);
        }
        
        static void Main(string[] args)
        {
            int s1 = 0;
            Console.WriteLine(" Main s1 {0}", s1);
            int a = 2, b = 3;
            p_ref(a, b, ref s1);
            Console.WriteLine(" \n Опять Main a {0} b {1} s1 {2} ", a, b, s1);
        }
    }
}