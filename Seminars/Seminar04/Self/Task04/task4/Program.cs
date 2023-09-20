namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите A + оператор + B: ");
            string? str = Console.ReadLine().Replace('.', ',');
            Console.WriteLine();

            string[] arr = str.Split();

            double.TryParse(arr[0], out double A);
            char.TryParse(arr[1], out char op);
            double.TryParse(arr[2], out double B);

            switch (op)
            {
                case ('+'):
                    Console.WriteLine(A + B);
                    break;

                case ('-'):
                    Console.WriteLine(A - B);
                    break;

                case ('*'):
                    Console.WriteLine(A * B);
                    break;

                case ('/'):
                    if (B != 0)
                    {
                        Console.WriteLine(A / B);
                    }
                    else
                    {
                        Console.WriteLine("Нельзя делить на ноль");
                    }
                    break;

                default:
                    Console.WriteLine("Что-то пошло не так");
                    break;
            }





        }
    }
}