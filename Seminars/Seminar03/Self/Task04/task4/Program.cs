namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            double.TryParse(Console.ReadLine().Replace('.', ','), out double x);
            Console.WriteLine();

            Console.Write("Введите y: ");
            double.TryParse(Console.ReadLine().Replace('.', ','), out double y);
            Console.WriteLine();

            double F = 0;

            if (x < y)
            {
                F = Math.Sin(x) + Math.Pow(Math.Cos(y), 2);
            }
            else if (x == y)
            {
                F = Math.Log(Math.Abs(x));
            }
            else if (x > y)
            {
                F = Math.Pow(Math.Sin(x), 2) + Math.Cos(y);
            }

            Console.WriteLine(F);

            Console.WriteLine("нажмите enter");
            Console.ReadLine();
        }
    }
}