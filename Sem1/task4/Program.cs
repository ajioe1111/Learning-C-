// №6 Напишите программу, которая на вход принимает число и выдаёт, является ли число
// чётным (делится ли оно на два без остатка).
//  4 -> да
//  -3 -> нет
//  7 -> нет

Console.WriteLine("Введите число ");
string? num = Console.ReadLine();

if (num != null)
{
    int pars_number = int.Parse(num);
    if (pars_number % 2 == 0) {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
