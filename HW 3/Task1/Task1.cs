double a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
double result = 1.0;

if (b < 0)
{
    a = 1 / a;
    b *= -1;
}

for (int i = 1; i <= b; i++)
{
    result = result * a;
}
Console.WriteLine(result);

