Console.WriteLine("Введите имя");
string username = Console.ReadLine();

if (username.ToLower()=="маша")
{
    Console.WriteLine("Это же Маша!");
}
else
{
    Console.WriteLine($"Привет {username}");
}
