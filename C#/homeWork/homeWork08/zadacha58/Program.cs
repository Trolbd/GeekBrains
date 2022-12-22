// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] matrix1 = new int[2, 2];
int[,] matrix2 = new int[2, 2];
int[,] resultMatrix = new int[2, 2];

Matrix1Random(matrix1);
PrintArray(matrix1);

System.Console.WriteLine();

Matrix2Random(matrix2);
PrintArray(matrix2);


PrintArray(resultMatrix);



void Matrix1Random(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = new Random().Next(1, 9);
		}
	}
}

void Matrix2Random(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = new Random().Next(1, 9);
		}
	}
}

void PrintArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			System.Console.Write($"{array[i, j]} ");
		}
		System.Console.WriteLine();
	}
}

// void MultiplyMatrix(int[,] matrix1, int[,] matrix2, int[,] resultMatrix)
// {
// 	for (int i = 0; i < resultMatrix.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < resultMatrix.GetLength(1); j++)
// 		{
// 			int sum = 0;
// 			for (int k = 0; k < matrix1.GetLength(1); k++)
// 				{
// 					sum += ((matrix1[i,k] * matrix2[k,j]) + (matrix1[i+1,k+1] * matrix2[k+1,j+1]));
// 				}
// 		resultMatrix[i,j] = sum;
// 		}
// 	}
// }