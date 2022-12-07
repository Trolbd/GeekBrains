// Сортировка массива от мин к макс

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
// подзадачу делаем вывода данного массива на экран

void PrintArray(int[] array)
{
	int count = array.Length;

	for (int i = 0; i < count; i++)
	{
		Console.Write($"{array[i]} ");
	}
	Console.WriteLine();
}

// теперь пишем метод, кот упорядочивает наш массив

void SelectionSort(int[] array)
{

	for (int i = 0; i < array.Length - 1; i++)
	{
		int minPosiyion = i;
// ищем макс элемент
		for (int j = i + 1; j < array.Length; j++)
		{
			if(array[j] < array[minPosiyion]) minPosiyion = j;
		}
		// свап элементов
		int temporarry = array[i];
		array[i] = array[minPosiyion];
		array[minPosiyion] = temporarry;
	}
}




PrintArray(arr);
SelectionSort(arr); // упорядочивание

PrintArray(arr);