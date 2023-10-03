namespace Task01
{
    internal class Program
    {
        static void Main()
        {
            int number = 0;
            do
            {
                if (number == 20) // если число нужно исключить     
                { continue;
                }
                else if (number % 2 == 0 && number % 3 == 0)
                {
                   Console.WriteLine($"{number}  Число кратно 2 и 3");
                }
                else
                {
                    Console.WriteLine($"{number} Число не соответствует условию");
                }
        } while (++number <= 50);
        }
    }
}