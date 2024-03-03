// №13 Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// # Сделать вариант для числа длиной до 10 цифр не используя char или string

Console.WriteLine("Введите число (до 10 чисел): ");
string number = Console.ReadLine();

// Проверяем на Null
if (number != null)
{
    int parsNumber = int.Parse(number);
    if (parsNumber >= 100)
    {
        while (parsNumber >= 1000)
        {
            parsNumber /= 10;
        }
        int result = (int)parsNumber % 10;
        Console.WriteLine(result);
    }
    else
    {
        Console.WriteLine("Третий цифры нету");
    }
}
else
{
    Console.WriteLine("Ошибка: null");
}
