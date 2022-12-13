// вывечти первые N числа фибоначчи (0 и 1 первые числа)

double Fib(double n)
{
	if (n == 1 || n == 2) return 1;
	else return Fib(n-1) + Fib(n-2);
}
 for (int i = 1; i < 20; i++)
 {
	System.Console.WriteLine($"F= {i} - {Fib(i)}");
 }