// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

System.Console.WriteLine("Введите цифры через пробел");

int PositiveNumbers()
{
	string text = Console.ReadLine()!;
	int[] array = GetNumbers(text);
	return GetCount(array);
}

System.Console.WriteLine(PositiveNumbers()!);

int[] GetNumbers(string input)
{
	int[] array = input.Split(' ').
				Where(x => !string.IsNullOrWhiteSpace(x)).
				Select(x => int.Parse(x)).ToArray();
	return array;
}

int GetCount(int[] array)
{
	int count = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if(array[i] > 0)
		count ++;
	}
	return count;
}