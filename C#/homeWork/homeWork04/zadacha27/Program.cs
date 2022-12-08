// прога на входе число на выходе сумма цифр этого числа: 465 => 15

Console.WriteLine("Введите число: ");
int newN = int.Parse(Console.ReadLine()!);

int number = Math.Abs(newN);
int n = number;
int summ = 0;
Console.WriteLine(n);

for (int i = 0; number >= 1; i++)

{
	n = number % 10;
	summ = summ + n;
	number = (number - n)/10;
	Console.WriteLine($"Цикл: {i}");
}

Console.WriteLine($"Сумма: {summ}");