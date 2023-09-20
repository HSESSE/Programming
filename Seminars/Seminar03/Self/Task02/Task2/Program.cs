namespace Task2
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.Write("Введите x: ");
            double.TryParse(Console.ReadLine().Replace('.', ','), out double x);
            Console.WriteLine();

            Console.Write("Введите y: ");
            double.TryParse(Console.ReadLine().Replace('.', ','), out double y);
            Console.WriteLine();

            double distance_from_center = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

            if ((y >= 0 && (Math.Abs(distance_from_center) == 2)) || (y == 0 && (Math.Abs(distance_from_center) >= 1 && Math.Abs(distance_from_center) < 2)) || (y > 0 && (Math.Abs(distance_from_center) == 1)))
            {
                Console.WriteLine("Попадание в границу");
            }     
            else if (y > 0 && (Math.Abs(distance_from_center) > 1 && Math.Abs(distance_from_center) < 2))
            {
                Console.WriteLine("Попадание в область");
            }
            else
            {
                Console.WriteLine("Попадание вне области");
            }

            Console.WriteLine("нажмите enter");
            Console.ReadLine();
        }
    }
}