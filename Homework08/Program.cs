// Задача 8: Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Напишите число: ");
int num = int.Parse(Console.ReadLine());
int count = 2;
Console.WriteLine("Четные числа до: " + num);
while (count <= num)
{
    Console.Write(count +" ");
    count = count + 2;
}
