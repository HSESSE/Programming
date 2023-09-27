char rep;
do
{
    Console.Clear();  // Очистка экрана
    Console.WriteLine("Hello world");  //Здесь наша программа.
    Console.WriteLine("Для повтора вычислений нажмите клавишу Y:");

    rep = char.Parse(Console.ReadLine());
} while (rep == 'Y' || rep == 'y');
