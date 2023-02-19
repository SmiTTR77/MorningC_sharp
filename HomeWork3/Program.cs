// HomeWork 3
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


// Task 19. String decision.
/*
bool PalyndromeCheck(string number)
{
	int length = number.Length;
	int counter = length / 2;
	int index = 0;
	int indexInverse = length - 1;

	if (length > 1)
	{
		while (index < counter)
		{
			if (number[index] == number[indexInverse])
			{
				index++;
				indexInverse--;
			}
			else
				return false;
		}
		return true;
	}
	else return false;
}

Console.Write("Input a any number: ");
string num = Console.ReadLine();

if (PalyndromeCheck(num)) Console.WriteLine($"Your number {num} is a palyndrome");
else Console.WriteLine($"Your number {num} is not a palyndrome");
*/

// Task 19. VERY STRANGE DECISION!!! but it works for a 32-bit integer ;)
/*
int CounterN(int userNumber)
{
	int counter = 0;
	while (userNumber > 0)
	{
		userNumber = userNumber / 10;
		counter++;
	}
	return counter;
}

bool PalyndromeCheck(int number, int counter)
{
	if (counter == 2)
	{
		int digitFirst = number / 10;
		int digitEnd = number % 10;
		if (digitFirst == digitEnd) return true;
		return false;
	}
	else if (counter == 3)
	{
		int digitFirst = number / 100;
		int digitEnd = number % 10;
		if (digitFirst == digitEnd) return true;
		return false;
	}
	else if (counter == 4)
	{
		int digitFirst = number / 1000;
		int digitTwo = number / 100 % 10;
		int digitThree = number / 10 % 10;
		int digitEnd = number % 10;
		if (digitFirst == digitEnd && digitTwo == digitThree) return true;
		return false;
	}
	else if (counter == 5)
	{
		int digitFirst = number / 10000;
		int digitTwo = number / 1000 % 10;
		int digitFour = number / 10 % 10;
		int digitEnd = number % 10;
		if (digitFirst == digitEnd && digitTwo == digitFour) return true;
		return false;
	}
	else if (counter == 6)
	{
		int digitFirst = number / 100000;
		int digitTwo = number / 10000 % 10;
		int digitThree = number / 1000 % 10;
		int digitFour = number / 100 % 10;
		int digitFive = number / 10 % 10;
		int digitEnd = number % 10;
		if (digitFirst == digitEnd && digitTwo == digitFive && digitThree == digitFour) return true;
		return false;
	}
	else if (counter == 7)
	{
		int digitFirst = number / 1000000;
		int digitTwo = number / 100000 % 10;
		int digitThree = number / 10000 % 10;
		int digitFive = number / 100 % 10;
		int digitSix = number / 10 % 10;
		int digitEnd = number % 10;
		if (digitFirst == digitEnd && digitTwo == digitSix && digitThree == digitFive) return true;
		return false;
	}
	else if (counter == 8)
	{
		int digitFirst = number / 10000000;
		int digitTwo = number / 1000000 % 10;
		int digitThree = number / 100000 % 10;
		int digitFour = number / 10000 % 10;
		int digitFive = number / 1000 % 10;
		int digitSix = number / 100 % 10;
		int digitSeven = number / 10 % 10;
		int digitEnd = number % 10;
		if (digitFirst == digitEnd && digitTwo == digitSeven && digitThree == digitSix && digitFour == digitFive) return true;
		return false;
	}
	else if (counter == 9)
	{
		int digitFirst = number / 100000000;
		int digitTwo = number / 10000000 % 10;
		int digitThree = number / 1000000 % 10;
		int digitFour = number / 100000 % 10;
		int digitSix = number / 1000 % 10;
		int digitSeven = number / 100 % 10;
		int digitEight = number / 10 % 10;
		int digitEnd = number % 10;
		if (digitFirst == digitEnd && digitTwo == digitEight && digitThree == digitSeven && digitFour == digitSix) return true;
		return false;
	}
	else if (counter == 10)
	{
		int digitFirst = number / 1000000000;
		int digitTwo = number / 100000000 % 10;
		int digitThree = number / 10000000 % 10;
		int digitFour = number / 1000000 % 10;
		int digitFive = number / 100000 % 10;
		int digitSix = number / 10000 % 10;
		int digitSeven = number / 1000 % 10;
		int digitEight = number / 100 % 10;
		int digitNine = number / 10 % 10;
		int digitEnd = number % 10;
		if (digitFirst == digitEnd && digitTwo == digitNine && digitThree == digitEight && digitFour == digitSeven && digitFive == digitSix) return true;
		return false;
	}
	else return false;
}

Console.Write("Input a any number: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = CounterN(num);

if (PalyndromeCheck(num, count)) Console.WriteLine($"Your number {num} is a palyndrome");
else Console.WriteLine($"Your number {num} is not a palyndrome");
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