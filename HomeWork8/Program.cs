// Task 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

int[,] SortedArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
		for (int j = 0; j < array.GetLength(1); j++)
			for (int k = 0; k < array.GetLength(1); k++)
				if (array[i, j] > array[i, k])
				{
					int temp = array[i, j];
					array[i, j] = array[i, k];
					array[i, k] = temp;
				}
	return array;
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

SortedArray(newArray);
Show2dArray(newArray);
*/

// Task 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] Random2dArray4x5()
{
	int[,] array = new int[4, 5];
	for (int i = 0; i < 4; i++)
		for (int j = 0; j < 5; j++)
			array[i, j] = new Random().Next(1, 10);
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

int MinSumOfRows(int[,] array)
{
	int result = 0;
	int[] tempMinSumRow = new int[array.GetLength(0)];

	for (int i = 0; i < array.GetLength(0); i++)
	{
		int tempSum = 0;
		for (int j = 0; j < array.GetLength(1); j++) 
			tempSum += array[i, j];
		tempMinSumRow[i] = tempSum;
		Console.WriteLine(tempSum); // оставил для проверки
	}

	int temp = tempMinSumRow[0];

	for (int i = 0; i < tempMinSumRow.Length; i++)
		if (tempMinSumRow[i] < temp)
		{
			temp = tempMinSumRow[i];
			result = i;
		}
	return result + 1;
}

int[,] newArray = Random2dArray4x5();
Show2dArray(newArray);

Console.WriteLine($" The smallest sum of the numbers is in a row: {MinSumOfRows(newArray)}");
*/

// Task 58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/*
int[,] CreateMatrix(int size, int minValue, int maxValue)
{
	int[,] array = new int[size, size];
	for (int i = 0; i < size; i++)
		for (int j = 0; j < size; j++)
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

int[,] ProductMatrix(int[,] arrayA, int[,] arrayB)
{
	int[,] arrayC = new int[arrayA.GetLength(0), arrayA.GetLength(1)];

	for (int i = 0; i < arrayA.GetLength(0); i++)
		for (int j = 0; j < arrayA.GetLength(1); j++)
			for (int k = 0; k < arrayA.GetLength(1); k++)
				arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
	return arrayC;
}

Console.Write("Input a size of matrices: ");
int sizeMatrix = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value matrix A: ");
int minValueMatrixA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value matrix A: ");
int maxValueMatrixA = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value matrix B: ");
int minValueMatrixB = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value matrix B: ");
int maxValueMatrixB = Convert.ToInt32(Console.ReadLine());

int[,] matrixA = CreateMatrix(sizeMatrix, minValueMatrixA, maxValueMatrixA);
Show2dArray(matrixA);

int[,] matrixB = CreateMatrix(sizeMatrix, minValueMatrixB, maxValueMatrixB);
Show2dArray(matrixB);

int[,] matrixAB = ProductMatrix(matrixA, matrixB);
Show2dArray(matrixAB);
*/

// Task 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[,,] CreateUniqRandom3dArray()
{
	Console.Write("Input a number of X: ");
	int valueX = Convert.ToInt32(Console.ReadLine());
	Console.Write("Input a number of Y: ");
	int valueY = Convert.ToInt32(Console.ReadLine());
	Console.Write("Input a number of Z: ");
	int valueZ = Convert.ToInt32(Console.ReadLine());

	int size = 90;
	int[] arrayX = new int[size];
	for (int i = 0, j = 10; i < arrayX.Length; i++, j++)
	{
		arrayX[i] = j;
	}
	Console.WriteLine();

	int[,,] array = new int[valueX, valueY, valueZ];

	for (int i = 0; i < valueX; i++)
		for (int j = 0; j < valueY; j++)
			for (int k = 0; k < valueZ; k++)
			{
				int n = new Random().Next(0, size);
				array[i, j, k] = arrayX[n];

				for (int m = n; m < arrayX.Length - 1; m++)
				{
					arrayX[m] = arrayX[m + 1];
				}
				size--;
			}
	return array;
}

void Show3dArray(int[,,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			for (int k = 0; k < array.GetLength(2); k++)
			{
				Console.Write(array[i, j, k] + " ");
				Console.Write($"({i}, {j}, {k}) ");
				Console.Write(" ");
			}
			Console.WriteLine(" ");
		}
		Console.WriteLine();
	}
	Console.WriteLine();
}

int[,,] newArray = CreateUniqRandom3dArray();
Show3dArray(newArray);
*/

// Task 62. Напишите программу, которая заполнит спирально массив 4 на 4. 

int[,] SpiralArray()
{
	int[,] array = new int[4, 4];
	int n = 0;

	for (int i = 0, j = 0; j < array.GetLength(1); j++, n++)
		array[i, j] = n + 1;
	for (int i = 1, j = array.GetLength(1) - 1; i < array.GetLength(0); i++, n++)
		array[i, j] = n + 1;
	for (int i = array.GetLength(0) - 1, j = array.GetLength(1) - 2; j > 0; j--, n++)
		array[i, j] = n + 1;
	for (int i = array.GetLength(0) - 1, j = 0; i > 0; i--, n++)
		array[i, j] = n + 1;
	for (int i = 1, j = 1; j < array.GetLength(1) - 1; j++, n++)
		array[i, j] = n + 1;
	for (int i = 2, j = array.GetLength(1) - 2; j > 0; j--, n++)
		array[i, j] = n + 1;
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

Show2dArray(SpiralArray());