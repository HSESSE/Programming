namespace Task08
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                char zanovo;
                do
                {
                    int funkziya;
                    do
                    {
                        Console.Write("Введите номер функции (1 или 2):");
                        int.TryParse(Console.ReadLine(), out funkziya);

                    }while (!(funkziya == 1 ||  funkziya == 2));

                    Console.WriteLine("Сколько будет значений Х?");
                    int n = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите шаг Х:");
                    double dx = double.Parse(Console.ReadLine());

                    Console.WriteLine("Сколько будет значений Z?");
                    int m = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите шаг Z:");
                    double dz = double.Parse(Console.ReadLine());

                    double res;
                    double x;
                    double z;

                    if (funkziya == 1)
                    {
                        while (n != 0 && m != 0)
                        {
                            Console.WriteLine("Введите значение Х:");
                            x = double.Parse(Console.ReadLine());

                            Console.WriteLine("Введите значение Z:");
                            z = double.Parse(Console.ReadLine());
   
                            res = (x * Math.Acos(x / Math.Pow(z,1/2))) - Math.Log(Math.Pow(x*x + z,1/3) + 1);
                            Console.WriteLine($"При {x} и {z} функция = {res}");
                            x += dx;
                            z += dz;

                            m -= 1;
                            n -= 1;
                        }
                    }


                    if (funkziya == 2)
                    {
                        while (n != 0 && m != 0)
                        {
                            Console.WriteLine("Введите значение Х:");
                            x = double.Parse(Console.ReadLine());

                            Console.WriteLine("Введите значение Z:");
                            z = double.Parse(Console.ReadLine());

                            res = Math.Pow(Math.E,Math.Pow(z,1/2)) + Math.Pow(x*x*x*x,1/3) * (1 + (x - z/x)/(x + z/x)) * Math.Abs(Math.Sin(x));
                            Console.WriteLine($"При {x} и {z} функция = {res}");
                            x += dx;
                            z += dz;

                            m -= 1;
                            n -= 1;
                        }
                    }




                    Console.WriteLine("Для повтора нажмите z");
                 char.TryParse(Console.ReadLine(), out zanovo);
                }while (zanovo == 'z');
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input");
            }
        }
    }
}