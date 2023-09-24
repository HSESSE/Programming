double s;  //Значение суммы.
double sl;  //Очередное слагаемое (оно же результат произведения).
int k;  //Номер очередного слагаемого.
int n;  //Предельный номер слагаемого.
int i;  //Номер сомножителя.

string strin;
string strout;

Console.Write("Введите предел суммирования: ");
strin = Console.ReadLine();
n = int.Parse(strin);

if (n < 2)
{
    Console.Write("Введено ошибочное значение");
    Console.ReadLine();
    return;
}

for (s = 0, k = 2; k <= n; k++) //Вычисляем сумму
{
    for (sl = 1, i = 1; i < k; i++) //Вычисляем произведение sl *= Math.Sin(Math.PI * i / k);
    {
        sl *= Math.Sin(Math.PI * i / k);
    }

    s += sl;
}

strout = string.Format($"При n={n} сумма={s:f3}\n");
Console.Write(strout);
Console.WriteLine();
