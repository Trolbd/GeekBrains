// Задайте массив из 12 элементов  заполненные случайными чисоами от -9 до 9 включительно. 
// Найдите сумму отрицательных и отдельно положительных чисел.

int[] array = GetArray(ReadInt(), ReadInt(), ReadInt());// в скобках (длина, мин элемент массива, макс элемент массива)

System.Console.WriteLine(GetArrayAsString(array));


System.Console.WriteLine($"summ отриц число: {GetNegativeSumm(array)}");//делаем в самом конце, когда есть массивы, которые можно вставить
System.Console.WriteLine($"summ положит число: {GetPositiveSumm(array)}");

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

int GetPositiveSumm(int[] array)//сумма положит элементов массива
{
	int summ = 0;// 1

	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] > 0) //если число iго элемента массива > 0
			summ += array[i];
	}
	return summ; //к 1
}

int GetNegativeSumm(int[] array)//сумма положит элементов массива
{
	int summ = 0;// 1

	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] < 0)//если число iго элемента массива < 0
			summ += array[i];
	}
	return summ; //к 1
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