// как задача03, но от макс к мин

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
		int maxPosiyion = i;
// ищем мин элемент
		for (int j = i + 1; j < array.Length; j++)
		{
			if(array[j] > array[maxPosiyion]) maxPosiyion = j; // меняем только знак равенства на if(array[j] >
		}
		// свап элементов
		int temporarry = array[i];
		array[i] = array[maxPosiyion];
		array[maxPosiyion] = temporarry;
	}
}

PrintArray(arr); //неупорядоч vассив на экран
SelectionSort(arr); // упорядочивание массива

PrintArray(arr);//упорядоч массив на экран
