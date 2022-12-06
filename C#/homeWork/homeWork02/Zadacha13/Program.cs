// напишите программу, кот выводит 3ю цифру или сообщает, что 3й цифры нет
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

if(Math.Abs(number) < 100)
{
	Console.WriteLine("нет 3го числа");
}

if(number<-99)
{
	string str = number.ToString();
	Console.WriteLine(str[3]);
}
else
{
	string str = number.ToString();
	Console.WriteLine(str[2]);
}
