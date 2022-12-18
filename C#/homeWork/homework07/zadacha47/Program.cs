// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами


double[,] inputTwoDimmansionArray(int length1, int length2)
{
	Random random = new Random();
	double[,] array = new double[length1, length2];
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = random.NextSingle() * 100 * MinusOne();
		}
	}
	return array;
}

int ReadInt()
{
	System.Console.WriteLine("Ввод");
	int a = int.Parse(Console.ReadLine()!);
	return a;
}

int MinusOne()
{
	Random random = new Random();
	if (random.Next(10) > 5) return 1;
	return -1;
}

void GetArrayAsString(double[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			System.Console.Write("{0:0.##} ", array[i, j]);
		}
		System.Console.WriteLine();
	}
}

Task();
void Task()
{
	double[,] array = inputTwoDimmansionArray(ReadInt(), ReadInt());
	GetArrayAsString(array);
}