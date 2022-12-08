int[] arr = new int[100];

// подзадачу делаем вывода данного массива на экран




void PrintArray(int[] array)
{
	// int count = array.Length;

	int count = 100;
	for (int i = 0; i < count; i++)
	{
		Console.Write($"{array[i]} ");
	}
	Console.WriteLine();
}

PrintArray(arr);
