namespace Task1
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.Write("Введите количество углов n: ");
            int.TryParse(Console.ReadLine(), out int n);   // считываем из консоли значения n и l 
            if (n == 0)
            {
                Console.WriteLine("n не может быть равно 0");
                return;
            }
            Console.WriteLine();

            Console.Write("Введите длину стороны l: ");
            double.TryParse(Console.ReadLine(), out double l);
            Console.WriteLine();

            if (n >= 1 && n <= 11 && l > 0)
            {
                double S = ((double)n * l * l) / (4 * Math.Tan((Math.PI) / (double)n));  // после проверки корректности введенных значений, высчитываем площадь
                Console.WriteLine($"площадь многоугольника S = {S}");
            }
            else
            {
                Console.WriteLine("Неверные значения");

            }
            Console.WriteLine("нажмите enter, чтобы закрыть");
            Console.ReadLine();
        }
    }
}