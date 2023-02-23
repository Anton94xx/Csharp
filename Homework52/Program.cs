// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] arr = {
            {5, 4, 2, 7},
            {8, 2, 4, 6},
            {3, 9, 7, 1}
        };

// нахождение среднего арифметического для каждого столбца
double[] averages = CalculateColumnAverages(arr);

// вывод результатов на экран
for (int i = 0; i < averages.Length; i++)
{
    Console.WriteLine($"Среднее арифметическое элементов столбца {i}: {averages[i]}");
}

Console.ReadLine();
static double[] CalculateColumnAverages(int[,] arr)
{
    int rows = arr.GetLength(0);
    int cols = arr.GetLength(1);
    double[] averages = new double[cols];

    for (int j = 0; j < cols; j++)
    {
        double sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum += arr[i, j];
        }
        averages[j] = sum / rows;
    }
    return averages;
}