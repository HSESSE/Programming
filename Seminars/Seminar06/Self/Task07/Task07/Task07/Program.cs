namespace Task07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                char naschat;
                do { 
                int n;
                double x;
                double cur;
                do
                {
                    x = double.Parse(Console.ReadLine());
                    Console.Write("1 <= n <= 20:");
                    n = int.Parse(Console.ReadLine());
                    if (n < 1 || n > 20)
                    {
                        Console.WriteLine("Область значений n не учтена");

                    }
                } while (n < 1 || n > 20);
                double S = 0.0;
                for (int k = 1; k <= n; k++)
                {
                        cur = Math.Abs(x -k) * Math.Cos(Math.Pow(k,1/3)* x / 2);
                        S += cur;

                }
                    double viraschenie = (Math.Log(x) - (2 / 9)) * S;
                    Console.WriteLine($"{viraschenie:F3}");
                    Console.WriteLine("Чтобы повторить нажмите z");
                    char.TryParse(Console.ReadLine(), out naschat);
                    
                }while (naschat == 'z');


            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input");
            }
        }
    }
}