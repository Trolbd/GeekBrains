// программа принимает число А и выдаёт сумму чисел

Console.WriteLine(sdf(1, 7));

int sdf(int from, int to)
{
	int result = 0;

	for (int i = from; i <= to; i++)
	{
		result += i;
	}
	return result;
}