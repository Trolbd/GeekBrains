// чё то сложное
void FillArray(int[] collection)
{
	int Length = collection.Length;
	int index = 0;
	while(index < Length)
	{
		collection[index] = new Random().Next(1, 10);
		index++;
	}
}

void PrintArray(int[] col)
{
	int count = col.Length;
	int position = 0;
	while(position<count)
	{
		Console.WriteLine(col[position]);
		position++;
	}
}

int IndexOf(int[] collection, int find)
{
	int count = collection.Length;
	int index = 0;
	int position =-1;//если ввести слишком большое число программа покажет -1 ак то, что такой элемент ннее найден

	while(index < count)
	{
		if(collection[index]==find)
		{
		position = index;
		break;
		}
		index++;
	}
	return position;
}

int[] array = new int[10];//создать новый массивв кот будет 10 элементов

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
