﻿// Задача №12
// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе
// число кратным первому. Если второе число
// некратно первому, то программа выводит остаток от
// деления.
// Например:
// 34, 5 -> некратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число: ");
int fn = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int sn = int.Parse(Console.ReadLine());

if (fn % sn == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    int rem = fn % sn;
    Console.WriteLine($"некратно, остаток {rem}");
}