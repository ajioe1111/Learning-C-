// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите имя пользователя: ");
string usernames = Console.ReadLine();

if (usernames == "Masha")
{
    Console.WriteLine("Это Маша!");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(usernames);
}