/*
 * Demo 03. Параметрический цикл for.
 */

int n = 10;

for (; ; )
{
    Console.WriteLine(n);

    if (n >= 15)
    {
        break;
    }

    n += 2;
}
