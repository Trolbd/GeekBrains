// найти элемент массива равный find
//Console.WriteLine(n); это длина массива
//Console.WriteLine(array[n-1]); это послед элемент массива
//Console.WriteLine(array[0]); это 1й



//int find = 4;
//Console.Write("Введите число: ");
//int find = Console.ReadLine();
//int find = Convert.ToInt32(Console.ReadLine());


//Console.WriteLine(find);




//while(index<n)
//{
//	Console.WriteLine(index);
//	if(array[index] == find)
//	{
//	Console.WriteLine("index= ", index);
//		
//	}
//index++;
//}

//Console.WriteLine("Конец программы");
int[] array = {17,2,3,5,4,99,6,7,99};

int n = array.Length;
int find = 99;
int index = 0;
while(index<n)
{
	if(array[index] == find)
	{
		Console.WriteLine(index);
		break;//останавливает работу программы на первом подходящем числе.
	}
	index++;
}