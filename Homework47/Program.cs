int m = 3;
int n = 4;
double[,] array = GenerateRandomArray(m, n, -10, 10);

// вывод массива на консоль
PrintArray(array);

static double[,] GenerateRandomArray(int m, int n, double minValue, double maxValue)
{
    double[,] array = new double[m, n];
    Random rnd = new Random();

    // заполнение массива случайными вещественными числами от minValue до maxValue
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rnd.NextDouble() * (maxValue - minValue) + minValue;
        }
    }

    return array;
}

static void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0:F1} ", array[i, j]);
        }
        Console.WriteLine();
    }
}