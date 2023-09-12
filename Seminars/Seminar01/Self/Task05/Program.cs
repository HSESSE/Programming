// Your code here!
class Program {
    static void Main() {
        double voltage = double.Parse(Console.ReadLine());
        double resistance = double.Parse(Console.ReadLine());
        Console.WriteLine("1. I = {0}", voltage/resistance);
        Console.WriteLine("2. P = {0}", Math.Pow(voltage, 2)/resistance);
    }
}
