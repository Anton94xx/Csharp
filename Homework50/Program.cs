// // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> по такому индексу нет элемента.

// Создание и заполнение массива

// Задание размеров массива

int m = 3;
int n = 4;

// Создание и заполнение массива случайными числами
int[,] arr = new int[m, n];
Random rand = new Random();
for (int z = 0; z < m; z++)
{
    for (int x = 0; x < n; x++)
    {
        arr[z, x] = rand.Next(0, 10);
    }
}

// Вывод массива на консоль
PrintArray(arr);

// Ввод индексов элемента
Console.Write("Введите номер строки: ");
int i = int.Parse(Console.ReadLine()!);

Console.Write("Введите номер столбца: ");
int j = int.Parse(Console.ReadLine()!);

// Поиск значения элемента или вывод сообщения об отсутствии элемента
int? value = GetElementValue(arr, i, j);
if (value.HasValue)
{
    Console.WriteLine($"Значение элемента [{i}, {j}]: {value}");
}
else
{
    Console.WriteLine($"Элемент [{i}, {j}] отсутствует в массиве");
}

Console.ReadLine();


// Метод для поиска значения элемента в массиве по заданным индексам
static int? GetElementValue(int[,] arr, int i, int j)
{
    if (i >= 0 && i < arr.GetLength(0) && j >= 0 && j < arr.GetLength(1))
    {
        return arr[i, j];
    }
    else
    {
        return null;
    }
}

// Метод для вывода массива на консоль
static void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
        Console.Write($"{arr[i, j]} ");
        }
    Console.WriteLine();
    }
}