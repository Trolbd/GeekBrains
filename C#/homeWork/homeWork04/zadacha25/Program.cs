// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число 1: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число 2: ");
int degree = int.Parse(Console.ReadLine()!);

System.Console.WriteLine(Math.Pow((number), (degree)));
