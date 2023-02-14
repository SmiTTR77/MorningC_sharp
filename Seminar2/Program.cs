//Seminar 2
//Task 1.

/*
int CutNumber(int num)
{
	int hundreds = num / 100;
	int units = num % 10;
	int result = hundreds * 10 + units;

	return result;
}

int randNumber = new Random().Next(100, 1000);

int newNumber = CutNumber(randNumber);
Console.WriteLine($"New version {randNumber} is {newNumber}");
*/


//Task 2.
/*
bool IsMultiplyed(int num, int div1, int div2)
{
	if (num % div1 == 0 && num % div2 == 0)
		return true;
	else
		return false;
}
*/
/*
bool IsMultiplyedBest(int num, int div1, int div2)
{
	return (num % div1 == 0 && num % div2 == 0);
}

Console.Write("Input a number for cheking: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a first divider: ");
int divider1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second divider: ");
int divider2 = Convert.ToInt32(Console.ReadLine());

bool result = IsMultiplyedBest(number, divider1, divider2);
if (result)
	Console.WriteLine($"You number {number} is divisibly by {divider1} and {divider2}");
else
	Console.WriteLine($"You number {number} is not divisibly by {divider1} and {divider2}");
*/
//ClassWork

//Task 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
/*
int BigNumer(int num)
{
	int units = num % 10;
	int tens = num / 10;
	if (tens > units)
		return tens;
	else
		return units;
}
int randNumber = new Random().Next(10, 100);

int newNumber = BigNumer(randNumber);
Console.WriteLine($"The bigest number {randNumber} is {newNumber}");
*/


//Task 2. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
/*
bool Square2num(int numA, int numB)
{
	return (numA * numA == numB || numB * numB == numA);
}

Console.Write("input fist number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool result = Square2num(num1, num2);

if (result)
	Console.WriteLine($"yes, {num1} or {num2} is the square of another number");
else
	Console.WriteLine($"no, {num1} or {num2} is not the square of another number");
	*/