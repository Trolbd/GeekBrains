// Программа принимает на вход координаты двух точек и находит расстояние между ними в 2D. Формула расчета длины см в задании или в инэте.
// A (3, 6); B (2, 1); -> 5,09
// A (7, -5); B(1, -1) -> 7,21

Console.WriteLine("Введите Х для точки А");
double xA = double.Parse(Console.ReadLine()!); //вместо int вводим double так как работаем с дробными числми
Console.WriteLine("Введите У для точки А");
double yA = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите Х для точки В");
double xB = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите У для точки В");
double yB = double.Parse(Console.ReadLine()!);

double ab = Math.Pow (xB - xA, 2) + Math.Pow (yB - yA, 2); //вычисление квадратного корня и сумма двух квадратов
ab = Math.Sqrt (ab); // извлечение квадратного корня из предыдущего вырожения

Console.WriteLine("Длина линии = " + ab);



