// Ваше решение.
using System;
class Aboba
{
    public static void Main()
    {
        string a = "Число кратно 2 и 3";
        string b = "Число не соответствует условию";
        int number = 0;
        do
        {
            if (number == 20)
            {
                number++;
            }
            else if (number % 2 == 0 && number % 3 == 0)
                {
                    Console.WriteLine($"{number} - {a}");
                    number++;
                }
                else
                {
                    Console.WriteLine($"{number} - {b}");
                    number++;
                }

        } while(number <= 50);
    }
}