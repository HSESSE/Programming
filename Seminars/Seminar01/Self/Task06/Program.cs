namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {

            double pervi_katet = double.Parse(Console.ReadLine());

            double vtoroi_katet = double.Parse(Console.ReadLine());



            Console.WriteLine("Гипотенуза = " + Math.Sqrt(pervi_katet * pervi_katet + vtoroi_katet * vtoroi_katet));


        }
    }
}