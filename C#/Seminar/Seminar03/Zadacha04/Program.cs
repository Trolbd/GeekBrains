// Программа принимает число N и выдаёт таблицу квадратов чисел от 1 до N

Console.WriteLine("Введите число: ");
int Number = int.Parse(Console.ReadLine()!);

int index = 1;

while (index < Number)
	{
		Console.WriteLine(Math.Pow (index, 2));
		index++;
	}



