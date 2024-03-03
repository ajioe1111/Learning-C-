// №15 Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
// Сделать вариант с использованием конструкции Dictionary

Dictionary<int, bool> weekends = new Dictionary<int, bool>
{
    {6, true},
    {7, true}
};

Console.WriteLine("Введите цифру, обозначающую день недели (1-7): ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
bool isWeekend = weekends.ContainsKey(dayNumber);

Console.WriteLine(isWeekend ? "да": "нет");