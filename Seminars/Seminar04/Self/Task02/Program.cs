using System;
class Program
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();

        switch (str)
        {
            case "January" or "Январь" or "january" or "январь":
                Console.WriteLine("1");
                break;
            case "February" or "Февраль" or "february" or "февраль":
                Console.WriteLine("2");
                break;
            case "March" or "Март" or "march" or "март":
                Console.WriteLine("3");
                break;
            case "April" or "Апрель" or "april" or "апрель":
                Console.WriteLine("4");
                break;
            case "May" or "Май" or "may" or "май":
                Console.WriteLine("5");
                break;
            case "June" or "Июнь" or "june" or "июнь":
                Console.WriteLine("6");
                break;
            case "July" or "Июль" or "july" or "июль":
                Console.WriteLine("7");
                break;
            case "August" or "Август" or "august" or "август":
                Console.WriteLine("8");
                break;
            case "September" or "Сентябрь" or "september" or "сентябрь":
                Console.WriteLine("9");
                break;
            case "October" or "Октябрь" or "october" or "октябрь":
                Console.WriteLine("10");
                break;
            case "November" or "Ноябрь" or "november" or "ноябрь":
                Console.WriteLine("11");
                break;
            case "December" or "Декабрь" or "december" or "декабрь":
                Console.WriteLine("12");
                break;

            default:
                Console.WriteLine("В году такой месяц отстутствует.");
                break;
        }
    }
}