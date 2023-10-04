// Ваше решение.
using System;
class Program
{
    public static void Main()
    {
        int.TryParse(Console.ReadLine(), out int n);
        int.TryParse(Console.ReadLine(), out int k);
        string str_n = Convert.ToString(n);
        string answer = "";
        if (k == 0 || k > str_n.Length)
        {
            while (k == 0 || k > str_n.Length)
            {   
                Console.WriteLine("Некорректный ввод K!");
                k = int.Parse(Console.ReadLine());
            }
            int i = 0;
            while (i < k)
            {
                answer += str_n[i];
                i += 1;
            }
            Console.WriteLine(answer);
        }
        else
        {
            int i = 0;
            while (i < k)
            {
                answer += str_n[i];
                i += 1;
            }
            Console.WriteLine(answer);
        }
    }
}