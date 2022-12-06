// программа, которая по заданному номеру четверти показывает диапазон возможных координат в этой четверти (x, y)

Console.WriteLine("Введите номер четверти: ");
int quarter = int.Parse(Console.ReadLine());

if (quarter == 1)
	Console.WriteLine("x > 0, y > 0");
if (quarter == 2)
	Console.WriteLine("x < 0, y > 0");
if (quarter == 3)
	Console.WriteLine("x < 0, y < 0");
if (quarter == 4)
	Console.WriteLine("x > 0, y < 0");
if (quarter < 1 ^ quarter > 4)
	Console.WriteLine("Некорректная четверть");



