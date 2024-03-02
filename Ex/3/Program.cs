// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите имя пользователя: ");
string usernames = Console.ReadLine();

// Преобразование ввода пользователя и строки для сравнения в нижний регистр
if (usernames.ToLower() == "masha")
{
    Console.WriteLine("Это Маша!");
}
else
{
    Console.WriteLine("Привет ");
    Console.WriteLine(usernames);
}
