// задайте двумерный массив. найдите сумму элементов, нахлдящихся на главной диагонали
//(с индексами (0.0) (1.1) и тд)
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

int Replase(int[,] array)
{
	int summ = 0;
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			if (i == j)
				{
					summ = summ + array[i, j];
				}
		}
		
	}
	return summ;
}

Task();
void Task()
{
	int[,] array = inputTwoDimmansionArray(ReadInt(), ReadInt());
	GetArrayAsString(array);
	System.Console.WriteLine();
	Replase(array);
	System.Console.WriteLine(Replase(array));
}
