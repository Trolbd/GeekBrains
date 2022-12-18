// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

int stroka = ReadInt("Введите индекс строки: ");
int stolb = ReadInt("Введите индекс столбца: ");
int[,] numbers = new int[5, 5];
FillArray(numbers);
PrintArray(numbers);

if (stroka < numbers.GetLength(0) && stolb < numbers.GetLength(1)) 
{
	Console.WriteLine(numbers[stroka, stolb]);
}
else 
{
Console.WriteLine($"{stroka}{stolb} такого числа в массиве нет");
}


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}