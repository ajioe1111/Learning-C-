// №10 Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{
    string numberAsString = number.ToString();
    char secondDigit = numberAsString[1];

    Console.WriteLine($"Вторая цифра числа: {secondDigit}");
}
else
{
    Console.WriteLine("Введенное число не является трехзначным.");
}