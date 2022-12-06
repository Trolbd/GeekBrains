// Программа, кот принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру от 1 до 7: ");
int number = int.Parse(Console.ReadLine());

if(number == 1)
{
	Console.WriteLine("Понедельник не выходной");
}
if(number == 2)
{
	Console.WriteLine("Вторник не выходной");
}
if(number == 3)
{
	Console.WriteLine("Среда не выходной");
}
if(number == 4)
{
	Console.WriteLine("Четверг не выходной");
}
if(number == 5)
{
	Console.WriteLine("Пятница почти выходной");
}
if(number == 6)
{
	Console.WriteLine("Суббота - ДА, выходной");
}
if(number == 7)
{
	Console.WriteLine("Воскресенье - ДА, выходной");
}
if(number < 1 ^ number > 7)
{
	Console.WriteLine("Введённая цифра не в диапозоне циф 1-7");
}

