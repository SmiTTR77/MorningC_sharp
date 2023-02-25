// Seminar 5

// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.
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

int GetNegativeSum(int[] array)
{
	int sum = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] < 0)
			sum += array[i];
	}
	return sum;
}

Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);

int result = GetNegativeSum(newArray);
Console.WriteLine($"Sum of negative is: {result}");
*/


// ClassWork
// Task 1. Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
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

int[] ReplacingSignsNumbers(int[] array)
{
	for (int i = 0; i < array.Length; i++)
		array[i] *= -1;
	return array;
}

Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);

int[] result = ReplacingSignsNumbers(newArray);
Console.WriteLine($"New replacement array is: ");
ShowArray(newArray);
*/


// Task 2. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
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

bool FindNumber(int[] array, int number)
{
	for (int i = 0; i < array.Length; i++)
		if (array[i] == number) return true;
	return false;
}

Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray); // Выводим для наглядности

Console.WriteLine("Enter the number you want to find: ");
int num = Convert.ToInt32(Console.ReadLine());

if (FindNumber(newArray, num)) Console.WriteLine("Your number is found in the array");
else Console.WriteLine("Your number is not found in the array");
*/


// Task 3. Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].


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

int NumberOfElements(int[] array, int a, int b)
{
	int counter = 0;
	for (int i = 0; i < array.Length; i++)
		if (array[i] >= a && array[i] <= b) counter++;
	return counter;
}

Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);

Console.Write("Input a value A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a value B: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = NumberOfElements(newArray, a, b);
Console.WriteLine($"The number of elements located from A to B: {result}");
