// HomeWork3
// Task 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
bool ValidationNumber(int number)
{
	if (number > 9999 && number < 100000)
		return true;
	else
	{
		Console.WriteLine("Your number not five-digit! please try again");
		return false;
	}
}


bool PalyndromeCheck(int number)
{
	int digitOne = number / 10000;
	int digitTwo = number / 1000 % 10;
	int digitFour = number / 10 % 10;
	int digitFive = number % 10;

	if (digitOne == digitFive && digitTwo == digitFour)
	{
		return true;
	}
	else return false;
}

Console.Write("Input a five-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (ValidationNumber(num))
{
	if (PalyndromeCheck(num)) Console.WriteLine($"Your number {num} is a palyndrome");
	else Console.WriteLine($"Your number {num} is not a palyndrome");
}
*/


// Task 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distance(int xDotA, int yDotA, int zDotA, int xDotB, int yDotB, int zDotB)
{
	int LenghtX = xDotB - xDotA;
	int LenghtY = yDotB - yDotA;
	int LenghtZ = zDotB - zDotA;

	double quad = Math.Sqrt(Math.Pow(LenghtX, 2) + Math.Pow(LenghtY, 2) + Math.Pow(LenghtZ, 2));
	return quad;
}

Console.WriteLine("Input X dot A: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y dot A: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Z dot A: ");
int zA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input X dot B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y dot B: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Z dot B: ");
int zB = Convert.ToInt32(Console.ReadLine());

double dist = Distance(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Distance : {Math.Round(dist, 2)}");
*/


// Task 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void TableOneForN(int n)
{
	int i = 1;
	while (i <= n)
	{
		Console.WriteLine(Math.Pow(i, 3));
		i++;
	}
}

Console.Write("Input any number: ");
int num = Convert.ToInt32(Console.ReadLine());

TableOneForN(num);
*/