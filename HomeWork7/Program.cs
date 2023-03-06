// Task 47. Задайте двумерный массив размером m x n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dDoubleArray()
{
	Console.Write("Input a number of rows: ");
	int rows = Convert.ToInt32(Console.ReadLine());
	Console.Write("Input a number of columns: ");
	int columns = Convert.ToInt32(Console.ReadLine());
	Console.Write("Input a min possible value: ");
	int minValue = Convert.ToInt32(Console.ReadLine());
	Console.Write("Input a max possible value: ");
	int maxValue = Convert.ToInt32(Console.ReadLine());

	double[,] array = new double[rows, columns];
	for (int i = 0; i < rows; i++)
		for (int j = 0; j < columns; j++)
			array[i, j] = Math.Round((new Random().Next(minValue, maxValue + 1) + new Random().NextDouble()), 2);
	return array;
}

void Show2dArray(double[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
			Console.Write(array[i, j] + " ");
		Console.WriteLine();
	}
	Console.WriteLine();
}

double[,] newArray = CreateRandom2dDoubleArray();
Show2dArray(newArray);
*/


// Task 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
	int[,] array = new int[rows, columns];
	for (int i = 0; i < rows; i++)
		for (int j = 0; j < columns; j++)
			array[i, j] = new Random().Next(minValue, maxValue + 1);
	return array;
}

void Show2dArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
			Console.Write(array[i, j] + " ");
		Console.WriteLine();
	}
	Console.WriteLine();
}

void ElementsChecked(int[,] array, int rows, int columns, int rowPosition, int colPosition)
{
	if (rows > rowPosition && columns > colPosition) Console.WriteLine($"Your value is: {array[rowPosition, colPosition]}");
	else Console.WriteLine($"There is no element with such indexes in the array");
}

Console.Write("Input a number of rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateRandom2dArray(row, col, min, max);
Show2dArray(newArray);

Console.Write("Input the index row of the element you are looking for: ");
int findValueRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the index column of the element you are looking for: ");
int findValueCol = Convert.ToInt32(Console.ReadLine());

ElementsChecked(newArray, row, col, findValueRow, findValueCol);
*/


// Task 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
	int[,] array = new int[rows, columns];
	for (int i = 0; i < rows; i++)
		for (int j = 0; j < columns; j++)
			array[i, j] = new Random().Next(minValue, maxValue + 1);
	return array;
}

void Show2dArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
			Console.Write(array[i, j] + " ");
		Console.WriteLine();
	}
	Console.WriteLine();
}

double[] ArithmeticMeanOfColumns(int[,] array, int columns)
{
	double[] result = new double[columns];

	for (int j = 0; j < array.GetLength(1); j++)
	{
		double current = 0;
		double counter = 0;

		for (int i = 0; i < array.GetLength(0); i++)
		{
			current += Convert.ToInt32(array[i, j]);
			counter++;
		}
		result[j] = Math.Round(current / counter, 2);
	}
	return result;
}

void ShowArray(double[] array)
{
	for (int i = 0; i < array.Length; i++)
		Console.Write(array[i] + " ");
	Console.WriteLine();
}

Console.Write("Input a number of rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateRandom2dArray(row, col, min, max);
Show2dArray(newArray);

Console.WriteLine("Arithmetic mean of each column: ");
ShowArray(ArithmeticMeanOfColumns(newArray, col));