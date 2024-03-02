// Задача №3
// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// Например:
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите номер дня недели: ");
string input = Console.ReadLine();

// Попытка преобразовать введенную строку в число
bool isSuccess = int.TryParse(input, out int dayNumber);

if (isSuccess && dayNumber >= 1 && dayNumber <= 7)
{
    switch (dayNumber)
    {
        case 1:
            Console.WriteLine("Понедельник");
            break;
        case 2:
            Console.WriteLine("Вторник");
            break;
        case 3:
            Console.WriteLine("Среда");
            break;
        case 4:
            Console.WriteLine("Четверг");
            break;
        case 5:
            Console.WriteLine("Пятница");
            break;
        case 6:
            Console.WriteLine("Суббота");
            break;
        case 7:
            Console.WriteLine("Воскресенье");
            break;
    }
}
else
{
    Console.WriteLine("Некорректный ввод. Введите число от 1 до 7.");
}
