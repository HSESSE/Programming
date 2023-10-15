// Your code here!
using System;
class Program
{
    static void Main()
    {
        string firstname = Console.ReadLine();
        string lastname= Console.ReadLine();
        string secondname = Console.ReadLine();

        Console.WriteLine($"Фамилия: {firstname}");
        Console.WriteLine($"Имя: {lastname}");
        Console.WriteLine($"Отчество: {secondname}");
    }
}