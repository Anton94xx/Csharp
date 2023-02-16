// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника

double a = Input();
double b = Input();
double c = Input();

if (CheckTriangle(a, b, c))
{
    Console.WriteLine("треугольник со сторонами такой длины может существовать");
}

else
{
    Console.WriteLine("треугольник со сторонами такой длины не может существовать");
}

bool CheckTriangle(double a, double b, double c)
{
    if ((a < (b + c)) && (b < (a + c)) && (c < (a + b))) 
    return true;
    else return false;
}


double Input()
{
    Console.WriteLine("Введите длину: ");
    double res = double.Parse(Console.ReadLine()!);
    return res;
}