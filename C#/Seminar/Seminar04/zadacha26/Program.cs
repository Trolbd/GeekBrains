// программа принимает число А и выдаёт количество цифр в числе

// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);

// int delenie = Math.Abs(number);
// int i = 1;

// for (int i1 = 1; delenie > 10; i1++)
// {
// 	delenie = delenie / 10;
// 	i++;
// }

// Console.WriteLine(i);
// Console.WriteLine("Выход");



//вариант 2

Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
int number = Convert.ToInt32(Console.ReadLine()!);

int newN = Math.Abs(number);

string stroka = newN.ToString();
// int n = stroka.Length;
// Console.WriteLine($"Ответ: {n}");
Console.WriteLine($"Ответ: {stroka.Length}");