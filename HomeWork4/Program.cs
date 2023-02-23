// HomeWork 4
// Task 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
void Exponentiation(int numberA, int numberB)
{
	if (numberA > 0 && numberB > 0)
	{
		int newNumber = 1;
		for (int current = 0; current < numberB; current++)
		{
			newNumber *= numberA;
		}
		Console.WriteLine($"result = {newNumber}");
	}
	else
		Console.WriteLine("Please input value A and B > 0");
}

Console.Write("Please input number A: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Please input number B: ");
int numB = Convert.ToInt32(Console.ReadLine());

Exponentiation(numA, numB);
*/

// Task 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumOfDigits(int number)
{
	int sum = 0;

	while (number > 0)
	{
		sum += (number % 10);
		number /= 10;
	}

	return sum;
}

Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = SumOfDigits(num);
Console.WriteLine($"Sum of digits = {result}");




// int x = Convert.ToInt32(Console.ReadLine());

// int sum = 0;

// for (int i = 3; i >= 0; i--)
// {
// 	sum = sum + x % 10;
// 	x = x / 10;
// }

// Console.WriteLine(sum);




// Task 29. Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*
int[] CreateArray(int size)
{
	int[] array = new int[size];

	for (int i = 0; i < size; i++)
	{
		Console.Write("Input a value: ");
		array[i] = Convert.ToInt32(Console.ReadLine());
	}
	return array;
}

void ShowArray(int[] array)
{
	Console.WriteLine("Your array: ");
	Console.Write("[ ");					//для красоты
	for (int i = 0; i < array.Length; i++)
		Console.Write(array[i] + " ");
	Console.Write("]");						//для красоты
	Console.WriteLine();
}

Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateArray(size);
ShowArray(newArray);
*/