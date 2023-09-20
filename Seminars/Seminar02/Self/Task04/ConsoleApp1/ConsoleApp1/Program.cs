namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ans = "Ни цифра, ни буква";

            char a = char.Parse(Console.ReadLine());

            ans = a >= '0' ? (a <= '9' ? "Это цифра" : "") : "";
            ans = a > 'а' ? (a < 'я' ? "Это буква" : "") : "";
            ans = a > 'А' ? (a < 'Я' ? "Это буква" : "") : "";

            Console.WriteLine(ans);
        }
    }
}