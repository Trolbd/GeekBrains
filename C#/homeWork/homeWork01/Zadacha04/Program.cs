Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int c = int.Parse(Console.ReadLine());

if(a>b && a>c)
{
	Console.WriteLine(a);
}

if(b>a && b>c)
{
	Console.WriteLine(b);
}

if(c>b && c>a)
{
	Console.WriteLine(c);
}

if(a==b ^ a==c ^ b==c)
{
	Console.WriteLine('=');
}