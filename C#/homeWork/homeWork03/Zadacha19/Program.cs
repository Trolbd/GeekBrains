// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Start:
Console.WriteLine("Введите пятизначное число: ");
int Number = int.Parse(Console.ReadLine()!);

string Line = Number.ToString();

if (Number > 99999 ^ Number < 10000)
{
	Console.WriteLine("Число не пятизначное");
	goto Start;
}

if ((Line[0] == Line[4]) && (Line[1] == Line[3]))
			Console.WriteLine("Да");
			else
				Console.WriteLine("Нет");

