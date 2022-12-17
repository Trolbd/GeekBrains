//задайте двумерный массив. найдите элементы у которых оба индекса чётные
// и замените эти элементы на их квадраты


int[,] inputTwoDimmansionArray(int length1, int length2)
{
	int[,] array = new int[length1, length2];
	for (int i = 0; i < array.GetLength(0); i++)
	{
		FillDimension(i, array);
	}
	return array;
}

int ReadInt()
{
	System.Console.WriteLine("Ввод");
	int a = int.Parse(Console.ReadLine()!);
	return a;
}

void FillDimension(int index, int[,] array) //заполнение 2 строки или столбца
{
	for (int i = 0; i < array.GetLength(1); i++)
	{
		array[index, i] = new Random().Next(1, 10);
	}
}

void GetArrayAsString(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			System.Console.Write($"{array[i, j]} ");
		}
		System.Console.WriteLine();
	}
}

void Replase(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			if ((i+1) % 2 == 0 && (j+1) % 2 == 0)
				{
					array[i, j] = array[i, j] * array[i, j];
				}
		}
		
	}
}

Task();
void Task()
{
	int[,] array = inputTwoDimmansionArray(ReadInt(), ReadInt());
	GetArrayAsString(array);
	System.Console.WriteLine();
	Replase(array);
	GetArrayAsString(array);
}