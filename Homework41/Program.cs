// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите количество чисел, которые вы хотите ввести: ");
int m = int.Parse(Console.ReadLine());

int count = 0;
for (int i = 0; i < m; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    int num = int.Parse(Console.ReadLine());
    if (num > 0)
    {
        count++;
    }
}

Console.WriteLine($"Вы ввели {count} чисел больше нуля.");