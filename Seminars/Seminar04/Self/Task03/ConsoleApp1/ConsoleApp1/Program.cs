namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            uint zifra;
            Console.WriteLine("Введите операцию цифрой от 1 до 4: ");

            string ArfDeistvie = Console.ReadLine();

            Console.WriteLine("Введите вещественные числа сначала А, потом В: ");

            double A = double.Parse(Console.ReadLine());

            double B = double.Parse(Console.ReadLine());

            zifra = uint.Parse(ArfDeistvie);

            if (zifra == 1 && (A != 0 && B != 0))
            {
                Console.WriteLine("A + B = " + (A + B));

            }
            else if (zifra == 2 && (A != 0 && B != 0))
            {
                Console.WriteLine("A - B = " + (A - B));

            }
            else if (zifra == 3 && (A != 0 && B != 0))
            {
                Console.WriteLine("A * B = " + (A * B));

            }
            else if (zifra == 4 && (A != 0 && B != 0))
            {
                Console.WriteLine("A / B = " + (A / B));

            }
            else
            {
                Console.WriteLine("Нет такой операции");

            }
        }
    }
}