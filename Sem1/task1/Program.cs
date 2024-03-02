// Задача №0
// Напишите программу, которая на вход принимает
// число и выдаёт его квадрат (число умноженное на
// само себя).
// Например: 4 -> 16 -3 -> 9 -7 -> 49

Console.WriteLine("Введите число для вывода его в квадрат: ");
string? inputNum = Console.ReadLine();

//Проверяем на нуль
if (inputNum != null)
{
    int number = int.Parse(inputNum); //Парсим строку в число
    // int outNum = number * number;
    int outNum = (int)Math.Pow(number, 2);
    Console.WriteLine("Квадрат числа " + number + " равен " + outNum);

    // Console.WriteLine("Квадрат числа: "+Math.Pow(int.Parse(inputNum), 2)); В одну строку
}
