// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] numbers = new int[size];

Console.WriteLine("Введите элементы массива:");
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write("Элемент {0}: ", i + 1);
    numbers[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Элементы массива:");
Console.Write("[");
foreach (int number in numbers)
{
    Console.Write($"{number}, ");
}
Console.Write($"]");

Console.ReadLine();