using System;
class Program1
{
    static void Main()
    {
        string str = Console.ReadLine();
        char a = str[0];
        switch (a)
        {
            case >='0' and <='9':
                Console.WriteLine($"{a} 100");
                break;
            case >='A' and <='Z':
                Console.WriteLine($"{a} 200");
                break;
            case >='a' and <='z':
                Console.WriteLine($"{a} 300");
                break;

            default:
                Console.WriteLine($"{a} 400");
                break;
        }
    }
}