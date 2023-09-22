internal class Program
{
    public static void Main()
    {
        Console.Write("Введите код операции: ");
        bool code_flag = int.TryParse(Console.ReadLine(), out int code);

        if (code == 0)
        {
            Console.WriteLine("Некорректно введено значение кода операции");
            Console.ReadKey();
            return;
        }

        Console.Write("Введите A: ");
        bool a_flag = Single.TryParse(Console.ReadLine(), out float a);

        if (a == 0)
        {
            Console.WriteLine("Некорректно введено значение A");
            Console.ReadKey();
            return;
        }

        Console.Write("Введите B: ");
        bool b_flag = Single.TryParse(Console.ReadLine(), out float b);

        if (b == 0)
        {
            Console.WriteLine("Некорректно введено значение B");
            Console.ReadKey();
            return;
        }

        switch (code)
        {
            case 1: 
                Console.WriteLine($"{a} + {b} = {a + b}"); break;
            case 2: 
                Console.WriteLine($"{a} - {b} = {a - b}"); break;
            case 3: 
                Console.WriteLine($"{a} * {b} = {a * b}"); break;
            case 4: 
                Console.WriteLine($"{a} / {b} = {a / b}"); break;
        }
        Console.ReadKey();
    }
}