uint shool;
string str = Console.ReadLine();
shool = uint.Parse(str);
if (shool >= 1 && shool <= 4)
{
    Console.WriteLine("Начальная школа");
}
else if (shool >= 5 && shool <= 9)
{
    Console.WriteLine("Средняя школа");
}
else if (shool >= 10 && shool <= 11)
{
    Console.WriteLine("Старшая школа");
}
