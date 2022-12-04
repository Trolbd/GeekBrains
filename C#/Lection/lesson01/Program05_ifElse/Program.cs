Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "даша")
{
	Console.WriteLine("Ну привет, Дашуля");
}
else
{
	Console.Write("Здравствуй, ");
	Console.WriteLine(username);
}