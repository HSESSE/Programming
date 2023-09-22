internal class Program
{
    public static void Main()
    {
        string? data = Console.ReadLine();

        int output = data.ToLower() /* Nintendo */ switch
        {
            "january" or "январь" => 1,
            "february" or "февраль" => 2,
            "march" or "март" => 3,
            "april" or "апрель" => 4,
            "may" or "май" => 5,
            "june" or "июнь" => 6,
            "july" or "июль" => 7,
            "august" or "август" => 8,
            "september" or "сентябрь" => 9,
            "october" or "октябрь" => 10,
            "november" or "ноябрь" => 11,
            "december" or "декабрь" => 12,
            _ => 0
        };
        
        if (output == 0)
        {
            Console.WriteLine("В году такой месяц отсутствует");
            Console.ReadKey();
            return;
        }

        Console.WriteLine(output);
        Console.ReadKey();
    }
}