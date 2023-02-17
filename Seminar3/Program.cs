// Seminar3
/*
string - это по сути массив

Math.Round(a,b) - округление, где a - число, b - количество знаков.
использовать лучше непосредственно перед выводом.

double Math.Pow(a,b) - возведение в степень, где a - число, b - степень.
double Math.Sqrt(a) - квадратный корень числа

if (...);
else if(...);
else if(...);
else if(...);
можно убирать "else" если после выполненного условия дальше проверка не идёт
*/




// Task1. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void ShowDiapozone(int quad)
{
	if (quad == 1) Console.WriteLine("x > 0 and y > 0");
	else if (quad == 2) Console.WriteLine("x < 0 and y > 0");
	else if (quad == 3) Console.WriteLine("x < 0 and y < 0");
	else if (quad == 4) Console.WriteLine("x > 0 and y < 0");
	else Console.WriteLine("Uncorect input");
}
Console.Write("Input a numer quadrant: ");
int quadrant = Convert.ToInt32(Console.ReadLine());

ShowDiapozone(quadrant);
*/

// ClassWork
// Task1. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int ShowQuadrant(int xN, int yN)
{
	int quad = 0;
	if (xN > 0 && yN > 0) quad = 1;
	else if (xN < 0 && yN > 0) quad = 2;
	else if (xN < 0 && yN < 0) quad = 3;
	else if (xN > 0 && yN < 0) quad = 4;
	else Console.WriteLine("Uncorect input");
	return quad;
}

Console.WriteLine("Input X: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y: ");
int yA = Convert.ToInt32(Console.ReadLine());

int quadrant = ShowQuadrant(xA, yA);
Console.WriteLine($"Your quad {quadrant}");
*/

//int

// Task 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними 
//double
/*
double Distance(int xDotA, int yDotA, int xDotB, int yDotB)
{
	int LenghtX = xDotB - xDotA;
	int LenghtY = yDotB - yDotA;
	double quad = Math.Sqrt(Math.Pow(LenghtX, 2) + Math.Pow(LenghtY, 2));
	return quad;
}

Console.WriteLine("Input X dot A: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y dot A: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input X dot B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y dot B: ");
int yB = Convert.ToInt32(Console.ReadLine());

double dist = Distance(xA, yA, xB, yB);
Console.WriteLine($"Distance : {Math.Round(dist, 2)}");
*/

// Task 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
/*
void TableOneForN(int n)
{
	int i = 1;
	while (i <= n)
	{
		Console.WriteLine(Math.Pow(i, 2));
		i++;
	}
}

Console.Write("Input any number: ");
int num = Convert.ToInt32(Console.ReadLine());

TableOneForN(num);
*/