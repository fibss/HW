double x1 = Convert.ToDouble(Console.ReadLine());
double x2 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());

double a = (x2 - x1) / (y2 - y1);
double b = y2 - a * x2;

Console.WriteLine($"y = {a}x + {b}");