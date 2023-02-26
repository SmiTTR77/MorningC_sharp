// HomeWork 5
// Task 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
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

int NumberOfEvenNumbers(int[] array)
{
	int counter = 0;
	for (int i = 0; i < array.Length; i++)
		if (array[i] % 2 == 0) counter++;
	return counter;
}

Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, 100, 999);
ShowArray(newArray);

int result = NumberOfEvenNumbers(newArray);
Console.WriteLine($"Number of Even Numbers in array: {result}");
*/


// Task 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
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

int SumOddIndex(int[] array)
{
	int sum = 0;
	for (int i = 1; i < array.Length; i += 2)
		sum += array[i];
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

int result = SumOddIndex(newArray);
Console.WriteLine($"Sum of numbers with odd index value: {result}");
*/


// Task 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

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

int DifferenceMaxMin(int[] array)
{
	int i = 0;
	int result = 0;
	int min = array[i];
	int max = array[i];
	for (i = 0; i < array.Length; i++)
	{
		if (array[i] >= max) max = array[i];
		else if (array[i] <= min) min = array[i];
	}
	result = max - min;
	return result;
}

Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);

int result = DifferenceMaxMin(newArray);
Console.WriteLine($"The difference between the maximum and minimum value: {result}");
