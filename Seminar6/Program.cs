// Seminar 6
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
	int[] array = new int[size];

	for (int i = 0; i < size; i++)
	{
		array[i] = new Random().Next(minValue, maxValue + 1);
	}
	return array;
}

void ShowArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
		Console.Write(array[i] + " ");
	Console.WriteLine();
}

void ReverseArray(int[] array)
{
	for (int i = 0, j = array.Length - 1; i < j; i++, j++)
	{
		int temp = array[i];
		array[i] = array[j];
		array[j] = temp;
	}
}

Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);
ReverseArray(newArray);
ShowArray(newArray);
*/


//ClassWork

//Task 1. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
/*
bool TriangleCheck(int a, int b, int c)
{
	return a < b + c && b < a + c && c < a + b;
}

Console.Write("Input a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input c: ");
int c = Convert.ToInt32(Console.ReadLine());

if (TriangleCheck(a, b, c)) Console.WriteLine("Yes, triangle exist");
else Console.WriteLine("Triangle not found");
*/


// Task 2. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
/*
int[] Fibonacci(int n, int a, int b)
{
	int[] array = new int[n];
	array[0] = a;
	array[1] = b;
	for (int i = 2; i < n; i++)
	{
		array[i] = array[i - 1] + array[i - 2];
	}
	return array;
}

void ShowArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
		Console.Write(array[i] + " ");
	Console.WriteLine();
}

Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b: ");
int b = Convert.ToInt32(Console.ReadLine());

ShowArray(Fibonacci(n, a, b));
*/

// Task 3. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
	int[] array = new int[size];

	for (int i = 0; i < size; i++)
	{
		array[i] = new Random().Next(minValue, maxValue + 1);
	}
	return array;
}

void ShowArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
		Console.Write(array[i] + " ");
	Console.WriteLine();
}

int[] CopyArray(int[] array)
{
	int[] newArray = new int[array.Length];
	for (int i = 0; i < array.Length; i++)
	{
		newArray[i] = array[i];
	}
	return newArray;
}

Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);

ShowArray(CopyArray(newArray));


// Task 4*. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
/*
string ConvertToBin(int number)
{
	string res = "";
	int remainder;
	while (number > 0)
	{
		remainder = number % 2;
		number = number / 2;

		if (remainder > 0) res = "1" + res;
		else res = "0" + res;
	}

	return res;
}

Console.Write("Input dec number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ConvertToBin(number));
*/

// string ConvertToBin(int number)
// {
// 	string result = string.Empty;
// 	while (number > 0)
// 	{
// 		result = number % 2 + result;
// 		number = number / 2;
// 	}
// 	return result;
// }
// Console.Write("Input dec number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(ConvertToBin(number));