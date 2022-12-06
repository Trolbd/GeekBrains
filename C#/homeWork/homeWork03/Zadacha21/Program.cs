// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите Х для точки А");
double xA = double.Parse(Console.ReadLine()!); //вместо int вводим double так как работаем с дробными числми
Console.WriteLine("Введите У для точки А");
double yA = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите z для точки А");
double zA = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите Х для точки В");
double xB = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите У для точки В");
double yB = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите z для точки В");
double zB = double.Parse(Console.ReadLine()!);



double ab = Math.Pow (xB - xA, 2) + Math.Pow (yB - yA, 2) + Math.Pow (zB - zA, 2); //вычисление квадратного корня и сумма трёх квадратов
ab = Math.Sqrt (ab); // извлечение квадратного корня из предыдущего вырожения

Console.WriteLine("Длина линии = " + ab);
