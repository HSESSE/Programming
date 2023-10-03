namespace Task08
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            int chislo = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            if (Math.Pow(10, k - 1) <= chislo)
            {
                while (Math.Pow(10, k) <= chislo)
                {
                    chislo /= 10;
                }
                Console.WriteLine(chislo);
            }
            else
            {
                Console.WriteLine("Неверно введено К");
            }
        }
    }
}