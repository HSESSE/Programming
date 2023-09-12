// Your code here!
class Program {
    static void Main() {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Write("Напишите свое имя: ");
        string name = Console.ReadLine();
        Console.WriteLine("Привет, " + name);
    }
}
