double a = Convert.ToInt32(Console.ReadLine());
double b = Convert.ToInt32(Console.ReadLine());
double c = Convert.ToInt32(Console.ReadLine());
double d;

d = b * b - 4 * a * c;
double x;
double x1;
double x2;

if (d > 0)
{
    x1 = (- b + Math.Sqrt(d)) / 2 * a;
    x2 = (-b - Math.Sqrt(d)) / 2 * a;
    Console.WriteLine($"{x1}, { x2}");
}
else if (d == 0)
{
    x = (- b) / (2 * a);
    Console.WriteLine($"{x}");
}
else if (d < 0)
{
    Console.WriteLine("Нет действительных корней");
}
