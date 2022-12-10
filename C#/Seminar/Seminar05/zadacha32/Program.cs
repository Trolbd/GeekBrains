// программа замены элементов массива:положит элементы заменить на соответств отриц и наоборот
//[-4, -8, 8, 2] в [4, 8, -8, -2]


int[] array = GetArray(ReadInt(), ReadInt(), ReadInt());
System.Console.WriteLine(GetArrayAsString(array));

Change(array);
System.Console.WriteLine(GetArrayAsString(array));


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
	string s = Console.ReadLine(); // прочитали число с консоли

	if (int.TryParse(s, out int i));
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

void Change(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = array[i] * -1;
	}
}