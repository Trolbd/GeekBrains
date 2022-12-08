// на входе число на выходе произведение от  1до числа

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int proizv = 1;

for (int i = 1; i <= number; i++)
{
proizv = proizv * i;
Console.WriteLine(proizv);
}
Console.WriteLine("конец");



