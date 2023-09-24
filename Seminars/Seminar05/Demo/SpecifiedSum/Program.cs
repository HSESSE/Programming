/*
 * Demo 01. Вычисляем сумму чисел, меньших 100 и кратных 3 и 7 одновременно.
 */

int number = 1;
int summ = 0; // Сумму обнуляем до цикла.

do
{
    if (number % 3 == 0 && (number) % 7 == 0)
    {
        summ += number;
    }
} while (++number < 100);

Console.WriteLine(summ); // 210
