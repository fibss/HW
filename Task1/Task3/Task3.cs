int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && b >= c)
{
    Console.WriteLine($"{c}, {b}, {a}");
}
else if (b > a && a >= c)
{
    Console.WriteLine($"{c}, {a}, {b}");
}
else if (c > a && a >= b)
{
    Console.WriteLine($"{b}, {a}, {c}");
}
else if (c > b && b >= a)
{
    Console.WriteLine($"{a}, {b}, {c}");
}
else if (b > c && c >= a)
{
    Console.WriteLine($"{a}, {c}, {b}");
}
else (a > c && c >= b)
{
    Console.WriteLine($"{b}, {c}, {a}");
}