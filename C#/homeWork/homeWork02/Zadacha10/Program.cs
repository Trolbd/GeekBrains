			// принимает 3х значное число и на выходе показывает 2ю цифру

Start:
Console.WriteLine("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());

if(number > 999 ^ (number < 100 && number > -100) ^ number < -999)
	{
	Console.WriteLine("Введённое число не трёхзначное. +");	
	goto Start;
	}

string stroka = number.ToString();

if (number > 0)
{
	Console.WriteLine(stroka[1]);
}
else
{
	Console.WriteLine(stroka[2]);
}

// int answer = number % 100 / 10;
// Console.WriteLine($"Вторая цифра в числе: {answer}"); или Console.WriteLine("Вторая цифра в числе:" + answer);