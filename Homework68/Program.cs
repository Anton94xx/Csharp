// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите первое неотрицательное число: ");
int m = GetNonNegativeInt();

Console.Write("Введите второе неотрицательное число: ");
int n = GetNonNegativeInt();

int result = Ackermann(m, n);
Console.WriteLine($"Результат функции Аккермана от {m} и {n}: {result}");

Console.ReadLine();


static int GetNonNegativeInt()
{
    int num;
    while (!int.TryParse(Console.ReadLine(), out num) || num < 0)
    {
        Console.Write("Ошибка ввода. Введите неотрицательное число: ");
    }
    return num;
}

static int Ackermann(int m, int n)

{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}