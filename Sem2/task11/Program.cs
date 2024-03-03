// Задача №11
// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.

int rndNum = new Random().Next(100,1000);
Console.WriteLine(rndNum);
string numberString = rndNum.ToString();
string resultString = numberString.Remove(1,1);
Console.WriteLine(resultString);