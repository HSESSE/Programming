double x;           //Значение аргумента
double y;           //Значение функции​
string str;                ​
Console.WriteLine("Введите аргумент функции:  ");​
str = Console.ReadLine();​
x = double.Parse(str);
if (x <= 0)
{                             // Слева от 0.​
    if (x <= - 0.5)​ {
        y = (float)0.5;       // Слева от -0.5.​
    }
    else
    {
        y = (float)(x + 1.0); //Справа от -0.5.​
    }
}
else
{                             //Справа от 0.​
    if (x <= 1.0)
    { ​
       y = (float)(x * x - 1.0); //Слева от 1.0.​
    }
    else
    {
        y = (float)(x - 1.0); //Справа от 1.0.​
    }
}
