using System.Runtime.Serialization;
using System.Runtime.Intrinsics.X86;
using Microsoft.VisualBasic;
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ввод: ");
        string str = Console.ReadLine();
        string[] strings = str.Split(' ');
        if (strings.Length != 3)
        {
            Console.WriteLine("Переполнение");
        }
        else
        {
            string a = strings[0];
            string b = strings[2];
            char op = Convert.ToChar(strings[1]);

            switch(op)
            {
                case '+':
                    double.TryParse(a, out double aa);
                    double.TryParse(b, out double bb);
                    Console.Write("Вывод: ");
                    Console.WriteLine(aa + bb);
                    break;
                case '-':
                    double.TryParse(a, out double aaa);
                    double.TryParse(b, out double bbb);
                    Console.Write("Вывод: ");
                    Console.WriteLine(aaa - bbb);
                    break;
                case '*':
                    double.TryParse(a, out double a1);
                    double.TryParse(b, out double b1);
                    Console.Write("Вывод: ");
                    Console.WriteLine(a1 * b1);
                    break;
                case '/':
                    double.TryParse(a, out double a2);
                    double.TryParse(b, out double b2);
                    Console.Write("Вывод: ");
                    Console.WriteLine(a2 / b2);
                    break;

                default:
                Console.WriteLine("Недопустимая операция");
                break;
            }
        }
    }
}