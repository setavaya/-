using System;

double Function(double x)
{
    double a = Math.Sqrt(x * x + 4) / 2;
    double b = Math.Sqrt(x * x + 1) / 2;

    return 2 * Math.Sin(a) * Math.Cos(b);
}

Console.Write("Введите x: ");
double x = double.Parse(Console.ReadLine());

double y = Function(x);

Console.WriteLine("f(x) = " + y);
