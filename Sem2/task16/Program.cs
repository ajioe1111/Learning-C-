// Задача №16
// Напишите программу, которая принимает на вход
// два числа и проверяет, является ли одно число
// квадратом другого.

// Console.WriteLine("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if (firstNumber * firstNumber == secondNumber || secondNumber * secondNumber == firstNumber)
// {
//     Console.WriteLine("Да, одно число является квадратом другого.");
// }
// else
// {
//     Console.WriteLine("Нет, ни одно из чисел не является квадратом другого.");
// }

{
    Console.WriteLine("Введите первое число: ");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int secondNumber = Convert.ToInt32(Console.ReadLine());

    if (IsSquareOf(firstNumber, secondNumber))
    {
        Console.WriteLine("Да, одно число является квадратом другого.");
    }
    else
    {
        Console.WriteLine("Нет, ни одно из чисел не является квадратом другого.");
    }
}

bool IsSquareOf(int a, int b)
{
    return a * a == b || b * b == a;
}