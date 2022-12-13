// Треугольники

bool CheckTriangel(int a, int b, int c)
{
	bool chech = CheckSize(a, b, c) &&  //проверка 1 из сторон на то что она меньше суммы двух других
	CheckSize(b, c ,a) &&
	CheckSize(c, a, b);
	return chech;
}

bool CheckSize(int a, int b, int c)
{
	if (a < b +c)
	{
		return true;
	}
	else
	{
		return false;
	}
}
System.Console.WriteLine(CheckTriangel(3, 4, 5));
