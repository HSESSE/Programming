using System;

class Program {
    static void Main() {
        Console.Write("Enter text: ");
        // Рекомендуется описывать переменные максимально близко 
        // к месту первого использования в коде.
        string userInput = Console.ReadLine();
	    Console.WriteLine("Your input: {0}", userInput);
        Console.WriteLine($"Your input: {userInput}");
        Console.WriteLine("Your input: " + userInput);
    }
}