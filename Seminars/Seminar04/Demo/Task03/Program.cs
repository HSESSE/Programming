uint level = 0;
switch (level)
{
    case >= 1 and <= 4:
        Console.WriteLine("Начальная школа");
        break;
    case >= 5 and <= 9:
        Console.WriteLine("Средняя школа");
        break;
    case >= 10 and <= 11:
        Console.WriteLine("Старшая школа");
        break;
    default:
        Console.WriteLine("Нет такого класса в школе");
        break;
}
