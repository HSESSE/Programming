uint  ch; // Исходное число
uint copych; // Копия исходного числа
uint c1, c2, c3; //Переменные для запоминания цифр
uint newch; // Новое число (после переворота цифр)
string str;    // Строка для приема данных и вывода данных  
Console.Write("Введите трехзначное натуральное число:  "); 
str = Console.ReadLine();
ch = uint.Parse(str); 
copych = ch;
c1 = copych % 10;
copych /= 10;
c2 = copych % 10;
copych /= 10;
c3 = copych % 10;
newch = c1*100 + c2*10 + c3;
str = "Если перевернуть " + ch.ToString() + " будет " + newch.ToString();
//Формирование выходной строки можно реализовать более компактно.
//str = "Если перевернуть " + ch + " будет " + newch;
Console.WriteLine(str);
Console.ReadLine();  

