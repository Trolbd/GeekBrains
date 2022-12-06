// Программа принимает на вход координаты точки X, Y (причём x не=0 и y не= 0 и выдаёт номер плоскости, в кот. точка)

int x = int.Parse(Console.ReadLine()!);
int y = int.Parse(Console.ReadLine()!);

int quarter = -1; //quarter перевод Четверть
if (x > 0 && y > 0)
	quarter = 1; //первая Четверть

if (x < 0 && y > 0)
	quarter = 2; //вторая Четверть

if (x < 0 && y < 0)
	quarter = 3; //третья Четверть

if (x > 0 && y < 0)
	quarter = 4; //четвёртая Четверть

if (quarter == -1)
	System.Console.WriteLine("Error");
else
	System.Console.WriteLine($"{quarter} четверть");