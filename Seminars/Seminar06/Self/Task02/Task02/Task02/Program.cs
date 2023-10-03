namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a = false;
            bool b = false;
            bool c = false;
            do
            {
                do
                {
                    do
                    {
                        Console.WriteLine($"A={a} B={b} C={c} F={!(a | b & c) | a}");
                        c = !c;
                    } while (c);
                    b = !b;
                } while (b);
                a = !a;
            } while (a);
        }
    }
}