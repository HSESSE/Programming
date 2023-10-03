namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            string month = Console.ReadLine();
            int zifra = 0;

            switch (month)
            {
                case "Январь":
                    zifra = 1; break;
                case "Февраль":
                    zifra = 2; break;
                case "Март":
                    zifra = 3; break;
                case "Апрель":
                    zifra = 4; break;
                case "Май":
                    zifra = 5; break;
                case "Июнь":
                    zifra = 6; break;
                case "Июль":
                    zifra = 7; break;
                case "Август":
                    zifra = 8; break;
                case "Сентябрь":
                    zifra = 9; break;
                case "Октябрь":
                    zifra = 10; break;
                case "Ноябрь":
                    zifra = 11; break;
                case "Декабрь":
                    zifra = 12; break;

                default: Console.WriteLine("Ошибка"); break;


            }
            if (zifra != 0)
            {
                Console.WriteLine(zifra);
            }
            else { Console.WriteLine(""); }
        }
    }
}