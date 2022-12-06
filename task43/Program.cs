// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// Значения b1, k1, b2 и k2 задаются пользователем.


Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());


double X(double b1, double k1, double b2, double k2)
{
    double x = -(b1 - b2) / (k1 - k2);
    return x;
}

double Y(double b1, double k1)
{
    double x = X(b1, k1, b2, k2);
    double y = k1 * x + b1;
    return x;
}

double x = X(b1, k1, b2, k2);
double y = Y(b1, k1);
x = Math.Round(x, 2);
y = Math.Round(y, 2);
Console.WriteLine($"Точка пересечения двух прямых ----> ({x};{y})");
