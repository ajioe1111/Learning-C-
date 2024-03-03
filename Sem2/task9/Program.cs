// Задача №9
// Напишите программу, которая выводит случайное
// число из отрезка [10, 99] и показывает наибольшую
// цифру числа.
// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

System.Random numSintezator = new System.Random();

//Вариант 1
int rndNumber = numSintezator.Next(10, 100);
Console.WriteLine(rndNumber);
int fn = rndNumber/10;
int sn = rndNumber%10;

if(fn>sn)
{
    Console.WriteLine(fn);
}
else
{
    Console.WriteLine(sn);
}