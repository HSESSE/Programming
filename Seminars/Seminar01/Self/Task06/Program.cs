class Program {
    static void Main() {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine(Math.Pow(Math.Pow(a, 2) + Math.Pow(b, 2), 0.5));
    }
}
