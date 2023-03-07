// Seminar 8

// Task 1. Задайте двумерный массив. Напишите программу, которая поменяет местами любые две строки массива.
/*
int[,] CreateRandom2dArray()
{
	Console.Write("Input a number of rows: ");
	int rows = Convert.ToInt32(Console.ReadLine());
	Console.Write("Input a number of columns: ");
	int columns = Convert.ToInt32(Console.ReadLine());
	Console.Write("Input a min possible value: ");
	int minValue = Convert.ToInt32(Console.ReadLine());
	Console.Write("Input a max possible value: ");
	int maxValue = Convert.ToInt32(Console.ReadLine());

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

void ChangeRows(int[,] array, int row1, int row2)
{
	if (row1 >= 0 && row1 < array.GetLength(0) &&
	row2 >= 0 && row2 < array.GetLength(0)
	&& row1 != row2)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			int temp = array[row1, j];
			array[row1, j] = array[row2, j];
			array[row2, j] = temp;
		}
	}
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

Console.Write("Input a first row chaging: ");
int r1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Input a second row chaging: ");
int r2 = Convert.ToInt32(Console.ReadLine()) - 1;

ChangeRows(newArray, r1, r2);
Show2dArray(newArray);
*/

// ClassWork

// Task 1. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
/*
int[,] CreateRandom2dArray()
{
	Console.Write("Input a number of rows: ");
	int rows = Convert.ToInt32(Console.ReadLine());
	Console.Write("Input a number of columns: ");
	int columns = Convert.ToInt32(Console.ReadLine());
	Console.Write("Input a min possible value: ");
	int minValue = Convert.ToInt32(Console.ReadLine());
	Console.Write("Input a max possible value: ");
	int maxValue = Convert.ToInt32(Console.ReadLine());

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

void ChangeRowsToColumns(int[,] array)
{
	if (array.GetLength(0) == array.GetLength(1))
	{
		for (int i = 0; i < array.GetLength(0); i++)
		{
			for (int j = i; j < array.GetLength(1); j++)
			{
				int temp = array[i, j];
				array[i, j] = array[j, i];
				array[j, i] = temp;
			}
		}
	}
	else Console.WriteLine("The number of columns is not equal to the number of rows");
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

ChangeRowsToColumns(newArray);
Show2dArray(newArray);
*/

// Task 2. Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

int[,] CreateRandom2dArray()
{
	Console.Write("Input a number of rows: ");
	int rows = Convert.ToInt32(Console.ReadLine());
	Console.Write("Input a number of columns: ");
	int columns = Convert.ToInt32(Console.ReadLine());
	Console.Write("Input a min possible value: ");
	int minValue = Convert.ToInt32(Console.ReadLine());
	Console.Write("Input a max possible value: ");
	int maxValue = Convert.ToInt32(Console.ReadLine());

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

int[] FindMinPosition(int[,] array)
{
	int[] result = new int[2];
	for (int i = 0; i < array.GetLength(0); i++)
		for (int j = 0; j < array.GetLength(1); j++)
			if (array[i, j] < array[result[0], result[1]])
			{
				result[0] = i;
				result[1] = j;
			}

	return result;
}

void ShowArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
		Console.Write(array[i] + " ");
	Console.WriteLine();
}

int[,] RemoveRowAndColumn(int[,] array, int row, int col)
{
	int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
	for (int i = 0, newI = 0; i < array.GetLength(0); i++)
		if (i != row)
		{
			for (int j = 0, newJ = 0; j < array.GetLength(1); j++)
				if (j != col)
				{
					result[newI, newJ] = array[i, j];
					newJ++;
				}
			newI++;
		}
	return result;
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

int[] minPosition = FindMinPosition(newArray);
ShowArray(minPosition);
Console.WriteLine();

int[,] removedArray = RemoveRowAndColumn(newArray, minPosition[0], minPosition[1]);
Show2dArray(removedArray);