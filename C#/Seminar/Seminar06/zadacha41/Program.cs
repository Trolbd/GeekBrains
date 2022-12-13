// преобразует десятичное число в двоичное (подсказка методом остатка от деления на 2(%2))

int number = int.Parse(System.Console.ReadLine()!);
string a = string.Empty;
while (number > 0)
{
	a = a + (number % 2);
	number = number / 2;
}
System.Console.WriteLine(a);