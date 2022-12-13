// Задача на создание массива от 0 до 10 и переворот его (от 10 до 0)


// функция длины массива
int[] Massive(int length)
{
	int[] mass = new int[length];
	for (int i = 0; i < length; i++)
	{
		mass[i] = i;
	}
	return mass;
}

// Функция переворота элементов массива с последнего на первый
void Reverse(int[] massivReverse)
{
	for (int i = 0; i < massivReverse.Length/2; i++)
	{
		ChengeElements(massivReverse, i, massivReverse.Length-1-i);
	}
}

// функция вывода массива
string GetArray(int[] array)
{
	string result = string.Empty;
	for (int i = 0; i < array.Length; i++)
	{
		result += $"{array[i]},  ";
	}
	return result;
}

// функция определения первого и последнего элемента массива и замена их местами
void ChengeElements(int[] mas, int iFirst, int iLlast)
{
	int temp = mas[iFirst];
	mas[iFirst] = mas[iLlast];
	mas[iLlast] = temp;
}

int[] massive = Massive(10); //именно Massive. Определили тут что массив из 10
System.Console.WriteLine(GetArray(massive)); //выводим наш массив от 0 до 10
Reverse(massive);//выполняем функцию переворота на массив
System.Console.WriteLine(GetArray(massive));