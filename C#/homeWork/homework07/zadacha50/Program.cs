// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

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

void FillDimension(int index, int[,] array)
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

int ReadInt2()
{
	System.Console.WriteLine("Ввод искомого числа");
	int a = int.Parse(Console.ReadLine()!);
	return a;
}

int Poisk(int index, int[,] array)
{

}


Task();
void Task()
{
	int[,] array = inputTwoDimmansionArray(ReadInt(), ReadInt());
	GetArrayAsString(array);
	
}