// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] array = GetArray(ReadInt(), ReadInt(), ReadInt());// в скобках (длина, мин элемент массива, макс элемент массива)

System.Console.WriteLine(GetArrayAsString(array));


System.Console.WriteLine(GetMaxNumber(array) - GetMinNumber(array));//мак минус мин


int[] GetArray(int length, int minValye, int maxValye) // в скобках (длина, мин элемент массива, макс элемент массива)
{
	//указываем осн переменные
	int[] array = new int[length];// создание массива чисел длиной length (он пустой)

	Random random = new Random();

	//заполнение массива рандомными числами
	for (int i = 0; i < array.Length; i++) // for от 0 до длины массива
	{
		array[i] = random.Next(minValye - 1, maxValye); //заполнение ранд числами
	}
	return array;
}

int ReadInt()
{
	string s = Console.ReadLine()!; // прочитали число с консоли

	if (int.TryParse(s, out int i))
		return i;

	return -1;
}

string GetArrayAsString(int[] array)//перевод массива в строку?
{
	string s = string.Empty;// пустая строка

	foreach (var item in array)// создаём строку кот перечисляет все массивы
	{
		s += $"{item}, ";
	}
	return s;
}

int GetMaxNumber(int[] array)//нахождение макс элемента
{
	int max = 0;// 1

	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] > max)
			max = array[i];
	}
	return max; //к 1
	
}

int GetMinNumber(int[] array)//нахождение мин элемента
{
	int min = int.MaxValue;// 1

	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] < min)
			min = array[i];
	}
	return min; //к 1
}