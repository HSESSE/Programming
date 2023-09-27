namespace Demo03
{
    internal class Program
    {
        public static double sqrCircle(int r) {
            return Math.PI * r * r;
        }

        public static double longCircle(int r)
        {
            return 2 * Math.PI * r;
        }

        public static void writeResult(int r)
        {
            Console.WriteLine("Вычислить площадь или длину? s/l:");
            string s = Console.ReadLine();
            s = s.ToLower();
            if (s == "ы")
            {
                Console.WriteLine("Площадь круга равна {0:#.###}",sqrCircle(r));
                return;
            }
            else
            {
                Console.WriteLine("Длина окружности равна {0:#.##}", longCircle(r));
                return;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус: ");
            string radius = Console.ReadLine();
            int rad = int.Parse(radius);

            writeResult(rad);

            Console.ReadLine();
        }
    }
}