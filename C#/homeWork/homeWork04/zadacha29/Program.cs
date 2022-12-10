// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// int[] Array8;
// Array8 = new int [834564];
// // Array8[0] = number2[0];
// System.Console.WriteLine(Array8.Length);

Console.Write("Введите число (N): ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int[number];

for (int i = 0; i < number; i++)
{
	array[i] = new Random().Next(number+1);
	Console.Write(array[i] + "; ");
}
