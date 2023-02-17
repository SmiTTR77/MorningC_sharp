//HomeWork 2
//Task 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondDigit(int number)
{
	int result = number / 10 % 10;
	return result;
}

Console.Write("enter a three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

int newNum = SecondDigit(num);
Console.WriteLine($"desired number: {newNum}");
*/


//Task 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

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

int ThirdDigit(int userNumber, int counter)
{
	while (counter > 3)
	{
		userNumber = userNumber / 10;
		counter--;
	}
	userNumber = userNumber % 10;
	return userNumber;
}

Console.Write("Please, enter any number: ");
int num = Convert.ToInt32(Console.ReadLine());

int count = CounterN(num);

if (count > 2)
{
	int result = ThirdDigit(num, count);
	Console.WriteLine($"Third number is: {result}");
}

else
	Console.WriteLine(-1);


//Task 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool Weekend(int numDay)
{
	return (numDay == 6 || numDay == 7);
}

Console.Write("Insert day of the week (1-7): ");
int day = Convert.ToInt32(Console.ReadLine());

bool result = Weekend(day);
if (result)
	Console.WriteLine("Yes, this day is a weekend");
else
	Console.WriteLine("Sorry, but it's a working day.");
*/