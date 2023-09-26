namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vvod;
            int kolvoint = 0;
            int kolvodouble = 0;
            int kolvo = 0;


            do
            {
                vvod = Console.ReadLine();


                if (int.TryParse(vvod, out int i))
                {
                    kolvoint++;
                }
                else if (double.TryParse(vvod, out double a))
                {
                    kolvodouble++;
                }
                else
                {
                    kolvo++;
                }


            } while (vvod != "0");
            

            Console.WriteLine($"{kolvoint}, {kolvodouble}, {kolvo}");
        }
    }
}