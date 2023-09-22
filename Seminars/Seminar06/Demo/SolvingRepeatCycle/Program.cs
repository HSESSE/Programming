char rep;
do
{
    Console.Clear();  // Очистка экрана
    Console.WriteLine("Hello world");  //Здесь нашапрограмма.
    Console.WriteLine("Для повтора вычислений нажмите клавишу Y:");

    rep = char.Parse(Console.ReadLine());
} while (rep == 'Y' || rep == 'y');
