double x;           //Значение аргумента
double y;           //Значение функции​
string str;                ​
Console.WriteLine("Введите аргумент функции:  ");​
str = Console.ReadLine();​
x = double.Parse(str);                ​
if (x <= -0.5)
{
    y = 0.5;​
}
if (x > -0.5 && x <= 0.0) {
    y = x + 1.0;
}
if (x > 0.0 && x <= 1.0) {
    y = x * x - 1.0;​
}
if (x > 1.0) {
    y = x - 1.0;
}