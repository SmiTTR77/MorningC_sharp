// Seminar 7
//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
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

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
*/
// ClassWork
//Task 1. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i + j. Выведите полученный массив на экран.
/*
int[,] CreateArray(int rows, int columns)
{
	int[,] array = new int[rows, columns];
	for (int i = 0; i < rows; i++)
		for (int j = 0; j < columns; j++)
			array[i, j] = i + j;
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

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateArray(rows, columns);
Show2dArray(newArray);
*/

// Task 2. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
/*
void ArraySquare(int[,] array) 
{
    for(int i = 2; i < array.GetLength(0); i += 2)
        for(int j = 2; j < array.GetLength(1); j += 2)
            array[i, j] *= array[i, j];
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

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

ArraySquare(newArray);
Show2dArray(newArray); 
*/

// Task 3. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
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

int DiagSum(int[,] array) 
{
    int result = 0;
    for(int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
        result += array[i, i];
    return result;
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

int diagSum = DiagSum(newArray);
Console.WriteLine($"Sum of elements on main diag is: {diagSum}");
*/