// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!)!;
int count = 1;
while (count < num)
{
    Console.Write(count * count + ", ");
    count++;
}
Console.WriteLine(count * count + ". ");
