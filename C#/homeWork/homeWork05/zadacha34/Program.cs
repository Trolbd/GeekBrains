// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

//Проверка: 1- вводим кол-во элементов массива 2 - вводим 100 3- вводим 999



int[] array = GetArray(ReadInt(), ReadInt(), ReadInt());
System.Console.WriteLine(GetArrayAsString(array));

System.Console.WriteLine($"Кол-во чёт чисел: {ChetNumbers(array)}");


int[] GetArray(int length, int minValye, int maxValye) 
{
	//указываем осн переменные
	int[] array = new int[length];

	Random random = new Random();

	//заполнение массива рандомными числами
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = random.Next(minValye - 1, maxValye);
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

string GetArrayAsString(int[] array)//перевод массива в строку для вывода
{
	string s = string.Empty;// пустая строка

	foreach (var item in array)// создаём строку кот перечисляет все массивы
	{
		s += $"{item}, ";
	}
	return s;
}

int ChetNumbers(int[] array)//кол-во чёт чисел в массиве
{
	int chet = 0;// 1

	for (int i = 0; i < array.Length; i++)
	{
		if ((array[i] % 2) == 0) //если остаток равен 0, то число делится на 2 без остатка (чётное)
			chet ++;// 
	}
	return chet; //к 1
}

