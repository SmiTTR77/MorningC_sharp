// Шаблоны 

// Рандомный одномерный массив + вывод
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

Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min posimble value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max posimble value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);
*/

// Рандомный одномерный вещественный массив + вывод
/*
double[] CreateRandomDoubleArray(int size, int minValue, int maxValue)
{
	double[] array = new double[size];

	for (int i = 0; i < size; i++)
	{
		array[i] = Math.Round((new Random().Next(minValue, maxValue + 1) + new Random().NextDouble()), 2);
	}
	return array;
}

void ShowArray(double[] array)
{
	for (int i = 0; i < array.Length; i++)
		Console.Write(array[i] + " ");
	Console.WriteLine();
}

Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] newArray = CreateRandomDoubleArray(size, min, max);
ShowArray(newArray);
*/

// Рандомный двухмерный массив
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