﻿// Задача №14
// Напишите программу, которая принимает на вход
// число и проверяет, кратно ли оно одновременно 7 и
// 23.
// Например:
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число: ");
int fn = int.Parse(Console.ReadLine());


if (fn % 161 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}