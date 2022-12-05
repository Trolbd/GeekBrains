Console.WriteLine("Введите трёхзначное число: ");
int n = int.Parse(Console.ReadLine());

if(n>999)
{
	Console.WriteLine("Число не трёхзначное");
}
else
	if(n<100)
	{
		Console.WriteLine("Число не трёхзначное");
	}


Console.WriteLine(n%10);