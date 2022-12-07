// Методы 1
void Method1()
{
	Console.WriteLine("Автор...");
}
Method1();

// Методы 2
void Method2(string msg)
{
	Console.WriteLine(msg);
}
Method2("Text");
//или
void Method21(string msg, int count)
{
	int i = 0;
	while (i < count)
	{
		Console.WriteLine(msg);
		i++;
	}
}
Method21(msg: "Text", count: 4); //сколько раз хотим видеть это сообщение

//методы 3
int Method3()
{
	return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// методы 4
// string Method4(int count, string text)
// {
// 	int i = 0;
// 	string result = String.Empty; //создали строчную переменную с пустой строкой

// 	while (i < count)
// 	{
// 		result = result + text;
// 		i++;
// 	}
// 	return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);

string Method4(int count, string text)
{
	string result = String.Empty; //создали строчную переменную с пустой строкой
	for (int i = 0; i < count; i++)
	{
		result = result + text;
	}
	return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);

//таблица умножения
for (int i = 2; i <= 10; i++)
{
	for (int j = 2; j <= 10; j++)
	{
		Console.WriteLine($"{i} x {j} = {i * j}");
	}
	Console.WriteLine();// вывод пустой строки для красивого разделения строк (визуально)
}







