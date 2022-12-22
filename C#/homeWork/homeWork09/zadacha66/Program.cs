// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите число M: ");
int numberM = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N: ");
int numberN = int.Parse(Console.ReadLine()!);

void Summ(int numberM, int numberN, int summ)
{
	if (numberM > numberN) 
	{
		System.Console.WriteLine(summ);
		return;
	}
	summ = summ + (numberM++);
	Summ(numberM, numberN, summ);
}

Summ(numberM, numberN, 0);